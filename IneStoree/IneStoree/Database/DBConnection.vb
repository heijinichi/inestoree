Option Explicit On
Option Strict On

Imports MySql.Data.MySqlClient
Imports System.Data
Module MySQL_Connetion
    Dim host As String = "server=localhost;"
    Dim port As String = "port=3306;"
    Dim db As String = "database=inestoree;"
    Dim user As String = "user=root;"
    Dim pass As String = "password=1234;"
    Public Function GetConnectionString() As String

        Dim ConString As String = String.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass)
        Return ConString

    End Function

    Public Con As New MySqlConnection(GetConnectionString())
    Public Cmd As MySqlCommand
    Public Sql As String = ""


    Public Function PerformCRUD(Com As MySqlCommand) As DataTable

        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try
            da = New MySqlDataAdapter()
            da.SelectCommand = Com
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("An error occurred:" & ex.Message, "Perform CRUD Operations Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            dt = Nothing

        End Try

        Return dt
    End Function

End Module
