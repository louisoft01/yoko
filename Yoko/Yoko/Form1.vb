Public Class Form1
    Dim filename As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As String
        url = TextBox1.Text
        filename = TextBox2.Text
        My.Computer.Network.DownloadFile(url, filename)
        On Error Resume Next
        MsgBox("Complete")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        MsgBox("Please add a name for your file before clicking download")
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class
