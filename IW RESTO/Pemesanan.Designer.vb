<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pemesanan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LnoMeja = New System.Windows.Forms.Label()
        Me.LNamaPelanggan = New System.Windows.Forms.Label()
        Me.LidOrder = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TotalBayar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DGVPesanan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DGVPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 46)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(15, 2, 0, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(120, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(590, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 46)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "_"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(632, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(42, 46)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "<>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(674, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 46)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LnoMeja)
        Me.Panel2.Controls.Add(Me.LNamaPelanggan)
        Me.Panel2.Controls.Add(Me.LidOrder)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 134)
        Me.Panel2.TabIndex = 1
        '
        'LnoMeja
        '
        Me.LnoMeja.AutoSize = True
        Me.LnoMeja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnoMeja.Location = New System.Drawing.Point(319, 91)
        Me.LnoMeja.Name = "LnoMeja"
        Me.LnoMeja.Size = New System.Drawing.Size(20, 17)
        Me.LnoMeja.TabIndex = 12
        Me.LnoMeja.Text = "..."
        '
        'LNamaPelanggan
        '
        Me.LNamaPelanggan.AutoSize = True
        Me.LNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNamaPelanggan.Location = New System.Drawing.Point(319, 56)
        Me.LNamaPelanggan.Name = "LNamaPelanggan"
        Me.LNamaPelanggan.Size = New System.Drawing.Size(20, 17)
        Me.LNamaPelanggan.TabIndex = 11
        Me.LNamaPelanggan.Text = "..."
        '
        'LidOrder
        '
        Me.LidOrder.AutoSize = True
        Me.LidOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LidOrder.Location = New System.Drawing.Point(319, 22)
        Me.LidOrder.Name = "LidOrder"
        Me.LidOrder.Size = New System.Drawing.Size(20, 17)
        Me.LidOrder.TabIndex = 10
        Me.LidOrder.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(301, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(301, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(301, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nomer Meja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Order"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TotalBayar)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(489, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(227, 134)
        Me.Panel3.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(6, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 40)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Rp."
        '
        'TotalBayar
        '
        Me.TotalBayar.AutoSize = True
        Me.TotalBayar.Font = New System.Drawing.Font("Consolas", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TotalBayar.Location = New System.Drawing.Point(72, 33)
        Me.TotalBayar.Name = "TotalBayar"
        Me.TotalBayar.Size = New System.Drawing.Size(36, 40)
        Me.TotalBayar.TabIndex = 16
        Me.TotalBayar.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(3, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah Pesanan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.PictureBox2.Size = New System.Drawing.Size(149, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 180)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(716, 48)
        Me.Panel4.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(492, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 42)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pesanan Anda :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 505)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(716, 41)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DGVPesanan)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 228)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel6.Size = New System.Drawing.Size(716, 277)
        Me.Panel6.TabIndex = 4
        '
        'DGVPesanan
        '
        Me.DGVPesanan.AllowUserToAddRows = False
        Me.DGVPesanan.AllowUserToDeleteRows = False
        Me.DGVPesanan.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPesanan.Location = New System.Drawing.Point(10, 10)
        Me.DGVPesanan.Name = "DGVPesanan"
        Me.DGVPesanan.ReadOnly = True
        Me.DGVPesanan.Size = New System.Drawing.Size(696, 257)
        Me.DGVPesanan.TabIndex = 5
        '
        'Pemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 546)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pemesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemesanan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DGVPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LnoMeja As System.Windows.Forms.Label
    Friend WithEvents LNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents LidOrder As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TotalBayar As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DGVPesanan As System.Windows.Forms.DataGridView
End Class
