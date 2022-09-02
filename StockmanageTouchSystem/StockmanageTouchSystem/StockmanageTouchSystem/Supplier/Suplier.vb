Imports MySql.Data.MySqlClient
Public Class Suplier
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader


    Private Sub load_supplier()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select id,Name,Address,City,TelNo,Fax,RegDate from supplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        SupplierDataGridView.DataSource = table
        SupplierDataGridView.Columns(0).Width = 50
        SupplierDataGridView.Columns(1).Width = 300
        SupplierDataGridView.Columns(2).Width = 350
        SupplierDataGridView.Columns(3).Width = 150
        SupplierDataGridView.Columns(4).Width = 150
        conn.Close()
    End Sub
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select id,Name,Address,City,TelNo,Fax,RegDate from supplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        SupplierDataGridView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("Name Like '%{0}%'", Guna2TextBox2.Text)
        SupplierDataGridView.DataSource = dv

        conn.Close()
        '----------------'
    End Sub

    Private Sub Suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_supplier()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        NameTextBox.Clear()
        CityTextBox.Clear()
        AddressTextBox.Clear()
        Tel_NoTextBox.Clear()
        FaxTextBox.Clear()
        NameTextBox.Select()
    End Sub

    Private Sub NameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            CityTextBox.Select()
        End If
    End Sub

    Private Sub CityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddressTextBox.Select()

        End If
    End Sub

    Private Sub AddressTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tel_NoTextBox.Select()
        End If
    End Sub

    Private Sub Tel_NoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Tel_NoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            FaxTextBox.Select()

        End If
    End Sub

    Private Sub FaxTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FaxTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Issue_dateDateTimePicker.Select()
        End If
    End Sub

    Private Sub Issue_dateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Issue_dateDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveBtn.PerformClick()
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NameTextBox.Text = "" Then
            MsgBox("Please Enter Supplier Name")
        Else
            Dim name As String = NameTextBox.Text.Trim()
            Dim address As String = AddressTextBox.Text.Trim()


            Dim currentDate As String = Format(Me.Issue_dateDateTimePicker.Value, "yyyy-MM-dd")
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "insert into supplier (Name,Address,City,TelNo,Fax,RegDate) values ('" & name & "','" & address & "','" & CityTextBox.Text & "','" & Tel_NoTextBox.Text & "','" & FaxTextBox.Text & "','" & currentDate & "')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MySqlConn.Close()
            End Try
            NameTextBox.Clear()
            CityTextBox.Clear()
            AddressTextBox.Clear()
            Tel_NoTextBox.Clear()
            FaxTextBox.Clear()
            NameTextBox.Select()
            load_supplier()

        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If NoTextBox.Text = "" Then
            MessageBox.Show("Please Select The Item")
        Else
            Dim name As String = NameTextBox.Text.Trim()
            Dim address As String = AddressTextBox.Text.Trim()

            Try
                Dim Query As String
                MySqlConn.Open()


                Query = "update supplier set Name='" & name & "',Address='" & address & "',City='" & CityTextBox.Text & "',TelNo='" & Tel_NoTextBox.Text & "',Fax='" & FaxTextBox.Text & "' where id='" & NoTextBox.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
                MessageBox.Show("DATA UPDATE")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MySqlConn.Close()
            End Try
            load_supplier()

        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim COMMAND As MySqlCommand

            Dim READER As MySqlDataReader
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "delete  from supplier where id='" & NoTextBox.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
                MessageBox.Show("DATA Delete")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MySqlConn.Close()
            End Try
            load_supplier()

        End If
    End Sub

    Private Sub SupplierDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellContentClick

    End Sub

    Private Sub SupplierDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellClick
        Dim a As Integer = SupplierDataGridView.CurrentRow.Index
        NoTextBox.Text = SupplierDataGridView.Rows(a).Cells(0).Value.ToString
        NameTextBox.Text = SupplierDataGridView.Rows(a).Cells(1).Value.ToString
        CityTextBox.Text = SupplierDataGridView.Rows(a).Cells(3).Value.ToString
        AddressTextBox.Text = SupplierDataGridView.Rows(a).Cells(2).Value.ToString
        Tel_NoTextBox.Text = SupplierDataGridView.Rows(a).Cells(4).Value.ToString
        FaxTextBox.Text = SupplierDataGridView.Rows(a).Cells(5).Value.ToString
        Issue_dateDateTimePicker.Value = SupplierDataGridView.Rows(a).Cells(6).Value


    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        '--------------------'
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select id,Name,Address,City,TelNo,Fax,RegDate from supplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        SupplierDataGridView.DataSource = table
        Dim dv As New DataView(table)

        dv.RowFilter = String.Format("City Like '%{0}%'", Guna2TextBox1.Text)
        SupplierDataGridView.DataSource = dv

        conn.Close()
        '----------------'
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class