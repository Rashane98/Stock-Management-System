Imports MySql.Data.MySqlClient
Public Class RetailReturn
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim Tbl As New DataTable()

    Dim barcode As String
    Dim Invno As String
    Dim retuenDate As String
    Dim itemid As Integer
    Dim billid As Integer
    Dim sellItemTblPKID As Integer
    Dim sid As Integer 'Selling table PK'
    Dim oldnetamount As Double

    Private Sub ItemShowGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemShowGridView.CellClick
        '`Invno`,`id`,`barcode`,`des`,`qty`,`unit_price`,`cus_price`,`discount`,`amount`,`expire_date`
        ',`billing_date`,`Customer_id`,`CusName`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal`
        Dim s As Integer = ItemShowGridView.CurrentRow.Index
        Invno = ItemShowGridView.Rows(s).Cells(0).Value 'Invno'
        sellItemTblPKID = ItemShowGridView.Rows(s).Cells(1).Value 'id' selling table primary Key 
        barcode = ItemShowGridView.Rows(s).Cells(2).Value 'barcode'
        DesLbl.Text = ItemShowGridView.Rows(s).Cells(3).Value 'des'
        QtyPurchLbl.Text = ItemShowGridView.Rows(s).Cells(4).Value 'qty'
        UnitPriceLbl.Text = ItemShowGridView.Rows(s).Cells(5).Value 'unit_price'
        AmountLbl.Text = ItemShowGridView.Rows(s).Cells(8).Value 'amount'
        itemid = ItemShowGridView.Rows(s).Cells(17).Value 'itemid'
        sid = ItemShowGridView.Rows(s).Cells(18).Value 'sid'

        Bill_no_lbl.Text = sid.ToString

        oldnetamount = ItemShowGridView.Rows(s).Cells(13).Value 'netAmount'

    End Sub


    Private Sub RetailReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'
    End Sub

    Private Sub load_for_date()
        conn.Open()
        Dim Stadate As String
        Dim enddat As String
        enddat = Format(Me.EndDate.Value, "yyy-MM-dd")
        Stadate = Format(Me.StartDate.Value, "yyyy-MM-dd")

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `Invno`,`id`,`barcode`,`des`,`qty`,`unit_price`,`cus_price`,`discount`,`amount`,`expire_date`,`billing_date`,`Customer_id`,`CusName`,`netAmount`,`netdiscount`,`NetDisAmount`,`GrandTotal`,`itemid`,`sid` FROM `selling_view` where billing_date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        ItemShowGridView.DataSource = table
        Tbl = table
        ItemShowGridView.Columns(0).Width = 100 'Invno'
        ItemShowGridView.Columns(1).Visible = False  'id'
        ItemShowGridView.Columns(2).Width = 100 'barcode
        ItemShowGridView.Columns(3).Width = 150 'des'
        ItemShowGridView.Columns(4).Width = 90 'qty'
        ItemShowGridView.Columns(5).Width = 100 'unit_price'
        ItemShowGridView.Columns(5).Width = 100 'cus_price'
        ItemShowGridView.Columns(6).Width = 80 'discount'
        ItemShowGridView.Columns(7).Width = 100 'amount'
        ItemShowGridView.Columns(8).Width = 150 'expire_date'
        ItemShowGridView.Columns(9).Width = 150 'billing_date'
        ItemShowGridView.Columns(10).Visible = False 'customer_id'
        ItemShowGridView.Columns(11).Visible = False 'cusName'
        ItemShowGridView.Columns(12).Visible = False 'netAmount'
        ItemShowGridView.Columns(13).Visible = False 'netdiscount'
        ItemShowGridView.Columns(14).Visible = False 'netDisAmount'
        ItemShowGridView.Columns(15).Visible = False 'grandTotal'
        ItemShowGridView.Columns(17).Visible = False 'itemid'
        ItemShowGridView.Columns(18).Visible = False 'sid'

        conn.Close()

    End Sub


    Private Sub InvNoTxt_TextChanged(sender As Object, e As EventArgs) Handles InvNoTxt.TextChanged
        '--------------------'
        Dim dv As New DataView(Tbl)
        dv.RowFilter = String.Format("Invno Like '%{0}%'", InvNoTxt.Text)
        ItemShowGridView.DataSource = dv
        '----------------'
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        load_for_date()
    End Sub

    Private Sub RetuenBtn_Click(sender As Object, e As EventArgs) Handles RetuenBtn.Click
        'This Button For the Return Function'
        If QtyReturnTxt.Text = "" Then
            MessageBox.Show("Please type the return Qty")
        Else
            Dim qty As Double = QtyReturnTxt.Text
            If QtyPurchLbl.Text = "" Then
                MessageBox.Show("Please Select the Item")
            Else
                Dim Query As String
                Dim stock As Integer
                conn.Close()

                Dim ren As Integer = QtyReturnTxt.Text
                MySqlConn.Open()

                Query = "SELECT * FROM `all_items_sptbl` WHERE `id` = " & itemid
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    stock = READER.GetString("stock")
                End While
                ren = ren + stock
                MySqlConn.Close()
                '----------------------------------'
                'if return All Items'
                If QtyReturnTxt.Text = QtyPurchLbl.Text Then
                    Try
                        MySqlConn.Open()
                        Query = "UPDATE `all_items_sptbl` SET `stock` = '" & ren & "' WHERE `all_items_sptbl`.`id` =" & itemid
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MySqlConn.Close()
                    End Try

                    'Delete Item From Stock Table And change Amount'
                    Try

                        MySqlConn.Open()
                        Query = "DELETE FROM `selling_items` WHERE `selling_items`.`id` =" & sellItemTblPKID & "; UPDATE `selling` SET `netAmount` = '" & AmountLbl.Text & "', `GrandTotal` = '" & AmountLbl.Text & "' WHERE `selling`.`sid` = " & sid & ";"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        load_for_date() 'locad Data'
                        clearData() 'clear Data'
                    Catch ex As Exception
                        MySqlConn.Close()
                        MessageBox.Show(ex.Message)
                    End Try

                Else 'Not Return All Items'
                    Try
                        MySqlConn.Open()
                        Query = "UPDATE `all_items_sptbl` SET `stock` = '" & ren & "' WHERE `all_items_sptbl`.`id` =" & itemid
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MySqlConn.Close()
                    End Try
                    'This for the balance the Amount
                    Dim netamt As Double = oldnetamount - RCashAmountTxt.Text 'rtn net amount -
                    Dim rtnqty As Integer = QtyPurchLbl.Text - QtyReturnTxt.Text 'rtn qty -
                    Dim amt As Double = AmountLbl.Text - RCashAmountTxt.Text 'rtn product amount -
                    Try

                        MySqlConn.Open()
                        Query = "UPDATE `selling_items` SET `qty` = '" & rtnqty & "', `amount` = '" & amt & "' WHERE `selling_items`.`id` = " & sellItemTblPKID & " ; UPDATE `selling` SET `netAmount` = '" & netamt & "', `GrandTotal` = '" & netamt & "' WHERE `selling`.`sid` = " & sid & ";"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        load_for_date() 'locad Data'
                        clearData() 'clear Data'
                    Catch ex As Exception
                        MySqlConn.Close()
                        MessageBox.Show(ex.Message)
                    End Try
                End If

            End If
        End If
        '---------------------------------------------------'
    End Sub

    Private Sub ItCodeTxt_TextChanged(sender As Object, e As EventArgs) Handles ItCodeTxt.TextChanged
        If InvNoTxt.Text = "" Then
            '--------------------'
            Dim dv As New DataView(Tbl)
            dv.RowFilter = String.Format("barcode Like '%{0}%'", ItCodeTxt.Text)
            ItemShowGridView.DataSource = dv
            '----------------'
        Else
            '--------------------'
            Dim dv As New DataView(Tbl)
            'dv.RowFilter = String.Format("Invno Like '%{0}%'", InvNoTxt.Text)
            dv.RowFilter = "Invno Like '%" & InvNoTxt.Text & "%' AND barcode Like '%" & ItCodeTxt.Text & "%'"
            ItemShowGridView.DataSource = dv
            '----------------'
        End If
    End Sub

    Private Sub DesTxt_TextChanged(sender As Object, e As EventArgs) Handles DesTxt.TextChanged
        '--------------------'
        Dim dv As New DataView(Tbl)
        'dv.RowFilter = String.Format("Invno Like '%{0}%'", InvNoTxt.Text)
        dv.RowFilter = "Invno Like '%" & InvNoTxt.Text & "%' AND barcode Like '%" & ItCodeTxt.Text & "%' AND des Like '%" & DesTxt.Text & "%'"
        ItemShowGridView.DataSource = dv
        '----------------'
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cryRpt As New RetailDesign
        cryRpt.Refresh()
        cryRpt.RecordSelectionFormula = "{selling_view1.sid} = " & sid & ""
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub



    Private Sub QtyReturnTxt_TextChanged(sender As Object, e As EventArgs) Handles QtyReturnTxt.TextChanged
        If QtyReturnTxt.Text = "" Then
        Else
            Dim qty As Double = QtyReturnTxt.Text
            If QtyPurchLbl.Text = "" Then
            Else
                Dim aqty As Double = QtyPurchLbl.Text
                If aqty < qty Then
                    MsgBox("You Enter Qty IS Not Match Please Check")
                Else
                    Dim unitprice As Double = UnitPriceLbl.Text
                    Dim Cashreturn = qty * unitprice
                    RCashAmountTxt.Text = Cashreturn.ToString
                End If

            End If
        End If
    End Sub

    Private Sub clearData()
        DesLbl.Text = ""
        QtyPurchLbl.Text = ""
        QtyReturnTxt.Clear()
        UnitPriceLbl.Text = ""
        AmountLbl.Text = ""
        RCashAmountTxt.Clear()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub

    Private Sub ItemShowGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemShowGridView.CellContentClick

    End Sub
End Class