Imports System.Data.SqlClient

Public Class adminPanel

    Private Sub adminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()
    End Sub

    Public Sub Load_data()
        'TODO: This line of code loads data into the 'Database1DataSet1.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Database1DataSet1.Customers)
        'TODO: This line of code loads data into the 'Database1DataSet.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.Database1DataSet.Services)


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\vb.net\parlor\parlor\parlor\Database1.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Services where Service='" & service.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Service  is  Already Exist", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            cmd = New SqlCommand("insert into Services (Service, Rate) values ('" & service.Text & "','" & rate.Text & "')", con)

            If (service.Text = "" And rate.Text = "") Then
                MessageBox.Show("Please Enter The Details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Service Inserted Successfully", MsgBoxStyle.Information, "Success")
                Load_data()
                service.Clear()
                rate.Clear()

            End If
            con.Close()
        End If
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\vb.net\parlor\parlor\parlor\Database1.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        If (service.Text = "") Then
            MessageBox.Show("Please Enter The Service Name Whice You Want to Delete")
        Else
            cmd.CommandText = "DELETE from Services where Service='" & service.Text & "' "
            dr = cmd.ExecuteReader
            MessageBox.Show("Service Deleted Successfully")
        End If



    End Sub


End Class