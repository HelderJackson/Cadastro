Imports System.Data.Common
Imports System.Data.SqlClient

Public Class DataAccess
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Public Sub New()
        conexao = New SqlConnection("Server=SEUSERVIDOR;Database=Porfolio;Trusted_Connection=True; ")
    End Sub

    Public Sub CloseConn()
        If IsNothing(conexao) Then
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End If
    End Sub

    'Função que retorna a Inclusão, Alteração e Exclusão
    Public Function ExecuteQuery(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = True

        Try
            comando = New SqlCommand(SQL, conexao)

            For Each p As SqlParameter In parametros
                comando.Parameters.Add(p)
            Next

            conexao.Open()

            retorno = comando.ExecuteNonQuery()

        Catch ex As Exception
            retorno = False
            Throw New Exception(ex.Message)
        Finally
            comando = Nothing
        End Try

        Return retorno
    End Function

    ' Retorna uma consulta DataSet
    Public Function ExecuteDataSet(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As DataSet
        Dim ds As New DataSet()

        Try
            comando = New SqlCommand(SQL, conexao)

            For Each p As SqlParameter In parametros
                comando.Parameters.Add(p)
            Next

            conexao.Open()
            da = New SqlDataAdapter(comando)
            da.Fill(ds)

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados.")
        Finally
            comando = Nothing
        End Try

        Return ds
    End Function

    ' Retorna uma consulta DataReader
    Public Function ExecuteDataReader(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As DbDataReader

        Try
            comando = New SqlCommand(SQL, conexao)

            For Each p As SqlParameter In parametros
                comando.Parameters.Add(p)
            Next

            conexao.Open()
            dr = comando.ExecuteReader

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados.")
        Finally
            comando = Nothing
        End Try

        Return dr
    End Function

    Public Function ExecuteData(ByVal SQL As String, ByVal parametros As SqlParameter) As DbDataReader

        Try
            comando = New SqlCommand(SQL, conexao)

            comando.Parameters.Add(parametros)

            conexao.Open()
            dr = comando.ExecuteReader

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados.")
        Finally
            comando = Nothing
        End Try

        Return dr
    End Function

    Public Function Selecao(ByVal SQL As String) As DbDataReader

        Try
            comando = New SqlCommand(SQL, conexao)

            conexao.Open()
            dr = comando.ExecuteReader

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados.")
        Finally
            'comando = Nothing
        End Try
        Return dr
    End Function

End Class