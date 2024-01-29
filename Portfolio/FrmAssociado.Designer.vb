<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAssociado
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDtDeNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbIncluir = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeletar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDtDeNascimento)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpDtDeNascimento
        '
        Me.dtpDtDeNascimento.CustomFormat = """ """
        Me.dtpDtDeNascimento.Enabled = False
        Me.dtpDtDeNascimento.Location = New System.Drawing.Point(117, 114)
        Me.dtpDtDeNascimento.Name = "dtpDtDeNascimento"
        Me.dtpDtDeNascimento.Size = New System.Drawing.Size(200, 20)
        Me.dtpDtDeNascimento.TabIndex = 8
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(117, 82)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(100, 20)
        Me.txtCPF.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(117, 49)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(389, 20)
        Me.txtNome.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(117, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data de Nascimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluir, Me.tsbEditar, Me.tsbConsultar, Me.tsbDeletar, Me.tsbSalvar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbIncluir
        '
        Me.tsbIncluir.Image = Global.Portfolio.My.Resources.Resources.icone_inclusao
        Me.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(44, 35)
        Me.tsbIncluir.Text = "Incluir"
        Me.tsbIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = Global.Portfolio.My.Resources.Resources.icone_edicao
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(41, 35)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = Global.Portfolio.My.Resources.Resources.icone_procurar
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(62, 35)
        Me.tsbConsultar.Text = "Consultar"
        Me.tsbConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbDeletar
        '
        Me.tsbDeletar.Enabled = False
        Me.tsbDeletar.Image = Global.Portfolio.My.Resources.Resources.icone_deletar
        Me.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeletar.Name = "tsbDeletar"
        Me.tsbDeletar.Size = New System.Drawing.Size(48, 35)
        Me.tsbDeletar.Text = "Deletar"
        Me.tsbDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbSalvar
        '
        Me.tsbSalvar.Enabled = False
        Me.tsbSalvar.Image = Global.Portfolio.My.Resources.Resources.icone_salvar
        Me.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalvar.Name = "tsbSalvar"
        Me.tsbSalvar.Size = New System.Drawing.Size(42, 35)
        Me.tsbSalvar.Text = "Salvar"
        Me.tsbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.Image = Global.Portfolio.My.Resources.Resources.icone_cancelar
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(57, 35)
        Me.tsbCancelar.Text = "Cancelar"
        Me.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'FrmAssociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 288)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAssociado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Associado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbIncluir As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbConsultar As ToolStripButton
    Friend WithEvents tsbSalvar As ToolStripButton
    Friend WithEvents tsbDeletar As ToolStripButton
    Friend WithEvents epValida As ErrorProvider
    Friend WithEvents dtpDtDeNascimento As DateTimePicker
End Class
