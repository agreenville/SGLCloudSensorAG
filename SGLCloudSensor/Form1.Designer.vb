<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloudSensorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreesecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Every10SecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyTempToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLoggingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAIN_PANEL = New System.Windows.Forms.Panel()
        Me.Cur_Avg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_LIGHT_LABEL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Enter_positive_LABEL = New System.Windows.Forms.Label()
        Me.PRECIP_LABEL = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LoTempDiff = New System.Windows.Forms.TextBox()
        Me.LblSkyTemp = New System.Windows.Forms.Label()
        Me.LblDiff = New System.Windows.Forms.Label()
        Me.LblAmbTemp = New System.Windows.Forms.Label()
        Me.Sensorambient = New System.Windows.Forms.TextBox()
        Me.TextSkyTemp = New System.Windows.Forms.TextBox()
        Me.TextAmbTemp = New System.Windows.Forms.TextBox()
        Me.worthalooklimit = New System.Windows.Forms.TextBox()
        Me.WORTHALOOK_LABEL = New System.Windows.Forms.Label()
        Me.CLEAR_BUT_LABEL = New System.Windows.Forms.Label()
        Me.clbutlim = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Stable = New System.Windows.Forms.TextBox()
        Me.CL_STABLE_LABEL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CL_UNSTABLE_LIMIT_LABEL = New System.Windows.Forms.Label()
        Me.HiTempDiff = New System.Windows.Forms.TextBox()
        Me.Unstable = New System.Windows.Forms.TextBox()
        Me.LblIRsensor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RAIN_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CL_UNSTABLE_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CLEARISH_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CL_STABLE_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CLEARING_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CLOUD_LIGHT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.worthalook = New System.Windows.Forms.Label()
        Me.ButConn = New System.Windows.Forms.Button()
        Me.TXTCommPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Avail_Ports = New System.Windows.Forms.ListBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TmrCloudSensor = New System.Windows.Forms.Timer(Me.components)
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.COMMS_PANEL = New System.Windows.Forms.Panel()
        Me.ButHideTemp = New System.Windows.Forms.Button()
        Me.ButTempDif = New System.Windows.Forms.Button()
        Me.ChartSkyTemp = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.loggingcheck = New System.Windows.Forms.CheckBox()
        Me.IsSafeTextBox = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.MAIN_PANEL.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.COMMS_PANEL.SuspendLayout()
        CType(Me.ChartSkyTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ChartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1212, 28)
        Me.MenuStrip1.TabIndex = 102
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloudSensorToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'CloudSensorToolStripMenuItem
        '
        Me.CloudSensorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OffToolStripMenuItem, Me.ThreesecToolStripMenuItem, Me.Every10SecToolStripMenuItem})
        Me.CloudSensorToolStripMenuItem.Name = "CloudSensorToolStripMenuItem"
        Me.CloudSensorToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.CloudSensorToolStripMenuItem.Text = "CloudSensor"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'ThreesecToolStripMenuItem
        '
        Me.ThreesecToolStripMenuItem.Name = "ThreesecToolStripMenuItem"
        Me.ThreesecToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.ThreesecToolStripMenuItem.Text = "3 second (recommended)"
        '
        'Every10SecToolStripMenuItem
        '
        Me.Every10SecToolStripMenuItem.Name = "Every10SecToolStripMenuItem"
        Me.Every10SecToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.Every10SecToolStripMenuItem.Text = "Every 10 sec"
        '
        'ChartToolStripMenuItem
        '
        Me.ChartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SkyTempToolStripMenuItem})
        Me.ChartToolStripMenuItem.Name = "ChartToolStripMenuItem"
        Me.ChartToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ChartToolStripMenuItem.Text = "Chart"
        '
        'SkyTempToolStripMenuItem
        '
        Me.SkyTempToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.PrintToolStripMenuItem})
        Me.SkyTempToolStripMenuItem.Name = "SkyTempToolStripMenuItem"
        Me.SkyTempToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.SkyTempToolStripMenuItem.Text = "Sky Temp"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(118, 26)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1, Me.HelpToolStripMenuItem, Me.ContactToolStripMenuItem, Me.DataLoggingToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ExitToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(211, 26)
        Me.ExitToolStripMenuItem1.Text = "Close Cloud Sensor"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'DataLoggingToolStripMenuItem
        '
        Me.DataLoggingToolStripMenuItem.Name = "DataLoggingToolStripMenuItem"
        Me.DataLoggingToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.DataLoggingToolStripMenuItem.Text = "Data Logging"
        '
        'MAIN_PANEL
        '
        Me.MAIN_PANEL.BackColor = System.Drawing.Color.SlateGray
        Me.MAIN_PANEL.Controls.Add(Me.Cur_Avg)
        Me.MAIN_PANEL.Controls.Add(Me.Label1)
        Me.MAIN_PANEL.Controls.Add(Me.T_LIGHT_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.Label6)
        Me.MAIN_PANEL.Controls.Add(Me.Enter_positive_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.PRECIP_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.Label12)
        Me.MAIN_PANEL.Controls.Add(Me.LoTempDiff)
        Me.MAIN_PANEL.Controls.Add(Me.LblSkyTemp)
        Me.MAIN_PANEL.Controls.Add(Me.LblDiff)
        Me.MAIN_PANEL.Controls.Add(Me.LblAmbTemp)
        Me.MAIN_PANEL.Controls.Add(Me.Sensorambient)
        Me.MAIN_PANEL.Controls.Add(Me.TextSkyTemp)
        Me.MAIN_PANEL.Controls.Add(Me.TextAmbTemp)
        Me.MAIN_PANEL.Controls.Add(Me.worthalooklimit)
        Me.MAIN_PANEL.Controls.Add(Me.WORTHALOOK_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.CLEAR_BUT_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.clbutlim)
        Me.MAIN_PANEL.Controls.Add(Me.Label9)
        Me.MAIN_PANEL.Controls.Add(Me.Stable)
        Me.MAIN_PANEL.Controls.Add(Me.CL_STABLE_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.Label7)
        Me.MAIN_PANEL.Controls.Add(Me.CL_UNSTABLE_LIMIT_LABEL)
        Me.MAIN_PANEL.Controls.Add(Me.HiTempDiff)
        Me.MAIN_PANEL.Controls.Add(Me.Unstable)
        Me.MAIN_PANEL.Controls.Add(Me.LblIRsensor)
        Me.MAIN_PANEL.Controls.Add(Me.Label3)
        Me.MAIN_PANEL.Controls.Add(Me.ShapeContainer1)
        Me.MAIN_PANEL.Controls.Add(Me.worthalook)
        Me.MAIN_PANEL.Location = New System.Drawing.Point(0, 30)
        Me.MAIN_PANEL.Margin = New System.Windows.Forms.Padding(4)
        Me.MAIN_PANEL.Name = "MAIN_PANEL"
        Me.MAIN_PANEL.Size = New System.Drawing.Size(995, 145)
        Me.MAIN_PANEL.TabIndex = 103
        '
        'Cur_Avg
        '
        Me.Cur_Avg.BackColor = System.Drawing.Color.SlateGray
        Me.Cur_Avg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cur_Avg.ForeColor = System.Drawing.SystemColors.Control
        Me.Cur_Avg.Location = New System.Drawing.Point(404, 118)
        Me.Cur_Avg.Margin = New System.Windows.Forms.Padding(4)
        Me.Cur_Avg.Name = "Cur_Avg"
        Me.Cur_Avg.Size = New System.Drawing.Size(64, 15)
        Me.Cur_Avg.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(475, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "CURRENT DIFFERENCE"
        '
        'T_LIGHT_LABEL
        '
        Me.T_LIGHT_LABEL.BackColor = System.Drawing.Color.SlateGray
        Me.T_LIGHT_LABEL.ForeColor = System.Drawing.Color.White
        Me.T_LIGHT_LABEL.Location = New System.Drawing.Point(5, 47)
        Me.T_LIGHT_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.T_LIGHT_LABEL.Name = "T_LIGHT_LABEL"
        Me.T_LIGHT_LABEL.Size = New System.Drawing.Size(163, 25)
        Me.T_LIGHT_LABEL.TabIndex = 133
        Me.T_LIGHT_LABEL.Tag = ""
        Me.T_LIGHT_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(168, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 18)
        Me.Label6.TabIndex = 117
        '
        'Enter_positive_LABEL
        '
        Me.Enter_positive_LABEL.AutoSize = True
        Me.Enter_positive_LABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.Enter_positive_LABEL.Location = New System.Drawing.Point(213, 2)
        Me.Enter_positive_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Enter_positive_LABEL.Name = "Enter_positive_LABEL"
        Me.Enter_positive_LABEL.Size = New System.Drawing.Size(226, 17)
        Me.Enter_positive_LABEL.TabIndex = 132
        Me.Enter_positive_LABEL.Text = "LIMITS - POSITIVE VALUES ONLY"
        '
        'PRECIP_LABEL
        '
        Me.PRECIP_LABEL.AutoSize = True
        Me.PRECIP_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.PRECIP_LABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIP_LABEL.ForeColor = System.Drawing.Color.White
        Me.PRECIP_LABEL.Location = New System.Drawing.Point(60, 102)
        Me.PRECIP_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PRECIP_LABEL.Name = "PRECIP_LABEL"
        Me.PRECIP_LABEL.Size = New System.Drawing.Size(0, 17)
        Me.PRECIP_LABEL.TabIndex = 131
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(476, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 17)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "LOW DIFFERENCE (1K?)"
        '
        'LoTempDiff
        '
        Me.LoTempDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LoTempDiff.Location = New System.Drawing.Point(404, 84)
        Me.LoTempDiff.Margin = New System.Windows.Forms.Padding(4)
        Me.LoTempDiff.Name = "LoTempDiff"
        Me.LoTempDiff.Size = New System.Drawing.Size(63, 22)
        Me.LoTempDiff.TabIndex = 129
        '
        'LblSkyTemp
        '
        Me.LblSkyTemp.AutoSize = True
        Me.LblSkyTemp.BackColor = System.Drawing.Color.Transparent
        Me.LblSkyTemp.ForeColor = System.Drawing.SystemColors.Control
        Me.LblSkyTemp.Location = New System.Drawing.Point(801, 63)
        Me.LblSkyTemp.Name = "LblSkyTemp"
        Me.LblSkyTemp.Size = New System.Drawing.Size(77, 17)
        Me.LblSkyTemp.TabIndex = 45
        Me.LblSkyTemp.Text = "SKY TEMP"
        '
        'LblDiff
        '
        Me.LblDiff.AutoSize = True
        Me.LblDiff.ForeColor = System.Drawing.SystemColors.Control
        Me.LblDiff.Location = New System.Drawing.Point(771, 116)
        Me.LblDiff.Name = "LblDiff"
        Me.LblDiff.Size = New System.Drawing.Size(108, 17)
        Me.LblDiff.TabIndex = 90
        Me.LblDiff.Text = "SENSOR TEMP"
        '
        'LblAmbTemp
        '
        Me.LblAmbTemp.AutoSize = True
        Me.LblAmbTemp.ForeColor = System.Drawing.SystemColors.Control
        Me.LblAmbTemp.Location = New System.Drawing.Point(767, 90)
        Me.LblAmbTemp.Name = "LblAmbTemp"
        Me.LblAmbTemp.Size = New System.Drawing.Size(110, 17)
        Me.LblAmbTemp.TabIndex = 46
        Me.LblAmbTemp.Text = "AMBIENT TEMP"
        '
        'Sensorambient
        '
        Me.Sensorambient.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Sensorambient.Location = New System.Drawing.Point(888, 112)
        Me.Sensorambient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sensorambient.Name = "Sensorambient"
        Me.Sensorambient.Size = New System.Drawing.Size(63, 22)
        Me.Sensorambient.TabIndex = 92
        Me.Sensorambient.Text = "0"
        '
        'TextSkyTemp
        '
        Me.TextSkyTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextSkyTemp.Location = New System.Drawing.Point(888, 55)
        Me.TextSkyTemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextSkyTemp.Name = "TextSkyTemp"
        Me.TextSkyTemp.Size = New System.Drawing.Size(63, 22)
        Me.TextSkyTemp.TabIndex = 47
        '
        'TextAmbTemp
        '
        Me.TextAmbTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextAmbTemp.Location = New System.Drawing.Point(888, 84)
        Me.TextAmbTemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextAmbTemp.Name = "TextAmbTemp"
        Me.TextAmbTemp.Size = New System.Drawing.Size(63, 22)
        Me.TextAmbTemp.TabIndex = 48
        '
        'worthalooklimit
        '
        Me.worthalooklimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.worthalooklimit.Location = New System.Drawing.Point(217, 22)
        Me.worthalooklimit.Margin = New System.Windows.Forms.Padding(4)
        Me.worthalooklimit.MaxLength = 3
        Me.worthalooklimit.Name = "worthalooklimit"
        Me.worthalooklimit.Size = New System.Drawing.Size(33, 22)
        Me.worthalooklimit.TabIndex = 128
        Me.worthalooklimit.Text = "16"
        '
        'WORTHALOOK_LABEL
        '
        Me.WORTHALOOK_LABEL.AutoSize = True
        Me.WORTHALOOK_LABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.WORTHALOOK_LABEL.Location = New System.Drawing.Point(260, 28)
        Me.WORTHALOOK_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WORTHALOOK_LABEL.Name = "WORTHALOOK_LABEL"
        Me.WORTHALOOK_LABEL.Size = New System.Drawing.Size(60, 17)
        Me.WORTHALOOK_LABEL.TabIndex = 127
        Me.WORTHALOOK_LABEL.Text = "CLOUD "
        '
        'CLEAR_BUT_LABEL
        '
        Me.CLEAR_BUT_LABEL.AutoSize = True
        Me.CLEAR_BUT_LABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.CLEAR_BUT_LABEL.Location = New System.Drawing.Point(260, 59)
        Me.CLEAR_BUT_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CLEAR_BUT_LABEL.Name = "CLEAR_BUT_LABEL"
        Me.CLEAR_BUT_LABEL.Size = New System.Drawing.Size(101, 17)
        Me.CLEAR_BUT_LABEL.TabIndex = 126
        Me.CLEAR_BUT_LABEL.Text = "LIGHT CLOUD"
        '
        'clbutlim
        '
        Me.clbutlim.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.clbutlim.Location = New System.Drawing.Point(217, 54)
        Me.clbutlim.Margin = New System.Windows.Forms.Padding(4)
        Me.clbutlim.MaxLength = 2
        Me.clbutlim.Name = "clbutlim"
        Me.clbutlim.Size = New System.Drawing.Size(33, 22)
        Me.clbutlim.TabIndex = 125
        Me.clbutlim.Text = "18"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(168, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 124
        '
        'Stable
        '
        Me.Stable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Stable.Location = New System.Drawing.Point(217, 114)
        Me.Stable.Margin = New System.Windows.Forms.Padding(4)
        Me.Stable.MaxLength = 2
        Me.Stable.Name = "Stable"
        Me.Stable.Size = New System.Drawing.Size(33, 22)
        Me.Stable.TabIndex = 123
        Me.Stable.Text = "23"
        '
        'CL_STABLE_LABEL
        '
        Me.CL_STABLE_LABEL.AutoSize = True
        Me.CL_STABLE_LABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.CL_STABLE_LABEL.Location = New System.Drawing.Point(260, 119)
        Me.CL_STABLE_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CL_STABLE_LABEL.Name = "CL_STABLE_LABEL"
        Me.CL_STABLE_LABEL.Size = New System.Drawing.Size(110, 17)
        Me.CL_STABLE_LABEL.TabIndex = 122
        Me.CL_STABLE_LABEL.Text = "CLEAR STABLE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(476, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 17)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "HIGH DIFFERENCE (10K+)"
        '
        'CL_UNSTABLE_LIMIT_LABEL
        '
        Me.CL_UNSTABLE_LIMIT_LABEL.AutoSize = True
        Me.CL_UNSTABLE_LIMIT_LABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.CL_UNSTABLE_LIMIT_LABEL.Location = New System.Drawing.Point(260, 89)
        Me.CL_UNSTABLE_LIMIT_LABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CL_UNSTABLE_LIMIT_LABEL.Name = "CL_UNSTABLE_LIMIT_LABEL"
        Me.CL_UNSTABLE_LIMIT_LABEL.Size = New System.Drawing.Size(130, 17)
        Me.CL_UNSTABLE_LIMIT_LABEL.TabIndex = 120
        Me.CL_UNSTABLE_LIMIT_LABEL.Text = "CLEAR UNSTABLE"
        '
        'HiTempDiff
        '
        Me.HiTempDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HiTempDiff.Location = New System.Drawing.Point(404, 55)
        Me.HiTempDiff.Margin = New System.Windows.Forms.Padding(4)
        Me.HiTempDiff.MaxLength = 210
        Me.HiTempDiff.Name = "HiTempDiff"
        Me.HiTempDiff.Size = New System.Drawing.Size(63, 22)
        Me.HiTempDiff.TabIndex = 119
        '
        'Unstable
        '
        Me.Unstable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Unstable.Location = New System.Drawing.Point(217, 84)
        Me.Unstable.Margin = New System.Windows.Forms.Padding(4)
        Me.Unstable.MaxLength = 2
        Me.Unstable.Name = "Unstable"
        Me.Unstable.Size = New System.Drawing.Size(33, 22)
        Me.Unstable.TabIndex = 118
        Me.Unstable.Text = "22"
        '
        'LblIRsensor
        '
        Me.LblIRsensor.AutoSize = True
        Me.LblIRsensor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIRsensor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblIRsensor.Location = New System.Drawing.Point(535, 2)
        Me.LblIRsensor.Name = "LblIRsensor"
        Me.LblIRsensor.Size = New System.Drawing.Size(281, 36)
        Me.LblIRsensor.TabIndex = 115
        Me.LblIRsensor.Text = "SGL Cloud Detector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(167, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 51
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RAIN_LIGHT, Me.CL_UNSTABLE_LIGHT, Me.CLEARISH_LIGHT, Me.CL_STABLE_LIGHT, Me.CLEARING_LIGHT, Me.CLOUD_LIGHT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(995, 145)
        Me.ShapeContainer1.TabIndex = 105
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.Control
        Me.RectangleShape1.CornerRadius = 6
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.Size = New System.Drawing.Size(126, 61)
        '
        'RAIN_LIGHT
        '
        Me.RAIN_LIGHT.BackColor = System.Drawing.Color.DarkTurquoise
        Me.RAIN_LIGHT.CornerRadius = 6
        Me.RAIN_LIGHT.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RAIN_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAIN_LIGHT.Location = New System.Drawing.Point(3, 78)
        Me.RAIN_LIGHT.Name = "RAIN_LIGHT"
        Me.RAIN_LIGHT.Size = New System.Drawing.Size(36, 23)
        '
        'CL_UNSTABLE_LIGHT
        '
        Me.CL_UNSTABLE_LIGHT.CornerRadius = 6
        Me.CL_UNSTABLE_LIGHT.FillColor = System.Drawing.Color.MediumTurquoise
        Me.CL_UNSTABLE_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent75
        Me.CL_UNSTABLE_LIGHT.Location = New System.Drawing.Point(6, 5)
        Me.CL_UNSTABLE_LIGHT.Name = "CL_UNSTABLE_LIGHT"
        Me.CL_UNSTABLE_LIGHT.SelectionColor = System.Drawing.SystemColors.Control
        Me.CL_UNSTABLE_LIGHT.Size = New System.Drawing.Size(120, 30)
        '
        'CLEARISH_LIGHT
        '
        Me.CLEARISH_LIGHT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CLEARISH_LIGHT.CornerRadius = 6
        Me.CLEARISH_LIGHT.FillColor = System.Drawing.Color.Violet
        Me.CLEARISH_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent75
        Me.CLEARISH_LIGHT.Location = New System.Drawing.Point(5, 5)
        Me.CLEARISH_LIGHT.Name = "CLEARISH_LIGHT"
        Me.CLEARISH_LIGHT.Size = New System.Drawing.Size(120, 30)
        '
        'CL_STABLE_LIGHT
        '
        Me.CL_STABLE_LIGHT.BackColor = System.Drawing.Color.Lime
        Me.CL_STABLE_LIGHT.CornerRadius = 6
        Me.CL_STABLE_LIGHT.FillColor = System.Drawing.Color.GreenYellow
        Me.CL_STABLE_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent75
        Me.CL_STABLE_LIGHT.Location = New System.Drawing.Point(5, 5)
        Me.CL_STABLE_LIGHT.Name = "CL_STABLE_LIGHT"
        Me.CL_STABLE_LIGHT.Size = New System.Drawing.Size(120, 30)
        '
        'CLEARING_LIGHT
        '
        Me.CLEARING_LIGHT.BackColor = System.Drawing.Color.Yellow
        Me.CLEARING_LIGHT.CornerRadius = 6
        Me.CLEARING_LIGHT.FillColor = System.Drawing.Color.Orange
        Me.CLEARING_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent75
        Me.CLEARING_LIGHT.Location = New System.Drawing.Point(5, 5)
        Me.CLEARING_LIGHT.Name = "CLEARING_LIGHT"
        Me.CLEARING_LIGHT.Size = New System.Drawing.Size(120, 30)
        '
        'CLOUD_LIGHT
        '
        Me.CLOUD_LIGHT.BackColor = System.Drawing.Color.Red
        Me.CLOUD_LIGHT.CornerRadius = 6
        Me.CLOUD_LIGHT.FillColor = System.Drawing.Color.Red
        Me.CLOUD_LIGHT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent75
        Me.CLOUD_LIGHT.Location = New System.Drawing.Point(5, 5)
        Me.CLOUD_LIGHT.Name = "CLOUD_LIGHT"
        Me.CLOUD_LIGHT.Size = New System.Drawing.Size(120, 30)
        '
        'worthalook
        '
        Me.worthalook.AutoSize = True
        Me.worthalook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.worthalook.ForeColor = System.Drawing.Color.White
        Me.worthalook.Location = New System.Drawing.Point(167, 32)
        Me.worthalook.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.worthalook.Name = "worthalook"
        Me.worthalook.Size = New System.Drawing.Size(0, 18)
        Me.worthalook.TabIndex = 50
        '
        'ButConn
        '
        Me.ButConn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButConn.Location = New System.Drawing.Point(124, 81)
        Me.ButConn.Margin = New System.Windows.Forms.Padding(4)
        Me.ButConn.Name = "ButConn"
        Me.ButConn.Size = New System.Drawing.Size(99, 32)
        Me.ButConn.TabIndex = 110
        Me.ButConn.Text = "Connect"
        Me.ButConn.UseVisualStyleBackColor = False
        '
        'TXTCommPort
        '
        Me.TXTCommPort.Location = New System.Drawing.Point(121, 31)
        Me.TXTCommPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCommPort.Name = "TXTCommPort"
        Me.TXTCommPort.Size = New System.Drawing.Size(97, 22)
        Me.TXTCommPort.TabIndex = 109
        Me.TXTCommPort.Text = "COM3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(127, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Comm Port:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(7, 10)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 22)
        Me.TextBox3.TabIndex = 107
        Me.TextBox3.Text = "Available Ports"
        '
        'Avail_Ports
        '
        Me.Avail_Ports.FormattingEnabled = True
        Me.Avail_Ports.ItemHeight = 16
        Me.Avail_Ports.Location = New System.Drawing.Point(7, 33)
        Me.Avail_Ports.Margin = New System.Windows.Forms.Padding(4)
        Me.Avail_Ports.Name = "Avail_Ports"
        Me.Avail_Ports.Size = New System.Drawing.Size(105, 84)
        Me.Avail_Ports.TabIndex = 106
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'TmrCloudSensor
        '
        Me.TmrCloudSensor.Enabled = True
        Me.TmrCloudSensor.Interval = 10000
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(21, 148)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Temp Sky"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Temp Amb"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "Temp Diff"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(942, 287)
        Me.Chart2.TabIndex = 105
        Me.Chart2.Text = "Chart1"
        '
        'COMMS_PANEL
        '
        Me.COMMS_PANEL.BackColor = System.Drawing.Color.SlateGray
        Me.COMMS_PANEL.Controls.Add(Me.TXTCommPort)
        Me.COMMS_PANEL.Controls.Add(Me.Avail_Ports)
        Me.COMMS_PANEL.Controls.Add(Me.ButConn)
        Me.COMMS_PANEL.Controls.Add(Me.TextBox3)
        Me.COMMS_PANEL.Controls.Add(Me.Label2)
        Me.COMMS_PANEL.Location = New System.Drawing.Point(985, 30)
        Me.COMMS_PANEL.Margin = New System.Windows.Forms.Padding(4)
        Me.COMMS_PANEL.Name = "COMMS_PANEL"
        Me.COMMS_PANEL.Size = New System.Drawing.Size(232, 145)
        Me.COMMS_PANEL.TabIndex = 115
        '
        'ButHideTemp
        '
        Me.ButHideTemp.BackColor = System.Drawing.Color.Silver
        Me.ButHideTemp.Location = New System.Drawing.Point(1067, 318)
        Me.ButHideTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.ButHideTemp.Name = "ButHideTemp"
        Me.ButHideTemp.Size = New System.Drawing.Size(108, 47)
        Me.ButHideTemp.TabIndex = 119
        Me.ButHideTemp.Text = "Hide Real Time Values"
        Me.ButHideTemp.UseVisualStyleBackColor = False
        '
        'ButTempDif
        '
        Me.ButTempDif.BackColor = System.Drawing.Color.Silver
        Me.ButTempDif.Location = New System.Drawing.Point(1067, 391)
        Me.ButTempDif.Margin = New System.Windows.Forms.Padding(4)
        Me.ButTempDif.Name = "ButTempDif"
        Me.ButTempDif.Size = New System.Drawing.Size(108, 44)
        Me.ButTempDif.TabIndex = 120
        Me.ButTempDif.Text = "Hide Averages"
        Me.ButTempDif.UseVisualStyleBackColor = False
        '
        'ChartSkyTemp
        '
        Me.ChartSkyTemp.BackColor = System.Drawing.Color.SlateGray
        Me.ChartSkyTemp.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Me.ChartSkyTemp.BackSecondaryColor = System.Drawing.Color.LightSteelBlue
        ChartArea2.AxisX2.CustomLabels.Add(CustomLabel1)
        ChartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.LabelStyle.Interval = 5.0R
        ChartArea2.AxisY.MajorGrid.Interval = 5.0R
        ChartArea2.AxisY.MajorTickMark.Interval = 5.0R
        ChartArea2.AxisY.Maximum = 35.0R
        ChartArea2.AxisY.Minimum = -25.0R
        ChartArea2.AxisY.Title = "Temperature"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY2.MinorGrid.Enabled = True
        ChartArea2.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.BackSecondaryColor = System.Drawing.Color.LightSteelBlue
        ChartArea2.Name = "ChartArea1"
        Me.ChartSkyTemp.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Gainsboro
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartSkyTemp.Legends.Add(Legend2)
        Me.ChartSkyTemp.Location = New System.Drawing.Point(0, 174)
        Me.ChartSkyTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.ChartSkyTemp.Name = "ChartSkyTemp"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series4.Legend = "Legend1"
        Series4.MarkerColor = System.Drawing.Color.White
        Series4.Name = "Sky Temp"
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.Fuchsia
        Series5.Legend = "Legend1"
        Series5.MarkerColor = System.Drawing.Color.White
        Series5.Name = "Sky Temp Average"
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.Orange
        Series6.Legend = "Legend1"
        Series6.Name = "Ambient Temp"
        Series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Color = System.Drawing.Color.OrangeRed
        Series7.Legend = "Legend1"
        Series7.Name = "Temp Diff"
        Series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.Lime
        Series8.Legend = "Legend1"
        Series8.MarkerColor = System.Drawing.Color.White
        Series8.Name = "Temp Diff Average"
        Series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.Color = System.Drawing.Color.Yellow
        Series9.Legend = "Legend1"
        Series9.Name = "Sensor Temp"
        Series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.ChartSkyTemp.Series.Add(Series4)
        Me.ChartSkyTemp.Series.Add(Series5)
        Me.ChartSkyTemp.Series.Add(Series6)
        Me.ChartSkyTemp.Series.Add(Series7)
        Me.ChartSkyTemp.Series.Add(Series8)
        Me.ChartSkyTemp.Series.Add(Series9)
        Me.ChartSkyTemp.Size = New System.Drawing.Size(1213, 353)
        Me.ChartSkyTemp.TabIndex = 105
        Me.ChartSkyTemp.Text = "Chart1"
        '
        'loggingcheck
        '
        Me.loggingcheck.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.loggingcheck.AutoSize = True
        Me.loggingcheck.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.loggingcheck.Checked = True
        Me.loggingcheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.loggingcheck.ForeColor = System.Drawing.Color.Black
        Me.loggingcheck.Location = New System.Drawing.Point(1074, 455)
        Me.loggingcheck.Name = "loggingcheck"
        Me.loggingcheck.Size = New System.Drawing.Size(81, 21)
        Me.loggingcheck.TabIndex = 121
        Me.loggingcheck.Text = "Logging"
        Me.loggingcheck.UseVisualStyleBackColor = False
        '
        'IsSafeTextBox
        '
        Me.IsSafeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsSafeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IsSafeTextBox.HideSelection = False
        Me.IsSafeTextBox.Location = New System.Drawing.Point(1091, 493)
        Me.IsSafeTextBox.Name = "IsSafeTextBox"
        Me.IsSafeTextBox.Size = New System.Drawing.Size(84, 22)
        Me.IsSafeTextBox.TabIndex = 123
        Me.IsSafeTextBox.Text = "isSafe"
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1212, 527)
        Me.Controls.Add(Me.IsSafeTextBox)
        Me.Controls.Add(Me.loggingcheck)
        Me.Controls.Add(Me.ButHideTemp)
        Me.Controls.Add(Me.ButTempDif)
        Me.Controls.Add(Me.COMMS_PANEL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MAIN_PANEL)
        Me.Controls.Add(Me.ChartSkyTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "SGL Cloud Sensor Evo - v3.1  "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MAIN_PANEL.ResumeLayout(False)
        Me.MAIN_PANEL.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.COMMS_PANEL.ResumeLayout(False)
        Me.COMMS_PANEL.PerformLayout()
        CType(Me.ChartSkyTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloudSensorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Every10SecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAIN_PANEL As System.Windows.Forms.Panel
    Friend WithEvents Sensorambient As System.Windows.Forms.TextBox
    Friend WithEvents LblDiff As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents worthalook As System.Windows.Forms.Label
    Friend WithEvents TextAmbTemp As System.Windows.Forms.TextBox
    Friend WithEvents TextSkyTemp As System.Windows.Forms.TextBox
    Friend WithEvents LblAmbTemp As System.Windows.Forms.Label
    Friend WithEvents LblSkyTemp As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TmrCloudSensor As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ButConn As System.Windows.Forms.Button
    Friend WithEvents TXTCommPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Avail_Ports As System.Windows.Forms.ListBox
    Friend WithEvents COMMS_PANEL As System.Windows.Forms.Panel
    Friend WithEvents LblIRsensor As System.Windows.Forms.Label
    Friend WithEvents ButHideTemp As System.Windows.Forms.Button
    Friend WithEvents ButTempDif As System.Windows.Forms.Button
    Friend WithEvents SkyTempToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLOUD_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CLEARING_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CL_STABLE_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CLEARISH_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Unstable As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CL_UNSTABLE_LIMIT_LABEL As System.Windows.Forms.Label
    Friend WithEvents CL_STABLE_LABEL As System.Windows.Forms.Label
    Friend WithEvents Stable As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CL_UNSTABLE_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents clbutlim As System.Windows.Forms.TextBox
    Friend WithEvents HiTempDiff As System.Windows.Forms.TextBox
    Friend WithEvents CLEAR_BUT_LABEL As System.Windows.Forms.Label
    Friend WithEvents worthalooklimit As System.Windows.Forms.TextBox
    Friend WithEvents WORTHALOOK_LABEL As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LoTempDiff As System.Windows.Forms.TextBox
    Friend WithEvents RAIN_LIGHT As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PRECIP_LABEL As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Enter_positive_LABEL As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Private WithEvents T_LIGHT_LABEL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cur_Avg As System.Windows.Forms.TextBox
    Friend WithEvents ThreesecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartSkyTemp As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents loggingcheck As CheckBox
    Friend WithEvents IsSafeTextBox As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents DataLoggingToolStripMenuItem As ToolStripMenuItem
End Class
