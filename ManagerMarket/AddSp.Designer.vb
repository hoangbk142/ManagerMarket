<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSp
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
        Me.lablbla = New System.Windows.Forms.Label()
        Me.labbale = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLoaisp = New System.Windows.Forms.TextBox()
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.txtTensp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCanc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lablbla
        '
        Me.lablbla.AutoSize = True
        Me.lablbla.Location = New System.Drawing.Point(13, 26)
        Me.lablbla.Name = "lablbla"
        Me.lablbla.Size = New System.Drawing.Size(44, 13)
        Me.lablbla.TabIndex = 0
        Me.lablbla.Text = "Loai SP"
        '
        'labbale
        '
        Me.labbale.AutoSize = True
        Me.labbale.Location = New System.Drawing.Point(13, 71)
        Me.labbale.Name = "labbale"
        Me.labbale.Size = New System.Drawing.Size(39, 13)
        Me.labbale.TabIndex = 1
        Me.labbale.Text = "Ma SP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ten SP"
        '
        'txtLoaisp
        '
        Me.txtLoaisp.Location = New System.Drawing.Point(72, 23)
        Me.txtLoaisp.Name = "txtLoaisp"
        Me.txtLoaisp.ReadOnly = True
        Me.txtLoaisp.Size = New System.Drawing.Size(179, 20)
        Me.txtLoaisp.TabIndex = 3
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(72, 68)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(179, 20)
        Me.txtMasp.TabIndex = 4
        '
        'txtTensp
        '
        Me.txtTensp.Location = New System.Drawing.Point(72, 116)
        Me.txtTensp.Name = "txtTensp"
        Me.txtTensp.Size = New System.Drawing.Size(179, 20)
        Me.txtTensp.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "So Luong"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(72, 168)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(179, 20)
        Me.txtSoluong.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(48, 207)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(160, 207)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 9
        Me.btnCanc.Text = "Cancel"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'AddSp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTensp)
        Me.Controls.Add(Me.txtMasp)
        Me.Controls.Add(Me.txtLoaisp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labbale)
        Me.Controls.Add(Me.lablbla)
        Me.Name = "AddSp"
        Me.Text = "AddSp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lablbla As System.Windows.Forms.Label
    Friend WithEvents labbale As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoaisp As System.Windows.Forms.TextBox
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents txtTensp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
End Class
