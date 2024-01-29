<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssociacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.cmbAssociado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbIncluirAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditarAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultarAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeletarAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalvarAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelarAssociacao = New System.Windows.Forms.ToolStripButton()
        Me.epValidaAssociacao = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.epValidaAssociacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.cmbEmpresa)
        Me.GroupBox1.Controls.Add(Me.cmbAssociado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(78, 38)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(77, 20)
        Me.txtID.TabIndex = 5
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.Enabled = False
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(78, 92)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(231, 21)
        Me.cmbEmpresa.TabIndex = 4
        '
        'cmbAssociado
        '
        Me.cmbAssociado.Enabled = False
        Me.cmbAssociado.FormattingEnabled = True
        Me.cmbAssociado.Location = New System.Drawing.Point(78, 64)
        Me.cmbAssociado.Name = "cmbAssociado"
        Me.cmbAssociado.Size = New System.Drawing.Size(231, 21)
        Me.cmbAssociado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Associado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluirAssociacao, Me.tsbEditarAssociacao, Me.tsbConsultarAssociacao, Me.tsbDeletarAssociacao, Me.tsbSalvarAssociacao, Me.tsbCancelarAssociacao})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbIncluirAssociacao
        '
        Me.tsbIncluirAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_inclusao
        Me.tsbIncluirAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluirAssociacao.Name = "tsbIncluirAssociacao"
        Me.tsbIncluirAssociacao.Size = New System.Drawing.Size(44, 35)
        Me.tsbIncluirAssociacao.Text = "Incluir"
        Me.tsbIncluirAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEditarAssociacao
        '
        Me.tsbEditarAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_edicao
        Me.tsbEditarAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditarAssociacao.Name = "tsbEditarAssociacao"
        Me.tsbEditarAssociacao.Size = New System.Drawing.Size(41, 35)
        Me.tsbEditarAssociacao.Text = "Editar"
        Me.tsbEditarAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbConsultarAssociacao
        '
        Me.tsbConsultarAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.tsbConsultarAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultarAssociacao.Name = "tsbConsultarAssociacao"
        Me.tsbConsultarAssociacao.Size = New System.Drawing.Size(62, 35)
        Me.tsbConsultarAssociacao.Text = "Consultar"
        Me.tsbConsultarAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDeletarAssociacao
        '
        Me.tsbDeletarAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_deletar
        Me.tsbDeletarAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeletarAssociacao.Name = "tsbDeletarAssociacao"
        Me.tsbDeletarAssociacao.Size = New System.Drawing.Size(48, 35)
        Me.tsbDeletarAssociacao.Text = "Deletar"
        Me.tsbDeletarAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbSalvarAssociacao
        '
        Me.tsbSalvarAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_salvar
        Me.tsbSalvarAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalvarAssociacao.Name = "tsbSalvarAssociacao"
        Me.tsbSalvarAssociacao.Size = New System.Drawing.Size(42, 35)
        Me.tsbSalvarAssociacao.Text = "Salvar"
        Me.tsbSalvarAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCancelarAssociacao
        '
        Me.tsbCancelarAssociacao.Image = Global.Portfolio.My.Resources.Resources.icone_cancelar
        Me.tsbCancelarAssociacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelarAssociacao.Name = "tsbCancelarAssociacao"
        Me.tsbCancelarAssociacao.Size = New System.Drawing.Size(57, 35)
        Me.tsbCancelarAssociacao.Text = "Cancelar"
        Me.tsbCancelarAssociacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'epValidaAssociacao
        '
        Me.epValidaAssociacao.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmAssociacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAssociacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associados das Empresas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.epValidaAssociacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAssociado As ComboBox
    Friend WithEvents cmbEmpresa As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbIncluirAssociacao As ToolStripButton
    Friend WithEvents tsbEditarAssociacao As ToolStripButton
    Friend WithEvents tsbConsultarAssociacao As ToolStripButton
    Friend WithEvents tsbDeletarAssociacao As ToolStripButton
    Friend WithEvents tsbSalvarAssociacao As ToolStripButton
    Friend WithEvents tsbCancelarAssociacao As ToolStripButton
    Friend WithEvents epValidaAssociacao As ErrorProvider
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
