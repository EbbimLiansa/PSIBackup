Public Class Form4
    Private Sub Lhome_Click(sender As Object, e As EventArgs) Handles Lhome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Linput_Click(sender As Object, e As EventArgs) Handles Linput.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Lcetak_Click(sender As Object, e As EventArgs) Handles Lcetak.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Lexit_Click(sender As Object, e As EventArgs) Handles Lexit.Click
        End
    End Sub
End Class