Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Services.Show()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        AdminLogin.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Registration.Show()
        
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet5.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.Database1DataSet5.Services)
        'TODO: This line of code loads data into the 'Database1DataSet1.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter2.Fill(Me.Database1DataSet1.Customers)
        'TODO: This line of code loads data into the 'Database1DataSet4.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter1.Fill(Me.Database1DataSet4.Customers)
        'TODO: This line of code loads data into the 'Database1DataSet3.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Database1DataSet3.Customers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles print.Click
        bill.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        rate.Clear()
        total.Text = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim a As Integer
        Dim b As Integer
        Dim sum As Integer

        a = total.Text
        b = rate.Text
        sum = a + b
        total.Text = sum


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer
        Dim b As Integer
        Dim subt As Integer

        a = total.Text
        b = rate.Text
        subt = a - b
        total.Text = subt
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Gallery.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        About.Show()

    End Sub
End Class
