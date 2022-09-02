Imports MySql.Data.MySqlClient
Public Class AddBalanceProduct
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub load_data()
        conn.Open()
        '`barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date`
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product order by barcode;", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Guna2DataGridView1.Columns(0).Width = 140
        Guna2DataGridView1.Columns(1).Width = 420
        Guna2DataGridView1.Columns(2).Width = 110
        'Guna2DataGridView1.Columns(3).Visible = False 'cost visible'
        Guna2DataGridView1.Columns(4).Width = 100

        If SerCodeTxt.Text = "POS" Then
            Guna2DataGridView1.Columns(3).Visible = True
        Else
            Guna2DataGridView1.Columns(3).Visible = False
        End If

        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub itemCodeNotEmptyLoadData()
        If searchBrcodeTxt.Text = "" Then

            '--------------------'
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product order by barcode", conn)
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
            Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product where barcode like'" & searchBrcodeTxt.Text & "%' order by barcode", conn)
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
        weightTxt.Clear()
        AvgWeightTxt.Clear()
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


    Private Sub AddBalanceProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
        rowcount()
        load_brandTbl() 'This for the load brand table'
        brandDatagridView.Visible = False 'brand grid view visible false'
    End Sub
    Private Sub rowcount()
        Dim k As Integer = Guna2DataGridView1.Rows.Count()
        productcountLbl.Text = k
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        clearTxt()
        barcodeTxt.Select()

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
            Issue_dateDateTimePicker.Select()
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
            weightTxt.Select()
        End If
    End Sub


    Private Sub weightTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles weightTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            AvgWeightTxt.Select()
        End If
    End Sub


    Private Sub AvgWeightTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles AvgWeightTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveBtn.PerformClick()

        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SerCodeTxt.Text = "1010" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to delete selected product?", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim Query As String
                If barcodeTxt.Text <> "" Then
                    Try

                        MySqlConn.Open()
                        Query = "DELETE FROM `all_balance_product` WHERE `barcode` = '" & barcodeTxt.Text & "';"
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
                                If weightTxt.Text = "" Then
                                    MessageBox.Show("Weight is Empty")
                                Else
                                    If AvgWeightTxt.Text = "" Then
                                        MessageBox.Show("Average Weight is Empty")
                                    Else
                                        Dim expire_date As String = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")
                                        Dim barcode As String = barcodeTxt.Text.Trim()
                                        Dim des As String = DesTxt.Text.Trim()
                                        Dim brand As String = BrandTxt.Text.Trim()


                                        Dim clean As String
                                        clean = des.Replace("'", " ")
                                        des = clean
                                        clean = barcode.Replace("'", " ")
                                        barcode = clean
                                        clean = brand.Replace("'", " ")
                                        brand = clean

                                        Dim Query As String

                                        Try 'This for the item Add'

                                            MySqlConn.Open()
                                            Query = "UPDATE `all_balance_product` SET `Des` = '" & des & "', `brand` = '" & brand & "', `cost` = '" & CostTxt.Text & "', `wholesale` = '" & WholesaleTxt.Text & "', `retail` = '" & RetailTxt.Text & "', `cm_price` = '" & cmpriceTxt.Text & "', `weight` = '" & weightTxt.Text & "', `average_weight` = '" & AvgWeightTxt.Text & "',`expire_date` = '" & expire_date & "' WHERE (`barcode` = '" & barcode & "');"
                                            COMMAND = New MySqlCommand(Query, MySqlConn)
                                            READER = COMMAND.ExecuteReader
                                            MySqlConn.Close()
                                            MessageBox.Show("Product Updated successfully")
                                        Catch ex As Exception

                                            MessageBox.Show(ex.Message)
                                            MySqlConn.Close()
                                        End Try

                                        itemCodeNotEmptyLoadData()
                                        rowcount()
                                        clearTxt()
                                        barcodeTxt.Select()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
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
                                If weightTxt.Text = "" Then
                                    MessageBox.Show("Weight is Empty")
                                Else
                                    If AvgWeightTxt.Text = "" Then
                                        MessageBox.Show("Average Weight is Empty")
                                    Else
                                        Dim expire_date As String = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")
                                        Dim barcode As String = barcodeTxt.Text.Trim()
                                        Dim des As String = DesTxt.Text.Trim()
                                        Dim brand As String = BrandTxt.Text.Trim()


                                        Dim clean As String
                                        clean = des.Replace("'", " ")
                                        des = clean
                                        clean = barcode.Replace("'", " ")
                                        barcode = clean
                                        clean = brand.Replace("'", " ")
                                        brand = clean

                                        Dim Query As String

                                        Try 'This for the item Add'

                                            MySqlConn.Open()
                                            Query = "INSERT INTO `mainstmdb`.`all_balance_product` (`barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date`) VALUES ('" & barcode & "', '" & des & "', '" & brand & "', '" & CostTxt.Text & "', '" & WholesaleTxt.Text & "', '" & RetailTxt.Text & "', '" & cmpriceTxt.Text & "', '" & weightTxt.Text & "', '" & AvgWeightTxt.Text & "','" & expire_date & "');"
                                            COMMAND = New MySqlCommand(Query, MySqlConn)
                                            READER = COMMAND.ExecuteReader
                                            MySqlConn.Close()
                                            MessageBox.Show("Product added successfully")
                                        Catch ex As Exception

                                            MessageBox.Show(ex.Message)
                                            MySqlConn.Close()
                                        End Try

                                        itemCodeNotEmptyLoadData()
                                        rowcount()
                                        clearTxt()
                                        barcodeTxt.Select()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        '`barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date`
        Dim k As Integer = Guna2DataGridView1.CurrentRow.Index
        barcodeTxt.Text = Guna2DataGridView1.Rows(k).Cells(0).Value.ToString
        DesTxt.Text = Guna2DataGridView1.Rows(k).Cells(1).Value.ToString
        BrandTxt.Text = Guna2DataGridView1.Rows(k).Cells(2).Value.ToString
        CostTxt.Text = Guna2DataGridView1.Rows(k).Cells(3).Value.ToString
        WholesaleTxt.Text = Guna2DataGridView1.Rows(k).Cells(4).Value.ToString
        RetailTxt.Text = Guna2DataGridView1.Rows(k).Cells(5).Value.ToString
        cmpriceTxt.Text = Guna2DataGridView1.Rows(k).Cells(6).Value.ToString
        weightTxt.Text = Guna2DataGridView1.Rows(k).Cells(7).Value.ToString
        AvgWeightTxt.Text = Guna2DataGridView1.Rows(k).Cells(8).Value.ToString
        Issue_dateDateTimePicker.Value = Guna2DataGridView1.Rows(k).Cells(9).Value
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

    Private Sub searchBrcodeTxt_TextChanged(sender As Object, e As EventArgs) Handles searchBrcodeTxt.TextChanged
        '--------------------'
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product order by barcode", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("barcode Like '{0}%'", searchBrcodeTxt.Text)
        Guna2DataGridView1.DataSource = dv
        conn.Close()
        rowcount()

    End Sub

    Private Sub searchDesTxt_TextChanged(sender As Object, e As EventArgs) Handles searchDesTxt.TextChanged
        If searchBrcodeTxt.Text = "" Then

            '--------------------'
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product order by barcode", conn)
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
            Dim adapter As New MySqlDataAdapter("SELECT `barcode`, `Des`, `brand`, `cost`, `wholesale`, `retail`, `cm_price`, `weight`, `average_weight`,`expire_date` FROM all_balance_product where barcode like'" & searchBrcodeTxt.Text & "%' order by barcode", conn)
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

    Private Sub BrandTxt_TextChanged(sender As Object, e As EventArgs) Handles BrandTxt.TextChanged

    End Sub

    Private Sub Issue_dateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Issue_dateDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            CostTxt.Select()
        End If
    End Sub
End Class