Imports MySql.Data.MySqlClient
Public Class ProfitCalculate
    Private Sub loadProfitTbl()
        conn.Open()
        Dim prodate As String = Format(Me.StartDate.Value, "yyyy-MM-dd")
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Inv_no`,`barcode`,`des`,`cost`,`qty`,`selling_price`,`cm_price`,`sel_date` FROM `daily_proft_tbl` WHERE sel_date LIKE '" & prodate & "%' ", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Prift_tblGrid_View.DataSource = table
        Prift_tblGrid_View.Columns(0).Width = 50
        Prift_tblGrid_View.Columns(1).Width = 60
        Prift_tblGrid_View.Columns(2).Width = 60
        Prift_tblGrid_View.Columns(3).Width = 400
        Prift_tblGrid_View.Columns(4).Width = 100
        Prift_tblGrid_View.Columns(5).Width = 100

        Prift_tblGrid_View.Columns(8).Visible = False

        conn.Close()
    End Sub
    Private Sub ProfitCalculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProfitTbl()
        cal_total_profit()
        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        loadProfitTbl()
        cal_total_profit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prodate As String = Format(Me.StartDate.Value, "yyyy-MM-dd")

        Dim cryRpt As New Daily_RetailSale_Profit
        cryRpt.Refresh()
        'cryRpt.RecordSelectionFormula = "{daily_proft_tbl1.sel_date} = '" & StartDate.Value.ToString("dd/MM/yyyy") & "'"
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub
    Private Sub cal_total_profit()
        Dim netcost As Double = 0
        Dim netprice As Double = 0
        Dim netprofit As Double = 0
        Dim num As Integer = 1
        For q As Integer = 0 To Prift_tblGrid_View.Rows.Count - 1 Step +1 'item add to the selling'
            Dim cost = Prift_tblGrid_View.Rows(q).Cells(4).Value 'cost'
            Dim qty = Prift_tblGrid_View.Rows(q).Cells(5).Value 'qty'
            Dim unit_price = Prift_tblGrid_View.Rows(q).Cells(6).Value 'selling_price'

            If CodeTxt.Text = "1010" Then
                netcost = netcost + (cost * qty)
                netprice = netprice + (unit_price * qty)
                netprofit = netprofit + ((unit_price * qty) - (cost * qty))
            Else

                If num < Prift_tblGrid_View.Rows.Count - 2 Then
                    If num Mod 2 <> 0 Then
                        Prift_tblGrid_View.Rows(num).Visible = False
                        netcost = netcost + (cost * qty)
                        netprice = netprice + (unit_price * qty)
                        netprofit = netprofit + ((unit_price * qty) - (cost * qty))


                    End If

                End If


            End If
            num += 1

        Next
        CostLbl.Text = netcost.ToString
        PriceLbl.Text = netprice.ToString
        ProfitLbl.Text = netprofit.ToString
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub

    Private Sub CodeTxt_TextChanged(sender As Object, e As EventArgs) Handles CodeTxt.TextChanged
        If CodeTxt.Text = "1010" Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim netcost As Double = 0
        Dim netprice As Double = 0
        Dim netprofit As Double = 0
        Dim num As Integer = 1
        If CodeTxt.Text = "1010" Then
            For q As Integer = 0 To Prift_tblGrid_View.Rows.Count - 1 Step +1 'item add to the selling'
                Prift_tblGrid_View.Rows(q).Visible = True
                Dim cost = Prift_tblGrid_View.Rows(q).Cells(4).Value 'cost'
                Dim qty = Prift_tblGrid_View.Rows(q).Cells(5).Value 'qty'
                Dim unit_price = Prift_tblGrid_View.Rows(q).Cells(6).Value 'selling_price'


                netcost = netcost + (cost * qty)
                netprice = netprice + (unit_price * qty)
                netprofit = netprofit + ((unit_price * qty) - (cost * qty))

            Next
        Else
            For q As Integer = 0 To Prift_tblGrid_View.Rows.Count - 1 Step +1 'item add to the selling'
                If num < Prift_tblGrid_View.Rows.Count - 2 Then
                    If num Mod 2 <> 0 Then

                        Dim cost = Prift_tblGrid_View.Rows(q).Cells(4).Value 'cost'
                        Dim qty = Prift_tblGrid_View.Rows(q).Cells(5).Value 'qty'
                        Dim unit_price = Prift_tblGrid_View.Rows(q).Cells(6).Value 'selling_price'

                        Prift_tblGrid_View.Rows(num).Visible = False
                        netcost = netcost + (cost * qty)
                        netprice = netprice + (unit_price * qty)
                        netprofit = netprofit + ((unit_price * qty) - (cost * qty))


                    End If

                End If
                num += 1
            Next
        End If
        CostLbl.Text = netcost.ToString
        PriceLbl.Text = netprice.ToString
        ProfitLbl.Text = netprofit.ToString
    End Sub

    Private Sub CodeTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles CodeTxt.KeyDown
        If e.KeyCode = Keys.Escape Then
            Button1.PerformClick()
        End If
    End Sub
End Class