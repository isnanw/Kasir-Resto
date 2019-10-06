<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonfirmasiOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKonfirmasiOrder))
        Me.PanelAtas = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LTotalHarga = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.LId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAtas
        '
        Me.PanelAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelAtas.Controls.Add(Me.Button4)
        Me.PanelAtas.Controls.Add(Me.PictureBox1)
        Me.PanelAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAtas.Location = New System.Drawing.Point(0, 0)
        Me.PanelAtas.Name = "PanelAtas"
        Me.PanelAtas.Size = New System.Drawing.Size(668, 42)
        Me.PanelAtas.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(626, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 42)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(15, 2, 0, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(120, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Konfirmasi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LTotalHarga
        '
        Me.LTotalHarga.AutoSize = True
        Me.LTotalHarga.Location = New System.Drawing.Point(130, 302)
        Me.LTotalHarga.Name = "LTotalHarga"
        Me.LTotalHarga.Size = New System.Drawing.Size(13, 13)
        Me.LTotalHarga.TabIndex = 43
        Me.LTotalHarga.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Rp."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Total Harga :"
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(12, 111)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(643, 176)
        Me.DGV2.TabIndex = 40
        '
        'LId
        '
        Me.LId.AutoSize = True
        Me.LId.Location = New System.Drawing.Point(86, 74)
        Me.LId.Name = "LId"
        Me.LId.Size = New System.Drawing.Size(10, 13)
        Me.LId.TabIndex = 37
        Me.LId.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Id Order :"
        '
        'LNama
        '
        Me.LNama.AutoSize = True
        Me.LNama.Location = New System.Drawing.Point(243, 74)
        Me.LNama.Name = "LNama"
        Me.LNama.Size = New System.Drawing.Size(10, 13)
        Me.LNama.TabIndex = 34
        Me.LNama.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nama Pelanggan :"
        '
        'FormKonfirmasiOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 344)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LTotalHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.LId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelAtas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKonfirmasiOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKonfirmasiOrder"
        Me.PanelAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelAtas As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LTotalHarga As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents LId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LNama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
