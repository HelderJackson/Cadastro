Imports DBOCadastro
Imports System.Data.SqlClient

Public Class frmPesquisaEmpresa
    Public Property ID As Integer

    Private Sub btnPesquisarEmpresa_Click(sender As Object, e As EventArgs) Handles btnPesquisaEmpresa.Click
        Dim associado As New Associado
        Dim ds As DataSet
        Dim par As New List(Of SqlParameter)

        Try

            If txtNome.TextLength > 0 And txtCNPJ.TextLength > 0 Then
                par.Add(New SqlParameter("@NOME", txtNome.Text))
                par.Add(New SqlParameter("@CNPJ", txtCNPJ.Text))
                ds = associado.ConsultaDataSet("SELECT * FROM EMPRESAS WHERE NOMEDAEMPRESA LIKE '%' + @NOME + '%' and CNPJ LIKE '%' + @CNPJ + '%'", par)
            Else
                If txtNome.TextLength > 0 Then
                    par.Add(New SqlParameter("@NOME", txtNome.Text))
                    ds = associado.ConsultaDataSet("SELECT * FROM EMPRESAS WHERE NOMEDAEMPRESA LIKE '%' + @NOME + '%'", par)
                End If

                If txtCNPJ.TextLength > 0 Then
                    par.Add(New SqlParameter("@CNPJ", txtCNPJ.Text))
                    ds = associado.ConsultaDataSet("SELECT * FROM EMPRESAS WHERE CNPJ LIKE '%' + @CNPJ + '%'", par)
                End If

                If txtNome.TextLength = 0 And txtCNPJ.TextLength = 0 Then
                    ds = associado.ConsultaDataSet("SELECT * FROM EMPRESAS", par)
                End If

            End If

            dvgDadosEmpresa.AutoGenerateColumns = False
            dvgDadosEmpresa.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvDados_DoubleClick(sender As Object, e As EventArgs) Handles dvgDadosEmpresa.DoubleClick
        If dvgDadosEmpresa.Rows.Count > 0 Then
            ID = dvgDadosEmpresa.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub

    Private Sub dgvDados_KeyDown(sender As Object, e As KeyEventArgs) Handles dvgDadosEmpresa.KeyDown
        If dvgDadosEmpresa.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            ID = dvgDadosEmpresa.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub
End Class