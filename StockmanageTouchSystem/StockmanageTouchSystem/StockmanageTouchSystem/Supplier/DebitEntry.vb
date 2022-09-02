Imports MySql.Data.MySqlClient
Public Class DebitEntry
    Dim userid As Integer = 0
    Dim Query As String
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim suplierid As Integer = 0
    Dim id As Integer = 0
    Private Sub loadthecreditDetails() 'load the user Credit Table
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date` FROM `supplier_credit` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        CreditDetailsDataGridView1.DataSource = table
        CreditDetailsDataGridView1.Columns(0).Width = 60
        CreditDetailsDataGridView1.Columns(1).Visible = False
        CreditDetailsDataGridView1.Columns(2).Width = 350
        CreditDetailsDataGridView1.Columns(3).Width = 150



        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub TotalCredit()
        Dim rowcount As Integer = CreditDetailsDataGridView1.Rows.Count
        Dim tot As Double = 0
        For d As Integer = 0 To rowcount - 1 Step +1
            tot = tot + CreditDetailsDataGridView1.Rows(d).Cells(3).Value
        Next
        Label4.Text = tot.ToString
    End Sub
    Private Sub clearTxt()
        NameTxt.Clear()
        AmountTxt.Clear()
        userid = 0
    End Sub
    Private Sub loaduserTbl() 'load user Table'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Name`,`Address`,`TelNo`,`Fax`,`City`,`RegDate` FROM `supplier` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        UserNameDataGridView.DataSource = table
        UserNameDataGridView.Columns(0).Width = 20
        UserNameDataGridView.Columns(1).Width = 150
        UserNameDataGridView.Columns(2).Visible = False
        UserNameDataGridView.Columns(4).Visible = False



        'DataGridView1.Columns(5).Width = 60
        conn.Close()
    End Sub
    Private Sub DebitEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadthecreditDetails()
        loaduserTbl()
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
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Name`,`Address`,`TelNo`,`Fax`,`City`,`RegDate` FROM `supplier` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        UserNameDataGridView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", NameTxt.Text)
        UserNameDataGridView.DataSource = dv

        conn.Close()
    End Sub

    Private Sub NameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NameTxt.KeyDown
        If e.KeyCode = Keys.Up Then
            UserNameDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            UserNameDataGridView.Select()
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
        If userid <> 0 Then
            If NameTxt.Text <> "" Then
                If AmountTxt.Text <> "" Then

                    Try
                        Dim duedate As String = Format(Me.AddDateTimePicker.Value, "yyyy-MM-dd")
                        MySqlConn.Open()
                        Query = "INSERT INTO `supplier_credit` (`id`, `Supplier_id`, `Name`, `Amount`, `Credit_Date`) VALUES (NULL, '" & userid & "', '" & NameTxt.Text & "', '" & AmountTxt.Text & "', '" & duedate & "');"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        userid = 0
                        loadthecreditDetails()
                        TotalCredit() 'cal the credit'
                        clearTxt()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
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

    Private Sub UserNameDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserNameDataGridView.CellContentClick

    End Sub

    Private Sub UserNameDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserNameDataGridView.CellClick
        Dim s As Integer = UserNameDataGridView.CurrentRow.Index

        userid = UserNameDataGridView.Rows(s).Cells(0).Value 'this for the user id'
        NameTxt.Text = UserNameDataGridView.Rows(s).Cells(1).Value 'Nametxt
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
        AmountTxt.Select()
    End Sub

    Private Sub UserNameDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles UserNameDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim s As Integer = UserNameDataGridView.CurrentRow.Index
            userid = UserNameDataGridView.Rows(s).Cells(0).Value 'this for the user id'
            NameTxt.Text = UserNameDataGridView.Rows(s).Cells(1).Value 'Nametxt
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            AmountTxt.Select()
        End If

    End Sub

    Private Sub AmountTxt_TextChanged(sender As Object, e As EventArgs) Handles AmountTxt.TextChanged

    End Sub

    Private Sub AmountTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddBtn.PerformClick()
        End If
    End Sub

    Private Sub EndDate_ValueChanged(sender As Object, e As EventArgs) Handles EndDate.ValueChanged
        Dim startdate As String = Format(Me.StartDate.Value, "yyyy-MM-dd")
        Dim enddate As String = Format(Me.EndDate.Value, "yyyy-MM-dd")
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date` FROM `supplier_credit` WHERE `Credit_Date` BETWEEN '" & startdate & "' AND '" & enddate & "';", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        CreditDetailsDataGridView1.DataSource = table
        conn.Close()
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date` FROM `supplier_credit` WHERE 1", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        CreditDetailsDataGridView1.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", SearchTxt.Text)
        CreditDetailsDataGridView1.DataSource = dv
        TotalCredit()
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cryRpt As New suplierCredit
        cryRpt.Refresh()
        cryRpt.RecordSelectionFormula = "{supplier_credit1.Supplier_id} = " & suplierid & ""
        cryRpt.Refresh()
        cryRpt.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        cryRpt.PrintToPrinter(0, False, 1, 1)
    End Sub

    Private Sub CreditDetailsDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CreditDetailsDataGridView1.CellContentClick
        '`id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date`
        Dim s As Integer = CreditDetailsDataGridView1.CurrentRow.Index
        id = CreditDetailsDataGridView1.Rows(s).Cells(0).Value
        suplierid = CreditDetailsDataGridView1.Rows(s).Cells(1).Value 'suplierId

        NameTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(2).Value
        AmountTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(3).Value
        AddDateTimePicker.Value = CreditDetailsDataGridView1.Rows(s).Cells(4).Value
    End Sub



    Private Sub CreditDetailsDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles CreditDetailsDataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            '`id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date`
            Dim s As Integer = CreditDetailsDataGridView1.CurrentRow.Index
            id = CreditDetailsDataGridView1.Rows(s).Cells(0).Value
            suplierid = CreditDetailsDataGridView1.Rows(s).Cells(1).Value 'suplierId

            NameTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(2).Value
            AmountTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(3).Value
            AddDateTimePicker.Value = CreditDetailsDataGridView1.Rows(s).Cells(4).Value
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If PasswordTxt.Text = "40012" Then
            If suplierid <> 0 Then
                Try
                    Dim duedate As String = Format(Me.AddDateTimePicker.Value, "yyyy-MM-dd")
                    MySqlConn.Open()
                    Query = "UPDATE `supplier_credit` SET `Amount` = '" & AmountTxt.Text & "', `Credit_Date` = '" & duedate & "' WHERE `supplier_credit`.`id` = " & id
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    userid = 0
                    loadthecreditDetails()
                    TotalCredit() 'cal the credit'
                    clearTxt()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Please Select Item")
            End If
        Else
            MessageBox.Show("You are not Admin")
        End If

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If PasswordTxt.Text = "40012" Then
            Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If suplierid <> 0 Then
                    Try

                        MySqlConn.Open()
                        Query = "DELETE FROM `supplier_credit` WHERE `supplier_credit`.`id` = " & id
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                        MySqlConn.Close()
                        userid = 0
                        loadthecreditDetails()
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

    Private Sub CreditDetailsDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CreditDetailsDataGridView1.CellClick
        '`id`,`Supplier_id`,`Name`,`Amount`,`Credit_Date`
        Dim s As Integer = CreditDetailsDataGridView1.CurrentRow.Index
        id = CreditDetailsDataGridView1.Rows(s).Cells(0).Value
        suplierid = CreditDetailsDataGridView1.Rows(s).Cells(1).Value 'suplierId

        NameTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(2).Value
        AmountTxt.Text = CreditDetailsDataGridView1.Rows(s).Cells(3).Value
        AddDateTimePicker.Value = CreditDetailsDataGridView1.Rows(s).Cells(4).Value
    End Sub

    Private Sub StartDate_ValueChanged(sender As Object, e As EventArgs) Handles StartDate.ValueChanged

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class