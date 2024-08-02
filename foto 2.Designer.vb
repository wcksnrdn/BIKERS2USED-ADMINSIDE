<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foto_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foto_2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btntampil1 = New System.Windows.Forms.Button()
        Me.btnsembunyi1 = New System.Windows.Forms.Button()
        Me.btntampil2 = New System.Windows.Forms.Button()
        Me.btnsembunyi2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Location = New System.Drawing.Point(340, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(266, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btntampil1
        '
        Me.btntampil1.BackgroundImage = CType(resources.GetObject("btntampil1.BackgroundImage"), System.Drawing.Image)
        Me.btntampil1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntampil1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntampil1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntampil1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntampil1.Location = New System.Drawing.Point(37, 226)
        Me.btntampil1.Name = "btntampil1"
        Me.btntampil1.Size = New System.Drawing.Size(154, 69)
        Me.btntampil1.TabIndex = 7
        Me.btntampil1.Text = "Tampilkan Foto 1"
        Me.btntampil1.UseVisualStyleBackColor = True
        '
        'btnsembunyi1
        '
        Me.btnsembunyi1.Location = New System.Drawing.Point(37, 301)
        Me.btnsembunyi1.Name = "btnsembunyi1"
        Me.btnsembunyi1.Size = New System.Drawing.Size(154, 69)
        Me.btnsembunyi1.TabIndex = 8
        Me.btnsembunyi1.Text = "Sembunyikan"
        Me.btnsembunyi1.UseVisualStyleBackColor = True
        '
        'btntampil2
        '
        Me.btntampil2.BackgroundImage = CType(resources.GetObject("btntampil2.BackgroundImage"), System.Drawing.Image)
        Me.btntampil2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntampil2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntampil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntampil2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntampil2.Location = New System.Drawing.Point(340, 226)
        Me.btntampil2.Name = "btntampil2"
        Me.btntampil2.Size = New System.Drawing.Size(154, 69)
        Me.btntampil2.TabIndex = 9
        Me.btntampil2.Text = "Tampilan Foto 2"
        Me.btntampil2.UseVisualStyleBackColor = True
        '
        'btnsembunyi2
        '
        Me.btnsembunyi2.Location = New System.Drawing.Point(340, 301)
        Me.btnsembunyi2.Name = "btnsembunyi2"
        Me.btnsembunyi2.Size = New System.Drawing.Size(154, 69)
        Me.btnsembunyi2.TabIndex = 10
        Me.btnsembunyi2.Text = "Sembunyikan"
        Me.btnsembunyi2.UseVisualStyleBackColor = True
        '
        'foto_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 396)
        Me.Controls.Add(Me.btnsembunyi2)
        Me.Controls.Add(Me.btntampil2)
        Me.Controls.Add(Me.btnsembunyi1)
        Me.Controls.Add(Me.btntampil1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(669, 435)
        Me.Name = "foto_2"
        Me.Text = "foto_2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btntampil1 As System.Windows.Forms.Button
    Friend WithEvents btnsembunyi1 As System.Windows.Forms.Button
    Friend WithEvents btntampil2 As System.Windows.Forms.Button
    Friend WithEvents btnsembunyi2 As System.Windows.Forms.Button
End Class
