Imports MySql.Data.MySqlClient
Public Class RetailSale3
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    'This for the customer'
    Dim customerid As Integer = 1
    '---------------------------------

    'This for the product'
    Dim stock As Integer
    Dim cost As Double
    Dim expireDate As String
    Dim CmPrice As String
    '------------------------------------------------'
    'This for the delete product'
    Dim isdelete As Integer = 0
    Dim invid As Integer = 0
    '------------------------------------------------'
    Dim itemid As Integer = 0

    Dim sid As Integer 'selling table sid'
    Dim invno As String
    'This part for the new product Add load'
    Private Sub load_data()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ItemsShow.DataSource = table
        ItemsShow.Columns(0).Width = 140
        ItemsShow.Columns(1).Width = 420
        ItemsShow.Columns(2).Visible = False 'cost'
        ItemsShow.Columns(3).Width = 100
        ItemsShow.Columns(4).Width = 100
        ItemsShow.Columns(5).Width = 100 'stock'

        ItemsShow.Columns(8).Visible = False 'id visible'

        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub load_InvNo() 'This for the load Invoice No'
        conn.Open()
        Dim quer As String
        quer = "SELECT * FROM `inv_no_2`"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            Dim invNo = READER.GetString("id")
            InvLbl.Text = invNo
        End While
        conn.Close()
    End Sub
    Private Sub change_InvNo()
        Dim invno As Integer = InvLbl.Text + 1
        Try
            Dim Query As String
            MySqlConn.Open()
            Query = "UPDATE `inv_no_2` SET `id` = '" & invno & "' WHERE `inv_no_2`.`id` = '" & InvLbl.Text & "';"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MySqlConn.Close()
            MessageBox.Show(ex.Message)
        End Try
        load_InvNo() 'This for the load Invoice No'

    End Sub
    Private Sub ShowRetailSale() 'load Retail Sale'
        conn.Open()
        '`id``Invno``billing_date``Customer_id``CusName``itemid``barcode``des``qty``unit_price``cus_price``discount``amount``expire_date`

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select barcode,des,qty,unit_price,cus_price,discount,expire_date,amount,id,Invno,billing_date,Customer_id,CusName,itemid from selling_temp_2", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        RetailDataGridView.DataSource = table
        RetailDataGridView.Columns(0).Width = 150 'barcode'
        RetailDataGridView.Columns(1).Width = 250 'des'
        RetailDataGridView.Columns(2).Width = 90 'qty'
        RetailDataGridView.Columns(3).Width = 150 'unit_price'
        RetailDataGridView.Columns(4).Width = 150 'cus_price'
        RetailDataGridView.Columns(5).Width = 150 'discount'
        RetailDataGridView.Columns(6).Width = 150 'expire_date'
        RetailDataGridView.Columns(7).Width = 150 'amount'

        RetailDataGridView.Columns(8).Visible = False 'id'
        RetailDataGridView.Columns(9).Visible = False 'Invno'
        RetailDataGridView.Columns(10).Visible = False 'billing_date'
        RetailDataGridView.Columns(11).Visible = False 'Customer_id'
        RetailDataGridView.Columns(12).Visible = False 'CusName'
        RetailDataGridView.Columns(13).Visible = False 'itemid'
        conn.Close()
    End Sub
    Private Sub RetailSale3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_InvNo() 'load_invNo
        load_data() 'load product table'
        ShowRetailSale() 'show retails sale'
        Dim rowcount As Integer = RetailDataGridView.Rows.Count
        If rowcount <> 0 Then

            TimePicker1.Value = RetailDataGridView.Rows(0).Cells(10).Value 'billing_date'
            customerid = RetailDataGridView.Rows(0).Cells(11).Value 'Customer_id'
            CNameTxt.Text = RetailDataGridView.Rows(0).Cells(12).Value 'CusName'

            calculate_netamount()
        End If
        BarCodeTxt.Select()

        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If

        BalanceGridView.Visible = False

        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'
    End Sub

    Private Sub CNameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles CNameTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            BarCodeTxt.Select()

        End If
    End Sub



    Private Sub DesTxt_TextChanged(sender As Object, e As EventArgs) Handles DesTxt.TextChanged
        If BarCodeTxt.Text = "" Then
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view Where NOT stock = 0 order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", DesTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        Else
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view where barcode like '%" & BarCodeTxt.Text & "%' AND NOT stock = 0  order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", DesTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        End If
    End Sub




    Private Sub DesTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles DesTxt.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Up Then
            ItemsShow.Select()
        End If
        If e.KeyCode = Keys.Down Then
            ItemsShow.Select()
        End If
        If e.KeyCode = Keys.Enter Then
            Dim s As Integer = 0

            itemid = ItemsShow.Rows(s).Cells(8).Value
            Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
            Dim des As String = ItemsShow.Rows(s).Cells(1).Value
            If BillTypeCombo.Text = "W" Then
                Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(3).Value 'wholeSale'
            Else
                Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'
            End If
            CmPrice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'

            stock = ItemsShow.Rows(s).Cells(5).Value 'stock'

            expireDate = Format(Me.ItemsShow.Rows(s).Cells(7).Value, "yyyy-MM-dd") 'expiredate'
            cost = ItemsShow.Rows(s).Cells(2).Value 'cost'

            BarCodeTxt.Text = itmcode
            DesTxt.Text = des
            isdelete = 0
            QutTextBox.Select()
        End If

        If e.KeyCode = Keys.F1 Then
            SaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F2 Then
            InvSaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub DesTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DesTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        Else
            If Panel1.Visible Then
                Panel1.Visible = True
            Else
                Panel1.Visible = True

            End If

        End If
    End Sub

    Private Sub ItemsShow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsShow.CellContentClick

    End Sub

    Private Sub ItemsShow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsShow.CellClick
        'barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand

        Dim s As Integer = ItemsShow.CurrentRow.Index

        itemid = ItemsShow.Rows(s).Cells(8).Value
        Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
        Dim des As String = ItemsShow.Rows(s).Cells(1).Value
        If BillTypeCombo.Text = "W" Then
            Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
        Else
            Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'
        End If
        CmPrice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'

        stock = ItemsShow.Rows(s).Cells(5).Value 'stock'

        expireDate = Format(Me.ItemsShow.Rows(s).Cells(7).Value, "yyyy-MM-dd") 'expiredate'
        cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
        BrandTxt.Text = ItemsShow.Rows(s).Cells(9).Value 'Brand'
        BarCodeTxt.Text = itmcode
        DesTxt.Text = des
        isdelete = 0
        ballance_pro_check = False
        QutTextBox.Select()
    End Sub

    Private Sub ItemsShow_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemsShow.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            Dim s As Integer = ItemsShow.CurrentRow.Index

            itemid = ItemsShow.Rows(s).Cells(8).Value
            Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
            Dim des As String = ItemsShow.Rows(s).Cells(1).Value
            If BillTypeCombo.Text = "W" Then
                Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            Else
                Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'
            End If
            CmPrice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'

            stock = ItemsShow.Rows(s).Cells(5).Value 'stock'

            expireDate = Format(Me.ItemsShow.Rows(s).Cells(7).Value, "yyyy-MM-dd") 'expiredate'
            cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
            BrandTxt.Text = ItemsShow.Rows(s).Cells(9).Value 'Brand'
            BarCodeTxt.Text = itmcode
            DesTxt.Text = des
            isdelete = 0
            ballance_pro_check = False
            QutTextBox.Select()
        End If
    End Sub

    Private Sub QutTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QutTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            Unit_PriceTextBox.Select()
        End If
        If e.KeyCode = Keys.F1 Then

            NextBtn.PerformClick()
            SaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F2 Then

            NextBtn.PerformClick()
            InvSaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub QutTextBox_TextChanged(sender As Object, e As EventArgs) Handles QutTextBox.TextChanged
        If QutTextBox.Text = "" Then
        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text

            End If
        End If
    End Sub

    Private Sub Unit_PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Unit_PriceTextBox.TextChanged
        If QutTextBox.Text = "" Then
        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text
            End If
        End If
    End Sub

    Private Sub Unit_PriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Unit_PriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTextBox.Select()
        End If
        If e.KeyCode = Keys.F1 Then
            NextBtn.PerformClick()
            SaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F2 Then
            NextBtn.PerformClick()
            InvSaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged
        If QutTextBox.Text = "" Then
        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                If DiscountTextBox.Text = "" Then
                    AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text
                Else
                    'Dim dis As Integer
                    AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text - DiscountTextBox.Text
                    'dis = 100 - DiscountTextBox.Text
                    'AmountTextBox.Text = (AmountTextBox.Text / 100)
                    'AmountTextBox.Text = AmountTextBox.Text * dis

                End If
            End If
        End If
    End Sub

    Private Sub DiscountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DiscountTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NextBtn.PerformClick()
        End If

        If e.KeyCode = Keys.F1 Then
            NextBtn.PerformClick()
            SaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F2 Then
            NextBtn.PerformClick()
            InvSaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub DiscountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DiscountTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then

        End If
    End Sub

    Private Function udercost() 'This condition for the check is that item is undercost item'
        Dim unitprice As Double = Unit_PriceTextBox.Text
        Dim state As Boolean = True
        If DiscountTextBox.Text <> "" Then
            Dim discount As Double = DiscountTextBox.Text
            Dim amt As Double = (100 - discount) * unitprice / 100
            If amt <= cost Then
                state = False
            End If
        End If
        If unitprice <= cost Then
            state = False
        End If
        Return state
    End Function

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If Unit_PriceTextBox.Text = "" Then
            MsgBox("Please Enter Unit Price")
        Else
            If DesTxt.Text = "" Then
                MsgBox("Please Enter Description")
            Else
                If BarCodeTxt.Text = "" Then
                    MsgBox("Please Enter Item Code")
                Else
                    If AmountTextBox.Text = "" Then
                        MsgBox("Please Enter Amount")
                    Else
                        If QutTextBox.Text = "" Then
                            MsgBox("Plese Enter Quantity")
                        Else
                            If Unit_PriceTextBox.Text < cost Then
                                MsgBox("Price undercost change unit price")
                            Else
                                If DiscountTextBox.Text = "" Then
                                    If ballance_pro_check = True Then 'This for the check is the balance Product'

                                        balnce_pro_ad_to_Bill()
                                        ShowRetailSale() 'show retails sale'
                                        clear_text()
                                        calculate_netamount() 'this for calculate net amount'

                                        ballance_pro_check = False
                                    ElseIf ballance_pro_check = False Then
                                        If changestock() = True Then
                                            AddtoGrideView()
                                            ShowRetailSale() 'show retails sale'
                                            clear_text()
                                            calculate_netamount() 'this for calculate net amount'
                                        Else
                                            MessageBox.Show("Error In Product Add")
                                        End If
                                    End If

                                Else
                                    If ballance_pro_check = True Then 'This for the check is the balance Product'

                                        balnce_pro_ad_to_Bill()
                                        ShowRetailSale() 'show retails sale'
                                        clear_text()
                                        calculate_netamount() 'this for calculate net amount'

                                        ballance_pro_check = False
                                    ElseIf ballance_pro_check = False Then
                                        Dim uncost As Double = Unit_PriceTextBox.Text * (100 - DiscountTextBox.Text) / 100
                                        If uncost >= cost Then
                                            If changestock() = True Then
                                                AddtoGrideView()
                                                ShowRetailSale() 'show retails sale'
                                                clear_text()
                                                calculate_netamount() 'this for calculate net amount'
                                            Else
                                                MessageBox.Show("Error In Product Add")
                                            End If
                                        Else
                                            MessageBox.Show("Price undercost change unit price")
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
    'End---------------------------------------------------------------------------------

    Private Function changestock() 'This function for the change stock manage'
        Dim nqty As Integer = QutTextBox.Text
        Dim newstk As Integer
        'Get The Stock'
        conn.Open()
        Dim quer As String
        quer = "SELECT `stock` FROM all_items_sptbl WHERE `id` = '" & itemid & "';"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            newstk = READER.GetString("stock")

        End While
        conn.Close()

        '-------End of the Getting Stock--------------------------------------------------------'

        Dim nstock As Integer = newstk - nqty

        If nstock >= 0 Then 'Under Stock check'
            If nstock = 0 Then
                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "UPDATE `all_items_sptbl` SET `stock` = '" & nstock & "',`status` = '1' WHERE `all_items_sptbl`.`id` = '" & itemid & "'; "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    load_data()
                    Return True
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try
            Else

                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "UPDATE `all_items_sptbl` SET `stock` = '" & nstock & "' WHERE `all_items_sptbl`.`id` = '" & itemid & "'; "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    load_data()
                    Return True
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Under Stock Error")
            Return False
        End If

    End Function

    Private Sub AddtoGrideView()
        Dim isin As Integer = 0
        Dim oldqty As Integer = 0
        Dim billdate As String = Format(Me.TimePicker1.Value, "yyyy-MM-dd hh:mm:ss")
        Dim discountno As Double = 0
        If DiscountTextBox.Text <> "" Then
            discountno = DiscountTextBox.Text
        End If
        For q As Integer = 0 To RetailDataGridView.Rows.Count - 1 Step +1
            If itemid = RetailDataGridView.Rows(q).Cells(13).Value Then 'Check for the item id'
                oldqty = RetailDataGridView.Rows(q).Cells(2).Value
                isin = 1
            End If
        Next
        If isin = 1 Then
            Dim nqty As Integer = oldqty + QutTextBox.Text
            Dim namt As Double = nqty * Unit_PriceTextBox.Text
            namt = namt * (100 - discountno) / 100
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "UPDATE `selling_temp_2` SET `qty` = '" & nqty & "', `unit_price` = '" & Unit_PriceTextBox.Text & "', `discount` = '" & discountno & "', `amount` = '" & namt & "' WHERE `selling_temp_2`.`itemid` = '" & itemid & "'; "
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "INSERT INTO `selling_temp_2` (`id`, `Invno`, `billing_date`, `Customer_id`, `CusName`, `itemid`, `barcode`, `des`, `qty`, `unit_price`, `cus_price`, `discount`, `amount`, `expire_date`) VALUES (NULL, '" & InvLbl.Text & "', '" & billdate & "', '" & customerid & "', '" & CNameTxt.Text & "', '" & itemid & "', '" & BarCodeTxt.Text & "', '" & DesTxt.Text & "', '" & QutTextBox.Text & "', '" & Unit_PriceTextBox.Text & "', '" & CmPrice & "', '" & discountno & "', '" & AmountTextBox.Text & "', '" & expireDate & "');"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try
        End If
        addtoProfitTbl() 'This for the item add for the profit Tbl'
    End Sub

    Private Sub clear_text() 'This for the clear Text Fildes'
        itemid = 0
        isdelete = 0

        BarCodeTxt.Clear()
        DesTxt.Clear()
        QutTextBox.Clear()
        Unit_PriceTextBox.Clear()
        DiscountTextBox.Clear()
        AmountTextBox.Clear()
        BarCodeTxt.Select()
    End Sub

    Private Sub calculate_netamount()
        Dim netamt As Double
        For q As Integer = 0 To RetailDataGridView.Rows.Count - 1 Step +1
            netamt = netamt + RetailDataGridView.Rows(q).Cells(7).Value
        Next
        NetAmountTxt.Text = netamt.ToString
    End Sub
    'This part for the time bill add to the selling tbl'
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        addtothrselling()
        ShowRetailSale() 'show retails sale'
        clear_text()
        calculate_netamount() 'this for calculate net amount'
        change_InvNo()
    End Sub
    Private Function addtothrselling()

        Dim Query As String
        Dim billdate As String = Format(Me.TimePicker1.Value, "yyyy-MM-dd hh:mm:ss")
        invno = "Inv-00" & InvLbl.Text
        Try
            MySqlConn.Open()
            Query = "INSERT INTO `selling` (`sid`, `Invno`, `billing_date`, `Customer_id`, `CusName`, `netAmount`, `netdiscount`, `NetDisAmount`, `GrandTotal`) VALUES (NULL, '" & invno & "', '" & billdate & "', '" & customerid & "', '" & CNameTxt.Text & "', '" & NetAmountTxt.Text & "', '0', '0', '" & NetAmountTxt.Text & "');"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MySqlConn.Close()
            MessageBox.Show(ex.Message)
        End Try


        MySqlConn.Open()
        Query = "SELECT * FROM `selling` WHERE `Invno` = '" & invno & "'"
        COMMAND = New MySqlCommand(Query, MySqlConn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            sid = READER.GetString("sid")
        End While
        MySqlConn.Close()

        Dim expiredate As String
        Dim itmida As Integer
        For q As Integer = 0 To RetailDataGridView.Rows.Count - 1 Step +1 'item add to the selling'
            expiredate = Format(Me.RetailDataGridView.Rows(q).Cells(6).Value, "yyyy-MM-dd")
            itmida = RetailDataGridView.Rows(q).Cells(13).Value
            Try
                MySqlConn.Open()
                Query = "INSERT INTO `selling_items` (`id`, `Selling_sid`,`itemid`, `barcode`, `des`, `qty`, `unit_price`, `cus_price`, `discount`, `amount`, `expire_date`) VALUES (NULL, '" & sid & "','" & itmida & "', '" & RetailDataGridView.Rows(q).Cells(0).Value & "', '" & RetailDataGridView.Rows(q).Cells(1).Value & "', '" & RetailDataGridView.Rows(q).Cells(2).Value & "', '" & RetailDataGridView.Rows(q).Cells(3).Value & "', '" & RetailDataGridView.Rows(q).Cells(4).Value & "', '" & RetailDataGridView.Rows(q).Cells(5).Value & "', '" & RetailDataGridView.Rows(q).Cells(7).Value & "', '" & expiredate & "');"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try
        Next

        Try
            MySqlConn.Open()
            Query = "DELETE FROM `selling_temp_2`"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MySqlConn.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Function Del_check_isblane_product(barcodess)
        Dim a As Boolean = False
        conn.Open()
        Dim quer As String
        quer = "SELECT * FROM all_balance_product WHERE `barcode` = '" & barcodess & "';"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            bfulbarcode = READER.GetString("barcode")
            bdes = READER.GetString("Des")
            bbrand = READER.GetString("brand")
            bcost = READER.GetString("cost")
            bwhprice = READER.GetString("wholesale")
            bretailPrice = READER.GetString("retail")
            bcm_price = READER.GetString("cm_price")
            bWeight = READER.GetString("weight")

            bexpire = READER.GetString("expire_date")
            bexpire = Format(Me.bexpire, "yyyy-MM-dd")

            a = True

        End While
        conn.Close()
        Return a
    End Function
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim Query As String
            Dim ncost As Double = 0
            Dim nstock As Integer
            'This Part for the Check That Product is a balance Product
            Dim bar As String = BarCodeTxt.Text
            Dim newbar = bar.Chars(0) & bar.Chars(1) & bar.Chars(2)
            If Del_check_isblane_product(newbar) = True Then
                Dim qty As Double = QutTextBox.Text
                Dim nqty As Double = bWeight + qty
                Try

                    MySqlConn.Open()
                    Query = "UPDATE `all_balance_product` SET `weight` = '" & nqty & "' WHERE `all_balance_product`.`barcode` = '" & newbar & "'; "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()

                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try

                Try
                    MySqlConn.Open()
                    Query = "DELETE FROM `selling_temp_2` WHERE `selling_temp_2`.`id` = '" & invid & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try
                'Delete From the profit Table -------------------------------'

                Try
                    MySqlConn.Open()
                    Query = "DELETE FROM `daily_proft_tbl` WHERE Inv_no = '" & InvLbl.Text & "' AND barcode = '" & BarCodeTxt.Text & "'; "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try

                '-----End Profit---------------------------------------------'
                isdelete = 0
                clear_text()
                ShowRetailSale() 'show retails sale'
                calculate_netamount() 'this for calculate net amount'
            Else
                If isdelete = 1 Then
                    Try

                        MySqlConn.Open()
                        Query = "SELECT * FROM `all_items_sptbl` WHERE `id` = '" & itemid & "'; "
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        While READER.Read
                            ncost = READER.GetString("cost")
                            nstock = READER.GetString("stock")
                        End While
                        MySqlConn.Close()
                        If ncost <> 0 Then
                            nstock = nstock + QutTextBox.Text

                            MySqlConn.Open()
                            Query = "UPDATE `all_items_sptbl` SET `stock` = '" & nstock & "',`status` = '0' WHERE `all_items_sptbl`.`id` = '" & itemid & "'; "
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()

                            MySqlConn.Open()
                            Query = "DELETE FROM `selling_temp_2` WHERE `selling_temp_2`.`id` = '" & invid & "'"
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()
                            delete_from_profit_Tbl() 'This for the delete That item from the profit Table'
                        Else
                            MessageBox.Show("Cant Delete This file")
                        End If

                    Catch ex As Exception
                        MySqlConn.Close()
                        MessageBox.Show(ex.Message)
                    End Try

                    isdelete = 0
                    clear_text()
                    ShowRetailSale() 'show retails sale'
                    calculate_netamount() 'this for calculate net amount'

                Else
                    MessageBox.Show("Item is not Selected")
                End If
            End If




        End If
    End Sub

    Private Sub RetailDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RetailDataGridView.CellClick

        Dim b As Integer = RetailDataGridView.CurrentRow.Index
        invid = RetailDataGridView.Rows(b).Cells(8).Value 'id'
        itemid = RetailDataGridView.Rows(b).Cells(13).Value 'itemid'
        BarCodeTxt.Text = RetailDataGridView.Rows(b).Cells(0).Value.ToString 'barcode'
        DesTxt.Text = RetailDataGridView.Rows(b).Cells(1).Value.ToString 'des'

        QutTextBox.Text = RetailDataGridView.Rows(b).Cells(2).Value.ToString 'qty'
        Unit_PriceTextBox.Text = RetailDataGridView.Rows(b).Cells(3).Value.ToString 'unit_price'
        DiscountTextBox.Text = RetailDataGridView.Rows(b).Cells(5).Value.ToString 'discount'
        expireDate = Format(Me.RetailDataGridView.Rows(b).Cells(6).Value, "yyyy-MM-dd") 'expiredate'
        AmountTextBox.Text = RetailDataGridView.Rows(b).Cells(7).Value.ToString 'amount'
        isdelete = 1
        CmPrice = RetailDataGridView.Rows(b).Cells(4).Value 'cus_price'


    End Sub

    Private Sub InvSaveBtn_Click(sender As Object, e As EventArgs) Handles InvSaveBtn.Click
        addtothrselling()
        ShowRetailSale() 'show retails sale'
        clear_text()
        calculate_netamount() 'this for calculate net amount'
        change_InvNo()
        load_invoice()
    End Sub

    Private Sub load_invoice() 'This for the load invoice'
        Dim cryRpt As New RetailDesign
        cryRpt.Refresh()
        cryRpt.RecordSelectionFormula = "{selling_view1.sid} = " & sid & ""
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub


    'This for the profit tbl'
    Private Sub addtoProfitTbl()
        Dim isinsystem As Integer = 0
        Dim poldqty As Integer
        Dim Query As String
        Dim discountno As Double = 0
        If DiscountTextBox.Text <> "" Then
            discountno = DiscountTextBox.Text
        End If
        Dim pbillingDate As String = Format(Me.TimePicker1.Value, "yyyy-MM-dd")
        Dim unit_price As Double = Unit_PriceTextBox.Text * (100 - discountno) / 100

        For q As Integer = 0 To RetailDataGridView.Rows.Count - 1 Step +1
            If itemid = RetailDataGridView.Rows(q).Cells(13).Value Then 'Check for the item id'
                poldqty = RetailDataGridView.Rows(q).Cells(2).Value
                isinsystem = 1
            End If
        Next
        If ballance_pro_check = True Then
            Try
                MySqlConn.Open()
                Query = "INSERT INTO `daily_proft_tbl` (`id`,`Inv_no`,`itemid`, `barcode`, `des`, `cost`, `qty`, `selling_price`, `cm_price`, `sel_date`) VALUES (NULL,'" & InvLbl.Text & "','" & 0 & "', '" & BarCodeTxt.Text & "', '" & DesTxt.Text & "', '" & bcost & "', '" & QutTextBox.Text & "', '" & unit_price & "', '" & bcm_price & "', '" & pbillingDate & "');"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try
        Else
            If isinsystem = 1 Then
                Dim pqty As Integer = poldqty + QutTextBox.Text

                Try
                    MySqlConn.Open()
                    Query = "UPDATE `daily_proft_tbl` SET `qty` = '" & pqty & "', `selling_price` = '" & unit_price & "' WHERE Inv_no = '" & InvLbl.Text & "' AND itemid = '" & itemid & "'; "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try
                isinsystem = 0
            ElseIf isinsystem = 0 Then

                Try
                    MySqlConn.Open()
                    Query = "INSERT INTO `daily_proft_tbl` (`id`,`Inv_no`,`itemid`, `barcode`, `des`, `cost`, `qty`, `selling_price`, `cm_price`, `sel_date`) VALUES (NULL,'" & InvLbl.Text & "','" & itemid & "', '" & BarCodeTxt.Text & "', '" & DesTxt.Text & "', '" & cost & "', '" & QutTextBox.Text & "', '" & unit_price & "', '" & CmPrice & "', '" & pbillingDate & "');"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MySqlConn.Close()
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If

    End Sub
    '-----------------------------------------------------------'

    Private Sub delete_from_profit_Tbl()
        Dim Query As String
        Try
            MySqlConn.Open()
            Query = "DELETE FROM `daily_proft_tbl` WHERE Inv_no = '" & InvLbl.Text & "' AND itemid = '" & itemid & "'; "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MySqlConn.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub



    Private Sub BarCodeTxt_TextChanged_1(sender As Object, e As EventArgs) Handles BarCodeTxt.TextChanged

        If BalanceGridView.Visible = True Then
            balance_product()
        Else
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view Where NOT stock = 0 order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("barcode Like '%{0}%'", BarCodeTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        End If





    End Sub
    Private Sub calculate_weight()
        Dim val As Double = 0
        Dim StringToCheck As String = BarCodeTxt.Text
        Dim num As Double = StringToCheck.Chars(3) & StringToCheck.Chars(4) & StringToCheck.Chars(5) & StringToCheck.Chars(6) & StringToCheck.Chars(7)
        val = num / 1000
        QutTextBox.Text = val
        DesTxt.Text = bdes
        BrandTxt.Text = bbrand
        Unit_PriceTextBox.Text = bretailPrice

    End Sub
    Dim bbarcode As String
    Dim bfulbarcode As String
    Dim bdes As String
    Dim bbrand As String
    Dim bcost As Double
    Dim bwhprice As Double
    Dim bretailPrice As Double
    Dim bcm_price As Double
    Dim bWeight As Double
    Dim bweight_kg As Double
    Dim bexpire As String

    Dim ballance_pro_check As Boolean = False 'This for the chech that product is a balance product'


    Private Function check_isblane_product()
        Dim a As Boolean = False
        conn.Open()
        Dim quer As String
        quer = "SELECT * FROM all_balance_product WHERE `barcode` = '" & bbarcode & "';"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            bfulbarcode = READER.GetString("barcode")
            bdes = READER.GetString("Des")
            bbrand = READER.GetString("brand")
            bcost = READER.GetString("cost")
            bwhprice = READER.GetString("wholesale")
            bretailPrice = READER.GetString("retail")
            bcm_price = READER.GetString("cm_price")
            bWeight = READER.GetString("weight")
            Dim dateaa As String = READER.GetString("expire_date")

            Dim myFormat = "yyyy-MM-dd"

            Dim myTime = Format(CDate(dateaa), myFormat) 'This for the String Dateforma Change'
            bexpire = myTime
            ballance_pro_check = True

            a = True

        End While
        conn.Close()
        Return a
    End Function

    Private Sub balnce_pro_ad_to_Bill()
        Dim qty As Double = QutTextBox.Text
        Dim isok As Boolean = False
        Dim weight As Double
        Dim new_weight As Double
        Dim billdate As String = Format(Me.TimePicker1.Value, "yyyy-MM-dd hh:mm:ss") 'This for the billing Date
        Dim discountno As Double = 0 'Discount'
        'Get Te Blanace Product Weight----------------'
        conn.Open()
        Dim quer As String
        quer = "SELECT `weight` FROM all_balance_product WHERE `barcode` = '" & bbarcode & "';"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            weight = READER.GetString("weight")
        End While
        conn.Close()
        If weight >= qty Then

            new_weight = weight - qty
            Dim cost As Double = qty * bcost
            Dim total As Double = AmountTextBox.Text
            If DiscountTextBox.Text <> "" Then

                Dim Discount As Double = DiscountTextBox.Text
                total -= Discount

                If total >= cost Then
                    isok = True
                Else
                    MessageBox.Show("Cann't Give that much Discount Because is under Cost")
                End If
            Else
                If total >= cost Then
                    isok = True
                Else
                    MessageBox.Show("Price Under Cost")
                End If
            End If
        Else
            MessageBox.Show("Product Weight Under the Toal Weight")
        End If
        'Balance product Wegiht Change'
        If isok = True Then
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "UPDATE `all_balance_product` SET `weight` = '" & new_weight & "' WHERE `all_balance_product`.`barcode` = '" & bbarcode & "'; "
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try
            Dim itid As Integer = 0

            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "INSERT INTO `selling_temp_2` (`id`, `Invno`, `billing_date`, `Customer_id`, `CusName`, `itemid`, `barcode`, `des`, `qty`, `unit_price`, `cus_price`, `discount`, `amount`, `expire_date`) VALUES (NULL, '" & InvLbl.Text & "', '" & billdate & "', '" & customerid & "', '" & CNameTxt.Text & "', '" & itid & "', '" & BarCodeTxt.Text & "', '" & DesTxt.Text & "', '" & QutTextBox.Text & "', '" & Unit_PriceTextBox.Text & "', '" & bcm_price & "', '" & discountno & "', '" & AmountTextBox.Text & "', '" & bexpire & "');"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MySqlConn.Close()
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("Error In Product Weight Check")
        End If
        addtoProfitTbl()
    End Sub

    Private Sub balance_product()
        conn.Open()
        '`barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight` FROM all_balance_product order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("barcode Like '%{0}%'", BarCodeTxt.Text)
        BalanceGridView.DataSource = dv
        BalanceGridView.Columns(0).Width = 140
        BalanceGridView.Columns(1).Width = 420
        BalanceGridView.Columns(2).Width = 110
        'BalanceGridView.Columns(3).Visible = False 'cost visible'
        BalanceGridView.Columns(4).Width = 100


        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub BarCodeTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles BarCodeTxt.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Up Then
            ItemsShow.Select()
        End If
        If e.KeyCode = Keys.Down Then
            ItemsShow.Select()
        End If
        If e.KeyCode = Keys.Enter Then
            If BarCodeTxt.Text <> "" Then

                Dim StringToCheck As String = BarCodeTxt.Text
                If StringToCheck.Length() = 8 Then
                    'Press Enter Then Work is Easy'
                    If Char.IsLetter(StringToCheck.Chars(0)) Then
                        If StringToCheck.Length() > 2 Then

                            bbarcode = StringToCheck.Chars(0) & StringToCheck.Chars(1) & StringToCheck.Chars(2)
                            If check_isblane_product() = True Then
                                'MessageBox.Show("Return Working")
                                calculate_weight()
                            End If
                        End If
                        ''check_isblane_product()
                    End If
                    QutTextBox.Select()
                Else

                    Dim s As Integer = 0

                    itemid = ItemsShow.Rows(s).Cells(8).Value
                    Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
                    Dim des As String = ItemsShow.Rows(s).Cells(1).Value
                    If BillTypeCombo.Text = "W" Then
                        Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(3).Value 'wholeSale'
                    Else
                        Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'
                    End If

                    CmPrice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'

                    stock = ItemsShow.Rows(s).Cells(5).Value 'stock'

                    expireDate = Format(Me.ItemsShow.Rows(s).Cells(7).Value, "yyyy-MM-dd") 'expiredate'
                    cost = ItemsShow.Rows(s).Cells(2).Value 'cost'

                    BarCodeTxt.Text = itmcode
                    DesTxt.Text = des
                    isdelete = 0

                    QutTextBox.Select()

                End If
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            SaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F2 Then
            InvSaveBtn.PerformClick()
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            BalanceGridView.Visible = True
        End If
        If e.KeyCode = Keys.F5 Then
            BalanceGridView.Visible = False
        End If
    End Sub

    Private Sub BarCodeTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BarCodeTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        Else
            If Panel1.Visible Then
                Panel1.Visible = True
            Else
                Panel1.Visible = True

            End If

        End If

    End Sub


    Private Sub BrandTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BrandTxt.KeyPress
        If BarCodeTxt.Text = "" And DesTxt.Text = "" Then
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view Where NOT stock = 0 order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Brand Like '%{0}%'", BrandTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        ElseIf BarCodeTxt.Text <> "" And DesTxt.Text = "" Then
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view where barcode like '%" & BarCodeTxt.Text & "%' AND NOT stock = 0  order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Brand Like '%{0}%'", BrandTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        Else
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id,Brand FROM all_items_view where barcode like '%" & BarCodeTxt.Text & "%' OR Des like '%" & DesTxt.Text & "%' AND NOT stock = 0  order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Brand Like '%{0}%'", BrandTxt.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'

        End If



    End Sub

    Private Sub BillTypeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BillTypeCombo.SelectedIndexChanged

    End Sub
End Class