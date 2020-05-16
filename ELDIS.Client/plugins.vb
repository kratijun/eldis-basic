Public Class plugins
    Private Sub plugins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eldisModule.InitAddons()
    End Sub

    Private Sub CheckedListBox1_DoubleClick(sender As Object, e As EventArgs) Handles CheckedListBox1.DoubleClick
        eldisModule.selectAddon()
    End Sub
End Class