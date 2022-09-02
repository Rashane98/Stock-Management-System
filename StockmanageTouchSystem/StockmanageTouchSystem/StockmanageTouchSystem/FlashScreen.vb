Public Class FlashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "initializing System..."
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Loading all Components..."
        ElseIf ProgressBar1.Value <= 60 Then
            Label1.Text = "Integrating Database..."
        ElseIf ProgressBar1.Value <= 90 Then
            Label1.Text = "Please Wait..."
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Welcome to SRM..."

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class