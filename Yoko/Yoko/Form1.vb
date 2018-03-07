Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As String
        Dim path As String
nopath:
        url = TextBox1.Text
        path = TextBox2.Text
        If url = ("c:\") Then
            MsgBox("path is Not allowed")
            GoTo nopath
        End If
        My.Computer.Network.DownloadFile(url, path)
        MsgBox("Complete")
    End Sub
End Class
