Public Class AddKH
    Private dataaccess As New DataBaseAccess


    Private Function AddStudent() As Boolean
        Dim sqlQuery = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", txtMakh.Text, txtTenkh.Text, txtDiachi.Text, txtSDT.Text)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMakh.Text) OrElse String.IsNullOrEmpty(txtTenkh.Text) OrElse String.IsNullOrEmpty(txtDiachi.Text) OrElse String.IsNullOrEmpty(txtSDT.Text)
    End Function

    Private Function UpdateKH() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KhachHang SET TenKH = '{0}', Diachi = '{1}', SoDT = '{2}' WHERE MaKH = '{3}'", Me.txtTenkh.Text, Me.txtDiachi.Text, Me.txtSDT.Text, Me.txtMakh.Text)
        Return dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
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

    Private Sub btnGetout_Click(sender As Object, e As EventArgs) Handles btnGetout.Click
        Me.Close()
    End Sub

    Private Sub AddKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
End Class