Imports System.Data.SqlClient

Public Class Registration

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\vb.net\parlor\parlor\parlor\Database1.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Customers where username='" & user.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Username  is  Already Registered", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            cmd = New SqlCommand("insert into Customers (Username, Contact, Age, Address) values ('" & user.Text & "','" & contact.Text & "','" & age.Text & "','" & address.Text & "')", con)

            If (user.Text = "" And contact.Text = "" And age.Text = "" And address.Text = "") Then
                MessageBox.Show("Please Enter The Details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                Me.Hide()
                Form1.Show()

                user.Clear()
                contact.Clear()
                age.Clear()
                address.Clear()

            End If
            con.Close()
        End If
        con.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        user.Clear()
        contact.Clear()
        age.Clear()
        address.Clear()
    End Sub
End Class