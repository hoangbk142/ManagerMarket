Public Class AddSp
    Private dataaccess As New DataBaseAccess
    Private Function AddStudent()
        Dim sqlQuery = "INSERT INTO SanPham (MaSP,TenSP,SL,MaLSP)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", txtMasp.Text, txtTensp.Text, txtSoluong.Text, txtLoaisp.Text)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty()
        Return String.IsNullOrEmpty(txtMasp.Text) OrElse String.IsNullOrEmpty(txtTensp.Text) OrElse String.IsNullOrEmpty(txtSoluong.Text) OrElse String.IsNullOrEmpty(txtLoaisp.Text)
    End Function

    Private Sub AddSp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("Chua nhap gia tri", "Error", MessageBoxButtons.OK)
        Else
            If AddStudent() Then
                MessageBox.Show("Them thanh cong", "Success", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                MessageBox.Show("Them that bai", "Error", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub
End Class