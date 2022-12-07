<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_carrinho
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carrinho))
        Me.btn_continua = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_logo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.pesquisa_genero_carrinho = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_ano = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_favoritos = New System.Windows.Forms.ToolStripButton()
        Me.btn_carrinho = New System.Windows.Forms.ToolStripButton()
        Me.btn_perfil = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemaEscuroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_carrinho = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_continua
        '
        Me.btn_continua.BackColor = System.Drawing.Color.Transparent
        Me.btn_continua.BackgroundImage = CType(resources.GetObject("btn_continua.BackgroundImage"), System.Drawing.Image)
        Me.btn_continua.Font = New System.Drawing.Font("High Tower Text", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_continua.ForeColor = System.Drawing.Color.White
        Me.btn_continua.Location = New System.Drawing.Point(174, 364)
        Me.btn_continua.Name = "btn_continua"
        Me.btn_continua.Size = New System.Drawing.Size(162, 61)
        Me.btn_continua.TabIndex = 51
        Me.btn_continua.Text = "CONTINUAR COMPRANDO"
        Me.btn_continua.UseVisualStyleBackColor = False
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.Red
        Me.btn_finalizar.BackgroundImage = CType(resources.GetObject("btn_finalizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_finalizar.Font = New System.Drawing.Font("High Tower Text", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar.Location = New System.Drawing.Point(421, 364)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(153, 61)
        Me.btn_finalizar.TabIndex = 52
        Me.btn_finalizar.Text = "FINALIZAR COMPRA"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_logo, Me.ToolStripLabel2, Me.pesquisa_genero_carrinho, Me.ToolStripLabel3, Me.cmb_ano, Me.ToolStripLabel1, Me.txt_busca, Me.btn_favoritos, Me.btn_carrinho, Me.btn_perfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(814, 39)
        Me.ToolStrip1.TabIndex = 53
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_logo
        '
        Me.btn_logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_logo.Image = CType(resources.GetObject("btn_logo.Image"), System.Drawing.Image)
        Me.btn_logo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_logo.Name = "btn_logo"
        Me.btn_logo.Size = New System.Drawing.Size(36, 36)
        Me.btn_logo.Text = "Logo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("High Tower Text", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(60, 36)
        Me.ToolStripLabel2.Text = "Gênero:"
        '
        'pesquisa_genero_carrinho
        '
        Me.pesquisa_genero_carrinho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pesquisa_genero_carrinho.Name = "pesquisa_genero_carrinho"
        Me.pesquisa_genero_carrinho.Size = New System.Drawing.Size(121, 39)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("High Tower Text", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(40, 36)
        Me.ToolStripLabel3.Text = "Ano:"
        '
        'cmb_ano
        '
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.Size = New System.Drawing.Size(121, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("High Tower Text", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 36)
        Me.ToolStripLabel1.Text = "Buscar:"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.Color.White
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(52, 39)
        '
        'btn_favoritos
        '
        Me.btn_favoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_favoritos.Image = CType(resources.GetObject("btn_favoritos.Image"), System.Drawing.Image)
        Me.btn_favoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_favoritos.Name = "btn_favoritos"
        Me.btn_favoritos.Size = New System.Drawing.Size(36, 36)
        Me.btn_favoritos.Text = "Favoritos"
        '
        'btn_carrinho
        '
        Me.btn_carrinho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_carrinho.Image = CType(resources.GetObject("btn_carrinho.Image"), System.Drawing.Image)
        Me.btn_carrinho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_carrinho.Name = "btn_carrinho"
        Me.btn_carrinho.Size = New System.Drawing.Size(36, 36)
        Me.btn_carrinho.Text = "Carrinho"
        '
        'btn_perfil
        '
        Me.btn_perfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_perfil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.VenderToolStripMenuItem, Me.TemaEscuroToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.btn_perfil.Image = CType(resources.GetObject("btn_perfil.Image"), System.Drawing.Image)
        Me.btn_perfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_perfil.Name = "btn_perfil"
        Me.btn_perfil.Size = New System.Drawing.Size(45, 36)
        Me.btn_perfil.Text = "Perfil"
        '
        'ContaToolStripMenuItem
        '
        Me.ContaToolStripMenuItem.Name = "ContaToolStripMenuItem"
        Me.ContaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ContaToolStripMenuItem.Text = "Perfil/Conta"
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.HistóricoToolStripMenuItem.Text = "Histórico"
        '
        'VenderToolStripMenuItem
        '
        Me.VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        Me.VenderToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VenderToolStripMenuItem.Text = "Vender"
        '
        'TemaEscuroToolStripMenuItem
        '
        Me.TemaEscuroToolStripMenuItem.Name = "TemaEscuroToolStripMenuItem"
        Me.TemaEscuroToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TemaEscuroToolStripMenuItem.Text = "Tema Escuro"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("High Tower Text", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(672, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 20)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Tema Escuro"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgv_carrinho
        '
        Me.dgv_carrinho.AllowUserToAddRows = False
        Me.dgv_carrinho.AllowUserToDeleteRows = False
        Me.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_carrinho.Location = New System.Drawing.Point(0, 40)
        Me.dgv_carrinho.Name = "dgv_carrinho"
        Me.dgv_carrinho.ReadOnly = True
        Me.dgv_carrinho.Size = New System.Drawing.Size(812, 277)
        Me.dgv_carrinho.TabIndex = 55
        '
        'Column7
        '
        Me.Column7.HeaderText = "N°"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Criador"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ano"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gênero"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Valor"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Remover"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frm_carrinho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 439)
        Me.Controls.Add(Me.dgv_carrinho)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.btn_continua)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_carrinho"
        Me.Text = "frm_carrinho"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_continua As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_logo As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents pesquisa_genero_carrinho As ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmb_ano As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents btn_favoritos As ToolStripButton
    Friend WithEvents btn_carrinho As ToolStripButton
    Friend WithEvents btn_perfil As ToolStripDropDownButton
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemaEscuroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgv_carrinho As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
