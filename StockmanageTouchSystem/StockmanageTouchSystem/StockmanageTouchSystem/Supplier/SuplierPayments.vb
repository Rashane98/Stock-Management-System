Imports MySql.Data.MySqlClient
Public Class SuplierPayments
    Dim userid As Integer = 0
    Dim Query As String
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim suplierid As Integer

    '--------------------------------------------credit amount change
    Dim creditamt As Double = 0
    Dim creditid As Integer = 0
    Dim paymentid As Integer

    '-------------------------------------------

    Private Sub loadsupplierTable()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date` FROM `supplier_credit` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        creditDataGridView.DataSource = table
        creditDataGridView.Columns(0).Width = 60
        creditDataGridView.Columns(1).Visible = False
        creditDataGridView.Columns(2).Width = 350
        creditDataGridView.Columns(3).Width = 150

        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub

    Private Sub loadpaymentsTbl()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Type`,`Amount`,`PDate` FROM `supplier_payments` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        PaymentsDataGridView1.DataSource = table
        PaymentsDataGridView1.Columns(0).Width = 60
        PaymentsDataGridView1.Columns(1).Visible = False
        PaymentsDataGridView1.Columns(2).Width = 350
        PaymentsDataGridView1.Columns(3).Width = 150

        conn.Close()
    End Sub
    Private Sub clearTxt()
        NameTxt.Clear()
        AmountTxt.Clear()
        userid = 0
    End Sub
    Private Sub TotalCredit()
        Dim rowcount As Integer = PaymentsDataGridView1.Rows.Count
        Dim tot As Double = 0
        For d As Integer = 0 To rowcount - 1 Step +1
            tot = tot + PaymentsDataGridView1.Rows(d).Cells(4).Value
        Next
        Label4.Text = tot.ToString
    End Sub

    Private Sub SuplierPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsupplierTable()
        loadpaymentsTbl()
        TotalCredit()

        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If

        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'

    End Sub

    Private Sub NameTxt_TextChanged(sender As Object, e As EventArgs) Handles NameTxt.TextChanged
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date` FROM `supplier_credit` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        creditDataGridView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", NameTxt.Text)
        creditDataGridView.DataSource = dv

        conn.Close()
    End Sub
    Private Sub NameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NameTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            creditDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            creditDataGridView.Select()
        End If
    End Sub
    Private Sub NameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTxt.KeyPress
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

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        clearTxt()
        AddDateTimePicker.Select()

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If userid <> 0 Then
            If NameTxt.Text <> "" Then
                If AmountTxt.Text <> "" Then
                    If AmountTxt.Text > creditamt Then
                        MessageBox.Show("Wrong Payment")
                    Else
                        If changecreditamt() = True Then
                            Try
                                Dim duedate As String = Format(Me.AddDateTimePicker.Value, "yyyy-MM-dd")
                                MySqlConn.Open()
                                Query = "INSERT INTO `supplier_payments` (`id`, `Supplier_id`, `Name`, `Type`, `Amount`, `PDate`) VALUES (NULL, '" & userid & "', '" & NameTxt.Text & "', '" & ComboBox2.Text & "', '" & AmountTxt.Text & "', '" & duedate & "');"
                                COMMAND = New MySqlCommand(Query, MySqlConn)
                                READER = COMMAND.ExecuteReader
                                MySqlConn.Close()
                                userid = 0
                                loadpaymentsTbl()
                                TotalCredit() 'cal the credit'
                                clearTxt()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        Else
                            MessageBox.Show("Credit Amount Change Error")
                        End If
                    End If


                Else
                    MessageBox.Show("Please Enter Credit amount")
                End If
            Else
                MessageBox.Show("Plase Select the user")
            End If
        Else
            MessageBox.Show("Please Select the product")
        End If
    End Sub
    Private Function changecreditamt()
        If AmountTxt.Text = creditamt Then
            Try
                MySqlConn.Open()
                Query = "DELETE FROM `supplier_credit` WHERE `supplier_credit`.`id` = " & creditid
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Dim newamt As Double = creditamt - AmountTxt.Text

            Try
                MySqlConn.Open()
                Query = "UPDATE `supplier_credit` SET `Amount` = '" & newamt & "' WHERE `supplier_credit`.`id` = " & creditid
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If

    End Function

    Private Sub AddDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles AddDateTimePicker.ValueChanged

    End Sub


    Private Sub AddDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles AddDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            NameTxt.Select()
        End If
    End Sub

    Private Sub creditDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles creditDataGridView.CellContentClick

    End Sub

    Private Sub creditDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles creditDataGridView.CellClick

    End Sub

    Private Sub creditDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles creditDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            '`id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date`'
            Dim s As Integer = creditDataGridView.CurrentRow.Index
            creditid = creditDataGridView.Rows(s).Cells(0).Value
            userid = creditDataGridView.Rows(s).Cells(1).Value 'this for the user id'

            creditamt = creditDataGridView.Rows(s).Cells(3).Value 'credit amount'
            NameTxt.Text = creditDataGridView.Rows(s).Cells(2).Value 'Nametxt
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            ComboBox2.Select()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            AmountTxt.Select()
        End If
    End Sub


    Private Sub AmountTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveBtn.PerformClick()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If PasswordTxt.Text = "40012" Then
            Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If paymentid <> 0 Then
                    Try

                        MySqlConn.Open()
                        Query = "DELETE FROM `supplier_payments` WHERE `supplier_payments`.`id` =" & paymentid
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        userid = 0
                        loadpaymentsTbl()
                        TotalCredit() 'cal the credit'
                        clearTxt()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please Select Item")
                End If
            End If

        Else
                MessageBox.Show("You are not Admin")
        End If
    End Sub


    Private Sub PaymentsDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PaymentsDataGridView1.CellClick
        '`id`,`Supplier_id`,`Name`,`Type`,`Amount`,`PDate`
        Dim s As Integer = PaymentsDataGridView1.CurrentRow.Index
        paymentid = PaymentsDataGridView1.Rows(s).Cells(0).Value 'id'
        suplierid = PaymentsDataGridView1.Rows(s).Cells(1).Value
        SearchTxt.Text = PaymentsDataGridView1.Rows(s).Cells(2).Value
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Type`,`Amount`,`PDate` FROM `supplier_payments` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        PaymentsDataGridView1.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", SearchTxt.Text)
        PaymentsDataGridView1.DataSource = dv
        TotalCredit()
        conn.Close()
    End Sub

    Private Sub StartDate_ValueChanged(sender As Object, e As EventArgs) Handles StartDate.ValueChanged

    End Sub

    Private Sub EndDate_ValueChanged(sender As Object, e As EventArgs) Handles EndDate.ValueChanged
        Dim startdate As String = Format(Me.StartDate.Value, "yyyy-MM-dd")
        Dim enddate As String = Format(Me.EndDate.Value, "yyyy-MM-dd")
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Type`,`Amount`,`PDate` FROM `supplier_payments`  WHERE `PDate` BETWEEN '" & startdate & "' AND '" & enddate & "';", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        PaymentsDataGridView1.DataSource = table
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cryRpt As New SupplierPaymentsReport
        cryRpt.Refresh()
        cryRpt.RecordSelectionFormula = "{supplier_payments1.Supplier_id} = " & suplierid & ""
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class