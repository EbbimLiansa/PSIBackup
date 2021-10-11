Public Class Form2
    Dim conn As New OleDb.OleDbConnection
    Dim Myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\PSI.accdb"
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lhome_Click(sender As Object, e As EventArgs) Handles Lhome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Lcetak_Click(sender As Object, e As EventArgs) Handles Lcetak.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Lexit_Click(sender As Object, e As EventArgs) Handles Lexit.Click
        End
    End Sub

    Private Sub Linput_Click(sender As Object, e As EventArgs) Handles Linput.Click
        MsgBox("Kamu Sudah Berada Di Menu Input")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox2.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim mstream As New System.IO.MemoryStream()
            PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length

            mstream.Close()
            conn.ConnectionString = Myconnection
            conn.Open()
            sql = "INSERT INTO tblstudent(NAMA,foto) VALUES (@NAMA,@foto)"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@NAMA", TBusername.Text)
            cmd.Parameters.AddWithValue("@foto", arrImage)
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Dokement Penting Kamu Sudah Di Backup Oleh PSIbackup Ke server Yang Aman!")
            Else
                MsgBox("Yah.. Maaf Dokement Penting Kamu Tidak Bisa Di Backup Oleh PSIbackup Ke server Yang Aman!")
            End If
            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class