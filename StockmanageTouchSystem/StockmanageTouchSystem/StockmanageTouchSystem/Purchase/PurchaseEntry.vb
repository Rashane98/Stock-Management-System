Imports MySql.Data.MySqlClient
Public Class PurchaseEntry
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim stockqty As Double
    Dim quty As Double
    Dim suplierid As Integer
    Dim stock As Integer

    'This for the auto stock Add System'
    Dim cost As Double
    Dim whprice As Double
    Dim Retailprice As Double
    Dim cmprice As Double
    Dim expireDate As String

    'this for the check that record is same to old record'
    Dim chekrecord As Integer
    Dim itemid As Integer 'This for the get itemid for update cost unitprice

    'This for the item delete'
    Dim delitemid As Integer
    Dim purchid As Integer
    'End of the itm delete'


    Private Sub PurchEntLoad() 'This is forthe perchaseing Entry Load'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select barcode,des,qty,unit_price,cus_price,discount,expire_date,amount,id,Invno,billing_date,Supplier_id,SupName,itemid from purchase_temp", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        PurchGrideView.DataSource = table
        PurchGrideView.Columns(0).Width = 150 'barcode'
        PurchGrideView.Columns(1).Width = 250 'des'
        PurchGrideView.Columns(2).Width = 90 'qty'
        PurchGrideView.Columns(3).Width = 150 'unit_price'
        PurchGrideView.Columns(4).Width = 150 'cus_price'
        PurchGrideView.Columns(5).Width = 150 'discount'
        PurchGrideView.Columns(6).Width = 150 'expire_date'
        PurchGrideView.Columns(7).Width = 150 'amount'

        PurchGrideView.Columns(8).Visible = False 'id'
        PurchGrideView.Columns(9).Visible = False 'Invno'
        PurchGrideView.Columns(10).Visible = False 'billing_date'
        PurchGrideView.Columns(11).Visible = False 'Supplier_id'
        PurchGrideView.Columns(12).Visible = False 'SupName'
        PurchGrideView.Columns(13).Visible = False 'itemid'
        conn.Close()
    End Sub
    Private Sub SupplicerShow()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select id,Name from supplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        SupplicerGrideView.DataSource = table
        SupplicerGrideView.Columns(0).Visible = False
        'SupplicerGrideView.Columns(0).Width = 450
        conn.Close()

    End Sub
    Private Sub creditSeach() 'This for the credit search for supplier'
        conn.Open()
        Dim creditamt As Double
        Dim quer As String
        quer = "select Supplier_id,Amount from supplier_credit  WHERE Supplier_id = '" & suplierid & "'"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            Dim amt = READER.GetString("Amount")
            creditamt = creditamt + amt
        End While
        creditAmtTxt.Text = creditamt

        conn.Close()
    End Sub
    Private Sub PurchaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchEntLoad()
        SupplicerShow()
        load_data() 'This for the product Load'

        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
        If Panel2.Visible Then
            Panel2.Visible = False
        Else
            Panel2.Visible = False
        End If
        Me.TextBox4.Text = Format(Me.TimePicker1.Value, "yyyy-MM-dd hh:mm:ss")
        Dim check As Integer = PurchGrideView.Rows.Count - 1
        If check >= 0 Then
            InvNoTxt.Text = PurchGrideView.Rows(check).Cells(9).Value.ToString
            suplierid = PurchGrideView.Rows(check).Cells(11).Value.ToString
            SupplierNameTxt.Text = PurchGrideView.Rows(check).Cells(12).Value.ToString

            Dim netsum As Double = 0

            For j As Integer = 0 To PurchGrideView.Rows.Count() - 1 Step +1
                netsum = netsum + PurchGrideView.Rows(j).Cells(7).Value
            Next
            NetamountTxt.Text = netsum.ToString()

            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        creditSeach() 'This for the credit search for supplier'
    End Sub

    Private Sub suplierliad()
        conn.Open()
        Dim quer As String
        quer = "select id,Name from supplier"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            Dim sName = READER.GetString("Name")
            SupplierNameTxt.Text = sName
        End While
        conn.Close()
    End Sub
    Private Sub get_netamount() 'This for the get net amount 
        Dim netsum As Double = 0

        For j As Integer = 0 To PurchGrideView.Rows.Count() - 1 Step +1
            netsum = netsum + PurchGrideView.Rows(j).Cells(7).Value
        Next
        NetamountTxt.Text = netsum.ToString
    End Sub

    Private Sub SupplierNameTxt_TextChanged(sender As Object, e As EventArgs) Handles SupplierNameTxt.TextChanged
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select id,Name from supplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        SupplicerGrideView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", SupplierNameTxt.Text)
        SupplicerGrideView.DataSource = dv

        conn.Close()

        If Panel1.Visible Then
            Panel1.Visible = True
        Else
            Panel1.Visible = True
        End If
    End Sub


    Private Sub InvNoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles InvNoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SupplierNameTxt.Select()

        End If
    End Sub
    Private Sub SupplierNameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierNameTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            SupplicerGrideView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            SupplicerGrideView.Select()
        End If
        If e.KeyCode = Keys.Escape Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub SupplicerGrideView_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplicerGrideView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim a As Integer = SupplicerGrideView.CurrentRow.Index
            suplierid = SupplicerGrideView.Rows(a).Cells(0).Value.ToString
            SupplierNameTxt.Text = SupplicerGrideView.Rows(a).Cells(1).Value.ToString
            creditSeach() 'This for the credit'
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            IT_CodeTextBox.Select()

        End If
    End Sub


    'This part for the new product Add load'
    Private Sub load_data()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id FROM all_items_view order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ItemsShow.DataSource = table
        ItemsShow.Columns(0).Width = 140
        ItemsShow.Columns(1).Width = 420
        ItemsShow.Columns(2).Width = 110 'cost'
        ItemsShow.Columns(3).Width = 100
        ItemsShow.Columns(4).Width = 100
        ItemsShow.Columns(5).Width = 100 'stock'

        ItemsShow.Columns(8).Visible = False 'id visible'

        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub

    Private Sub IT_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles IT_CodeTextBox.TextChanged

        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id FROM all_items_view order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ItemsShow.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("barcode Like '%{0}%'", IT_CodeTextBox.Text)
        ItemsShow.DataSource = dv
        conn.Close()
        '----------------'
    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged
        If IT_CodeTextBox.Text = "" Then
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id FROM all_items_view order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", DescriptionTextBox.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        Else
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id FROM all_items_view where barcode like '%" & IT_CodeTextBox.Text & "%'  order by barcode;", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ItemsShow.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Des Like '%{0}%'", DescriptionTextBox.Text)
            ItemsShow.DataSource = dv
            conn.Close()
            '----------------'
        End If
    End Sub

    Private Sub IT_CodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IT_CodeTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
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

            Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
            Dim des As String = ItemsShow.Rows(s).Cells(1).Value

            Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value 'cost'
            WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'

            stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
            CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            ExpireDateTimePicker.Value = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
            whprice = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            Retailprice = ItemsShow.Rows(s).Cells(4).Value 'rprice'
            cmprice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            expireDate = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            itemid = ItemsShow.Rows(s).Cells(8).Value

            IT_CodeTextBox.Text = itmcode
            DescriptionTextBox.Text = des

            Unit_PriceTextBox.Select()
        End If
    End Sub

    Private Sub IT_CodeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IT_CodeTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
        Else
            If Panel2.Visible Then
                Panel2.Visible = True
            Else
                Panel2.Visible = True

            End If
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If

        End If
    End Sub

    Private Sub DescriptionTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DescriptionTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
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

            Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
            Dim des As String = ItemsShow.Rows(s).Cells(1).Value

            Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value 'cost'
            WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'

            stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
            CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            ExpireDateTimePicker.Value = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
            whprice = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            Retailprice = ItemsShow.Rows(s).Cells(4).Value 'rprice'
            cmprice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            expireDate = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            itemid = ItemsShow.Rows(s).Cells(8).Value

            IT_CodeTextBox.Text = itmcode
            DescriptionTextBox.Text = des

            Unit_PriceTextBox.Select()
        End If
    End Sub

    Private Sub DescriptionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescriptionTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
        Else
            If Panel2.Visible Then
                Panel2.Visible = True
            Else
                Panel2.Visible = True

            End If
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If

        End If
    End Sub

    Private Sub ItemsShow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsShow.CellContentClick
        'barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id

        Dim s As Integer = ItemsShow.CurrentRow.Index

        Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
        Dim des As String = ItemsShow.Rows(s).Cells(1).Value

        Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value 'cost'
        WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
        RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'

        stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
        CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
        ExpireDateTimePicker.Value = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

        cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
        whprice = ItemsShow.Rows(s).Cells(3).Value 'whprice'
        Retailprice = ItemsShow.Rows(s).Cells(4).Value 'rprice'
        cmprice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
        expireDate = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

        itemid = ItemsShow.Rows(s).Cells(8).Value

        IT_CodeTextBox.Text = itmcode
        DescriptionTextBox.Text = des

        Unit_PriceTextBox.Select()
    End Sub
    Private Sub ItemsShow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsShow.CellClick
        'barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id

        Dim s As Integer = ItemsShow.CurrentRow.Index

        Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
        Dim des As String = ItemsShow.Rows(s).Cells(1).Value

        Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value 'cost'
        WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
        RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'

        stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
        CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
        ExpireDateTimePicker.Value = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

        cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
        whprice = ItemsShow.Rows(s).Cells(3).Value 'whprice'
        Retailprice = ItemsShow.Rows(s).Cells(4).Value 'rprice'
        cmprice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
        expireDate = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

        itemid = ItemsShow.Rows(s).Cells(8).Value

        IT_CodeTextBox.Text = itmcode
        DescriptionTextBox.Text = des

        Unit_PriceTextBox.Select()
    End Sub

    Private Sub ItemsShow_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemsShow.KeyDown
        If e.KeyCode = Keys.Enter Then
            'barcode,Des,cost,whprice,rprice,stock,CMshowprice,ExpireDate,id

            Dim s As Integer = ItemsShow.CurrentRow.Index

            Dim itmcode As String = ItemsShow.Rows(s).Cells(0).Value
            Dim des As String = ItemsShow.Rows(s).Cells(1).Value

            Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value 'cost'
            WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value 'rprice'

            stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
            CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            ExpireDateTimePicker.Value = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            cost = ItemsShow.Rows(s).Cells(2).Value 'cost'
            whprice = ItemsShow.Rows(s).Cells(3).Value 'whprice'
            Retailprice = ItemsShow.Rows(s).Cells(4).Value 'rprice'
            cmprice = ItemsShow.Rows(s).Cells(6).Value 'cmprice'
            expireDate = ItemsShow.Rows(s).Cells(7).Value 'expiredate'

            itemid = ItemsShow.Rows(s).Cells(8).Value

            IT_CodeTextBox.Text = itmcode
            DescriptionTextBox.Text = des

            Unit_PriceTextBox.Select()
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
            QutTextBox.Select()
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

    Private Sub QutTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QutTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            WsalePriceTxt.Select()
        End If
    End Sub

    Private Sub WsalePriceTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles WsalePriceTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetailPriceTxt.Select()
        End If
    End Sub
    Private Sub RetailPriceTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles RetailPriceTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMPriceTxt.Select()
        End If
    End Sub

    Private Sub CMPriceTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles CMPriceTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExpireDateTimePicker.Select()
        End If
    End Sub

    Private Sub ExpireDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles ExpireDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
            NextBtn.PerformClick()

        End If
    End Sub
    'This for the clear textboxs'
    Private Sub clear_text()
        IT_CodeTextBox.Clear()
        DescriptionTextBox.Clear()
        Unit_PriceTextBox.Clear()
        QutTextBox.Clear()
        AmountTextBox.Clear()
        WsalePriceTxt.Clear()
        RetailPriceTxt.Clear()
        CMPriceTxt.Clear()

        IT_CodeTextBox.Select()

    End Sub
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click

        Dim isin As Integer = 0
        Dim Query As String


        If IT_CodeTextBox.Text = "" Then
                MessageBox.Show("Plese Enter BarCode")
            Else
                If DescriptionTextBox.Text = "" Then
                    MessageBox.Show("Plese Enter Description")
                Else
                    If QutTextBox.Text = "" Then
                        MessageBox.Show("Plese Enter Quantity")
                    Else
                        If Unit_PriceTextBox.Text = "" Then
                            MessageBox.Show("Plese Enter Cost")
                        Else
                            If QutTextBox.Text = "" Then
                                MessageBox.Show("Plese Enter Quantity")
                            Else
                                If WsalePriceTxt.Text = "" Then
                                    MessageBox.Show("Plese Enter Wholesale Price")
                                Else
                                    If RetailPriceTxt.Text = "" Then
                                        MessageBox.Show("Plese Enter Retail Price")
                                    Else
                                        If CMPriceTxt.Text = "" Then
                                            MessageBox.Show("Plese Enter Customer Show Price")
                                        Else
                                            Dim barcode As String = IT_CodeTextBox.Text.Trim()
                                            Dim des As String = DescriptionTextBox.Text.Trim()

                                            Dim clean As String

                                            clean = barcode.Replace("'", " ")
                                            barcode = clean
                                            clean = des.Replace("'", " ")
                                            des = clean
                                            Dim oldqty As Integer
                                            Dim nexpiredate = Format(Me.ExpireDateTimePicker.Value, "yyyy-MM-dd")

                                            For q As Integer = 0 To PurchGrideView.Rows.Count - 1 Step +1
                                                If barcode = PurchGrideView.Rows(q).Cells(0).Value And Unit_PriceTextBox.Text = PurchGrideView.Rows(q).Cells(3).Value Then
                                                    isin = 1
                                                    oldqty = PurchGrideView.Rows(q).Cells(2).Value
                                                End If
                                            Next
                                            Dim astk As Integer = QutTextBox.Text

                                            If isin = 1 Then 'That item in the system'
                                            astk = astk + oldqty
                                            Dim amt As Double = astk * Unit_PriceTextBox.Text 'part for the new amount'
                                            Try 'That item allread in the system'
                                                    MySqlConn.Open()
                                                    Query = "UPDATE `purchase_temp` SET `qty` = '" & astk & "', `unit_price` = '" & Unit_PriceTextBox.Text & "', `cus_price` = '" & CMPriceTxt.Text & "', `amount` = '" & amt & "', `expire_date` = '" & nexpiredate & "' WHERE barcode = '" & barcode & "'; "
                                                    COMMAND = New MySqlCommand(Query, MySqlConn)
                                                    READER = COMMAND.ExecuteReader
                                                    MySqlConn.Close()
                                                Catch ex As Exception
                                                    MessageBox.Show(ex.Message)
                                                    MySqlConn.Close()
                                                End Try
                                            ElseIf isin = 0 Then 'not in system'
                                                Try 'Add new record'
                                                    MySqlConn.Open()
                                                    Query = "INSERT INTO `purchase_temp` (`id`, `Invno`, `billing_date`, `Supplier_id`, `SupName`, `itemid`, `barcode`, `des`, `qty`, `unit_price`, `cus_price`, `discount`, `amount`, `expire_date`) VALUES (NULL, '" & InvNoTxt.Text & "', '" & TextBox4.Text & "', '" & suplierid & "', '" & SupplierNameTxt.Text & "', '" & itemid & "', '" & barcode & "', '" & des & "', '" & QutTextBox.Text & "', '" & Unit_PriceTextBox.Text & "', '" & CMPriceTxt.Text & "', '0', '" & AmountTextBox.Text & "', '" & nexpiredate & "');"
                                                    COMMAND = New MySqlCommand(Query, MySqlConn)
                                                    READER = COMMAND.ExecuteReader
                                                    MySqlConn.Close()
                                                Catch ex As Exception
                                                    MessageBox.Show(ex.Message)
                                                    MySqlConn.Close()
                                                End Try
                                            End If

                                            check_item_inrecord() 'ren the record check fiunction'

                                            If chekrecord = 0 Then 'item not match old record'
                                                'Add new record'

                                                Try 'This for the price And cost Add'
                                                    MySqlConn.Open()
                                                    Query = "INSERT INTO `all_items_sptbl` (`id`, `all_items_barcode`, `cost`, `whprice`, `rprice`, `stock`, `ExpireDate`, `CMshowprice`) VALUES (NULL, '" & barcode & "', '" & Unit_PriceTextBox.Text & "', '" & WsalePriceTxt.Text & "', '" & RetailPriceTxt.Text & "', '" & QutTextBox.Text & "', '" & nexpiredate & "', '" & CMPriceTxt.Text & "');"
                                                    COMMAND = New MySqlCommand(Query, MySqlConn)
                                                    READER = COMMAND.ExecuteReader
                                                    MySqlConn.Close()
                                                Catch ex As Exception
                                                    MessageBox.Show(ex.Message)
                                                    MySqlConn.Close()
                                                End Try
                                            ElseIf chekrecord = 1 Then 'itm match the old record'
                                            'update that record stock'
                                            Dim nstock As Integer = QutTextBox.Text ''
                                            nstock = nstock + stock

                                            Try 'This for the price And cost Add'
                                                    MySqlConn.Open()
                                                    Query = "UPDATE `all_items_sptbl` SET `cost` = '" & Unit_PriceTextBox.Text & "', `whprice` = '" & WsalePriceTxt.Text & "', `rprice` = '" & RetailPriceTxt.Text & "', `ExpireDate` = '" & nexpiredate & "', `CMshowprice` = '" & CMPriceTxt.Text & "', `stock` = '" & nstock & "' WHERE `all_items_sptbl`.`id` = '" & itemid & "'; "

                                                    COMMAND = New MySqlCommand(Query, MySqlConn)
                                                    READER = COMMAND.ExecuteReader
                                                    MySqlConn.Close()
                                                Catch ex As Exception
                                                    MessageBox.Show(ex.Message)
                                                    MySqlConn.Close()
                                                End Try
                                            End If
                                            'load the new product tbl'
                                            load_data()
                                        PurchEntLoad() 'purchase Entry load'
                                        get_netamount()
                                        clear_text() 'clear the textboxs'

                                    End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

    End Sub
    'THis for the check that item in the old record'
    Private Sub check_item_inrecord()
        Dim rec As Integer = 0
        Dim val = Format(Me.ExpireDateTimePicker.Value, "yyyy-MM-dd")
        For s As Integer = 0 To ItemsShow.Rows.Count - 1 Step +1

            If ((Unit_PriceTextBox.Text = ItemsShow.Rows(s).Cells(2).Value) And (WsalePriceTxt.Text = ItemsShow.Rows(s).Cells(3).Value) And (RetailPriceTxt.Text = ItemsShow.Rows(s).Cells(4).Value) And (CMPriceTxt.Text = ItemsShow.Rows(s).Cells(6).Value) And (val = ItemsShow.Rows(s).Cells(7).Value)) Then
                rec = 1
                stock = ItemsShow.Rows(s).Cells(5).Value 'stock'
            End If
        Next
        chekrecord = rec 'check record values change'
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'This for the search that item stock'
            Dim dodstock As Integer
            Dim Query As String

            conn.Open()
            Query = "SELECT * FROM `all_items_sptbl` where id = '" & delitemid & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim stk = READER.GetString("stock")
                dodstock = stk
            End While
            conn.Close()
            'End-----------------------------------'
            If dodstock = QutTextBox.Text Then
                Try
                    MySqlConn.Open()
                    Query = "DELETE FROM `all_items_sptbl` WHERE `all_items_sptbl`.`id` = '" & delitemid & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    MySqlConn.Close()
                End Try
            Else
                Try
                    Dim bval As Integer = QutTextBox.Text
                    bval = dodstock - bval
                    MySqlConn.Open()
                    Query = "UPDATE `all_items_sptbl` SET `stock` = '" & bval & "' WHERE `all_items_sptbl`.`id` = '" & delitemid & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    MySqlConn.Close()
                End Try

            End If

            Try
                MySqlConn.Open()
                Query = "DELETE FROM `purchase_temp` WHERE `purchase_temp`.`id` = '" & purchid & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MySqlConn.Close()
            End Try


            'This for the id reset'
            purchid = 0
            delitemid = 0
            'End-----------------'
            load_data()
            PurchEntLoad()
            clear_text() 'clear the textboxs'
            get_netamount() 'net amount'
        End If
    End Sub

    Private Sub PurchGrideView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchGrideView.CellClick
        'barcode,des,qty,unit_price,cus_price,discount,expire_date,amount,id,Invno,billing_date,Supplier_id,SupName,itemid
        Dim s As Integer = PurchGrideView.CurrentRow.Index
        delitemid = PurchGrideView.Rows(s).Cells(13).Value
        IT_CodeTextBox.Text = PurchGrideView.Rows(s).Cells(0).Value
        DescriptionTextBox.Text = PurchGrideView.Rows(s).Cells(1).Value
        Unit_PriceTextBox.Text = PurchGrideView.Rows(s).Cells(3).Value
        QutTextBox.Text = PurchGrideView.Rows(s).Cells(2).Value
        AmountTextBox.Text = PurchGrideView.Rows(s).Cells(7).Value
        CMPriceTxt.Text = PurchGrideView.Rows(s).Cells(4).Value

        purchid = PurchGrideView.Rows(s).Cells(8).Value

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NetDiscountTxt.Text = "" Then
            MessageBox.Show("Please Enter Discount")
        Else
            Dim errorcode As String = 0
            Dim billingDate = Format(Me.TimePicker1.Value, "yyyy-MM-dd hh:mm:ss")
            Dim Supplier_id As String = PurchGrideView.Rows(0).Cells(11).Value
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "INSERT INTO `purchase` (`pid`, `Invno`, `billing_date`, `Supplier_id`, `SupName`, `netAmount`, `netdiscount`, `NetDisAmount`, `GrandTotal`) VALUES (NULL, '" & InvNoTxt.Text & "', '" & billingDate & "', '" & Supplier_id & "', '" & SupplierNameTxt.Text & "', '" & NetamountTxt.Text & "', '" & NetDiscountTxt.Text & "', '" & DiscountAmountTxt.Text & "', '" & GrandTotalTxt.Text & "');"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '---------------------------------------------------------------------'
            Dim purid As Integer
            conn.Open()
            Dim quer As String
            quer = "SELECT * FROM `purchase` WHERE `Invno` = '" & InvNoTxt.Text & "'; "
            COMMAND = New MySqlCommand(quer, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim pid = READER.GetString("pid")
                purid = pid
            End While
            conn.Close()
            '---------------------------------------------------------------------'
            'This for the produc Add
            For g As Integer = 0 To PurchGrideView.Rows.Count - 1 Step +1
                'barcode,des,qty,unit_price,cus_price,discount,expire_date,amount,id,Invno,billing_date,Supplier_id,SupName,itemid
                Dim proitemid As Integer = PurchGrideView.Rows(g).Cells(13).Value ''
                Dim barcode As String = PurchGrideView.Rows(g).Cells(0).Value 'barcode' 
                Dim des As String = PurchGrideView.Rows(g).Cells(1).Value 'des'
                Dim qty As String = PurchGrideView.Rows(g).Cells(2).Value 'qty'
                Dim unit_price As String = PurchGrideView.Rows(g).Cells(3).Value 'unit_price'
                Dim cus_price As String = PurchGrideView.Rows(g).Cells(4).Value 'cus_price'
                'Dim discount As String = PurchGrideView.Rows(g).Cells(5).Value 'discount'
                Dim amount As String = PurchGrideView.Rows(g).Cells(7).Value 'amount'
                Dim expire_date As String = Format(Me.PurchGrideView.Rows(g).Cells(6).Value, "yyyy-MM-dd")  'expire_date'

                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "INSERT INTO `purchase_items` (`id`, `Purchase_pid`,`itemid`, `barcode`, `des`, `qty`, `unit_price`, `cus_price`, `discount`, `amount`, `expire_date`) VALUES (NULL, '" & purid & "','" & proitemid & "', '" & barcode & "', '" & des & "', '" & qty & "', '" & unit_price & "', '" & cus_price & "', '0', '" & amount & "', '" & expire_date & "');"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    errorcode = 1
                    MessageBox.Show(ex.Message)
                End Try

            Next
            If errorcode = 1 Then
                MessageBox.Show("Purchase Add Error Please Check")
            Else
                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "delete from purchase_temp"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                NetamountTxt.Clear()
                NetDiscountTxt.Clear()
                DiscountAmountTxt.Clear()
                GrandTotalTxt.Clear()
                InvNoTxt.Clear()
                SupplierNameTxt.Clear()
                PurchEntLoad() 'purchase Entry load'
                clear_text()
            End If

        End If
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If


    End Sub

    Private Sub NetDiscountTxt_TextChanged(sender As Object, e As EventArgs) Handles NetDiscountTxt.TextChanged
        If NetamountTxt.Text <> "" Then
            If NetDiscountTxt.Text <> "" Then
                If NetDiscountTxt.Text = "0" Then
                    DiscountAmountTxt.Text = "0"
                    GrandTotalTxt.Text = NetamountTxt.Text
                Else
                    Dim mgsum As Double = NetamountTxt.Text
                    Dim disrate As Double = NetDiscountTxt.Text
                    Dim disAmt As Double
                    Dim fulltot As Double
                    disAmt = (mgsum / 100) * disrate
                    fulltot = (100 - disrate) * mgsum / 100

                    DiscountAmountTxt.Text = disAmt.ToString
                    GrandTotalTxt.Text = fulltot.ToString
                End If
            End If
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class