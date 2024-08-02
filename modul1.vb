Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Public Class ClsKoneksi
    Protected tblUser = New DataTable
    Protected SQL As String
    Protected Cn As MySqlConnection
    Protected Cmd As MySqlCommand
    Protected Da As MySqlDataAdapter
    Protected Ds As DataSet
    Protected Dt As DataTable
    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost;User Id=root;database=dbmotor;Convert Zero Datetime=True")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub
    Public Sub ExecuteNonQueryWithParameters(ByVal Query As String, ByVal parameters As List(Of MySqlParameter))
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If

        Cmd = New MySqlCommand(Query, Cn)
        Cmd.Parameters.AddRange(parameters.ToArray())
        Cmd.ExecuteNonQuery()

        CloseConn()
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        Try
            Using Cn As New MySqlConnection("server=localhost;User Id=root;database=dbmotor;Convert Zero Datetime=True")
                Cn.Open()
                Cmd = New MySqlCommand(Query, Cn)
                Da = New MySqlDataAdapter(Cmd)
                Ds = New Data.DataSet
                Da.Fill(Ds)
                Return Ds.Tables(0)
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        Try
            Using Cn As New MySqlConnection("server=localhost;User Id=root;database=dbmotor;Convert Zero Datetime=True")
                Cn.Open()
                Cmd = New MySqlCommand(Query, Cn)
                Cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class