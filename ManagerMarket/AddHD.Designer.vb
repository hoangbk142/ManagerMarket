<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddHD
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
        Me.txtMaHD = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaHDD = New System.Windows.Forms.TextBox()
        Me.txtMaKHH = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCanc = New System.Windows.Forms.Button()
        Me.datetimeNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtMaHD
        '
        Me.txtMaHD.AutoSize = True
        Me.txtMaHD.Location = New System.Drawing.Point(13, 26)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(41, 13)
        Me.txtMaHD.TabIndex = 0
        Me.txtMaHD.Text = "Ma HD"
        '
        'txtMaKH
        '
        Me.txtMaKH.AutoSize = True
        Me.txtMaKH.Location = New System.Drawing.Point(12, 64)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(40, 13)
        Me.txtMaKH.TabIndex = 1
        Me.txtMaKH.Text = "Ma KH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngay Lap"
        '
        'txtMaHDD
        '
        Me.txtMaHDD.Location = New System.Drawing.Point(75, 26)
        Me.txtMaHDD.Name = "txtMaHDD"
        Me.txtMaHDD.Size = New System.Drawing.Size(197, 20)
        Me.txtMaHDD.TabIndex = 3
        '
        'txtMaKHH
        '
        Me.txtMaKHH.Location = New System.Drawing.Point(75, 61)
        Me.txtMaKHH.Name = "txtMaKHH"
        Me.txtMaKHH.Size = New System.Drawing.Size(197, 20)
        Me.txtMaKHH.TabIndex = 4
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(49, 163)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(163, 163)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 7
        Me.btnCanc.Text = "Cancel"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'datetimeNgayLap
        '
        Me.datetimeNgayLap.Location = New System.Drawing.Point(71, 101)
        Me.datetimeNgayLap.Name = "datetimeNgayLap"
        Me.datetimeNgayLap.Size = New System.Drawing.Size(200, 20)
        Me.datetimeNgayLap.TabIndex = 8
        '
        'AddHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.datetimeNgayLap)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtMaKHH)
        Me.Controls.Add(Me.txtMaHDD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Name = "AddHD"
        Me.Text = "AddHD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaHD As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaHDD As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKHH As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents datetimeNgayLap As System.Windows.Forms.DateTimePicker
End Class
