Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Password string
        RightUser = "User"
        'User string
        RightPassord = "Test"
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Password

        If RightPassord = TxtPassword.Text Then
            CbPassword.Hide()
        Else
            MsgBox("Wrong password", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "login")
            TxtPassword.Text = ""
            TxtPassword.Focus()
            CbPassword.Show()
        End If

        'username

        If TxtUserName.Text = RightUser Then
            CbUserName.Hide()
        Else
            MsgBox("Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "login")
            TxtUserName.Text = ""
            CbUserName.Show()
        End If
        'viss alt stemmer
        If TxtPassword.Text = RightPassord And TxtUserName.Text = RightUser Then
            MsgBox("You are logged in", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "login")
        End If
    End Sub
    'Enter to prossed
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = 13 Then

            If RightPassord = TxtPassword.Text Then
                CbPassword.Hide()
            Else
                MsgBox("Wrong password", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "login")
                TxtPassword.Text = ""
                TxtPassword.Focus()
                CbPassword.Show()
            End If

            'username

            If TxtUserName.Text = RightUser Then
                CbUserName.Hide()
            Else
                MsgBox("Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "login")
                TxtUserName.Text = ""
                CbUserName.Show()
            End If
            'viss alt stemmer
            If TxtPassword.Text = RightPassord And TxtUserName.Text = RightUser Then
                MsgBox("You are logged in", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "login")
            End If
        End If
    End Sub

    'Exit
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click

        iExit = MessageBox.Show("Confirm if you want to exit", "Passwordtest", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'red cross
    Private Sub CbUserName_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CbUserName.Paint, CbPassword.Paint
        If DirectCast(sender, CheckBox).Checked = False Then
            Dim rect As New Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 2, 11, 12)
            e.Graphics.DrawLine(New Pen(Color.Red, 2), rect.X, rect.Y, rect.Width, rect.Height)
            e.Graphics.DrawLine(New Pen(Color.Red, 2), rect.X, rect.Height, rect.Width, rect.Y)
        End If
    End Sub

    Private Sub TSMPassword_Click(sender As Object, e As EventArgs) Handles TSMPassword.Click
        Me.Hide()
        PasswordForm1.Show()
    End Sub

    Private Sub ChbHideShow_CheckedChanged(sender As Object, e As EventArgs) Handles ChbHideShow.CheckedChanged
        If ChbHideShow.Checked = True Then

            TxtPassword.UseSystemPasswordChar = False

        Else

            TxtPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class
