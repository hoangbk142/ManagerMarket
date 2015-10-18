<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddKH
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnGetout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ma KH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ten KH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dia Chi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SDT"
        '
        'txtMakh
        '
        Me.txtMakh.Location = New System.Drawing.Point(77, 32)
        Me.txtMakh.Name = "txtMakh"
        Me.txtMakh.Size = New System.Drawing.Size(174, 20)
        Me.txtMakh.TabIndex = 4
        '
        'txtTenkh
        '
        Me.txtTenkh.Location = New System.Drawing.Point(77, 63)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(174, 20)
        Me.txtTenkh.TabIndex = 5
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(77, 96)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(174, 20)
        Me.txtDiachi.TabIndex = 6
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(77, 133)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(174, 20)
        Me.txtSDT.TabIndex = 7
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(35, 181)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 8
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnGetout
        '
        Me.btnGetout.Location = New System.Drawing.Point(176, 181)
        Me.btnGetout.Name = "btnGetout"
        Me.btnGetout.Size = New System.Drawing.Size(75, 23)
        Me.btnGetout.TabIndex = 9
        Me.btnGetout.Text = "Get out"
        Me.btnGetout.UseVisualStyleBackColor = True
        '
        'AddKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGetout)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtTenkh)
        Me.Controls.Add(Me.txtMakh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddKH"
        Me.Text = "AddKH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMakh As System.Windows.Forms.TextBox
    Friend WithEvents txtTenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnGetout As System.Windows.Forms.Button
End Class
