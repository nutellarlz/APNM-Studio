Public Class AboutAPNMStudio
    Private Sub AboutAPNMStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Application.Info.AssemblyName
        Label2.Text = My.Application.Info.Version.ToString
        Label3.Text = My.Application.Info.Copyright
        RichTextBox1.Text = My.Application.Info.Description
        If My.Settings.AutoUpdate = True Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.AutoUpdate = True
        Else
            My.Settings.AutoUpdate = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class