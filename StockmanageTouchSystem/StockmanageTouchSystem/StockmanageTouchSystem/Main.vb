Public Class Main
    Private Sub navidationchange()
        Guna2Panel1.Width = 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        AddProducts.Show()
        AddProducts.MdiParent = Me
        'AddProducts.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AddProducts.Show()
        AddProducts.MdiParent = Me
        AddProducts.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Customer.Show()
        Customer.MdiParent = Me
        Customer.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        RetailSale1.Show()
        RetailSale1.MdiParent = Me
        RetailSale1.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        RetailReturn.Show()
        RetailReturn.MdiParent = Me
        RetailReturn.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        PurchaseEntry.Show()
        PurchaseEntry.MdiParent = Me
        PurchaseEntry.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Suplier.Show()
        Suplier.MdiParent = Me
        Suplier.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        FlashScreen.Close()
        Me.Close()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        PurchaseReturn.Show()
        PurchaseReturn.MdiParent = Me
        PurchaseReturn.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        ProfitCalculate.Show()
        ProfitCalculate.MdiParent = Me
        ProfitCalculate.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)
        CreditEntry.Show()
        CreditEntry.MdiParent = Me
        CreditEntry.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        'customer payments
        CustomerPayments.Show()
        CustomerPayments.MdiParent = Me
        CustomerPayments.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        'customer chaque
        CustomerChaque.Show()
        CustomerChaque.MdiParent = Me
        CustomerChaque.WindowState = FormWindowState.Maximized
        navidationchange()

    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs)
        DebitEntry.Show()
        DebitEntry.MdiParent = Me
        DebitEntry.WindowState = FormWindowState.Maximized
        navidationchange()

    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        SuplierPayments.Show()
        SuplierPayments.MdiParent = Me
        SuplierPayments.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs)
        ChaqueOut.Show()
        ChaqueOut.MdiParent = Me
        ChaqueOut.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Guna2Button9.Visible = False
        Guna2Button20.Visible = False
    End Sub



    Private Sub Guna2Button16_Click_1(sender As Object, e As EventArgs) Handles Guna2Button16.Click
        If Guna2Panel1.Width = 177 Then
            Guna2Panel1.Width = 0
        Else
            Guna2Panel1.Width = 177
        End If
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button18.Click
        User.Show()
        User.MdiParent = Me
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs)
        SendMessages.Show()
        SendMessages.MdiParent = Me
        SendMessages.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs)
        AddBalanceProduct.Show()
        AddBalanceProduct.MdiParent = Me
        AddBalanceProduct.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "1010" Then
            Guna2Button9.Visible = True
            Guna2Button20.Visible = True
        Else
            Guna2Button9.Visible = False
            Guna2Button20.Visible = False
        End If
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        stock_predictions.Show()
        stock_predictions.MdiParent = Me
        stock_predictions.WindowState = FormWindowState.Maximized
        navidationchange()
    End Sub
End Class