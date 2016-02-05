Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileEditor As New EditFileForm
        'TabControl1.TabPages.Add(FileEditor)
        CreateNewTab("")
        CreateNewTab("")
        CreateNewTab("")
        CreateNewTab("")
        CreateNewTab("")
    End Sub

    Function CreateNewTab(ByRef url As String)

        Dim t As New EditFileForm
        Dim NewTab = TabControl1.TabPages.Add(t)
        Return 0
    End Function

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutAPNMStudio.Visible = True
    End Sub
End Class
