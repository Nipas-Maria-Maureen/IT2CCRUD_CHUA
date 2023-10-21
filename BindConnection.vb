Imports MySql.Data.MySqlClient
Module BindConnection
    Dim conString As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim sqlquery As String
    Dim hostname, dbasename, user, pass As String
    Dim fname, lname, position, dept As String
    Dim adapter As MySqlDataAdapter
    Dim data As DataTable
    Public Sub dbConnect()
        hostname = "127.0.0.1"
        dbasename = "it2coop"
        user = "root"
        pass = "password"
        'check if connection is open
        If Not conString Is Nothing Then
            conString.Close()
            'establish the connection
            conString.ConnectionString = "server =" &
                hostname & ";user id=" & user & ";password=" &
                pass & ";database=" & dbasename & ""

            Try
                conString.Open()
                MessageBox.Show("CONNECTED")
            Catch ex As Exception
                MessageBox.Show("Error." & ex.Message)


            End Try

        End If
    End Sub
    Public Sub AddRec()
        fname = Form1.txtfname.Text
        lname = Form1.txtlname.Text
        position = Form1.txtpos.Text
        dept = Form1.txtdept.Text
        sqlquery = "insert into employee(empfname, emplname, position, dept)VALUES(@fname, @lname, @position, @dept)"
        'psas query and connection string to mysqlcommand
        cmd = New MySqlCommand(sqlquery, conString)
        'assign the parameter value
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@lname", lname)
        cmd.Parameters.AddWithValue("@position", position)
        cmd.Parameters.AddWithValue("@dept", dept)
        'execute the insert query command
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added Success./.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cleartextfield()


        End Try

    End Sub
    Private Sub cleartextfield()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtpos.Clear()
        Form1.txtdept.Clear()

    End Sub

    Public Sub FindRecord(empid As String)
        sqlquery = "SELECT * FROM employee where empid = @empid"
        cmd = New MySqlCommand(sqlquery, conString)
        cmd.Parameters.AddWithValue("@empid", empid)
        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Form1.txtfirstname.Text = reader("empfname").ToString
                Form1.txtlastname.Text = reader("emplname").ToString
                Form1.txtposition.Text = reader("position").ToString
                Form1.txtdepartment.Text = reader("dept").ToString
            Else
                MsgBox("NO RECORD FOUND!!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            reader.Close()

        End Try
    End Sub

    Public Sub loadDepartment()
        sqlquery = "SELECT deptname from department"

        Try
            cmd = New MySqlCommand(sqlquery, conString)
            reader = cmd.ExecuteReader
            While reader.Read()
                Form3.Cbodept.Items.Add(reader("deptname").ToString)
            End While

        Catch ex As Exception

        MsgBox(ex.Message)

        Finally

        conString.Close()

        End Try

    End Sub
    Public Sub loadrecord()
        sqlquery = "select e.emplname, e.empfname, d.deptname from employee e join department d on e.dept
         = d.deptid"
        adapter = New MySqlDataAdapter(sqlquery, conString)
        Try
            data = New DataTable
            adapter.Fill(data)
            Form3.dgvinfo.DataSource = data
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub loadrec(dept As String)
        sqlquery = "select e.emplname, e.empfname, d.deptname from employee e join department d on
        e.dept = d.deptid where dept = @dept"

        adapter = New MySqlDataAdapter(sqlquery, conString)
        adapter.SelectCommand.Parameters.AddWithValue("@dept", dept)
        Try
            data = New DataTable
            adapter.Fill(data)
            Form3.dgvinfo.DataSource = data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
