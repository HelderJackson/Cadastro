<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAssociado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAssociacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbAssociado = New System.Windows.Forms.ToolStripButton()
        Me.tsbEmpresa = New System.Windows.Forms.ToolStripButton()
        Me.tsbAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.mnuPesquisar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.mnuPesquisaEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAssociado, Me.mnuEmpresa, Me.mnuAssociacao, Me.mnuPesquisar, Me.mnuPesquisaEmpresa})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(71, 20)
        Me.mnuCadastro.Text = "Cadastros"
        '
        'mnuAssociado
        '
        Me.mnuAssociado.Image = Global.Portfolio.My.Resources.Resources.icone_cliente
        Me.mnuAssociado.Name = "mnuAssociado"
        Me.mnuAssociado.Size = New System.Drawing.Size(207, 22)
        Me.mnuAssociado.Text = "Associado"
        '
        'mnuEmpresa
        '
        Me.mnuEmpresa.Image = Global.Portfolio.My.Resources.Resources.icone_empresa
        Me.mnuEmpresa.Name = "mnuEmpresa"
        Me.mnuEmpresa.Size = New System.Drawing.Size(207, 22)
        Me.mnuEmpresa.Text = "Empresa"
        '
        'mnuAssociacao
        '
        Me.mnuAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_associados
        Me.mnuAssociacao.Name = "mnuAssociacao"
        Me.mnuAssociacao.Size = New System.Drawing.Size(207, 22)
        Me.mnuAssociacao.Text = "Associados das Empresas"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAssociado, Me.tsbEmpresa, Me.tsbAssociacao, Me.tsbPesquisar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAssociado
        '
        Me.tsbAssociado.Image = Global.Portfolio.My.Resources.Resources.icone_cliente
        Me.tsbAssociado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAssociado.Name = "tsbAssociado"
        Me.tsbAssociado.Size = New System.Drawing.Size(65, 35)
        Me.tsbAssociado.Text = "Associado"
        Me.tsbAssociado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbAssociado.ToolTipText = "Cadastro de Associado"
        '
        'tsbEmpresa
        '
        Me.tsbEmpresa.Image = Global.Portfolio.My.Resources.Resources.icone_empresa
        Me.tsbEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEmpresa.Name = "tsbEmpresa"
        Me.tsbEmpresa.Size = New System.Drawing.Size(56, 35)
        Me.tsbEmpresa.Text = "Empresa"
        Me.tsbEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbEmpresa.ToolTipText = "Empresa"
        '
        'tsbAssociacao
        '
        Me.tsbAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_associados
        Me.tsbAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAssociacao.Name = "tsbAssociacao"
        Me.tsbAssociacao.Size = New System.Drawing.Size(144, 35)
        Me.tsbAssociacao.Text = "Associados das Empresas"
        Me.tsbAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnuPesquisar
        '
        Me.mnuPesquisar.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.mnuPesquisar.Name = "mnuPesquisar"
        Me.mnuPesquisar.Size = New System.Drawing.Size(207, 22)
        Me.mnuPesquisar.Text = "Pequisa de Associado"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 62)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbPesquisar
        '
        Me.tsbPesquisar.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPesquisar.Name = "tsbPesquisar"
        Me.tsbPesquisar.Size = New System.Drawing.Size(130, 35)
        Me.tsbPesquisar.Text = "Pesquisa de Associado"
        Me.tsbPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbPesquisar.ToolTipText = "Pesquisa"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(121, 35)
        Me.ToolStripButton1.Text = "Pesquisa de Empresa"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "tsbPesquisaEmpresa"
        '
        'mnuPesquisaEmpresa
        '
        Me.mnuPesquisaEmpresa.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.mnuPesquisaEmpresa.Name = "mnuPesquisaEmpresa"
        Me.mnuPesquisaEmpresa.Size = New System.Drawing.Size(207, 22)
        Me.mnuPesquisaEmpresa.Text = "Pesquisa de Empresa"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuAssociado As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbAssociado As ToolStripButton
    Friend WithEvents tsbEmpresa As ToolStripButton
    Friend WithEvents mnuEmpresa As ToolStripMenuItem
    Friend WithEvents mnuAssociacao As ToolStripMenuItem
    Friend WithEvents tsbAssociacao As ToolStripButton
    Friend WithEvents mnuPesquisar As ToolStripMenuItem
    Friend WithEvents tsbPesquisar As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents mnuPesquisaEmpresa As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
