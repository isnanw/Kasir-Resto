<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.TUsername = New System.Windows.Forms.TextBox()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TUsername
        '
        Me.TUsername.Location = New System.Drawing.Point(69, 45)
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(215, 20)
        Me.TUsername.TabIndex = 0
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(69, 80)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(215, 20)
        Me.TPassword.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 183)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TUsername)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TUsername As System.Windows.Forms.TextBox
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
