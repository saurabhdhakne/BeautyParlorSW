Public Class Services

    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.Database1DataSet2.Services)

    End Sub
End Class