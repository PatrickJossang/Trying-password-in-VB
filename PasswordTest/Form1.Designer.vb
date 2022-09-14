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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblConnectInfo = New System.Windows.Forms.Label()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.CbUserName = New System.Windows.Forms.CheckBox()
        Me.CbPassword = New System.Windows.Forms.CheckBox()
        Me.TSMPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChbHideShow = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMPassword})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(122, 66)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(223, 20)
        Me.TxtUserName.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(122, 104)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(223, 20)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(12, 66)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(77, 13)
        Me.LblUserName.TabIndex = 3
        Me.LblUserName.Text = "User name:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(12, 104)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(70, 13)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password:"
        '
        'LblConnectInfo
        '
        Me.LblConnectInfo.AutoSize = True
        Me.LblConnectInfo.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConnectInfo.Location = New System.Drawing.Point(13, 33)
        Me.LblConnectInfo.Name = "LblConnectInfo"
        Me.LblConnectInfo.Size = New System.Drawing.Size(101, 12)
        Me.LblConnectInfo.TabIndex = 5
        Me.LblConnectInfo.Text = "Connect to Form2"
        '
        'BtnEnd
        '
        Me.BtnEnd.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnd.Location = New System.Drawing.Point(270, 146)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 6
        Me.BtnEnd.Text = "Cancel"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(189, 146)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 23)
        Me.BtnOk.TabIndex = 7
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'CbUserName
        '
        Me.CbUserName.AutoCheck = False
        Me.CbUserName.AutoSize = True
        Me.CbUserName.BackColor = System.Drawing.Color.Transparent
        Me.CbUserName.Location = New System.Drawing.Point(351, 69)
        Me.CbUserName.Name = "CbUserName"
        Me.CbUserName.Size = New System.Drawing.Size(15, 14)
        Me.CbUserName.TabIndex = 8
        Me.CbUserName.UseVisualStyleBackColor = False
        Me.CbUserName.Visible = False
        '
        'CbPassword
        '
        Me.CbPassword.AutoCheck = False
        Me.CbPassword.AutoSize = True
        Me.CbPassword.BackColor = System.Drawing.Color.Transparent
        Me.CbPassword.Location = New System.Drawing.Point(351, 107)
        Me.CbPassword.Name = "CbPassword"
        Me.CbPassword.Size = New System.Drawing.Size(15, 14)
        Me.CbPassword.TabIndex = 9
        Me.CbPassword.UseVisualStyleBackColor = False
        Me.CbPassword.Visible = False
        '
        'TSMPassword
        '
        Me.TSMPassword.Name = "TSMPassword"
        Me.TSMPassword.Size = New System.Drawing.Size(180, 22)
        Me.TSMPassword.Text = "Reset password"
        '
        'ChbHideShow
        '
        Me.ChbHideShow.AutoSize = True
        Me.ChbHideShow.BackColor = System.Drawing.Color.Transparent
        Me.ChbHideShow.Location = New System.Drawing.Point(292, 125)
        Me.ChbHideShow.Name = "ChbHideShow"
        Me.ChbHideShow.Size = New System.Drawing.Size(53, 17)
        Me.ChbHideShow.TabIndex = 10
        Me.ChbHideShow.Text = "Show"
        Me.ChbHideShow.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 181)
        Me.Controls.Add(Me.CbPassword)
        Me.Controls.Add(Me.CbUserName)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.LblConnectInfo)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ChbHideShow)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblConnectInfo As Label
    Friend WithEvents BtnEnd As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents CbUserName As CheckBox
    Friend WithEvents CbPassword As CheckBox
    Friend WithEvents TSMPassword As ToolStripMenuItem
    Friend WithEvents ChbHideShow As CheckBox
End Class
