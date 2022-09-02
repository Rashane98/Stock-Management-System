Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Text
Imports System.IO
Public Class SendMessages
    Dim logincookie As CookieContainer
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
    Private Sub SendMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_supplier()
    End Sub

    Private Sub SupplierDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellContentClick

    End Sub

    Private Sub SupplierDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellClick
        Dim a As Integer = SupplierDataGridView.CurrentRow.Index

        NameTextBox.Text = SupplierDataGridView.Rows(a).Cells(1).Value.ToString

        Tel_NoTextBox.Text = SupplierDataGridView.Rows(a).Cells(4).Value.ToString


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

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Dim postData As String = "referer=http%3A%2F%2Fforums.zybez.net%2Findex.php%3Fapp%3Dcore%26module%3Dglobal%26section%3Dlogin"
            Dim tempCookies As New CookieContainer
            Dim encoding As New UTF8Encoding
            Dim byteData As Byte() = encoding.GetBytes(postData)

            Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://localhost/SendSms/"), HttpWebRequest)
            postReq.Method = "POST"
            postReq.KeepAlive = True
            postReq.CookieContainer = tempCookies
            postReq.ContentType = "application/x-www-form-urlencoded"
            postReq.Referer = "https://localhost/SendSms/"
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
            postReq.ContentLength = byteData.Length

            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse

            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            logincookie = tempCookies
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

            Dim thepage As String = postreqreader.ReadToEnd

            RichTextBox1.Text = thepage
        Catch ex As Exception
            MessageBox.Show("Message Send Sucess")
        End Try

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        Main.Guna2Panel1.Width = 177
        Me.Close()
    End Sub
End Class