Public Class Form1
    Dim filename As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As String
        url = TextBox1.Text
        filename = TextBox2.Text
        My.Computer.Network.DownloadFile(url, filename) On Error GoTo problem
        MsgBox("Complete")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        MsgBox("Please add a name for your file before clicking download")
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
errorfix:
        If My.Settings.theme = True Then
            Me.BackColor = Color.White
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Button2.ForeColor = Color.Black
            Button3.ForeColor = Color.Black
            CheckBox1.ForeColor = Color.Black
        End If
        If My.Settings.theme = False Then
            Me.BackColor = Color.Black
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Button2.ForeColor = Color.White
            Button3.ForeColor = Color.White
            CheckBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.theme = True
            Me.BackColor = Color.White
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Button2.ForeColor = Color.Black
            Button3.ForeColor = Color.Black
            CheckBox1.ForeColor = Color.Black
        End If
        If CheckBox1.Checked = False Then
            My.Settings.theme = False
            Me.BackColor = Color.Black
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Button2.ForeColor = Color.White
            Button3.ForeColor = Color.White
            CheckBox1.ForeColor = Color.White
        End If
    End Sub
End Class
