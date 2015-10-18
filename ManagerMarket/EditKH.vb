Public Class EditKH
    Private dataaccess As New DataBaseAccess
    Private Function UpdateKH() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KhachHang SET TenKH = '{0}', Diachi = '{1}', SoDT = '{2}' WHERE MaKH = '{3}'", Me.txtTenkh.Text, Me.txtDiachi.Text, Me.txtSDT.Text, Me.txtMakh.Text)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMakh.Text) OrElse String.IsNullOrEmpty(txtTenkh.Text) OrElse String.IsNullOrEmpty(txtDiachi.Text) OrElse String.IsNullOrEmpty(txtSdt.Text)
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("Chua nhap gia tri", "Error", MessageBoxButtons.OK)
        Else
            If UpdateKH() Then
                MessageBox.Show("Cap Nhap thanh cong", "Success", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                MessageBox.Show("Cap nhap that bai", "Error", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
        End If
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub
End Class