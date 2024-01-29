<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCNPJ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbIncluir = New System.Windows.Forms.ToolStrip()
        Me.tsbIncluirEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditarEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultarEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeletarEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalvarEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelarEmp = New System.Windows.Forms.ToolStripButton()
        Me.epValidaEmp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.tsbIncluir.SuspendLayout()
        CType(Me.epValidaEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.txtCNPJ)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(56, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(56, 46)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(358, 20)
        Me.txtNome.TabIndex = 4
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Enabled = False
        Me.txtCNPJ.Location = New System.Drawing.Point(56, 77)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(100, 20)
        Me.txtCNPJ.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CNPJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'tsbIncluir
        '
        Me.tsbIncluir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluirEmp, Me.tsbEditarEmp, Me.tsbConsultarEmp, Me.tsbDeletarEmp, Me.tsbSalvarEmp, Me.tsbCancelarEmp})
        Me.tsbIncluir.Location = New System.Drawing.Point(0, 0)
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(800, 38)
        Me.tsbIncluir.TabIndex = 1
        Me.tsbIncluir.Text = "Incluir"
        '
        'tsbIncluirEmp
        '
        Me.tsbIncluirEmp.Image = Global.Portfolio.My.Resources.Resources.icone_inclusao
        Me.tsbIncluirEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluirEmp.Name = "tsbIncluirEmp"
        Me.tsbIncluirEmp.Size = New System.Drawing.Size(44, 35)
        Me.tsbIncluirEmp.Text = "Incluir"
        Me.tsbIncluirEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEditarEmp
        '
        Me.tsbEditarEmp.Image = Global.Portfolio.My.Resources.Resources.icone_edicao
        Me.tsbEditarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditarEmp.Name = "tsbEditarEmp"
        Me.tsbEditarEmp.Size = New System.Drawing.Size(41, 35)
        Me.tsbEditarEmp.Text = "Editar"
        Me.tsbEditarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbConsultarEmp
        '
        Me.tsbConsultarEmp.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.tsbConsultarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultarEmp.Name = "tsbConsultarEmp"
        Me.tsbConsultarEmp.Size = New System.Drawing.Size(62, 35)
        Me.tsbConsultarEmp.Text = "Consultar"
        Me.tsbConsultarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDeletarEmp
        '
        Me.tsbDeletarEmp.Image = Global.Portfolio.My.Resources.Resources.icone_deletar
        Me.tsbDeletarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeletarEmp.Name = "tsbDeletarEmp"
        Me.tsbDeletarEmp.Size = New System.Drawing.Size(48, 35)
        Me.tsbDeletarEmp.Text = "Deletar"
        Me.tsbDeletarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbSalvarEmp
        '
        Me.tsbSalvarEmp.Image = Global.Portfolio.My.Resources.Resources.icone_salvar
        Me.tsbSalvarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalvarEmp.Name = "tsbSalvarEmp"
        Me.tsbSalvarEmp.Size = New System.Drawing.Size(42, 35)
        Me.tsbSalvarEmp.Text = "Salvar"
        Me.tsbSalvarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCancelarEmp
        '
        Me.tsbCancelarEmp.Image = Global.Portfolio.My.Resources.Resources.icone_cancelar
        Me.tsbCancelarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelarEmp.Name = "tsbCancelarEmp"
        Me.tsbCancelarEmp.Size = New System.Drawing.Size(57, 35)
        Me.tsbCancelarEmp.Text = "Cancelar"
        Me.tsbCancelarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'epValidaEmp
        '
        Me.epValidaEmp.ContainerControl = Me
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 259)
        Me.Controls.Add(Me.tsbIncluir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbIncluir.ResumeLayout(False)
        Me.tsbIncluir.PerformLayout()
        CType(Me.epValidaEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCNPJ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbIncluir As ToolStrip
    Friend WithEvents tsbCancelarEmp As ToolStripButton
    Friend WithEvents tsbIncluirEmp As ToolStripButton
    Friend WithEvents tsbEditarEmp As ToolStripButton
    Friend WithEvents tsbConsultarEmp As ToolStripButton
    Friend WithEvents tsbDeletarEmp As ToolStripButton
    Friend WithEvents tsbSalvarEmp As ToolStripButton
    Friend WithEvents epValidaEmp As ErrorProvider
End Class
