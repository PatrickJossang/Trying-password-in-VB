<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm1
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
        Me.TxtOldPassword = New System.Windows.Forms.TextBox()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.LblOldPassword = New System.Windows.Forms.Label()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtOldPassword
        '
        Me.TxtOldPassword.Location = New System.Drawing.Point(298, 106)
        Me.TxtOldPassword.Name = "TxtOldPassword"
        Me.TxtOldPassword.Size = New System.Drawing.Size(204, 20)
        Me.TxtOldPassword.TabIndex = 0
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Location = New System.Drawing.Point(298, 150)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(204, 20)
        Me.TxtNewPassword.TabIndex = 1
        '
        'LblOldPassword
        '
        Me.LblOldPassword.AutoSize = True
        Me.LblOldPassword.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOldPassword.Location = New System.Drawing.Point(188, 112)
        Me.LblOldPassword.Name = "LblOldPassword"
        Me.LblOldPassword.Size = New System.Drawing.Size(83, 12)
        Me.LblOldPassword.TabIndex = 2
        Me.LblOldPassword.Text = "Old password:"
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewPassword.Location = New System.Drawing.Point(188, 153)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(81, 12)
        Me.LblNewPassword.TabIndex = 3
        Me.LblNewPassword.Text = "New password:"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(426, 202)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(345, 202)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PasswordForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 262)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.LblOldPassword)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.TxtOldPassword)
        Me.Name = "PasswordForm1"
        Me.Text = "Resett password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOldPassword As TextBox
    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents LblOldPassword As Label
    Friend WithEvents LblNewPassword As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnExit As Button
End Class
