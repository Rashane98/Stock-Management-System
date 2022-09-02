Imports MySql.Data.MySqlClient
Public Class stock_predictions
    Dim Query As String
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Calculate_Btn_Click(sender As Object, e As EventArgs) Handles Calculate_Btn.Click
        clear_old_db()
        Insert_record()
        load_system()
    End Sub
    Private Sub Insert_record()
        'INSERT INTO `mainstmdb`.`stock_predicion` (`barcode`, `des`, `cost`, `stock`, `unit_price`, `amount`, `profit`, `profit_count`) VALUES ('barcode', 'des', 'cost', 'stock', 'unitprice', 'amount', 'profit', 'profit_count');
        Dim startdates As String
        Dim enddat As String
        startdates = Format(Me.StartDate.Value, "yyy-MM-dd")
        enddat = Format(Me.endDate.Value, "yyyy-MM-dd")
        Dim old_barcode As String = ""
        Dim old_des As String = ""

        Dim netcost As Double
        Dim netstock As Double
        Dim net_unit_price As Double
        Dim val As Integer = 0

        Dim cost As Double
        Dim qty As Integer
        Dim sellPrice As Double
        conn.Open()
        Dim quer As String
        quer = "SELECT `barcode`,`des`,`cost`,`qty`,`selling_price`,`cm_price`,`sel_date` FROM daily_proft_tbl WHERE `sel_date` BETWEEN '" & startdates & "' AND '" & enddat & "' order by barcode;"
        COMMAND = New MySqlCommand(quer, conn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            Dim bacrode = READER.GetString("barcode")
            If old_barcode = "" Then 'This old barcode is Empty'
                old_barcode = bacrode
            End If

            If bacrode <> old_barcode Then
                netcost = netcost / val
                net_unit_price = net_unit_price / val


                Dim net_amount As Double = net_unit_price * netstock
                Dim profit As Double = net_unit_price - netcost
                Dim des = READER.GetString("des")
                'Add the Record'
                stock_predctionAdd(old_barcode, old_des, netcost, netstock, net_unit_price, net_amount, profit)

                'Need to change Barcode

                old_des = des
                old_barcode = bacrode
                val = 0
                netcost = 0
                netstock = 0
                net_unit_price = 0
                'need to run this cycle again
                cost = READER.GetString("cost")
                qty = READER.GetString("qty")
                sellPrice = READER.GetString("selling_price")

                netcost += cost
                netstock += qty
                net_unit_price += sellPrice
                val = val + 1

            Else
                cost = READER.GetString("cost")
                qty = READER.GetString("qty")
                sellPrice = READER.GetString("selling_price")

                netcost += cost
                netstock += qty
                net_unit_price += sellPrice
                val = val + 1
                old_des = READER.GetString("des")
            End If

        End While
        conn.Close()
    End Sub
    Private Sub stock_predctionAdd(old_barcode, old_des, netcost, netstock, net_unit_price, net_amount, profit)
        Dim NCOMMAND As MySqlCommand
        Dim NREADER As MySqlDataReader
        Try 'This for the item Add'

            MySqlConn.Open()
            Query = "INSERT INTO `mainstmdb`.`stock_predicion` (`barcode`, `des`, `cost`, `stock`, `unit_price`, `amount`, `profit`, `profit_count`) VALUES ('" & old_barcode & "', '" & old_des & "', '" & netcost & "', '" & netstock & "', '" & net_unit_price & "', '" & net_amount & "', '" & profit & "', '0');"
            NCOMMAND = New MySqlCommand(Query, MySqlConn)
            NREADER = NCOMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub clear_old_db()
        Try 'This for the item Add'

            MySqlConn.Open()
            Query = "DELETE FROM `stock_predicion`"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = Command.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub


    Private Sub load_system()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `des`, `cost`, `stock`, `unit_price`, `amount`, `profit`, `profit_count` FROM stock_predicion order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Stock_predicitc_Grid_View.DataSource = table
        Stock_predicitc_Grid_View.Columns(0).Width = 140
        Stock_predicitc_Grid_View.Columns(1).Width = 420
        Stock_predicitc_Grid_View.Columns(2).Width = 110
        Stock_predicitc_Grid_View.Columns(3).Width = 110
        Stock_predicitc_Grid_View.Columns(4).Width = 110
        Stock_predicitc_Grid_View.Columns(5).Width = 110
        Stock_predicitc_Grid_View.Columns(6).Width = 110
        Stock_predicitc_Grid_View.Columns(7).Width = 110
        'DataGridView1.Columns(5).Width = 60
        conn.Close()

        profit_cal()
    End Sub

    Private Sub profit_cal() 'This For the Calculate and Show
        Dim netcost As Double = 0
        Dim netprice As Double = 0
        Dim netprofit As Double = 0
        For q As Integer = 0 To Stock_predicitc_Grid_View.Rows.Count - 1 Step +1
            '`barcode`, `des`, `cost`, `stock`, `unit_price`, `amount`, `profit`, `profit_count`
            Dim cost = Stock_predicitc_Grid_View.Rows(q).Cells(2).Value
            Dim stock = Stock_predicitc_Grid_View.Rows(q).Cells(3).Value
            Dim unit_price = Stock_predicitc_Grid_View.Rows(q).Cells(4).Value
            Dim profit = Stock_predicitc_Grid_View.Rows(q).Cells(6).Value

            netcost += (cost * stock)
            netprice += (unit_price * stock)
            netprofit += (profit * stock)


        Next
        CostLbl.Text = netcost.ToString
        PriceLbl.Text = netprice.ToString
        ProfitLbl.Text = netprofit.ToString
    End Sub

    Private Sub stock_predictions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_system()

        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cryRpt As New StockpredictionsReport
        cryRpt.Refresh()
        'cryRpt.RecordSelectionFormula = "{daily_proft_tbl1.sel_date} = '" & StartDate.Value.ToString("dd/MM/yyyy") & "'"
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub


End Class