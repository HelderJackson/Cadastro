Imports System.Security
Imports DBOCadastro
Imports System.Data.SqlClient


Public Class FrmPrincipal

    Private associado As FrmAssociado = Nothing
    Private empresa As FrmEmpresa = Nothing
    Private associacao As FrmAssociacao = Nothing
    Private pesquisa As frmPesquisa = Nothing
    Private pesquisaEmpresa As frmPesquisaEmpresa = Nothing

    Private Sub mnuAssociado_Click(sender As Object, e As EventArgs) Handles mnuAssociado.Click

        'Verifica se o formilário já foi instaciado
        If associado Is Nothing Then
            associado = New FrmAssociado
            associado.Show()
        Else
            If associado.IsHandleCreated = True Then
                associado.Focus()
            Else
                associado = New FrmAssociado
                associado.Show()
            End If
        End If
    End Sub

    Private Sub tsbAssociado_Click(sender As Object, e As EventArgs) Handles tsbAssociado.Click
        mnuAssociado_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuEmpresa_Click(sender As Object, e As EventArgs) Handles mnuEmpresa.Click
        'Verifica se o formilário já foi instaciado
        If empresa Is Nothing Then
            empresa = New FrmEmpresa
            empresa.Show()
        Else
            If empresa.IsHandleCreated = True Then
                empresa.Focus()
            Else
                empresa = New FrmEmpresa
                empresa.Show()
            End If
        End If
    End Sub

    Private Sub tsbEmpresa_Click(sender As Object, e As EventArgs) Handles tsbEmpresa.Click
        mnuEmpresa_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuAssociacao_Click(sender As Object, e As EventArgs) Handles mnuAssociacao.Click
        'Verifica se o formilário já foi instaciado
        If associacao Is Nothing Then
            associacao = New FrmAssociacao
            associacao.Show()
        Else
            If associacao.IsHandleCreated = True Then
                associacao.Focus()
            Else
                associacao = New FrmAssociacao
                associacao.Show()
            End If
        End If
    End Sub

    Private Sub tsbAssociacao_Click(sender As Object, e As EventArgs) Handles tsbAssociacao.Click
        mnuAssociacao_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuPesquisar_Click(sender As Object, e As EventArgs) Handles mnuPesquisar.Click
        'Verifica se o formilário já foi instaciado
        If pesquisa Is Nothing Then
            pesquisa = New frmPesquisa
            pesquisa.Show()
        Else
            If pesquisa.IsHandleCreated = True Then
                pesquisa.Focus()
            Else
                pesquisa = New frmPesquisa
                pesquisa.Show()
            End If
        End If
    End Sub

    Private Sub tsbPesquisar_Click(sender As Object, e As EventArgs) Handles tsbPesquisar.Click
        mnuPesquisar_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuPesquisaEmpresa_Click(sender As Object, e As EventArgs) Handles mnuPesquisaEmpresa.Click
        'Verifica se o formilário já foi instaciado
        If pesquisaEmpresa Is Nothing Then
            pesquisaEmpresa = New frmPesquisaEmpresa
            pesquisaEmpresa.Show()
        Else
            If pesquisaEmpresa.IsHandleCreated = True Then
                pesquisaEmpresa.Focus()
            Else
                pesquisaEmpresa = New frmPesquisaEmpresa
                pesquisaEmpresa.Show()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        mnuPesquisaEmpresa_Click(Nothing, Nothing)
    End Sub
End Class
