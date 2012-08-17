Public Class Form1
    Dim p() As Process
    Dim clientl As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        p = Process.GetProcessesByName("bitcoin-qt")
        If Not TextBox1.Text = String.Empty Or Not My.Settings.Location = String.Empty Then
            If p.Count > 0 Then
                If Not TextBox3.Text = "" Then
                    Shell(My.Settings.Location + " walletpassphrase " + TextBox3.Text + " 120")
                    GoTo command
                End If
                GoTo command
            Else
                MsgBox("Please open up the bitcoin client", MsgBoxStyle.Critical, "Open client")
                Exit Sub
            End If
        Else
            MsgBox("Please make sure the required path is correct and there is a private key entered.", MsgBoxStyle.Critical)
            Exit Sub
        End If
command:
        Shell(My.Settings.Location + " importprivkey " + TextBox1.Text + " " + TextBox2.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p = Process.GetProcessesByName("bitcoin-qt")
        If p.Count <= 0 Then
            MsgBox("Please open up the bitcoin client", MsgBoxStyle.Critical, "Open client")
            Me.Close()
        End If
        TextBox5.Text = My.Settings.Location
    End Sub

    Private Sub OFD_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFD.FileOk
        TextBox5.Text = OFD.FileName
        My.Settings.Location = TextBox5.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OFD.ShowDialog()
    End Sub
End Class
