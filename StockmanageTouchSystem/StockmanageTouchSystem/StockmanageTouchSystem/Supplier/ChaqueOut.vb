Imports MySql.Data.MySqlClient
Public Class ChaqueOut
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim suplierid As Integer
    Dim StatusTextBox As String
    Dim bank_id As Integer
    Private Sub load_chaque()
        MySqlConn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE 1", MySqlConn)
        adapter.Fill(table)
        bsource.DataSource = table
        ChaquereceivedDataGridView.DataSource = table
        ChaquereceivedDataGridView.Columns(0).Width = 150
        ChaquereceivedDataGridView.Columns(1).Visible = False
        ChaquereceivedDataGridView.Columns(2).Width = 300
        ChaquereceivedDataGridView.Columns(3).Visible = False
        ChaquereceivedDataGridView.Columns(4).Width = 150
        ChaquereceivedDataGridView.Columns(5).Width = 150
        ChaquereceivedDataGridView.Columns(6).Width = 100 'Status' 
        ChaquereceivedDataGridView.Columns(7).Width = 160
        ChaquereceivedDataGridView.Columns(8).Width = 160

        MySqlConn.Close()
        Dim sss As Double = 0
        For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

            sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
            End If

        Next
        Label7.Text = sss.ToString
    End Sub
    Private Sub loadsupplier()
        MySqlConn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Name`,`Address` FROM `supplier` WHERE 1", MySqlConn)
        adapter.Fill(table)
        bsource.DataSource = table
        CustomerDataGridView.DataSource = table
        CustomerDataGridView.Columns(0).Visible = False
        CustomerDataGridView.Columns(1).Width = 450
        CustomerDataGridView.Columns(2).Width = 300
        MySqlConn.Close()
    End Sub

    Private Sub C_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles C_NameTextBox.TextChanged
        MySqlConn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT `id`,`Name`,`Address` FROM `supplier` WHERE 1", MySqlConn)
        adapter.Fill(table)
        bsource.DataSource = table
        CustomerDataGridView.DataSource = table
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("Name Like '%{0}%'", C_NameTextBox.Text)
        CustomerDataGridView.DataSource = dv

        MySqlConn.Close()
    End Sub

    Private Sub ChaqueOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False

        End If
        Me.load_chaque()
        loadsupplier()

        'this is for the printer select function'
        For Each strprinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(strprinterName)
        Next
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.SelectedIndex = 0 'Select defalt'
        ComboBox1.Visible = False

    End Sub

    Private Sub C_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_NameTextBox.KeyPress
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

    Private Sub C_NameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles C_NameTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Up Then
            CustomerDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            CustomerDataGridView.Select()
        End If
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub

    Private Sub CustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        Dim itm As Integer = CustomerDataGridView.CurrentRow.Index
        suplierid = CustomerDataGridView.Rows(itm).Cells(0).Value
        C_NameTextBox.Text = CustomerDataGridView.Rows(itm).Cells(1).Value
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
        BankTextBox.Select()
    End Sub

    Private Sub CustomerDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim itm As Integer = CustomerDataGridView.CurrentRow.Index
            suplierid = CustomerDataGridView.Rows(itm).Cells(0).Value
            C_NameTextBox.Text = CustomerDataGridView.Rows(itm).Cells(1).Value
            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            BankTextBox.Select()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Chq_NoTextBox.Clear()
        C_NameTextBox.Clear()
        BankTextBox.Clear()
        AmountTextBox.Clear()
        Issue_dateDateTimePicker.Select()
    End Sub

    Private Sub BankTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BankTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AmountTextBox.Select()

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Chq_NoTextBox.Text = "" Then
            MessageBox.Show("Please Enter ChqNo")
        Else
            If C_NameTextBox.Text = "" Then
                MessageBox.Show("Please Enter Customer Name")
            Else
                If BankTextBox.Text = "" Then
                    MessageBox.Show("Enter Bank")
                Else
                    If AmountTextBox.Text = "" Then
                        MessageBox.Show("Enter Chaque Amount")
                    Else
                        Dim State As String = "PENDING"
                        Dim startDate As String
                        Dim CloseDate As String
                        Dim chqno As String = Chq_NoTextBox.Text
                        Dim nchqn As String = chqno.Trim()

                        startDate = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")
                        CloseDate = Format(Me.Close_dateDateTimePicker.Value, "yyyy-MM-dd")
                        Try
                            Dim Query As String
                            MySqlConn.Open()
                            Query = "INSERT INTO `supplier_chaque` (`Chq_No`, `Supplier_id`, `Name`, `Bank_id`, `Bank`, `Amount`, `Status`, `Issue_Date`, `Close_Date`) VALUES ('" & chqno & "', '" & suplierid & "', '" & C_NameTextBox.Text & "', '1', '" & BankTextBox.Text & "', '" & AmountTextBox.Text & "', '" & State & "', '" & startDate & "', '" & CloseDate & "'); "
                            COMMAND = New MySqlCommand(Query, MySqlConn)
                            READER = COMMAND.ExecuteReader
                            MySqlConn.Close()
                            load_chaque()
                            Chq_NoTextBox.Clear()
                            C_NameTextBox.Clear()
                            BankTextBox.Clear()
                            AmountTextBox.Clear()
                            Chq_NoTextBox.Select()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            MySqlConn.Close()
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If TextBox3.Text = "40012" Then
            'This button for the delete'
            Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim Query As String
                    MySqlConn.Open()

                    Query = "DELETE FROM `supplier_chaque` WHERE `supplier_chaque`.`Chq_No` = '" & Chq_NoTextBox.Text & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    load_chaque()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                    MySqlConn.Close()
                End Try
            End If
        Else
            MessageBox.Show("You Cann't Delete This chaque You Are Not Admin")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        'This is the paid button'
        If StatusTextBox = "RETURNED" Then
            MsgBox("This is a Return Chaque ")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you Sure you want make this chaque as paid", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                StatusTextBox = "REALISED"

                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "UPDATE `supplier_chaque` SET `Status` = '" & StatusTextBox & "' where Chq_No='" & Chq_NoTextBox.Text & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    load_chaque()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        'This is the Return button'
        If StatusTextBox = "REALISED" Then
            MsgBox("This is a Realised Chaque ")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you Sure you want make this chaque as Return", "OR Not", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                StatusTextBox = "RETURNED"

                Try
                    Dim Query As String
                    MySqlConn.Open()
                    Query = "UPDATE `supplier_chaque` SET `Status` = '" & StatusTextBox & "' where Chq_No='" & Chq_NoTextBox.Text & "'"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                    load_chaque()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            End If

        End If
    End Sub

    Private Sub Chq_NoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Chq_NoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            C_NameTextBox.Select()
        End If
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox6.TextChanged
        If CheckBox1.Checked = False Then
            'state seach'
            '--------------------'
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Status Like '%{0}%'", Guna2TextBox6.Text)
            ChaquereceivedDataGridView.DataSource = dv



            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        Else
            'state seach'
            '--------------------'
            conn.Open()
            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Status Like '%{0}%'", Guna2TextBox6.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        End If
    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged
        If CheckBox1.Checked = True Then
            'This is for the Customer seach'
            '--------------------'
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Name Like '%{0}%'", Guna2TextBox5.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        Else
            'This is for the Customer seach'
            '--------------------'
            conn.Open()
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Name Like '%{0}%'", Guna2TextBox5.Text)
            ChaquereceivedDataGridView.DataSource = dv

            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        End If

    End Sub

    Private Sub ChaquereceivedDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ChaquereceivedDataGridView.CellContentClick

    End Sub

    Private Sub ChaquereceivedDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ChaquereceivedDataGridView.CellClick
        Dim k As Integer
        '`Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date`'

        k = ChaquereceivedDataGridView.CurrentRow.Index
        Chq_NoTextBox.Text = ChaquereceivedDataGridView.Rows(k).Cells(0).Value.ToString
        suplierid = ChaquereceivedDataGridView.Rows(k).Cells(1).Value 'Supplier_id
        C_NameTextBox.Text = ChaquereceivedDataGridView.Rows(k).Cells(2).Value.ToString
        bank_id = ChaquereceivedDataGridView.Rows(k).Cells(3).Value 'bank_id'
        BankTextBox.Text = ChaquereceivedDataGridView.Rows(k).Cells(4).Value.ToString
        AmountTextBox.Text = ChaquereceivedDataGridView.Rows(k).Cells(5).Value.ToString
        StatusTextBox = ChaquereceivedDataGridView.Rows(k).Cells(6).Value.ToString

        Issue_dateDateTimePicker.Value = ChaquereceivedDataGridView.Rows(k).Cells(7).Value.ToString
        Close_dateDateTimePicker.Value = ChaquereceivedDataGridView.Rows(k).Cells(8).Value.ToString
    End Sub

    Private Sub Guna2TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox7.TextChanged
        If CheckBox1.Checked = True Then
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Bank Like '%{0}%'", Guna2TextBox7.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        Else
            conn.Open()
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Bank Like '%{0}%'", Guna2TextBox7.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        End If
    End Sub

    Private Sub Guna2TextBox8_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox8.TextChanged
        If CheckBox1.Checked = True Then
            conn.Open()

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque`", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Chq_No Like '%{0}%'", Guna2TextBox8.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        Else
            conn.Open()
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table
            Dim dv As New DataView(table)

            dv.RowFilter = String.Format("Chq_No Like '%{0}%'", Guna2TextBox8.Text)
            ChaquereceivedDataGridView.DataSource = dv


            conn.Close()
            Dim sss As Double = 0
            For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

                sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
                End If
                If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
                End If

            Next
            Label7.Text = sss.ToString


            '----------------'
        End If
    End Sub

    Private Sub gettotandcolor()
        Dim sss As Double = 0
        For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

            sss = sss + ChaquereceivedDataGridView.Rows(s).Cells(5).Value


            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
            End If

        Next
        Label7.Text = sss.ToString
    End Sub

    Private Sub getchaquefordate()
        If Guna2TextBox6.Text = "" Then
            conn.Open()
            Dim Stadate As String
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date like '" & Stadate & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table

            conn.Close()
            gettotandcolor()
        Else
            Dim state As String = Guna2TextBox6.Text
            conn.Open()
            Dim Stadate As String
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date like '" & Stadate & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table

            Dim dv As New DataView(table)
            dv.RowFilter = String.Format("Status Like '%{0}%'", state)
            ChaquereceivedDataGridView.DataSource = dv

            conn.Close()
            gettotandcolor()
        End If
    End Sub

    Private Sub getdatediff()
        If Guna2TextBox6.Text = "" Then
            conn.Open()
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table

            conn.Close()
            gettotandcolor()
        Else
            Dim state As String = Guna2TextBox6.Text
            conn.Open()
            Dim Stadate As String
            Dim enddat As String
            enddat = Format(Me.DateTimePicker2.Value, "yyy-MM-dd")
            Stadate = Format(Me.DateTimePicker1.Value, "yyyy-MM-dd")

            Dim bsource As New BindingSource
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT `Chq_No`,`Supplier_id`,`Name`,`Bank_id`,`Bank`,`Amount`,`Status`,`Issue_Date`,`Close_Date` FROM `supplier_chaque` WHERE Close_Date BETWEEN '" & Stadate & "' And '" & enddat & "'", conn)
            adapter.Fill(table)
            bsource.DataSource = table
            ChaquereceivedDataGridView.DataSource = table

            Dim dv As New DataView(table)
            dv.RowFilter = String.Format("Status Like '%{0}%'", state)
            ChaquereceivedDataGridView.DataSource = dv

            conn.Close()
            gettotandcolor()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        getchaquefordate()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        getdatediff()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Guna2TextBox6.Text = "RETURNED"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(5).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Guna2TextBox6.Text = "REALISED"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(5).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Guna2TextBox6.Text = "PENDING"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(5).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub ChaquereceivedDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ChaquereceivedDataGridView.ColumnHeaderMouseClick
        For s As Integer = 0 To ChaquereceivedDataGridView.Rows.Count - 1 Step +1

            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "PENDING" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Yellow
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "RETURNED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.Red
            End If
            If ChaquereceivedDataGridView.Rows(s).Cells(6).Value = "REALISED" Then
                ChaquereceivedDataGridView.Rows(s).DefaultCellStyle.BackColor = Color.YellowGreen
            End If

        Next
    End Sub
    Private Sub Issue_dateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Issue_dateDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chq_NoTextBox.Select()
        End If
    End Sub

    Private Sub Close_dateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Close_dateDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub AmountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Close_dateDateTimePicker.Select()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ComboBox1.Visible = True
        Else
            ComboBox1.Visible = False

        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click

        Dim chqrep As New ChaqueOutReport
        chqrep.Refresh()
        'cryRpt.RecordSelectionFormula = "{selling_view1.sid} = " & sid & ""
        chqrep.Refresh()
        chqrep.PrintOptions.PrinterName = Me.ComboBox1.Text 'print by selected combobox'
        chqrep.PrintToPrinter(0, False, 1, 1)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class