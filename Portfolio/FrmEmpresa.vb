Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Imports DBOCadastro

Public Class FrmEmpresa
    Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum

    Private Sub AtivaDesativa(ByVal Valor As Boolean)
        txtNome.Enabled = Valor
        txtCNPJ.Enabled = Valor
    End Sub

    Private intOpcao As Opcao

    Private Sub tsbIncluirEmp_Click(sender As Object, e As EventArgs) Handles tsbIncluirEmp.Click
        intOpcao = Opcao.Incluir

        AtivaDesativa(True)

        tsbIncluirEmp.Enabled = True
        tsbEditarEmp.Enabled = True
        tsbConsultarEmp.Enabled = True
        tsbSalvarEmp.Enabled = True
        tsbCancelarEmp.Enabled = True

        txtNome.Focus()
    End Sub

    Private Sub tsbEditarEmp_Click(sender As Object, e As EventArgs) Handles tsbEditarEmp.Click
        intOpcao = Opcao.Editar

        txtID.Enabled = True
        txtID.Focus()
        txtNome.Enabled = False
        txtCNPJ.Enabled = False

        tsbIncluirEmp.Enabled = False
        tsbEditarEmp.Enabled = False
        tsbConsultarEmp.Enabled = False
        tsbCancelarEmp.Enabled = True
    End Sub

    Private Sub tsbConsultarEmp_Click(sender As Object, e As EventArgs) Handles tsbConsultarEmp.Click
        intOpcao = Opcao.Consultar

        txtID.Enabled = True
        txtID.Focus()
        txtNome.Enabled = False
        txtCNPJ.Enabled = False


        tsbIncluirEmp.Enabled = False
        tsbEditarEmp.Enabled = False
        tsbConsultarEmp.Enabled = False
        tsbCancelarEmp.Enabled = True
    End Sub

    Private Sub tsbCancelarEmp_Click(sender As Object, e As EventArgs) Handles tsbCancelarEmp.Click
        intOpcao = Opcao.Cancelar

        AtivaDesativa(False)
        txtID.Enabled = False
        txtID.Clear()
        txtNome.Clear()
        txtCNPJ.Clear()

        tsbIncluirEmp.Enabled = True
        tsbEditarEmp.Enabled = True
        tsbConsultarEmp.Enabled = True
        tsbDeletarEmp.Enabled = False
        tsbSalvarEmp.Enabled = False
        tsbCancelarEmp.Enabled = False
    End Sub

    Private Sub tsbSalvarEmp_Click(sender As Object, e As EventArgs) Handles tsbSalvarEmp.Click
        Dim empresa As New Empresa
        Dim par As New List(Of SqlParameter)
        Dim parametro As SqlParameter
        Dim SQL As String

        Try
            Select Case intOpcao
                Case Opcao.Incluir
                    SQL = "INSERT INTO EMPRESAS ("
                    If txtNome.TextLength = 0 Then
                        epValidaEmp.SetError(txtNome, "Informe o nome da Empresa.")
                        txtNome.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@Nome", txtNome.Text))
                        SQL = SQL & "NomeDaEmpresa"
                        epValidaEmp.SetError(txtNome, "")
                    End If

                    parametro = New SqlParameter("@CNPJ", txtCNPJ.Text)
                    par.Add(New SqlParameter("@CNPJ", txtCNPJ.Text))
                    If empresa.VerificaCNPJUnico("SELECT * FROM EMPRESAS WHERE CNPJ = @CNPJ", parametro) = True Then
                        epValidaEmp.SetError(txtCNPJ, "CNPJ já existente em outra Empresa.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    If txtCNPJ.TextLength = 0 Then
                        epValidaEmp.SetError(txtCNPJ, "Informe o CNPJ.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    If txtCNPJ.TextLength > 11 Then
                        epValidaEmp.SetError(txtCNPJ, "Número do CNPJ inválido.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    Dim validaCNPJ As Boolean = False

                    validaCNPJ = empresa.ValidarCNPJSomenteNumeros(txtCNPJ.Text)
                    If validaCNPJ = False Then
                        epValidaEmp.SetError(txtCNPJ, "Digite só números no campo CPF")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    SQL = SQL & ",CNPJ"

                    SQL = SQL & ") VALUES(@Nome,@CNPJ)"

                    If empresa.NovaEmpresa(SQL, par) = True Then
                        MessageBox.Show("Empresa adicionado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelarEmp_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar adicionar Empresa.")
                    End If

                Case Opcao.Editar
                    SQL = "UPDATE EMPRESAS SET "
                    par.Add(New SqlParameter("@ID", txtID.Text))
                    If txtNome.TextLength = 0 Then
                        epValidaEmp.SetError(txtNome, "Informe o nome da Empresa.")
                        txtNome.Focus()
                        Exit Sub
                    Else
                        par.Add(New SqlParameter("@Nome", txtNome.Text))
                        SQL = SQL & "NomeDaEmpresa = @Nome"
                        epValidaEmp.SetError(txtNome, "")
                    End If

                    parametro = New SqlParameter("@CNPJ", txtCNPJ.Text)
                    par.Add(New SqlParameter("@CNPJ", txtCNPJ.Text))
                    If empresa.VerificaCNPJUnico("SELECT * FROM EMPRESAS WHERE CNPJ = @CNPJ", parametro) = True Then
                        epValidaEmp.SetError(txtCNPJ, "CNPJ já existente em outra Empresa.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    If txtCNPJ.TextLength = 0 Then
                        epValidaEmp.SetError(txtCNPJ, "Informe o CNPJ.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    If txtCNPJ.TextLength > 11 Then
                        epValidaEmp.SetError(txtCNPJ, "Número do CNPJ inválido.")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    Dim validaCNPJ As Boolean = False

                    validaCNPJ = empresa.ValidarCNPJSomenteNumeros(txtCNPJ.Text)
                    If validaCNPJ = False Then
                        epValidaEmp.SetError(txtCNPJ, "Digite só números no campo CPF")
                        txtCNPJ.Focus()
                        Exit Sub
                    Else
                        epValidaEmp.SetError(txtCNPJ, "")
                    End If

                    SQL = SQL & " WHERE ID = @ID"

                    If empresa.AlterarEmpresa(SQL, par) = True Then
                        MessageBox.Show("Empresa alterado com sucesso.")
                        intOpcao = Opcao.Cancelar
                        tsbCancelarEmp_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Problema ao tentar alterar Empresa.")
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If txtID.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim empresa As New Empresa
            Dim par As New List(Of SqlParameter)

            par.Add(New SqlParameter("@ID", txtID.Text))
            If empresa.ConsultarDataReader("SELECT * FROM EMPRESAS WHERE ID = @ID", par) = True Then
                txtNome.Text = empresa.NomeDaEmpresa
                txtCNPJ.Text = empresa.CNPJ

                If intOpcao = Opcao.Editar Then
                    txtID.Enabled = False
                    AtivaDesativa(True)
                    tsbSalvarEmp.Enabled = True
                    tsbDeletarEmp.Enabled = True
                End If
            Else
                MessageBox.Show("ID não encontrado.")
            End If
        End If
    End Sub

    Private Sub tsbDeletarEmp_Click(sender As Object, e As EventArgs) Handles tsbDeletarEmp.Click
        Dim empresa As New Empresa
        Dim par As New List(Of SqlParameter)
        Dim parametro As SqlParameter

        Try
            par.Add(New SqlParameter("@ID", txtID.Text))

            If MessageBox.Show("Você tem certeza que deseja remover a empresa selecionado?", "Atenção",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then


                parametro = New SqlParameter("@ID", txtID.Text)
                If empresa.VerificaSeEstaAssociado("SELECT * FROM ASSOCIADOSEMPRESAS WHERE EmpresaID = @ID", parametro) = True Then
                    MessageBox.Show("Não é permitido excluir esta Empresa, pois ela já possuí associado.")
                    Exit Sub
                End If

                If empresa.DeleteEmpresa("DELETE EMPRESAS WHERE ID = @ID", par) = True Then
                    MessageBox.Show("Empresa removido com sucesso.")
                    tsbCancelarEmp_Click(Nothing, Nothing)
                Else
                    MessageBox.Show("Problema ao tentar remover a Empresa.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Problema ao tentar remover a Empresa")
        End Try
    End Sub
End Class