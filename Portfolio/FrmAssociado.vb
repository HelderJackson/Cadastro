Imports System.Data.SqlClient
Imports DBOCadastro

Public Class FrmAssociado
    Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum

    Private Sub AtivaDesativa(ByVal Valor As Boolean)
        txtNome.Enabled = Valor
        txtCPF.Enabled = Valor
        dtpDtDeNascimento.Enabled = Valor

    End Sub

    Private intOpcao As Opcao

    Private Sub tsbIncluir_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        intOpcao = Opcao.Incluir

        AtivaDesativa(True)

        tsbIncluir.Enabled = True
        tsbEditar.Enabled = True
        tsbConsultar.Enabled = True
        tsbSalvar.Enabled = True
        tsbCancelar.Enabled = True

        txtNome.Focus()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        intOpcao = Opcao.Editar

        txtID.Enabled = True
        txtID.Focus()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        dtpDtDeNascimento.Enabled = False


        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
    End Sub

    Private Sub tsbConsultar_Click(sender As Object, e As EventArgs) Handles tsbConsultar.Click
        intOpcao = Opcao.Consultar

        txtID.Enabled = True
        txtID.Focus()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        dtpDtDeNascimento.Enabled = False


        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        intOpcao = Opcao.Cancelar

        AtivaDesativa(False)
        txtID.Enabled = False
        txtID.Clear()
        txtNome.Clear()
        txtCPF.Clear()
        FrmAssociado_Load(Nothing, Nothing)


        tsbIncluir.Enabled = True
        tsbEditar.Enabled = True
        tsbConsultar.Enabled = True
        tsbDeletar.Enabled = False
        tsbSalvar.Enabled = False
        tsbCancelar.Enabled = False

    End Sub

    Private Sub tsbSalvar_Click(sender As Object, e As EventArgs) Handles tsbSalvar.Click
        Dim associado As New Associado
        Dim par As New List(Of SqlParameter)
        Dim parametro As SqlParameter
        Dim SQL As String
        Dim blDtNascimento As Boolean = False

        Try
            Select Case intOpcao
                Case Opcao.Incluir
                    SQL = "INSERT INTO ASSOCIADOS ("
                    If txtNome.TextLength = 0 Then
                        epValida.SetError(txtNome, "Informe o nome do Associado.")
                        txtNome.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@Nome", txtNome.Text))
                        SQL = SQL & "Nome"
                        epValida.SetError(txtNome, "")
                    End If

                    parametro = New SqlParameter("@CPF", txtCPF.Text)
                    par.Add(New SqlParameter("@CPF", txtCPF.Text))

                    If associado.VerificaCPFUnico("SELECT * FROM ASSOCIADOS WHERE CPF = @CPF", parametro) = True Then
                        epValida.SetError(txtCPF, "CPF já existente em outro Associado")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    If txtCPF.TextLength = 0 Then
                        epValida.SetError(txtCPF, "Informe o CPF.")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    If txtCPF.TextLength > 11 Then
                        epValida.SetError(txtCPF, "Número do CPF inválido.")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    Dim validaCPF As Boolean = False

                    validaCPF = associado.ValidarCPFSomenteNumeros(txtCPF.Text)
                    If validaCPF = False Then
                        epValida.SetError(txtCPF, "Digite só números no campo CPF")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    SQL = SQL & ",CPF"

                    If dtpDtDeNascimento.Text <> " " Then
                        par.Add(New SqlParameter("@DataDeNascimento", dtpDtDeNascimento.Text))
                        SQL = SQL & ",DataDeNascimento"
                        blDtNascimento = True
                    End If

                    SQL = SQL & ") VALUES(@Nome,@CPF"
                    If blDtNascimento = True Then
                        SQL = SQL & ",@DataDeNascimento"
                    End If

                    SQL = SQL & ")"

                    If associado.NovoAssociado(SQL, par) = True Then
                        MessageBox.Show("Associado adicionado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelar_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar adicionar Associado.")
                    End If

                Case Opcao.Editar
                    SQL = "UPDATE ASSOCIADOS SET "
                    par.Add(New SqlParameter("@ID", txtID.Text))
                    If txtNome.TextLength = 0 Then
                        epValida.SetError(txtNome, "Informe o nome do Associado.")
                        txtNome.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@Nome", txtNome.Text))
                        SQL = SQL & "Nome = @Nome"
                        epValida.SetError(txtNome, "")
                    End If

                    parametro = New SqlParameter("@CPF", txtCPF.Text)
                    If associado.VerificaCPFUnico("SELECT * FROM ASSOCIADOS WHERE CPF = @CPF", parametro) = True Then
                        epValida.SetError(txtCPF, "CPF já existente em outro Associado")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    If txtCPF.TextLength = 0 Then
                        epValida.SetError(txtCPF, "Informe o CPF.")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    If txtCPF.TextLength > 11 Then
                        epValida.SetError(txtCPF, "Número do CPF inválido.")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    Dim validaCPF As Boolean = False

                    validaCPF = associado.ValidarCPFSomenteNumeros(txtCPF.Text)
                    If validaCPF = False Then
                        epValida.SetError(txtCPF, "Digite só números no campo CPF")
                        txtCPF.Focus()
                        Exit Sub
                    Else
                        epValida.SetError(txtCPF, "")
                    End If

                    par.Add(New SqlParameter("@CPF", txtCPF.Text))
                    SQL = SQL & ",CPF = @CPF"

                    If IsDate(dtpDtDeNascimento) Then
                        par.Add(New SqlParameter("@DataDeNascimento", dtpDtDeNascimento.Text))
                        SQL = SQL & ",DataDeNascimento =  @DataDeNascimento"
                        blDtNascimento = True
                    End If

                    SQL = SQL & " WHERE ID = @ID"

                    If associado.AlterarAssociado(SQL, par) = True Then
                        MessageBox.Show("Associado alterado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelar_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar alterar Associado.")
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If txtID.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim associado As New Associado
            Dim par As New List(Of SqlParameter)

            par.Add(New SqlParameter("@ID", txtID.Text))
            If associado.ConsultarDataReader("SELECT * FROM ASSOCIADOS WHERE ID = @ID", par) = True Then
                txtNome.Text = associado.Nome
                txtCPF.Text = associado.CPF
                dtpDtDeNascimento.Text = associado.DataDeNascimento

                If intOpcao = Opcao.Editar Then
                    txtID.Enabled = False
                    AtivaDesativa(True)
                    tsbSalvar.Enabled = True
                    tsbDeletar.Enabled = True
                End If
            Else
                MessageBox.Show("ID não encontrado.")
            End If
        End If
    End Sub

    Private Sub tsbDeletar_Click(sender As Object, e As EventArgs) Handles tsbDeletar.Click
        Dim associado As New Associado
        Dim par As New List(Of SqlParameter)
        Dim parametro As SqlParameter

        Try
            par.Add(New SqlParameter("@ID", txtID.Text))

            If MessageBox.Show("Você tem certeza que deseja remover o associado selecionado?", "Atenção",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                parametro = New SqlParameter("@ID", txtID.Text)
                If associado.VerificaSeEstaAssociado("SELECT * FROM ASSOCIADOSEMPRESAS WHERE AssociadoID = @ID", parametro) = True Then
                    MessageBox.Show("Não é permitido excluir este Associado, pois ela já possuí empresa associada a ele.")
                    Exit Sub
                End If

                If associado.DeleteAssociado("DELETE ASSOCIADOS WHERE ID = @ID", par) = True Then
                    MessageBox.Show("Asssociado removido com sucesso.")
                    tsbCancelar_Click(Nothing, Nothing)
                Else
                    MessageBox.Show("Problema ao tentar remover o Asssociado.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Problema ao tentar remover Associado")
        End Try
    End Sub

    Private Sub FrmAssociado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDtDeNascimento.Format = DateTimePickerFormat.Custom
        dtpDtDeNascimento.CustomFormat = " "

    End Sub

    Private Sub dtpDtDeNascimento_ValueChanged(sender As Object, e As EventArgs) Handles dtpDtDeNascimento.ValueChanged
        dtpDtDeNascimento.CustomFormat = "dd/MM/yyyy"
    End Sub

End Class