Imports System.Data.SqlClient
Imports DBOCadastro

Public Class frmPesquisa
    Public Property ID As Integer

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim associado As New Associado
        Dim ds As DataSet
        Dim par As New List(Of SqlParameter)

        Try

            If txtNome.TextLength > 0 And txtCPF.TextLength > 0 Then
                par.Add(New SqlParameter("@NOME", txtNome.Text))
                par.Add(New SqlParameter("@CPF", txtCPF.Text))
                ds = associado.ConsultaDataSet("SELECT * FROM ASSOCIADOS WHERE NOME LIKE '%' + @NOME + '%' and CPF LIKE '%' + @CPF + '%'", par)
            Else
                If txtNome.TextLength > 0 Then
                    par.Add(New SqlParameter("@NOME", txtNome.Text))
                    ds = associado.ConsultaDataSet("SELECT * FROM ASSOCIADOS WHERE NOME LIKE '%' + @NOME + '%'", par)
                End If

                If txtCPF.TextLength > 0 Then
                    par.Add(New SqlParameter("@CPF", txtCPF.Text))
                    ds = associado.ConsultaDataSet("SELECT * FROM ASSOCIADOS WHERE CPF LIKE '%' + @CPF + '%'", par)
                End If

                If txtNome.TextLength = 0 And txtCPF.TextLength = 0 Then
                    ds = associado.ConsultaDataSet("SELECT * FROM ASSOCIADOS", par)
                End If
            End If

            dgvDados.AutoGenerateColumns = False
            dgvDados.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvDados_DoubleClick(sender As Object, e As EventArgs) Handles dgvDados.DoubleClick
        If dgvDados.Rows.Count > 0 Then
            ID = dgvDados.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub

    Private Sub dgvDados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDados.KeyDown
        If dgvDados.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            ID = dgvDados.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub
End Class