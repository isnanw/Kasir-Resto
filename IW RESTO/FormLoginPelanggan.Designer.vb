<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginPelanggan))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CBMeja = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.TSTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.idPelanggan = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STidOrder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tstatus = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(761, 510)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(203, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CBMeja)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Tnama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(761, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 486)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(32, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 47)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "MASUK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CBMeja
        '
        Me.CBMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMeja.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.CBMeja.FormattingEnabled = True
        Me.CBMeja.Location = New System.Drawing.Point(32, 361)
        Me.CBMeja.Name = "CBMeja"
        Me.CBMeja.Size = New System.Drawing.Size(200, 31)
        Me.CBMeja.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pilih Meja"
        '
        'Tnama
        '
        Me.Tnama.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.Tnama.Location = New System.Drawing.Point(32, 290)
        Me.Tnama.Name = "Tnama"
        Me.Tnama.Size = New System.Drawing.Size(200, 31)
        Me.Tnama.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM LOGIN"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(60, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(141, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(327, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 47)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "PETUGAS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSTanggal, Me.idPelanggan, Me.STidOrder, Me.Tstatus})
        Me.StatusStrip2.Location = New System.Drawing.Point(761, 488)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(258, 22)
        Me.StatusStrip2.TabIndex = 11
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'TSTanggal
        '
        Me.TSTanggal.Name = "TSTanggal"
        Me.TSTanggal.Size = New System.Drawing.Size(50, 17)
        Me.TSTanggal.Text = "Tanggal"
        '
        'idPelanggan
        '
        Me.idPelanggan.Name = "idPelanggan"
        Me.idPelanggan.Size = New System.Drawing.Size(73, 17)
        Me.idPelanggan.Text = "idPelanggan"
        '
        'STidOrder
        '
        Me.STidOrder.Name = "STidOrder"
        Me.STidOrder.Size = New System.Drawing.Size(47, 17)
        Me.STidOrder.Text = "idOrder"
        '
        'Tstatus
        '
        Me.Tstatus.Name = "Tstatus"
        Me.Tstatus.Size = New System.Drawing.Size(39, 17)
        Me.Tstatus.Text = "Status"
        '
        'FormLoginPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 510)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLoginPelanggan"
        Me.Text = "FormLoginPelanggan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CBMeja As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents idPelanggan As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STidOrder As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tstatus As System.Windows.Forms.ToolStripStatusLabel
End Class
