<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BIKERS2USED_DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BIKERS2USED_DB))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmerk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbojenis = New System.Windows.Forms.ComboBox()
        Me.tblhapus = New System.Windows.Forms.Button()
        Me.tblbatal = New System.Windows.Forms.Button()
        Me.tblsimpan = New System.Windows.Forms.Button()
        Me.tblbaru = New System.Windows.Forms.Button()
        Me.tblcetak = New System.Windows.Forms.Button()
        Me.tblkeluar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdeskripsi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Display = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.ListView1.Location = New System.Drawing.Point(12, 125)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(755, 389)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(804, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode"
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.Aqua
        Me.txtkode.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtkode.Location = New System.Drawing.Point(899, 125)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(236, 24)
        Me.txtkode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(804, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Merk"
        '
        'txtmerk
        '
        Me.txtmerk.BackColor = System.Drawing.Color.Aqua
        Me.txtmerk.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtmerk.Location = New System.Drawing.Point(899, 164)
        Me.txtmerk.Name = "txtmerk"
        Me.txtmerk.Size = New System.Drawing.Size(236, 24)
        Me.txtmerk.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(804, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.Color.Aqua
        Me.txtnama.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtnama.Location = New System.Drawing.Point(899, 204)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(236, 24)
        Me.txtnama.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(806, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenis"
        '
        'cbojenis
        '
        Me.cbojenis.BackColor = System.Drawing.Color.Aqua
        Me.cbojenis.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.cbojenis.FormattingEnabled = True
        Me.cbojenis.Location = New System.Drawing.Point(899, 244)
        Me.cbojenis.Name = "cbojenis"
        Me.cbojenis.Size = New System.Drawing.Size(236, 22)
        Me.cbojenis.TabIndex = 8
        '
        'tblhapus
        '
        Me.tblhapus.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblhapus.Location = New System.Drawing.Point(780, 547)
        Me.tblhapus.Name = "tblhapus"
        Me.tblhapus.Size = New System.Drawing.Size(88, 44)
        Me.tblhapus.TabIndex = 9
        Me.tblhapus.Text = "Hapus"
        Me.tblhapus.UseVisualStyleBackColor = True
        '
        'tblbatal
        '
        Me.tblbatal.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblbatal.Location = New System.Drawing.Point(874, 548)
        Me.tblbatal.Name = "tblbatal"
        Me.tblbatal.Size = New System.Drawing.Size(88, 44)
        Me.tblbatal.TabIndex = 10
        Me.tblbatal.Text = "Batal"
        Me.tblbatal.UseVisualStyleBackColor = True
        '
        'tblsimpan
        '
        Me.tblsimpan.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblsimpan.Location = New System.Drawing.Point(968, 548)
        Me.tblsimpan.Name = "tblsimpan"
        Me.tblsimpan.Size = New System.Drawing.Size(88, 44)
        Me.tblsimpan.TabIndex = 11
        Me.tblsimpan.Text = "Simpan"
        Me.tblsimpan.UseVisualStyleBackColor = True
        '
        'tblbaru
        '
        Me.tblbaru.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblbaru.Location = New System.Drawing.Point(1062, 548)
        Me.tblbaru.Name = "tblbaru"
        Me.tblbaru.Size = New System.Drawing.Size(88, 44)
        Me.tblbaru.TabIndex = 12
        Me.tblbaru.Text = "Baru"
        Me.tblbaru.UseVisualStyleBackColor = True
        '
        'tblcetak
        '
        Me.tblcetak.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblcetak.Location = New System.Drawing.Point(1156, 548)
        Me.tblcetak.Name = "tblcetak"
        Me.tblcetak.Size = New System.Drawing.Size(88, 44)
        Me.tblcetak.TabIndex = 13
        Me.tblcetak.Text = "Cetak"
        Me.tblcetak.UseVisualStyleBackColor = True
        '
        'tblkeluar
        '
        Me.tblkeluar.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.tblkeluar.Location = New System.Drawing.Point(1250, 548)
        Me.tblkeluar.Name = "tblkeluar"
        Me.tblkeluar.Size = New System.Drawing.Size(88, 44)
        Me.tblkeluar.TabIndex = 14
        Me.tblkeluar.Text = "Keluar"
        Me.tblkeluar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(289, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cari"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.TextBox4.Location = New System.Drawing.Point(355, 568)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(412, 24)
        Me.TextBox4.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(806, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Deskripsi"
        '
        'txtdeskripsi
        '
        Me.txtdeskripsi.BackColor = System.Drawing.Color.Aqua
        Me.txtdeskripsi.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtdeskripsi.Location = New System.Drawing.Point(899, 365)
        Me.txtdeskripsi.Multiline = True
        Me.txtdeskripsi.Name = "txtdeskripsi"
        Me.txtdeskripsi.Size = New System.Drawing.Size(443, 86)
        Me.txtdeskripsi.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Aqua
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 40.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(500, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(462, 60)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "BIKERS2USED"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(-8, -12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1375, 87)
        Me.Button1.TabIndex = 72
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(806, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Harga"
        '
        'txtharga
        '
        Me.txtharga.BackColor = System.Drawing.Color.Aqua
        Me.txtharga.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtharga.Location = New System.Drawing.Point(899, 282)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(236, 24)
        Me.txtharga.TabIndex = 75
        '
        'btndisplay
        '
        Me.btndisplay.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.btndisplay.Location = New System.Drawing.Point(1146, 256)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(191, 32)
        Me.btndisplay.TabIndex = 77
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(1147, 324)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(191, 25)
        Me.txtdisplay.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(1144, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 14)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Choose Photo :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Merk", "Nama", "Jenis"})
        Me.ComboBox1.Location = New System.Drawing.Point(355, 523)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(412, 24)
        Me.ComboBox1.TabIndex = 80
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(196, 527)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 16)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Pilih Pencarian"
        '
        'txtunit
        '
        Me.txtunit.BackColor = System.Drawing.Color.Aqua
        Me.txtunit.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtunit.Location = New System.Drawing.Point(899, 322)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(236, 24)
        Me.txtunit.TabIndex = 84
        Me.txtunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(806, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Unit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(120, 546)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 57)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Silver
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(12, 523)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 57)
        Me.PictureBox4.TabIndex = 82
        Me.PictureBox4.TabStop = False
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(1147, 125)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(191, 115)
        Me.Display.TabIndex = 76
        Me.Display.TabStop = False
        '
        'BIKERS2USED_DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1354, 603)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdeskripsi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tblkeluar)
        Me.Controls.Add(Me.tblcetak)
        Me.Controls.Add(Me.tblbaru)
        Me.Controls.Add(Me.tblsimpan)
        Me.Controls.Add(Me.tblbatal)
        Me.Controls.Add(Me.tblhapus)
        Me.Controls.Add(Me.cbojenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmerk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "BIKERS2USED_DB"
        Me.Text = "BIKERS2USED_DB"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmerk As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbojenis As System.Windows.Forms.ComboBox
    Friend WithEvents tblhapus As System.Windows.Forms.Button
    Friend WithEvents tblbatal As System.Windows.Forms.Button
    Friend WithEvents tblsimpan As System.Windows.Forms.Button
    Friend WithEvents tblbaru As System.Windows.Forms.Button
    Friend WithEvents tblcetak As System.Windows.Forms.Button
    Friend WithEvents tblkeluar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents txtdisplay As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
