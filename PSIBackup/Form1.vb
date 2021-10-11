Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Linput_Click(sender As Object, e As EventArgs) Handles Linput.Click
        Form2.Show()
    End Sub

    Private Sub Lcetak_Click(sender As Object, e As EventArgs) Handles Lcetak.Click
        Form3.Show()
    End Sub

    Private Sub Lexit_Click(sender As Object, e As EventArgs) Handles Lexit.Click
        End
    End Sub

    Private Sub Lhome_Click(sender As Object, e As EventArgs) Handles Lhome.Click
        MsgBox("Kamu Sudah Berada Di Menu Home")
    End Sub
End Class
