Public Class Associacao

#Region "Propriedades"
    Public Property ID As Integer
    Public Property AssociadoID As Integer
    Public Property EmpresaID As Integer

    Public Property NomeAssociado As String
    Public Property NomeEmpresa As String

#End Region

#Region "Funções"
    Public Function NovaAssociacao(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
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

    Public Function AlterarAssociacao(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
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

    Public Function DeleteAssociacao(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
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
                NomeAssociado = dr("Nome")
                NomeEmpresa = dr("NomeDaEmpresa")
                retorno = True
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try


        Return retorno
    End Function

    Public Function ValidaAssociacao(ByVal SQL As String, ByVal parametros As List(Of SqlClient.SqlParameter)) As Boolean
        Dim dr As IDataReader
        Dim banco As New DataAccess
        Dim retorno As Boolean = False

        Try
            dr = banco.ExecuteDataReader(SQL, parametros)

            While dr.Read
                AssociadoID = dr("AssociadoID")
                EmpresaID = dr("EmpresaID")
                retorno = True
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
            parametros.Clear()
        End Try

        Return retorno
    End Function

#End Region

End Class