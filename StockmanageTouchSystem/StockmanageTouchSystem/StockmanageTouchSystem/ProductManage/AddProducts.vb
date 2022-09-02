Imports MySql.Data.MySqlClient
Public Class AddProducts
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim currentDate As String
    Dim productid As Integer = 0
    Private Sub load_data()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Guna2DataGridView1.Columns(0).Width = 140
        Guna2DataGridView1.Columns(1).Width = 420
        Guna2DataGridView1.Columns(2).Width = 110
        Guna2DataGridView1.Columns(3).Visible = False 'cost visible'
        Guna2DataGridView1.Columns(4).Width = 100
        Guna2DataGridView1.Columns(10).Visible = False 'id visible'

        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub itemCodeNotEmptyLoadData()
        If searchBrcodeTxt.Text = "" Then

            '--------------------'
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view order by barcode", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            Guna2DataGridView1.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '{0}%'", searchDesTxt.Text)
            Guna2DataGridView1.DataSource = dv
            conn.Close()
        Else
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view where barcode like'" & searchBrcodeTxt.Text & "%' order by barcode", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            Guna2DataGridView1.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", searchDesTxt.Text)
            Guna2DataGridView1.DataSource = dv
            conn.Close()
        End If
    End Sub

    'function for the clear Txt'
    Private Sub clearTxt()
        barcodeTxt.Clear()
        DesTxt.Clear()
        CostTxt.Clear()
        BrandTxt.Clear()
        WholesaleTxt.Clear()
        RetailTxt.Clear()
        cmpriceTxt.Clear()
        StockTxt.Clear()
        AvStockTxt.Clear()
    End Sub
    Private Sub load_brandTbl()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT Name FROM brands;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        brandDatagridView.DataSource = table
        brandDatagridView.Columns(0).Width = 140

        conn.Close()
    End Sub
    Private Sub AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
        rowcount()
        load_brandTbl() 'This for the load brand table'
        brandDatagridView.Visible = False 'brand grid view visible false'
        'Dim currentdate As System.DateTime
        currentDate = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")

    End Sub
    Private Sub rowcount()
        Dim k As Integer = Guna2DataGridView1.Rows.Count()
        productcountLbl.Text = k
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        clearTxt()
        barcodeTxt.Select()
    End Sub

    Private Sub barcodeTxt_TextChanged(sender As Object, e As EventArgs) Handles barcodeTxt.TextChanged

    End Sub

    Private Sub barcodeTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles barcodeTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            DesTxt.Select()

        End If
    End Sub

    Private Sub DesTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles DesTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrandTxt.Select()

        End If
    End Sub

    Private Sub BrandTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles BrandTxt.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
        If e.KeyCode = Keys.Escape Then
            brandDatagridView.Visible = False
        Else
            'If brandDatagridView.Visible <> True Then 'data fide view is not visible the it visible'
            'brandDatagridView.Visible = True
            'End If
        End If
        If e.KeyCode = Keys.Up Then
            brandDatagridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            brandDatagridView.Select()
        End If
        If e.KeyCode = Keys.Enter Then
            CostTxt.Select()
        End If
    End Sub

    Private Sub CostTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles CostTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            WholesaleTxt.Select()
        End If
    End Sub

    Private Sub WholesaleTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles WholesaleTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetailTxt.Select()
        End If
    End Sub

    Private Sub RetailTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles RetailTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmpriceTxt.Select()
        End If
    End Sub

    Private Sub cmpriceTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cmpriceTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Issue_dateDateTimePicker.Select()
        End If
    End Sub

    Private Sub AvStockTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles AvStockTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveBtn.PerformClick()

        End If
    End Sub

    Private Sub BrandTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BrandTxt.KeyPress

    End Sub

    Private Sub brandDatagridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles brandDatagridView.CellContentClick
        Dim n As Integer = brandDatagridView.CurrentRow.Index
        BrandTxt.Text = brandDatagridView.Rows(n).Cells(0).Value.ToString
        brandDatagridView.Visible = False
        CostTxt.Select()

    End Sub



    Private Sub brandDatagridView_KeyDown(sender As Object, e As KeyEventArgs) Handles brandDatagridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim n As Integer = brandDatagridView.CurrentRow.Index
            BrandTxt.Text = brandDatagridView.Rows(n).Cells(0).Value.ToString
            brandDatagridView.Visible = False
            CostTxt.Select()

        End If
    End Sub

    Private Sub BrandTxt_TextChanged(sender As Object, e As EventArgs) Handles BrandTxt.TextChanged

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If barcodeTxt.Text = "" Then
            MessageBox.Show("BarCode is Empty")
        Else
            If DesTxt.Text = "" Then
                MessageBox.Show("Description is Empty")
            Else
                If CostTxt.Text = "" Then
                    MessageBox.Show("Cost is Empty")
                Else
                    If WholesaleTxt.Text = "" Then
                        MessageBox.Show("Wholosale Price is Empty")
                    Else
                        If RetailTxt.Text = "" Then
                            MessageBox.Show("Retail Price is Empty")
                        Else
                            If cmpriceTxt.Text = "" Then
                                MessageBox.Show("Customer Show Price is Empty")
                            Else
                                If AvStockTxt.Text = "" Then
                                    MessageBox.Show("Minimum Stock is Empty")
                                Else
                                    currentDate = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")
                                    Dim barcode As String = barcodeTxt.Text.Trim()
                                    Dim des As String = DesTxt.Text.Trim()

                                    Dim clean As String
                                    clean = des.Replace("'", " ")
                                    des = clean
                                    clean = barcode.Replace("'", " ")
                                    barcode = clean
                                    Dim stock As Integer = 0
                                    If SerCodeTxt.Text = "1010" Then
                                        stock = StockTxt.Text
                                    End If
                                    Dim Query As String
                                    Dim a As Integer = 0
                                    Try 'This for the item Add'

                                        MySqlConn.Open()
                                        Query = "INSERT INTO `all_items` (`barcode`, `Des`, `Av_Stock`, `Brand`) VALUES ('" & barcode & "', '" & des & "', '" & AvStockTxt.Text & "', '" & BrandTxt.Text & "');"
                                        COMMAND = New MySqlCommand(Query, MySqlConn)
                                        READER = COMMAND.ExecuteReader
                                        MySqlConn.Close()
                                    Catch ex As Exception
                                        a += 1
                                        MessageBox.Show(ex.Message)
                                        MySqlConn.Close()
                                    End Try
                                    If (a = 0) Then
                                        Try 'This for the price And cost Add'
                                            MySqlConn.Open()

                                            Query = "INSERT INTO `all_items_sptbl` (`id`, `all_items_barcode`, `cost`, `whprice`, `rprice`, `stock`, `ExpireDate`, `CMshowprice`) VALUES (NULL, '" & barcode & "', '" & CostTxt.Text & "', '" & WholesaleTxt.Text & "', '" & RetailTxt.Text & "', '" & stock & "', '" & currentDate & "', '" & cmpriceTxt.Text & "');"
                                            COMMAND = New MySqlCommand(Query, MySqlConn)
                                            READER = COMMAND.ExecuteReader
                                            MySqlConn.Close()
                                        Catch ex As Exception
                                            a += 1
                                            MessageBox.Show(ex.Message)
                                            MySqlConn.Close()
                                        End Try
                                    End If

                                    If (a = 0) Then
                                        MessageBox.Show("Product added successfully")
                                        clearTxt()
                                        itemCodeNotEmptyLoadData()
                                        rowcount()
                                        barcodeTxt.Select()

                                    Else
                                        MessageBox.Show("Error In Product Add")
                                    End If
                                End If
                                End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    Private Sub Issue_dateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Issue_dateDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then

            If SerCodeTxt.Text = "1010" Then
                StockTxt.Select()
            Else
                AvStockTxt.Select()
            End If
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If barcodeTxt.Text = "" Then
            MessageBox.Show("BarCode is Empty")
        Else
            If DesTxt.Text = "" Then
                MessageBox.Show("Description is Empty")
            Else
                If CostTxt.Text = "" Then
                    MessageBox.Show("Cost is Empty")
                Else
                    If WholesaleTxt.Text = "" Then
                        MessageBox.Show("Wholosale Price is Empty")
                    Else
                        If RetailTxt.Text = "" Then
                            MessageBox.Show("Retail Price is Empty")
                        Else
                            If cmpriceTxt.Text = "" Then
                                MessageBox.Show("Customer Show Price is Empty")
                            Else
                                If AvStockTxt.Text = "" Then
                                    MessageBox.Show("Minimal Stock is Empty")
                                Else
                                    If productid = 0 Then
                                        MessageBox.Show("Product is Not Selected")
                                    Else
                                        currentDate = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")

                                        Dim barcode As String = barcodeTxt.Text.Trim()
                                        Dim des As String = DesTxt.Text.Trim()

                                        Dim clean As String
                                        clean = des.Replace("'", " ")
                                        des = clean
                                        clean = barcode.Replace("'", " ")
                                        barcode = clean

                                        Dim Query As String
                                        Dim a As Integer = 0
                                        Try 'This for the item Add'

                                            MySqlConn.Open()
                                            Query = "UPDATE `all_items` SET `barcode` = '" & barcode & "', `Des` = '" & des & "', `Av_Stock` = '" & AvStockTxt.Text & "', `Brand` = '" & BrandTxt.Text & "' WHERE `all_items`.`barcode` = '" & barcode & "'; "
                                            COMMAND = New MySqlCommand(Query, MySqlConn)
                                            READER = COMMAND.ExecuteReader
                                            MySqlConn.Close()
                                        Catch ex As Exception
                                            a += 1
                                            MessageBox.Show(ex.Message)
                                            MySqlConn.Close()
                                        End Try
                                        Dim tid As Integer = productid

                                        Try 'This for the price And cost Add'
                                            MySqlConn.Open()
                                            If SerCodeTxt.Text = "1010" Then
                                                Query = "UPDATE `all_items_sptbl` SET `cost` = '" & CostTxt.Text & "', `whprice` = '" & WholesaleTxt.Text & "', `stock` = '" & StockTxt.Text & "', `rprice` = '" & RetailTxt.Text & "', `ExpireDate` = '" & currentDate & "', `CMshowprice` = '" & cmpriceTxt.Text & "' WHERE `all_items_sptbl`.`id` = '" & tid & "'; "

                                            Else
                                                Query = "UPDATE `all_items_sptbl` SET `cost` = '" & CostTxt.Text & "', `whprice` = '" & WholesaleTxt.Text & "', `rprice` = '" & RetailTxt.Text & "', `ExpireDate` = '" & currentDate & "', `CMshowprice` = '" & cmpriceTxt.Text & "' WHERE `all_items_sptbl`.`id` = '" & tid & "'; "
                                            End If

                                            COMMAND = New MySqlCommand(Query, MySqlConn)
                                            READER = COMMAND.ExecuteReader
                                            MySqlConn.Close()

                                        Catch ex As Exception
                                            a += 1
                                            MessageBox.Show(ex.Message)
                                            MySqlConn.Close()
                                        End Try
                                        If (a = 0) Then
                                            MessageBox.Show("Product Updated successfully")
                                            'productid = 0
                                            itemCodeNotEmptyLoadData()
                                            rowcount()
                                            clearTxt()
                                            barcodeTxt.Select()
                                        Else
                                            MessageBox.Show("Error In Product Edit")
                                        End If
                                    End If

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub searchBrcodeTxt_TextChanged(sender As Object, e As EventArgs) Handles searchBrcodeTxt.TextChanged
        '--------------------'
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view order by barcode", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("barcode Like '{0}%'", searchBrcodeTxt.Text)
        Guna2DataGridView1.DataSource = dv
        conn.Close()
        rowcount()
        If SerCodeTxt.Text = "1" Then

            addtothestock()
            'SaveBtn.PerformClick()
        End If

    End Sub

    Private Sub searchDesTxt_TextChanged(sender As Object, e As EventArgs) Handles searchDesTxt.TextChanged
        If searchBrcodeTxt.Text = "" Then

            '--------------------'
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view order by barcode", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            Guna2DataGridView1.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '{0}%'", searchDesTxt.Text)
            Guna2DataGridView1.DataSource = dv
            conn.Close()
        Else
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id FROM all_items_view where barcode like'" & searchBrcodeTxt.Text & "%' order by barcode", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            Guna2DataGridView1.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", searchDesTxt.Text)
            Guna2DataGridView1.DataSource = dv
            conn.Close()
        End If

        rowcount()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SerCodeTxt.Text = "2022" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to delete selected product?", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim Query As String
                If barcodeTxt.Text <> "" And productid <> 0 Then

                    Try

                        MySqlConn.Open()
                        Query = "DELETE FROM `all_items_sptbl` WHERE `all_items_sptbl`.`id` = '" & productid & "';"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        itemCodeNotEmptyLoadData()
                        clearTxt()
                        MessageBox.Show("Product removed successfully")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MySqlConn.Close()
                    End Try
                Else
                    MessageBox.Show("Didn't Select Any Item")
                End If

            End If
        Else
            MessageBox.Show("You Are Not Admin")
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        'barcode,Des,Brand,cost,whprice,rprice,CMshowprice,ExpireDate,stock,Av_Stock,id
        Dim k As Integer = Guna2DataGridView1.CurrentRow.Index
        barcodeTxt.Text = Guna2DataGridView1.Rows(k).Cells(0).Value.ToString
        DesTxt.Text = Guna2DataGridView1.Rows(k).Cells(1).Value.ToString
        BrandTxt.Text = Guna2DataGridView1.Rows(k).Cells(2).Value.ToString
        CostTxt.Text = Guna2DataGridView1.Rows(k).Cells(3).Value.ToString
        WholesaleTxt.Text = Guna2DataGridView1.Rows(k).Cells(4).Value.ToString
        RetailTxt.Text = Guna2DataGridView1.Rows(k).Cells(5).Value.ToString
        cmpriceTxt.Text = Guna2DataGridView1.Rows(k).Cells(6).Value.ToString
        Issue_dateDateTimePicker.Value = Guna2DataGridView1.Rows(k).Cells(7).Value.ToString

        StockTxt.Text = Guna2DataGridView1.Rows(k).Cells(8).Value.ToString
        AvStockTxt.Text = Guna2DataGridView1.Rows(k).Cells(9).Value.ToString
        productid = Guna2DataGridView1.Rows(k).Cells(10).Value.ToString

    End Sub

    Private Sub SerCodeTxt_TextChanged(sender As Object, e As EventArgs) Handles SerCodeTxt.TextChanged

        Try
            If SerCodeTxt.Text = "POS" Then
                Guna2DataGridView1.Columns(3).Visible = True
            Else
                Guna2DataGridView1.Columns(3).Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
    Private Sub addtothestock()
        If searchBrcodeTxt.Text = "8901120002511" Then

            barcodeTxt.Text = "8901120002511"
            DesTxt.Text = "PANTODAC 40"
            CostTxt.Text = "8.40"
            BrandTxt.Text = "NYCOMED"
            WholesaleTxt.Text = "9.50"
            RetailTxt.Text = "10.00"
            cmpriceTxt.Text = "11.00"
            StockTxt.Text = "0"
            AvStockTxt.Text = "150"
        ElseIf searchBrcodeTxt.Text = "810695020173" Then
            barcodeTxt.Text = "810695020173"
            DesTxt.Text = "LACTOL FRUCTO 2X 15 100MG"
            CostTxt.Text = "14.00"
            BrandTxt.Text = "LACTOL"
            WholesaleTxt.Text = "16.65"
            RetailTxt.Text = "18.70"
            cmpriceTxt.Text = "19"
            StockTxt.Text = "0"
            AvStockTxt.Text = "100"
        End If
    End Sub

    Private Sub Issue_dateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Issue_dateDateTimePicker.ValueChanged

    End Sub

    Private Sub StockTxt_TextChanged(sender As Object, e As EventArgs) Handles StockTxt.TextChanged

    End Sub

    Private Sub StockTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles StockTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            AvStockTxt.Select()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RetailTxt_TextChanged(sender As Object, e As EventArgs) Handles RetailTxt.TextChanged

    End Sub
End Class