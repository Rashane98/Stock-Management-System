Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class User
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim uid As Integer
    Dim username As String

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Close()
    End Sub
    Private Sub load_log()
        conn.Open()

        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select Uid,username from userlog", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        DataGridView1.DataSource = table
        DataGridView1.Columns(0).Width = 40
        DataGridView1.Columns(1).Width = 300

        conn.Close()
    End Sub
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_log()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unameTxt.Clear()
        passtxt.Clear()
        unameTxt.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim password As String
        Dim passwordSHA As String

        password = passtxt.Text

        Call passwordEncryptSHA(password) ' Lets call the first password encryption function for SHA1

        passwordSHA = passwordEncryptSHA(password) ' give the variable the returned SHA value

        Try
            Dim Query As String
            MySqlConn.Open()
            Query = "insert into userlog (username,password) values ('" & unameTxt.Text & "', '" & passwordSHA & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
            unameTxt.Clear()
            passtxt.Clear()
            MessageBox.Show("New UserName And Password Is Add to System")
            load_log()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub
    Public Function passwordEncryptSHA(ByVal password As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(password) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' boom there goes the encrypted password!

    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim password As String
        Dim passwordSHA As String
        password = passtxt.Text

        Call passwordEncryptSHA(password) ' Lets call the first password encryption function for SHA1

        passwordSHA = passwordEncryptSHA(password) ' give the variable the returned SHA value


        Try
            Dim Query As String
            MySqlConn.Open()


            Query = "update userlog set username='" & unameTxt.Text & "',password='" & passwordSHA & "' where Uid = '" & uid & "' "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
            MessageBox.Show("User Update")
            unameTxt.Clear()
            passtxt.Clear()
            MessageBox.Show("Edit User Name And Password")
            load_log()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MySqlConn.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you Sure to Delete This", "OR Not", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim COMMAND As MySqlCommand

            Dim READER As MySqlDataReader
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "delete  from userlog where Uid='" & uid & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MySqlConn.Close()
                MessageBox.Show("DATA Delete")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MySqlConn.Close()
            End Try
            load_log()

        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim a As Integer = DataGridView1.CurrentRow.Index
        uid = DataGridView1.Rows(a).Cells(0).Value.ToString
        unameTxt.Text = DataGridView1.Rows(a).Cells(1).Value.ToString

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim a As Integer = DataGridView1.CurrentRow.Index
        uid = DataGridView1.Rows(a).Cells(0).Value.ToString
        unameTxt.Text = DataGridView1.Rows(a).Cells(1).Value.ToString
    End Sub

    Private Sub unameTxt_TextChanged(sender As Object, e As EventArgs) Handles unameTxt.TextChanged

    End Sub

    Private Sub unameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles unameTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            passtxt.Select()

        End If
    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged

    End Sub

    Private Sub passtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        End If
    End Sub
End Class