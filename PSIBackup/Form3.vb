Public Class Form3
    Dim conn As New OleDb.OleDbConnection
    Dim Myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\PSI.accdb"
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lhome_Click_1(sender As Object, e As EventArgs) Handles Lhome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Linput_Click_1(sender As Object, e As EventArgs) Handles Linput.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Lexit_Click_1(sender As Object, e As EventArgs) Handles Lexit.Click
        End
    End Sub

    Private Sub Lcetak_Click_1(sender As Object, e As EventArgs) Handles Lcetak.Click
        MsgBox("Kamu Sudah Berada Di Menu Cetak")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "Select * from tblstudent where backupID=" & Val(TBusername.Text)
        conn.ConnectionString = Myconnection
        conn.Open()
        With cmd
            .Connection = conn
            .CommandText = sql
        End With
        Dim arrImage() As Byte
        Dim publictable As New DataTable


        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            TextBox1.Text = publictable.Rows(0).Item(1)
            arrImage = publictable.Rows(0).Item(2)
            Dim mstream As New System.IO.MemoryStream(arrImage)
            PictureBox2.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            conn.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ds As New DataSet1
            Dim ms As New System.IO.MemoryStream
            PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            Dim byt() As Byte = ms.ToArray
            ds.DataTable1.Rows.Add(byt)
            Dim rpt As New CrystalReport1
            rpt.SetDataSource(ds.Tables("DataTable1"))


            Dim frm As New Form4
            frm.CrystalReportViewer1.ReportSource = rpt
            frm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class