Imports MySql.Data.MySqlClient
Public Class PurchaseReturn
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Dim loadid As Integer
    Dim itemid As Integer
    Dim suplierid As Integer
    Dim oldqty As Integer
    Dim puritem_id As Integer 'purchase item table id
    Dim oldamt As Double
    Private Sub loaddateudingInv() 'This for the load date add Fildes'
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view`", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ShowPurchaseGideView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Invno Like '%{0}%'", InvTxt.Text)
        ShowPurchaseGideView.DataSource = dv
        ShowPurchaseGideView.Columns(0).Width = 150
        ShowPurchaseGideView.Columns(1).Visible = False 'Supplier_id
        ShowPurchaseGideView.Columns(2).Width = 450
        ShowPurchaseGideView.Columns(3).Width = 90
        ShowPurchaseGideView.Columns(4).Visible = False 'itemid'
        ShowPurchaseGideView.Columns(5).Width = 150
        ShowPurchaseGideView.Columns(6).Width = 150

        ShowPurchaseGideView.Columns(7).Visible = False
        ShowPurchaseGideView.Columns(8).Visible = False
        ShowPurchaseGideView.Columns(9).Visible = False
        ShowPurchaseGideView.Columns(10).Visible = False
        conn.Close()
        '----------------'
    End Sub

    Private Sub loaddateidingpid() 'load data using id
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`itemid`,`barcode`,`des`,`qty`,`unit_price`,`cus_price`,`discount`,`amount`,`expire_date`,`pid`,`Invno`,`billing_date`,`Supplier_id`,`SupName`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view` WHERE pid = " & loadid, conn)
        adapter.Fill(table)
        bsource.DataSource = table
        DataGridView1.DataSource = table

        DataGridView1.Columns(0).Visible = False 'id'
        DataGridView1.Columns(1).Visible = False 'itemid'
        DataGridView1.Columns(2).Width = 150 'barcode'
        DataGridView1.Columns(3).Width = 150 'des'
        DataGridView1.Columns(4).Width = 150 'qty'
        DataGridView1.Columns(5).Width = 150 'unit_price'
        DataGridView1.Columns(6).Width = 150 'cus_price'
        DataGridView1.Columns(7).Width = 150 'discount'
        DataGridView1.Columns(8).Width = 150 'amount'
        DataGridView1.Columns(9).Width = 150 'expire_date'

        DataGridView1.Columns(10).Visible = False 'pid
        DataGridView1.Columns(11).Visible = False 'Invno
        DataGridView1.Columns(12).Visible = False 'billing_date'
        DataGridView1.Columns(13).Visible = False 'Supplier_id'
        DataGridView1.Columns(14).Visible = False 'SupName'
        DataGridView1.Columns(15).Visible = False 'netAmount'
        DataGridView1.Columns(16).Visible = False 'netdiscount'
        DataGridView1.Columns(17).Visible = False 'NetDisAmount'
        DataGridView1.Columns(18).Visible = False 'GrandTotal'

        conn.Close()
        '----------------'
    End Sub

    Private Sub InvTxt_TextChanged(sender As Object, e As EventArgs) Handles InvTxt.TextChanged
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view`", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ShowPurchaseGideView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Invno Like '%{0}%'", InvTxt.Text)
        ShowPurchaseGideView.DataSource = dv

        conn.Close()
        '----------------'
    End Sub

    Private Sub PurchaseReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddateudingInv()
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub CNameTxt_TextChanged(sender As Object, e As EventArgs) Handles CNameTxt.TextChanged
        If InvTxt.Text = "" Then
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ShowPurchaseGideView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("SupName Like '%{0}%'", CNameTxt.Text)
            ShowPurchaseGideView.DataSource = dv

            conn.Close()
            '----------------'
        Else
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ShowPurchaseGideView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("SupName Like '%{0}%'", CNameTxt.Text)
            ShowPurchaseGideView.DataSource = dv

            conn.Close()
            '----------------'
        End If
    End Sub

    Private Sub DescriptionTxt_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTxt.TextChanged
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal` FROM `purchase_view`", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ShowPurchaseGideView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("SupName Like '%{0}%'", CNameTxt.Text)
        ShowPurchaseGideView.DataSource = dv

        conn.Close()
        '----------------'
    End Sub

    Private Sub InvTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InvTxt.KeyPress
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

    Private Sub CNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CNameTxt.KeyPress
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

    Private Sub DescriptionTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescriptionTxt.KeyPress
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

    Private Sub ShowPurchaseGideView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowPurchaseGideView.CellContentClick

    End Sub

    Private Sub ShowPurchaseGideView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowPurchaseGideView.CellClick
        '`Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`
        Dim s As Integer = ShowPurchaseGideView.CurrentRow.Index
        loadid = ShowPurchaseGideView.Rows(s).Cells(7).Value 'pid'
        loaddateidingpid()
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
        '`Invno`,`Supplier_id`,`SupName`,`billing_date`,`itemid`,`barcode`,`des`,`pid`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal`
        suplierid = ShowPurchaseGideView.Rows(s).Cells(1).Value 'Supplier_id'


        NetAmountTxt.Text = ShowPurchaseGideView.Rows(s).Cells(8).Value 'Net_amount
        NetDiscountTxt.Text = ShowPurchaseGideView.Rows(s).Cells(9).Value 'NetDiscount
        NetDiscountAmountTxt.Text = ShowPurchaseGideView.Rows(s).Cells(10).Value 'discountAmount'
        GrandTotalTxt.Text = ShowPurchaseGideView.Rows(s).Cells(11).Value 'grand_toal'
        InvTxt.Text = ShowPurchaseGideView.Rows(s).Cells(0).Value 'Invno'
        CNameTxt.Text = ShowPurchaseGideView.Rows(0).Cells(2).Value 'SupName'
        SaleDateTime.Value = Format(Me.ShowPurchaseGideView.Rows(0).Cells(3).Value, "yyyy-MM-dd") 'billing_date'
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim Query As String
        If IT_CodeTextBox.Text <> "" Then
            If QutTextBox.Text <> "" Then
                If QutTextBox.Text > oldqty Then
                    MessageBox.Show("Your Entered Qty Error")
                Else
                    If changeStock() = True Then
                        Dim netamt As Double = NetAmountTxt.Text
                        Dim amount As Double = AmountTextBox.Text
                        Dim discount As Double = NetDiscountTxt.Text
                        Dim grandtot As Double

                        netamt = netamt - amount
                        grandtot = netamt * (100 - discount) / 100
                        NetDiscountAmountTxt.Text = netamt / 100 * discount
                        NetAmountTxt.Text = netamt 'update netamountTxt'
                        GrandTotalTxt.Text = grandtot 'update grand Toal Txt'
                        If oldqty = QutTextBox.Text Then

                            MySqlConn.Open()
                            Query = "DELETE FROM `purchase_items` WHERE `id` = '" & puritem_id & "'"
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()


                            MySqlConn.Open()
                            Query = "Update `purchase` Set `netAmount` = '" & netamt & "', `GrandTotal` = '" & grandtot & "' WHERE (`pid` = '" & loadid & "');"
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()
                            clearTxt()
                            MessageBox.Show("Product Return Sucess")
                            loaddateidingpid()
                        Else
                            Dim nqty As Integer = oldqty - QutTextBox.Text
                            Dim namt As Double = oldamt - AmountTextBox.Text
                            MySqlConn.Open()
                            Query = "UPDATE `purchase_items` SET `qty` = '" & nqty & "', `amount` = '" & namt & "' WHERE `id` = '" & puritem_id & "'"
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()


                            MySqlConn.Open()
                            Query = "Update `purchase` Set `netAmount` = '" & netamt & "', `GrandTotal` = '" & grandtot & "' WHERE (`pid` = '" & loadid & "');"
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()
                            clearTxt()
                            MessageBox.Show("Product Return Sucess")
                            loaddateidingpid()
                        End If
                    Else
                        MessageBox.Show("Error Return Product")
                    End If
                End If

            Else
                MessageBox.Show("Please Enter the return Qty")
            End If
        Else
            MessageBox.Show("please Select the item")
        End If


    End Sub
    Private Sub clearTxt()
        IT_CodeTextBox.Clear()
        DescriptionTxt.Clear()
        QutTextBox.Clear()
        Unit_PriceTextBox.Clear()
        DiscountTextBox.Clear()
        AmountTextBox.Clear()
    End Sub
    Private Function changeStock()
        Dim Query As String
        Dim stock As Integer
        Dim qty As Integer = QutTextBox.Text
        conn.Open()
        Dim quer As String
        quer = "SELECT * FROM `all_items_view` WHERE `id` = " & itemid
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            stock = READER.GetString("stock")
        End While
        conn.Close()
        Try
            Dim nstock As Integer = stock - qty
            MySqlConn.Open()
            Query = "UPDATE `all_items_sptbl` SET `stock` = '" & nstock & "' WHERE `id` = '" & itemid & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try



    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim s As Integer = DataGridView1.CurrentRow.Index
        '`id`,`itemid`,`barcode`,`des`,`qty`,`unit_price`,`cus_price`,`discount`,`amount`,`expire_date`,`pid`,`Invno`,`billing_date`,`Supplier_id`,`SupName`,`netAmount`,`netdiscount`,
        puritem_id = DataGridView1.Rows(s).Cells(0).Value 'id'
        itemid = DataGridView1.Rows(s).Cells(1).Value 'itemid
        IT_CodeTextBox.Text = DataGridView1.Rows(s).Cells(2).Value 'barcode
        DesTxt.Text = DataGridView1.Rows(s).Cells(3).Value 'des
        QutTextBox.Text = DataGridView1.Rows(s).Cells(4).Value 'qty
        Unit_PriceTextBox.Text = DataGridView1.Rows(s).Cells(5).Value 'unit_price
        'itemid = DataGridView1.Rows(s).Cells(6).Value 'cus_price
        DiscountTextBox.Text = DataGridView1.Rows(s).Cells(7).Value 'discount
        AmountTextBox.Text = DataGridView1.Rows(s).Cells(8).Value 'amount
        'itemid = DataGridView1.Rows(s).Cells(9).Value 'expire_date
        oldqty = DataGridView1.Rows(s).Cells(4).Value 'qty'
        oldamt = DataGridView1.Rows(s).Cells(8).Value 'amount
    End Sub

    Private Sub InvTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles InvTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            ShowPurchaseGideView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            ShowPurchaseGideView.Select()
        End If
    End Sub

    Private Sub CNameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles CNameTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            ShowPurchaseGideView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            ShowPurchaseGideView.Select()
        End If
    End Sub

    Private Sub DescriptionTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles DescriptionTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            ShowPurchaseGideView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            ShowPurchaseGideView.Select()
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

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged
        If QutTextBox.Text = "" Then
        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                If DiscountTextBox.Text = "" Then
                    AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text
                Else
                    Dim dis As Integer
                    AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text
                    dis = 100 - DiscountTextBox.Text
                    AmountTextBox.Text = (AmountTextBox.Text / 100)
                    AmountTextBox.Text = AmountTextBox.Text * dis

                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class