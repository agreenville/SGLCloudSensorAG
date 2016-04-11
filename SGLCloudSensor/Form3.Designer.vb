<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contact))
        Me.ContactText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ContactText
        '
        Me.ContactText.BackColor = System.Drawing.SystemColors.Menu
        Me.ContactText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactText.Location = New System.Drawing.Point(12, 12)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.ReadOnly = True
        Me.ContactText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.ContactText.Size = New System.Drawing.Size(360, 218)
        Me.ContactText.TabIndex = 0
        Me.ContactText.Text = resources.GetString("ContactText.Text")
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 239)
        Me.Controls.Add(Me.ContactText)
        Me.Name = "Contact"
        Me.Text = "Contact Details"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContactText As System.Windows.Forms.RichTextBox
End Class
