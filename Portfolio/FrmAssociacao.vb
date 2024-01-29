Imports System.Data.SqlClient
Imports DBOCadastro

Public Class FrmAssociacao
    Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum

    Private Sub AtivaDesativa(ByVal Valor As Boolean)
        cmbAssociado.Enabled = Valor
        cmbEmpresa.Enabled = Valor
    End Sub

    Private intOpcao As Opcao

    Private Sub tbsIncluirAssociacao_Click(sender As Object, e As EventArgs) Handles tsbIncluirAssociacao.Click
        intOpcao = Opcao.Incluir

        AtivaDesativa(True)

        tsbIncluirAssociacao.Enabled = True
        tsbEditarAssociacao.Enabled = True
        tsbConsultarAssociacao.Enabled = True
        tsbSalvarAssociacao.Enabled = True
        tsbCancelarAssociacao.Enabled = True

        cmbAssociado.Focus()

    End Sub

    Private Sub tsbEditarAssociacao_Click(sender As Object, e As EventArgs) Handles tsbEditarAssociacao.Click
        intOpcao = Opcao.Editar

        txtID.Enabled = True
        txtID.Focus()
        cmbAssociado.Enabled = False
        cmbEmpresa.Enabled = False

        tsbIncluirAssociacao.Enabled = False
        tsbEditarAssociacao.Enabled = False
        tsbConsultarAssociacao.Enabled = False
        tsbCancelarAssociacao.Enabled = True
    End Sub

    Private Sub tsbConsultarAssociacao_Click(sender As Object, e As EventArgs) Handles tsbConsultarAssociacao.Click
        intOpcao = Opcao.Consultar

        txtID.Enabled = True
        txtID.Focus()
        cmbAssociado.Enabled = False
        cmbEmpresa.Enabled = False


        tsbIncluirAssociacao.Enabled = False
        tsbEditarAssociacao.Enabled = False
        tsbConsultarAssociacao.Enabled = False
        tsbCancelarAssociacao.Enabled = True
    End Sub

    Private Sub tsbCancelarAssociacao_Click(sender As Object, e As EventArgs) Handles tsbCancelarAssociacao.Click
        intOpcao = Opcao.Cancelar

        AtivaDesativa(False)
        txtID.Enabled = False
        txtID.Clear()
        cmbAssociado.Text = ""
        cmbEmpresa.Text = ""


        tsbIncluirAssociacao.Enabled = True
        tsbEditarAssociacao.Enabled = True
        tsbConsultarAssociacao.Enabled = True
        tsbDeletarAssociacao.Enabled = False
        tsbSalvarAssociacao.Enabled = False
        tsbCancelarAssociacao.Enabled = False
    End Sub

    Private Sub tsbSalvarAssociacao_Click(sender As Object, e As EventArgs) Handles tsbSalvarAssociacao.Click
        Dim associacao As New Associacao
        Dim par As New List(Of SqlParameter)
        Dim parametro As SqlParameter
        Dim SQL As String

        Try
            Select Case intOpcao
                Case Opcao.Incluir
                    SQL = "INSERT INTO ASSOCIADOSEMPRESAS ("

                    If Convert.ToInt32(cmbAssociado.SelectedValue) = 0 Then
                        epValidaAssociacao.SetError(cmbAssociado, "Informe o Associado")
                        cmbAssociado.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@AssociadoID", Convert.ToInt32(cmbAssociado.SelectedValue)))
                        SQL = SQL & "AssociadoID"
                        epValidaAssociacao.SetError(cmbAssociado, "")
                    End If

                    If Convert.ToInt32(cmbEmpresa.SelectedValue) = 0 Then
                        epValidaAssociacao.SetError(cmbEmpresa, "Informe a Empresa")
                        cmbEmpresa.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@EmpresaID", Convert.ToInt32(cmbEmpresa.SelectedValue)))
                        SQL = SQL & ", EmpresaID"
                        epValidaAssociacao.SetError(cmbEmpresa, "")
                    End If

                    If associacao.ValidaAssociacao("SELECT * FROM ASSOCIADOSEMPRESAS WHERE AssociadoID = @AssociadoID and EmpresaID = @EmpresaID", par) = True Then
                        epValidaAssociacao.SetError(cmbEmpresa, "Essa associação já existe")
                        cmbAssociado.Focus()
                        Exit Sub
                    Else
                        epValidaAssociacao.SetError(cmbAssociado, "")
                        epValidaAssociacao.SetError(cmbEmpresa, "")
                    End If

                    SQL = SQL & ") VALUES(@AssociadoID, @EmpresaID)"

                    If associacao.NovaAssociacao(SQL, par) = True Then
                        MessageBox.Show("Empresa adicionado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelarAssociacao_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar adicionar Empresa.")
                    End If

                Case Opcao.Editar
                    SQL = "UPDATE ASSOCIADOSEMPRESAS SET "

                    If Convert.ToInt32(cmbAssociado.SelectedValue) = 0 Then
                        epValidaAssociacao.SetError(cmbAssociado, "Informe o Associado")
                        cmbAssociado.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@AssociadoID", Convert.ToInt32(cmbAssociado.SelectedValue)))
                        SQL = SQL & "AssociadoID = @AssociadoID"
                        epValidaAssociacao.SetError(cmbAssociado, "")
                    End If

                    If Convert.ToInt32(cmbEmpresa.SelectedValue) = 0 Then
                        epValidaAssociacao.SetError(cmbEmpresa, "Informe a Empresa")
                        cmbEmpresa.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@EmpresaID", Convert.ToInt32(cmbEmpresa.SelectedValue)))
                        SQL = SQL & ", EmpresaID = @EmpresaID"
                        epValidaAssociacao.SetError(cmbEmpresa, "")
                    End If

                    If associacao.ValidaAssociacao("SELECT * FROM ASSOCIADOSEMPRESAS WHERE AssociadoID = @AssociadoID and EmpresaID = @EmpresaID", par) = True Then
                        epValidaAssociacao.SetError(cmbEmpresa, "Essa associação já existe")
                        cmbAssociado.Focus()
                        Exit Sub
                    Else
                        epValidaAssociacao.SetError(cmbAssociado, "")
                        epValidaAssociacao.SetError(cmbEmpresa, "")
                    End If

                    SQL = SQL & " WHERE ID = @ID"
                    par.Add(New SqlParameter("@ID", txtID.Text))
                    par.Add(New SqlParameter("@AssociadoID", Convert.ToInt32(cmbAssociado.SelectedValue)))
                    par.Add(New SqlParameter("@EmpresaID", Convert.ToInt32(cmbEmpresa.SelectedValue)))

                    If associacao.AlterarAssociacao(SQL, par) = True Then
                        MessageBox.Show("Empresa alterado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelarAssociacao_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar alterar Empresa.")
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbAssociado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAssociado.SelectedIndexChanged
        Dim associacao As New Associacao
        Dim associado As New Associado
        Dim ds As DataSet
        Dim dt As DataTable
        Try
            cmbAssociado.Items.Clear()
            dt = associado.ConsultarDataReaderAssociado("SELECT ID, Nome FROM ASSOCIADOS")

            cmbAssociado.DataSource = dt
            cmbAssociado.DisplayMember = "Nome"
            cmbAssociado.ValueMember = "ID"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbAssociado.KeyDown
        cmbAssociado_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        Dim associacao As New Associacao
        Dim empresa As New Empresa
        Dim ds As DataSet
        Dim dt As DataTable
        Try
            cmbEmpresa.Items.Clear()
            dt = empresa.ConsultarDataReaderAssociado("SELECT ID, NomeDaEmpresa FROM EMPRESAS")

            cmbEmpresa.DataSource = dt
            cmbEmpresa.DisplayMember = "NomeDaEmpresa"
            cmbEmpresa.ValueMember = "ID"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbEmpresa.KeyDown
        cmbEmpresa_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If txtID.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim associacao As New Associacao
            Dim par As New List(Of SqlParameter)

            par.Add(New SqlParameter("@ID", txtID.Text))
            If associacao.ConsultarDataReader("SELECT ados.Nome, emp.NomeDaEmpresa FROM ASSOCIADOSEMPRESAS ass
                                               join Associados ados on ass.AssociadoID = ados.ID
                                               join Empresas emp on ass.EmpresaID = emp.ID
                                               WHERE ass.ID = @ID", par) = True Then
                cmbAssociado.Text = associacao.NomeAssociado
                cmbEmpresa.Text = associacao.NomeEmpresa

                If intOpcao = Opcao.Editar Then
                    txtID.Enabled = False
                    AtivaDesativa(True)
                    tsbSalvarAssociacao.Enabled = True
                    tsbDeletarAssociacao.Enabled = True
                End If
            Else
                MessageBox.Show("ID não encontrado.")
            End If
        End If
    End Sub

    Private Sub tsbDeletarAssociacao_Click(sender As Object, e As EventArgs) Handles tsbDeletarAssociacao.Click
        Dim associacao As New Associacao
        Dim par As New List(Of SqlParameter)

        Try
            par.Add(New SqlParameter("@ID", txtID.Text))

            If MessageBox.Show("Você tem certeza que deseja remover a empresa selecionado?", "Atenção",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If associacao.DeleteAssociacao("DELETE ASSOCIADOSEMPRESAS WHERE ID = @ID", par) = True Then
                    MessageBox.Show("Empresa removido com sucesso.")
                    tsbCancelarAssociacao_Click(Nothing, Nothing)
                Else
                    MessageBox.Show("Problema ao tentar remover a Empresa.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Problema ao tentar remover a Empresa")
        End Try
    End Sub
End Class