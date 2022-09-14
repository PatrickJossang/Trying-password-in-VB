Public Class PasswordForm1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtOldPassword.Text = RightPassord Then
            RightPassord = TxtNewPassword.Text

            Me.Hide()
            Form1.Show()
            MsgBox("Password updatet", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Submit")
        Else
            MsgBox("Somthing Went Wrong", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Submit")
        End If
        TxtNewPassword.Text = ""
        TxtOldPassword.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        iExit = MessageBox.Show("Confirm if you want to exit", "Passwordtest", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class