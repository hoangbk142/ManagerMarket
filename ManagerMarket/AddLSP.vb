Public Class AddLSP
    Private dataaccess As New DataBaseAccess
    Private Function AddStudent()
        Dim sqlQuery = "INSERT INTO LoaiSP (MaLSP,TenLSP)"
        sqlQuery += String.Format("VALUES ('{0}','{1}')", txtMaLSP.Text, txtTenLSP.Text)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty()
        Return String.IsNullOrEmpty(txtMaLSP.Text) OrElse String.IsNullOrEmpty(txtTenLSP.Text)
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub
End Class