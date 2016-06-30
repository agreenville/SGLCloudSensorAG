Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing

Public Class Form1

    Public LoggingEnabled As Boolean
    Private rand As New Random()
    Private selectedDataPoint As DataPoint = Nothing
    Dim AmbientTemp As Int32
    Dim SkyTemp As Double
    Dim DifferenceTemp As Double
    Dim LuxVal As Int32
    Dim LuxVolt As Int32
    Dim oldtemp As Int32
    Dim tempdiffr As Int32
    Dim tdiff As Int32
    Dim stclear As Int32
    Dim temptest2 As String
    Dim clskytemp As Int32
    Dim lolimit As Integer
    Dim butlim As Integer
    Dim clunst As Integer
    Dim IRAm As Int32




    Dim clstab As Integer
    Dim avstor(7) As Integer
    Dim tdf(7) As Integer
    Dim tempavdiffr As Int32
    Dim lotempavdiffr As Int32
    Dim hitempavdiffr As Int32


    Private Property Form As Object

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        worthalooklimit.Text = My.Settings.Temp_Lo_Limit
        clbutlim.Text = My.Settings.Temp_MainlyCloud
        Unstable.Text = My.Settings.Temp_Litecloud
        Stable.Text = My.Settings.Temp_Stable
        LoTempDiff.Text = My.Settings.LoTempDif
        HiTempDiff.Text = My.Settings.HiTempDif
        TXTCommPort.Text = My.Settings.txtcom

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Temp_Lo_Limit = worthalooklimit.Text
        My.Settings.Temp_MainlyCloud = clbutlim.Text
        My.Settings.Temp_Litecloud = Unstable.Text
        My.Settings.Temp_Stable = Stable.Text
        My.Settings.LoTempDif = LoTempDiff.Text
        My.Settings.HiTempDif = HiTempDiff.Text
        My.Settings.txtcom = TXTCommPort.Text

        Application.Exit()
    End Sub

    Private Sub Recall_Limits()

        lolimit = Val(worthalooklimit.Text)
        butlim = Val(clbutlim.Text)
        clunst = Val(Unstable.Text)
        clstab = Val(Stable.Text)
        hitempavdiffr = Val(HiTempDiff.Text)
        lotempavdiffr = Val(LoTempDiff.Text)
    End Sub

    Private Sub FrmControls_Closing(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '  Bypass the instruction to Close this form
        e.Cancel = True
        '  But hide it from the user.
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim IncomingStr As String
        Dim Command1 As String
        Dim Parameter1 As String
        Dim Income1 As Integer
        Dim loopExit As Integer

        Recall_Limits()



        If SerialPort1.IsOpen = True Then
            If SerialPort1.BytesToRead > 7 Then
                loopExit = 0
                IncomingStr = ""
                Command1 = ""
                Parameter1 = ""
                Do
                    Income1 = (SerialPort1.ReadChar)
                    IncomingStr = Chr(Income1)
                    If Income1 > 64 And Income1 < 91 Then Command1 = Command1 + IncomingStr
                    loopExit = loopExit + 1

                Loop Until IncomingStr = ":" Or loopExit > 20

                loopExit = 0
                IncomingStr = ""
                Do
                    Income1 = (SerialPort1.ReadChar)
                    'MessageBox.Show(Str(Shite))
                    IncomingStr = Chr(Income1)
                    If IncomingStr <> ";" Then Parameter1 = Parameter1 + IncomingStr
                    loopExit = loopExit + 1

                Loop Until IncomingStr = ";" Or loopExit > 20
                Command1 = Trim(Command1)
                'MessageBox.Show(Command1)
                'MessageBox.Show(Parameter1)

                If Trim(Command1) = "TOB" Then
                    SkyTemp = Convert.ToInt32(Parameter1)
                End If
                If Trim(Command1) = "TAM" Then
                    AmbientTemp = Convert.ToInt32(Parameter1)
                End If

                If Trim(Command1) = "IRAM" Then
                    IRAm = Convert.ToInt32(Parameter1)
                End If




                TextAmbTemp.Text = Str(AmbientTemp / 100)
                TextSkyTemp.Text = Str(SkyTemp / 100)

                Sensorambient.Text = Str(IRAm / 100)




                avstor(1) = SkyTemp ' saving current temp for averaging

                tempdiffr = (SkyTemp - oldtemp) ' Temp difference between last temp reading and latest
                tdiff = (tempdiffr * tempdiffr) ' Turning temp diff into a positive number - div by 10000 for accuracy.



                If SkyTemp > AmbientTemp Then
                    RAIN_LIGHT.Visible = True
                    PRECIP_LABEL.Text = "IR SENSOR WET"
                Else
                    RAIN_LIGHT.Visible = False
                    PRECIP_LABEL.Text = ""
                End If


                DifferenceTemp = (AmbientTemp - oldtemp)


                If DifferenceTemp <= (lolimit * 100) Then
                    Set_Cloud_State("Cloud")
                End If

                If DifferenceTemp > (-(lolimit * 100)) And oldtemp < (butlim * 100) Then
                    Set_Cloud_State("PCloud")

                End If

                If DifferenceTemp >= (butlim * 100) Then
                    Set_Cloud_State("Clearbut")

                End If


                If DifferenceTemp >= (clunst * 100) And tempavdiffr <= hitempavdiffr Then
                    Set_Cloud_State("ClUns")

                End If

                If DifferenceTemp >= (clstab * 100) And tempavdiffr <= lotempavdiffr Then
                    Set_Cloud_State("Clear")

                End If


            End If
        End If





    End Sub
    Private Sub TmrCloudSensor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrCloudSensor.Tick
        Dim FileWriteString As String
        If Me.SerialPort1.IsOpen = True Then Me.SerialPort1.Write("TMP:00;#") ''#TMP:00;
        If LoggingEnabled = True Then
            If loggingcheck.Checked Then

                If Not Directory.Exists("C:\CloudData") Then

                    Directory.CreateDirectory("C:\CloudData")

                End If

                Dim timeStamp As DateTime = DateTime.Now
                AddNewPoint(tdiff / 10000, timeStamp, ChartSkyTemp.Series("Temp Diff"))
                AddNewPoint(AmbientTemp / 100, timeStamp, ChartSkyTemp.Series("Ambient Temp"))
                AddNewPoint(SkyTemp / 100, timeStamp, ChartSkyTemp.Series("Sky Temp"))
                AddNewPoint(oldtemp / 100, timeStamp, ChartSkyTemp.Series("Sky Temp Average"))
                AddNewPoint(tempavdiffr / 10000, timeStamp, ChartSkyTemp.Series("Temp Diff Average"))
                AddNewPoint(IRAm / 100, timeStamp, ChartSkyTemp.Series("Sensor Temp"))
                'AddNewPoint(DifferenceTemp / 100, timeStamp, ChartSkyTemp.Series("Sky-Amb Temp"))

                FileWriteString = DateAndTime.DateString + " " + DateAndTime.TimeString + "," + (TextAmbTemp.Text) + "," + (TextSkyTemp.Text) + "," + (Sensorambient.Text) + "," + (T_LIGHT_LABEL.Text) + "," + Str(DifferenceTemp / 100) + "," + (IsSafeTextBox.Text)
                Dim ioFile As New System.IO.StreamWriter(("C:\CloudData\SGL_Cloud_Data.txt"), True)
                ioFile.WriteLine(FileWriteString)
                ioFile.Close()
            End If
        End If

        AverageTemp()
        average_diff()




    End Sub
    Private Sub IsSafeTextBox_TextChanged(sender As Object, e As EventArgs) Handles IsSafeTextBox.TextChanged
        Timer2.Start()

    End Sub
    Sub Set_Cloud_State(ByVal ReqState As String)
        Dim FileWriteString As String
        Select Case ReqState
            Case "Cloud"
                CLOUD_LIGHT.Visible = True
                CLEARING_LIGHT.Visible = False
                CL_STABLE_LIGHT.Visible = False
                CLEARISH_LIGHT.Visible = False
                CL_UNSTABLE_LIGHT.Visible = False
                T_LIGHT_LABEL.Text = "1 - CLOUDY"

            Case "PCloud"
                CLOUD_LIGHT.Visible = False
                CLEARING_LIGHT.Visible = True
                CL_STABLE_LIGHT.Visible = False
                CLEARISH_LIGHT.Visible = False
                CL_UNSTABLE_LIGHT.Visible = False
                T_LIGHT_LABEL.Text = "2 - MAINLY CLOUD"
            Case "Clearbut"
                CLOUD_LIGHT.Visible = False
                CLEARING_LIGHT.Visible = False
                CL_STABLE_LIGHT.Visible = False
                CLEARISH_LIGHT.Visible = True
                CL_UNSTABLE_LIGHT.Visible = False
                T_LIGHT_LABEL.Text = "3 - LIGHT CLOUD"
            Case "Clear"
                CLOUD_LIGHT.Visible = False
                CLEARING_LIGHT.Visible = False
                CL_STABLE_LIGHT.Visible = True
                CLEARISH_LIGHT.Visible = False
                CL_UNSTABLE_LIGHT.Visible = False
                T_LIGHT_LABEL.Text = "5 - CLEAR-STABLE "
            Case "ClUns"
                CLOUD_LIGHT.Visible = False
                CLEARING_LIGHT.Visible = False
                CL_STABLE_LIGHT.Visible = False
                CLEARISH_LIGHT.Visible = False
                CL_UNSTABLE_LIGHT.Visible = True
                T_LIGHT_LABEL.Text = "4 - CLEAR-UNSTABLE"


        End Select

    End Sub





    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
        EnableLogging()
        TmrCloudSensor.Enabled = False

        Every10SecToolStripMenuItem.Checked = False


    End Sub
    Private Sub ThreesecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreesecToolStripMenuItem.Click
        EnableLogging()

        TmrCloudSensor.Interval = 3000
        TmrCloudSensor.Enabled = True

        ThreesecToolStripMenuItem.Checked = True
        Every10SecToolStripMenuItem.Checked = False



    End Sub
    Private Sub Every10SecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Every10SecToolStripMenuItem.Click
        EnableLogging()


        TmrCloudSensor.Interval = 10000
        TmrCloudSensor.Enabled = True

        ThreesecToolStripMenuItem.Checked = False
        Every10SecToolStripMenuItem.Checked = True




    End Sub



    Private Sub EnableLogging()


        If CheckState.Checked = 0 Then
            LoggingEnabled = False
        Else
            LoggingEnabled = True
        End If

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Recall_Limits()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AverageTemp()

        For n = 4 To 1 Step -1
            avstor(n) = avstor(n - 1)
        Next

        Dim dif As Integer

        For n = 2 To 4
            dif = avstor(n) + dif
        Next

        oldtemp = dif / 3 'l average the total

    End Sub
    Public Sub average_diff()
        Dim difftotal As Integer

        tdf(0) = tdiff ' storing tdiff for averaging the difference

        tdf(1) = tdf(0)
        ' move down the bus please

        For n = 4 To 1 Step -1
            tdf(n) = tdf(n - 1)
        Next

        ' totalling the diff values

        For n = 2 To 4
            difftotal = tdf(n) + difftotal
        Next

        tempavdiffr = difftotal / 3 ' average



        Cur_Avg.Text = Str(tempavdiffr)



    End Sub

    Public Sub AddNewPoint(ByVal Data1 As Double, ByVal timeStamp As DateTime, ByVal ptSeries As System.Windows.Forms.DataVisualization.Charting.Series)
        Dim newVal As Double = 0



        If ptSeries.Points.Count > 0 Then
            newVal = ptSeries.Points((ptSeries.Points.Count - 1)).YValues(0) + (rand.NextDouble() * 2 - 1)
        End If

        If newVal < 0 Then
            newVal = 0
        End If
        ' Add new data point to its series.
        ptSeries.Points.AddXY(timeStamp.ToOADate(), Data1)

        ' remove all points from the source series older than 1.5 minutes.
        Dim removeBefore As Double = timeStamp.AddSeconds((CDbl(1800) * -1)).ToOADate()
        'remove oldest values to maintain a constant number of data points
        While ptSeries.Points(0).XValue < removeBefore
            ptSeries.Points.RemoveAt(0)
        End While

        ChartSkyTemp.ChartAreas(0).AxisX.Minimum = ptSeries.Points(0).XValue
        ChartSkyTemp.ChartAreas(0).AxisX.Maximum = DateTime.FromOADate(ptSeries.Points(0).XValue).AddMinutes(30).ToOADate()

        ChartSkyTemp.Invalidate()


    End Sub 'AddNewPoint


    '/ <summary>
    '/ Mouse Down Event
    '/ </summary>
    Private Sub Chart1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChartSkyTemp.MouseDown
        ' Call Hit Test Method
        Dim hitResult As HitTestResult = ChartSkyTemp.HitTest(e.X, e.Y)

        ' Initialize currently selected data point

        selectedDataPoint = Nothing
        If hitResult.ChartElementType = ChartElementType.DataPoint Then
            selectedDataPoint = CType(hitResult.Object, DataPoint)

            ' Show point value as label
            selectedDataPoint.IsValueShownAsLabel = True

            ' Set cursor shape
            ChartSkyTemp.Cursor = Cursors.SizeNS
        End If
    End Sub 'Chart1_MouseDown


    '/ <summary>
    '/ Mouse Move Event
    '/ </summary>


    '/ <summary>
    '/ Mouse Up Event
    '/ </summary>
    Private Sub Chart1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChartSkyTemp.MouseUp
        ' Initialize currently selected data point
        If Not (selectedDataPoint Is Nothing) Then
            ' Hide point label
            selectedDataPoint.IsValueShownAsLabel = False

            ' reset selected object
            selectedDataPoint = Nothing

            ' Invalidate chart
            ChartSkyTemp.Invalidate()

            ' Reset cursor style
            ChartSkyTemp.Cursor = Cursors.Default
        End If
    End Sub 'Chart1_MouseUp


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each portName As String In My.Computer.Ports.SerialPortNames
            Me.Avail_Ports.Items.Add(portName)
        Next



    End Sub


    Private Sub ButConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButConn.Click
        If Me.SerialPort1.IsOpen = False Then Me.SerialPort1.PortName = TXTCommPort.Text
        If Me.SerialPort1.IsOpen = False Then Me.SerialPort1.Open()
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Avail_Ports.SelectedIndexChanged
        TXTCommPort.Text = Avail_Ports.Text
    End Sub



    Private Sub ButHideTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButHideTemp.Click

        If ChartSkyTemp.Series("Sky Temp").Enabled = True Then
            ButHideTemp.Text = "Show Real Time Values"
            ChartSkyTemp.Series("Sky Temp").Enabled = False
            ChartSkyTemp.Series("Temp Diff").Enabled = False
        Else
            ButHideTemp.Text = "Hide Real Time Values"
            ChartSkyTemp.Series("Sky Temp").Enabled = True
            ChartSkyTemp.Series("Temp Diff").Enabled = True
        End If
    End Sub

    Private Sub ButTempDif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButTempDif.Click

        If ChartSkyTemp.Series("Temp Diff Average").Enabled = True Then
            ButTempDif.Text = "Show Averages"
            ChartSkyTemp.Series("Temp Diff Average").Enabled = False
            ChartSkyTemp.Series("Sky Temp Average").Enabled = False
        Else
            ButTempDif.Text = "Hide Averages"
            ChartSkyTemp.Series("Temp Diff Average").Enabled = True
            ChartSkyTemp.Series("Sky Temp Average").Enabled = True
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        ' Create a memory stream to save the chart image    
        Dim stream As New System.IO.MemoryStream()

        ' Save the chart image to the stream    
        ChartSkyTemp.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp)

        ' Create a bitmap using the stream    
        Dim bmp As New Bitmap(stream)

        ' Save the bitmap to the clipboard    
        Clipboard.SetDataObject(bmp)
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Create a memory stream to save the chart image    
        Dim stream As New System.IO.MemoryStream()

        ' Create a bitmap using the stream    
        Dim bmp As New Bitmap(stream)

        ' Save the bitmap to the clipboard    
        Clipboard.SetDataObject(bmp)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        ' Create a new save file dialog
        Dim saveFileDialog1 As New SaveFileDialog()

        ' Sets the current file name filter string, which determines 
        ' the choices that appear in the "Save as file type" or 
        ' "Files of type" box in the dialog box.
        saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|SVG (*.svg)|*.svg|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        ' Set image file format
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim format As ChartImageFormat = ChartImageFormat.Bmp

            If saveFileDialog1.FileName.EndsWith("bmp") Then
                format = ChartImageFormat.Bmp
            Else
                If saveFileDialog1.FileName.EndsWith("jpg") Then
                    format = ChartImageFormat.Jpeg
                Else
                    If saveFileDialog1.FileName.EndsWith("emf") Then
                        format = ChartImageFormat.Emf
                    Else
                        If saveFileDialog1.FileName.EndsWith("gif") Then
                            format = ChartImageFormat.Gif
                        Else
                            If saveFileDialog1.FileName.EndsWith("png") Then
                                format = ChartImageFormat.Png
                            Else
                                If saveFileDialog1.FileName.EndsWith("tif") Then
                                    format = ChartImageFormat.Tiff
                                End If
                            End If ' Save image
                        End If
                    End If
                End If
            End If
            ChartSkyTemp.SaveImage(saveFileDialog1.FileName, format)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Create a new save file dialog
        Dim saveFileDialog1 As New SaveFileDialog()

        ' Sets the current file name filter string, which determines 
        ' the choices that appear in the "Save as file type" or 
        ' "Files of type" box in the dialog box.
        saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|SVG (*.svg)|*.svg|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        ' Set image file format
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim format As ChartImageFormat = ChartImageFormat.Bmp

            If saveFileDialog1.FileName.EndsWith("bmp") Then
                format = ChartImageFormat.Bmp
            Else
                If saveFileDialog1.FileName.EndsWith("jpg") Then
                    format = ChartImageFormat.Jpeg
                Else
                    If saveFileDialog1.FileName.EndsWith("emf") Then
                        format = ChartImageFormat.Emf
                    Else
                        If saveFileDialog1.FileName.EndsWith("gif") Then
                            format = ChartImageFormat.Gif
                        Else
                            If saveFileDialog1.FileName.EndsWith("png") Then
                                format = ChartImageFormat.Png
                            Else
                                If saveFileDialog1.FileName.EndsWith("tif") Then
                                    format = ChartImageFormat.Tiff
                                End If
                            End If ' Save image
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        ChartSkyTemp.Series("Temp Sky").Points.Clear()
        ChartSkyTemp.Series("Temp Amb").Points.Clear()
        ChartSkyTemp.Series("Temp Diff").Points.Clear()
    End Sub

    Private Sub ClearToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        ChartSkyTemp.Printing.PrintPreview()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButBoth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChartSkyTemp.Width = 490
        ChartSkyTemp.Location = New System.Drawing.Point(0, 139)
        ChartSkyTemp.Show()
    End Sub

    Private Sub Unstable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Unstable.Click
        If clunst > clstab Then
            clunst = clstab
        Else
            clunst = clunst
        End If
        Unstable.Text = Str(clunst)

    End Sub


    Private Sub Unstable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Unstable.KeyPress
