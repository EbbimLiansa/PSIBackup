<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Ladmin = New System.Windows.Forms.Label()
        Me.Lsignin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lexit = New System.Windows.Forms.Label()
        Me.Lcetak = New System.Windows.Forms.Label()
        Me.Linput = New System.Windows.Forms.Label()
        Me.Lhome = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 575)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Ladmin)
        Me.Panel7.Controls.Add(Me.Lsignin)
        Me.Panel7.Location = New System.Drawing.Point(92, 166)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(232, 320)
        Me.Panel7.TabIndex = 17
        '
        'Ladmin
        '
        Me.Ladmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ladmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ladmin.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ladmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Ladmin.Location = New System.Drawing.Point(0, 49)
        Me.Ladmin.Name = "Ladmin"
        Me.Ladmin.Size = New System.Drawing.Size(232, 271)
        Me.Ladmin.TabIndex = 4
        Me.Ladmin.Text = resources.GetString("Ladmin.Text")
        '
        'Lsignin
        '
        Me.Lsignin.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lsignin.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lsignin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Lsignin.Location = New System.Drawing.Point(0, 0)
        Me.Lsignin.Name = "Lsignin"
        Me.Lsignin.Size = New System.Drawing.Size(232, 49)
        Me.Lsignin.TabIndex = 3
        Me.Lsignin.Text = "Home"
        Me.Lsignin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 514)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Lexit)
        Me.Panel2.Controls.Add(Me.Lcetak)
        Me.Panel2.Controls.Add(Me.Linput)
        Me.Panel2.Controls.Add(Me.Lhome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 61)
        Me.Panel2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Backup"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(96, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "PSI Backup"
        '
        'Lexit
        '
        Me.Lexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lexit.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Lexit.Location = New System.Drawing.Point(765, 40)
        Me.Lexit.Name = "Lexit"
        Me.Lexit.Size = New System.Drawing.Size(45, 18)
        Me.Lexit.TabIndex = 15
        Me.Lexit.Text = "Exit"
        '
        'Lcetak
        '
        Me.Lcetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lcetak.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcetak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Lcetak.Location = New System.Drawing.Point(680, 40)
        Me.Lcetak.Name = "Lcetak"
        Me.Lcetak.Size = New System.Drawing.Size(45, 18)
        Me.Lcetak.TabIndex = 14
        Me.Lcetak.Text = "Cetak"
        '
        'Linput
        '
        Me.Linput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Linput.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Linput.Location = New System.Drawing.Point(601, 40)
        Me.Linput.Name = "Linput"
        Me.Linput.Size = New System.Drawing.Size(45, 18)
        Me.Linput.TabIndex = 13
        Me.Linput.Text = "Input"
        '
        'Lhome
        '
        Me.Lhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lhome.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lhome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Lhome.Location = New System.Drawing.Point(522, 40)
        Me.Lhome.Name = "Lhome"
        Me.Lhome.Size = New System.Drawing.Size(45, 18)
        Me.Lhome.TabIndex = 12
        Me.Lhome.Text = "Home"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 575)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lexit As Label
    Friend WithEvents Lcetak As Label
    Friend WithEvents Linput As Label
    Friend WithEvents Lhome As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Lsignin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ladmin As Label
End Class
