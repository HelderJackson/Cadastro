Imports System.Data.SqlClient
Imports System.Text

Public Class Empresa

#Region "Propriedades"
    Public Property ID As Integer
    Public Property NomeDaEmpresa As String
    Public Property CNPJ As String
#End Region

#Region "Funções"
    Public Function NovaEmpresa(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function AlterarEmpresa(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeleteEmpresa(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function ConsultaDataSet(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As DataSet
        Dim ds As DataSet
        Dim banco As New DataAccess

        Try
            ds = banco.ExecuteDataSet(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return ds
    End Function

    Public Function ConsultarDataReader(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
        Dim dr As IDataReader
        Dim banco As New DataAccess
        Dim retorno As Boolean = False

        Try
            dr = banco.ExecuteDataReader(SQL, parametros)

            While dr.Read
                If Not IsDBNull(dr("NomeDaEmpresa")) Then NomeDaEmpresa = dr("NomeDaEmpresa")
                If Not IsDBNull(dr("CNPJ")) Then CNPJ = dr("CNPJ")
                retorno = True
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try
        Return retorno
    End Function

    Public Function ValidarCNPJSomenteNumeros(ByVal campo As String) As Boolean
        Dim padraoRegex As String = "^[0-9]*$"
        Dim verifica As New RegularExpressions.Regex(padraoRegex)
        'variavel boolean para tratar o status
        Dim valida As Boolean = False
        'usa o método IsMatch Method para validar o regex
        valida = verifica.IsMatch(campo, 0)
        Return valida
    End Function

    Public Function VerificaCNPJUnico(ByVal SQL As String, ByVal parametros As SqlParameter) As Boolean
        Dim dr As IDataReader
        Dim banco As New DataAccess
        Dim retorno As Boolean = False

        Try
            dr = banco.ExecuteData(SQL, parametros)

            While dr.Read
                CNPJ = dr("CNPJ")
                retorno = True
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function ConsultarDataReaderAssociado(ByVal SQL As String) As DataTable
        Dim dt As New DataTable
        Dim dr As IDataReader
        Dim banco As New DataAccess

        Try
            dr = banco.Selecao(SQL)

            dt.Load(dr)
            Dim linha As DataRow
            linha = dt.NewRow
            linha("NomeDaEmpresa") = ""
            dt.Rows.InsertAt(linha, 0)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return dt
    End Function

    Public Function VerificaSeEstaAssociado(ByVal SQL As String, ByVal parametros As SqlParameter) As Boolean
        Dim dr As IDataReader
        Dim banco As New DataAccess
        Dim retorno As Boolean = False

        Try
            dr = banco.ExecuteData(SQL, parametros)

            While dr.Read
                ID = dr("ID")
                retorno = True
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno
    End Function

#End Region

End Class