2:
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
3:
            If clunst > clstab Then
                clunst = clstab
            Else
                clunst = clunst
            End If
            Unstable.Text = Str(clunst)
4:
        End If
5:
    End Sub


    Private Sub TextSkyTemp2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unstable.TextChanged


    End Sub

    Private Sub worthalooklimit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles worthalooklimit.Click



        If lolimit >= butlim Then
            lolimit = (butlim - 1)
        Else
            lolimit = lolimit
        End If
        worthalooklimit.Text = Str(lolimit)
    End Sub

    Private Sub worthalooklimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles worthalooklimit.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            If lolimit >= butlim Then
                lolimit = (butlim - 1)
            Else
                lolimit = lolimit
            End If
            worthalooklimit.Text = Str(lolimit)

        End If

    End Sub

    Private Sub clbutlim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clbutlim.Click
        If butlim >= clunst Then
            butlim = (clunst - 1)
        Else
            butlim = butlim
        End If
        clbutlim.Text = Str(butlim)
    End Sub
    Private Sub clbutlim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clbutlim.KeyPress
2:
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
3:
            If butlim >= clunst Then
                butlim = (clunst - 1)
            Else
                butlim = butlim
            End If
            clbutlim.Text = Str(butlim)
4:
        End If
5:
    End Sub


    Private Sub LoTempDiff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoTempDiff.Click

        lotempavdiffr = Val(LoTempDiff.Text)

        If lotempavdiffr >= hitempavdiffr Then

            lotempavdiffr = (hitempavdiffr - 1)
        Else
            lotempavdiffr = lotempavdiffr
        End If
        LoTempDiff.Text = Str(lotempavdiffr)
    End Sub

    Private Sub HiTempDiff_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HiTempDiff.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            hitempavdiffr = Val(HiTempDiff.Text)

            If hitempavdiffr < lotempavdiffr Then

                hitempavdiffr = (lotempavdiffr + 100)
            Else
                hitempavdiffr = hitempavdiffr
            End If
            HiTempDiff.Text = Str(hitempavdiffr)
        End If

    End Sub

    Private Sub HiTempDiff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HiTempDiff.Click

        If hitempavdiffr < lotempavdiffr Then

            hitempavdiffr = (lotempavdiffr + 100)
        Else
            hitempavdiffr = hitempavdiffr
        End If
        HiTempDiff.Text = Str(hitempavdiffr)
    End Sub

    Private Sub LoTempDiff_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LoTempDiff.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            lotempavdiffr = Val(LoTempDiff.Text)

            If lotempavdiffr >= hitempavdiffr Then

                lotempavdiffr = (hitempavdiffr - 1)
            Else
                lotempavdiffr = lotempavdiffr
            End If
            LoTempDiff.Text = Str(lotempavdiffr)

        End If

    End Sub


    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub



    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactToolStripMenuItem.Click
        Contact.Show()
    End Sub

    Private Sub ChartSkyTemp_Click(sender As Object, e As EventArgs) Handles ChartSkyTemp.Click

    End Sub

    Private Sub Chart2_AutoSizeChanged(sender As Object, e As EventArgs) Handles Chart2.AutoSizeChanged

    End Sub

    Private Sub Chart2_AxisViewChanged(sender As Object, e As ViewEventArgs) Handles Chart2.AxisViewChanged

    End Sub


    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Recall_Limits() ''' working but need to refine below criteria
        If DifferenceTemp <= (lolimit * 100) Then
            IsSafeTextBox.Text = "Not Safe"
            IsSafeTextBox.BackColor = Color.Red
        End If
        If DifferenceTemp >= (lolimit * 100) Then
            IsSafeTextBox.Text = "Safe"
            IsSafeTextBox.BackColor = Color.LightGreen
        End If
    End Sub
End Class