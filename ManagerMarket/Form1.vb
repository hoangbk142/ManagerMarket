Public Class Form1
    Private dataaccess As New DataBaseAccess
    Private isloading As Boolean = False

    Private Sub LoaddataComboBox()
        Dim sqlQuery As String = "SELECT MaLSP,TenLSP FROM dbo.LoaiSP"
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.cbSP.DataSource = dTable
        Me.cbSP.ValueMember = "MaLSP"
        Me.cbSP.DisplayMember = "TenLSP"
    End Sub

    Private Sub LoadDataGridView(ClassID As String)
        Dim sqlQuery As String = String.Format("SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{0}'", ClassID)
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.dgvLoad.DataSource = dTable
        With Me.dgvLoad
            .Columns(0).HeaderText = "Ma SP"
            .Columns(0).HeaderText = "Ten SP"
            .Columns(0).HeaderText = "So Luong"
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isloading = True
        LoaddataComboBox()
        LoadDataGridView(Me.cbSP.SelectedValue)
        isloading = False
    End Sub

    Private Sub cbSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSP.SelectedIndexChanged
        If Not isloading Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub


    Private Sub SearchLoading(ClassID As String, value As String)
        Dim sqlQuery As String = String.Format("SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{0}'", ClassID)
        If Me.cbSearch.SelectedIndex = 0 Then 'Tim theo ID
            sqlQuery += String.Format(" AND MaSP LIKE '{0}%'", value)
        ElseIf Me.cbSearch.SelectedIndex = 1 Then 'Tim theo ten
            sqlQuery += String.Format(" AND TenSP LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.dgvLoad.DataSource = dTable
        With Me.dgvLoad
            .Columns(0).HeaderText = "Ma SP"
            .Columns(0).HeaderText = "Ten SP"
            .Columns(0).HeaderText = "So Luong"
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchLoading(Me.cbSP.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub btnkhachhang_Click(sender As Object, e As EventArgs) Handles btnkhachhang.Click
        Dim frKH As New AddKH
        frKH.ShowDialog()
        If frKH.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub

    Private Sub btnsanpham_Click(sender As Object, e As EventArgs) Handles btnsanpham.Click
        Dim frSP As New AddSp
        frSP.txtLoaisp.Text = Me.cbSP.SelectedValue
        frSP.ShowDialog()
        If frSP.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub

    Private Sub cbKH_CheckedChanged(sender As Object, e As EventArgs) Handles cbKH.CheckedChanged
        Dim sqlQuery As String = "SELECT MaKH,TenKH,Diachi,SoDT FROM dbo.KhachHang"
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.dgvLoad.DataSource = dTable
        With Me.dgvLoad
            .Columns(0).HeaderText = "Ma KH"
            .Columns(0).HeaderText = "Ten KH"
            .Columns(0).HeaderText = "Dia Chi"
            .Columns(0).HeaderText = "So DT"
        End With
    End Sub

    Private Sub cbHD_CheckedChanged(sender As Object, e As EventArgs) Handles cbHD.CheckedChanged
        Dim sqlQuery As String = "SELECT MaHD,MaKH,Ngaylap FROM dbo.HoaDon"
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.dgvLoad.DataSource = dTable
        With Me.dgvLoad
            .Columns(0).HeaderText = "Ma HD"
            .Columns(0).HeaderText = "Ma KH"
            .Columns(0).HeaderText = "Ngay Lap"
        End With
    End Sub

    Private Sub cbCTHD_CheckedChanged(sender As Object, e As EventArgs) Handles cbCTHD.CheckedChanged
        Dim sqlQuery As String = "SELECT MaSP,MaHD,SoLuong,DonGia FROM dbo.ChiTietHoaDon"
        Dim dTable As DataTable = dataaccess.GetDataTable(sqlQuery)
        Me.dgvLoad.DataSource = dTable
        With Me.dgvLoad
            .Columns(0).HeaderText = "Ma SP"
            .Columns(0).HeaderText = "Ma HD"
            .Columns(0).HeaderText = "So Luong"
            .Columns(0).HeaderText = "Don Gia"
        End With
    End Sub

    Private Sub btnAddHD_Click(sender As Object, e As EventArgs) Handles btnAddHD.Click
        Dim frHD As New AddHD
        frHD.ShowDialog()
        If frHD.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub

    Private Sub btnAddLSP_Click(sender As Object, e As EventArgs) Handles btnAddLSP.Click
        Dim frLSP As New AddLSP
        frLSP.ShowDialog()
        If frLSP.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub

    Private Sub btnEditKH_Click(sender As Object, e As EventArgs) Handles btnEditKH.Click
        Dim frm As New EditKH
        With Me.dgvLoad
            frm.txtMakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txtTenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.txtDiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("Diachi").Value
            frm.txtSdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SoDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataGridView(Me.cbSP.SelectedValue)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
       

        If cbKH.Checked Then
            Dim MaKH As String = Me.dgvLoad.Rows(Me.dgvLoad.CurrentCell.RowIndex).Cells("MaKH").Value
            Dim sqlQuery As String = String.Format("DELETE KhachHang WHERE MaKH = '{0}'", MaKH)
            If dataaccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Xoa thanh cong")
                LoadDataGridView(Me.cbSP.SelectedValue)
            Else
                MessageBox.Show("Loi xoa")
            End If
        End If

        If cbHD.Checked Then
            Dim MaHD As String = Me.dgvLoad.Rows(Me.dgvLoad.CurrentCell.RowIndex).Cells("MaHD").Value
            Dim sqlQuery As String = String.Format("DELETE HoaDon WHERE MaHD = '{0}'", MaHD)
            If dataaccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Xoa thanh cong")
                LoadDataGridView(Me.cbSP.SelectedValue)
            Else
                MessageBox.Show("Loi xoa")
            End If
        End If

    End Sub

End Class
