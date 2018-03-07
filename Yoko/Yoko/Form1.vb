Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As String
        Dim path As String
        url = TextBox1.Text
        path = TextBox2.Text
        My.Computer.Network.DownloadFile(url, path)
        On Error Resume Next
        MsgBox("Complete")
    End Sub
End Class
