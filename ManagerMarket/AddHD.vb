Public Class AddHD
    Private dataaccess As New DataBaseAccess
    Private Function AddStudent() As Boolean
        Dim sqlQuery = "INSERT INTO HoaDon (MaHD,MaKH,Ngaylap)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}')", txtMaHDD.Text, txtMaKHH.Text, datetimeNgayLap.Value.Date)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMaHDD.Text) OrElse String.IsNullOrEmpty(txtMaKHH.Text) OrElse String.IsNullOrEmpty(datetimeNgayLap.Value.Date)
    End Function
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If IsEmpty() Then
            MessageBox.Show("Chua nhap gia tri", "Error", MessageBoxButtons.OK)
        Else
            If AddStudent() Then
                MessageBox.Show("Them thanh cong", "Success", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                MessageBox.Show("Them that bai", "Error", MessageBoxButtons.OK)
                MessageBox.Show("ID " + Me.txtMaKHH.Text + "Ten: " + Me.txtMaHDD.Text + "Date: " + Me.datetimeNgayLap.Value)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub
End Class