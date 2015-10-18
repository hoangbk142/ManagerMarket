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
        Me.components = New System.ComponentModel.Container()
        Me.dgvLoad = New System.Windows.Forms.DataGridView()
        Me.btnsanpham = New System.Windows.Forms.Button()
        Me.btnkhachhang = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAddHD = New System.Windows.Forms.Button()
        Me.cbKH = New System.Windows.Forms.CheckBox()
        Me.cbHD = New System.Windows.Forms.CheckBox()
        Me.cbCTHD = New System.Windows.Forms.CheckBox()
        Me.btnAddLSP = New System.Windows.Forms.Button()
        Me.btnEditKH = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLoad
        '
        Me.dgvLoad.AllowUserToAddRows = False
        Me.dgvLoad.AllowUserToDeleteRows = False
        Me.dgvLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoad.Location = New System.Drawing.Point(12, 71)
        Me.dgvLoad.MultiSelect = False
        Me.dgvLoad.Name = "dgvLoad"
        Me.dgvLoad.ReadOnly = True
        Me.dgvLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoad.Size = New System.Drawing.Size(508, 308)
        Me.dgvLoad.TabIndex = 0
        '
        'btnsanpham
        '
        Me.btnsanpham.Location = New System.Drawing.Point(538, 97)
        Me.btnsanpham.Name = "btnsanpham"
        Me.btnsanpham.Size = New System.Drawing.Size(100, 23)
        Me.btnsanpham.TabIndex = 1
        Me.btnsanpham.Text = "Them San Pham"
        Me.btnsanpham.UseVisualStyleBackColor = True
        '
        'btnkhachhang
        '
        Me.btnkhachhang.Location = New System.Drawing.Point(538, 39)
        Me.btnkhachhang.Name = "btnkhachhang"
        Me.btnkhachhang.Size = New System.Drawing.Size(100, 23)
        Me.btnkhachhang.TabIndex = 2
        Me.btnkhachhang.Text = "Them KH"
        Me.btnkhachhang.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSP)
        Me.GroupBox1.Location = New System.Drawing.Point(526, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loai San Pham"
        '
        'cbSP
        '
        Me.cbSP.FormattingEnabled = True
        Me.cbSP.Location = New System.Drawing.Point(6, 38)
        Me.cbSP.Name = "cbSP"
        Me.cbSP.Size = New System.Drawing.Size(121, 21)
        Me.cbSP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tìm kiếm"
        '
        'cbSearch
        '
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.Items.AddRange(New Object() {"MaSP", "TenSP"})
        Me.cbSearch.Location = New System.Drawing.Point(68, 36)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(109, 21)
        Me.cbSearch.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(184, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(336, 20)
        Me.txtSearch.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnAddHD
        '
        Me.btnAddHD.Location = New System.Drawing.Point(538, 68)
        Me.btnAddHD.Name = "btnAddHD"
        Me.btnAddHD.Size = New System.Drawing.Size(100, 23)
        Me.btnAddHD.TabIndex = 10
        Me.btnAddHD.Text = "Them Hoa Don"
        Me.btnAddHD.UseVisualStyleBackColor = True
        '
        'cbKH
        '
        Me.cbKH.AutoSize = True
        Me.cbKH.Location = New System.Drawing.Point(538, 198)
        Me.cbKH.Name = "cbKH"
        Me.cbKH.Size = New System.Drawing.Size(86, 17)
        Me.cbKH.TabIndex = 12
        Me.cbKH.Text = "Khach Hang"
        Me.cbKH.UseVisualStyleBackColor = True
        '
        'cbHD
        '
        Me.cbHD.AutoSize = True
        Me.cbHD.Location = New System.Drawing.Point(538, 221)
        Me.cbHD.Name = "cbHD"
        Me.cbHD.Size = New System.Drawing.Size(69, 17)
        Me.cbHD.TabIndex = 13
        Me.cbHD.Text = "Hoa Don"
        Me.cbHD.UseVisualStyleBackColor = True
        '
        'cbCTHD
        '
        Me.cbCTHD.AutoSize = True
        Me.cbCTHD.Location = New System.Drawing.Point(538, 245)
        Me.cbCTHD.Name = "cbCTHD"
        Me.cbCTHD.Size = New System.Drawing.Size(108, 17)
        Me.cbCTHD.TabIndex = 14
        Me.cbCTHD.Text = "Chi Tiet Hoa Don"
        Me.cbCTHD.UseVisualStyleBackColor = True
        '
        'btnAddLSP
        '
        Me.btnAddLSP.Location = New System.Drawing.Point(538, 126)
        Me.btnAddLSP.Name = "btnAddLSP"
        Me.btnAddLSP.Size = New System.Drawing.Size(100, 23)
        Me.btnAddLSP.TabIndex = 15
        Me.btnAddLSP.Text = "Them Loai SP"
        Me.btnAddLSP.UseVisualStyleBackColor = True
        '
        'btnEditKH
        '
        Me.btnEditKH.Location = New System.Drawing.Point(12, 394)
        Me.btnEditKH.Name = "btnEditKH"
        Me.btnEditKH.Size = New System.Drawing.Size(75, 23)
        Me.btnEditKH.TabIndex = 16
        Me.btnEditKH.Text = "Sua KH"
        Me.btnEditKH.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(102, 394)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 440)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnEditKH)
        Me.Controls.Add(Me.btnAddLSP)
        Me.Controls.Add(Me.cbCTHD)
        Me.Controls.Add(Me.cbHD)
        Me.Controls.Add(Me.cbKH)
        Me.Controls.Add(Me.btnAddHD)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnkhachhang)
        Me.Controls.Add(Me.btnsanpham)
        Me.Controls.Add(Me.dgvLoad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLoad As System.Windows.Forms.DataGridView
    Friend WithEvents btnsanpham As System.Windows.Forms.Button
    Friend WithEvents btnkhachhang As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnAddHD As System.Windows.Forms.Button
    Friend WithEvents cbKH As System.Windows.Forms.CheckBox
    Friend WithEvents cbHD As System.Windows.Forms.CheckBox
    Friend WithEvents cbCTHD As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddLSP As System.Windows.Forms.Button
    Friend WithEvents btnEditKH As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button

End Class
