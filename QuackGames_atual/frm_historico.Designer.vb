<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historico
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_historico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_nomec = New System.Windows.Forms.Label()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_forma = New System.Windows.Forms.Label()
        Me.cmb_historico_compra = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_logo = New System.Windows.Forms.ToolStripButton()
        Me.btn_perfil = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.img_jogo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(238, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Jogos Comprados:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome.Location = New System.Drawing.Point(75, 194)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(10, 13)
        Me.lbl_nome.TabIndex = 5
        Me.lbl_nome.Text = "."
        '
        'lbl_nomec
        '
        Me.lbl_nomec.AutoSize = True
        Me.lbl_nomec.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nomec.Location = New System.Drawing.Point(203, 430)
        Me.lbl_nomec.Name = "lbl_nomec"
        Me.lbl_nomec.Size = New System.Drawing.Size(13, 18)
        Me.lbl_nomec.TabIndex = 6
        Me.lbl_nomec.Text = "."
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_ano.Location = New System.Drawing.Point(203, 266)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(13, 18)
        Me.lbl_ano.TabIndex = 7
        Me.lbl_ano.Text = "."
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_genero.Location = New System.Drawing.Point(203, 350)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(13, 18)
        Me.lbl_genero.TabIndex = 8
        Me.lbl_genero.Text = "."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Jogo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(202, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Ano: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(202, 401)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Nome do criador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(202, 316)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Gênero:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("High Tower Text", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(370, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Selecione qual jogo comprado deseja ver:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(440, 226)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Data da compra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(440, 316)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Forma de Pagamento:"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_data.Location = New System.Drawing.Point(441, 266)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(13, 18)
        Me.lbl_data.TabIndex = 37
        Me.lbl_data.Text = "."
        '
        'lbl_forma
        '
        Me.lbl_forma.AutoSize = True
        Me.lbl_forma.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_forma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_forma.Location = New System.Drawing.Point(441, 350)
        Me.lbl_forma.Name = "lbl_forma"
        Me.lbl_forma.Size = New System.Drawing.Size(13, 18)
        Me.lbl_forma.TabIndex = 38
        Me.lbl_forma.Text = "."
        '
        'cmb_historico_compra
        '
        Me.cmb_historico_compra.FormattingEnabled = True
        Me.cmb_historico_compra.Location = New System.Drawing.Point(404, 132)
        Me.cmb_historico_compra.MaxDropDownItems = 30
        Me.cmb_historico_compra.Name = "cmb_historico_compra"
        Me.cmb_historico_compra.Size = New System.Drawing.Size(300, 21)
        Me.cmb_historico_compra.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 470)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Descrição do Jogo:"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.Location = New System.Drawing.Point(15, 492)
        Me.lbl_descricao.MaxLength = 1000
        Me.lbl_descricao.Multiline = True
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.ReadOnly = True
        Me.lbl_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.lbl_descricao.Size = New System.Drawing.Size(596, 79)
        Me.lbl_descricao.TabIndex = 42
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(440, 401)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(100, 19)
        Me.lbl.TabIndex = 43
        Me.lbl.Text = "Valor pago:"
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("High Tower Text", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_valor.Location = New System.Drawing.Point(441, 430)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(13, 18)
        Me.lbl_valor.TabIndex = 44
        Me.lbl_valor.Text = "."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_logo, Me.btn_perfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(719, 31)
        Me.ToolStrip1.TabIndex = 45
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_logo
        '
        Me.btn_logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_logo.Image = Global.QuackGames.My.Resources.Resources.logo_escuro
        Me.btn_logo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_logo.Name = "btn_logo"
        Me.btn_logo.Size = New System.Drawing.Size(28, 28)
        Me.btn_logo.Text = "Logo"
        '
        'btn_perfil
        '
        Me.btn_perfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_perfil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaToolStripMenuItem, Me.FavoritosToolStripMenuItem, Me.BibliotecaToolStripMenuItem, Me.VenderToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem, Me.SairToolStripMenuItem, Me.HistoricoToolStripMenuItem})
        Me.btn_perfil.Image = CType(resources.GetObject("btn_perfil.Image"), System.Drawing.Image)
        Me.btn_perfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_perfil.Name = "btn_perfil"
        Me.btn_perfil.Size = New System.Drawing.Size(37, 28)
        Me.btn_perfil.Text = "Perfil"
        '
        'ContaToolStripMenuItem
        '
        Me.ContaToolStripMenuItem.Image = CType(resources.GetObject("ContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContaToolStripMenuItem.Name = "ContaToolStripMenuItem"
        Me.ContaToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.ContaToolStripMenuItem.Text = "Perfil/Conta"
        '
        'FavoritosToolStripMenuItem
        '
        Me.FavoritosToolStripMenuItem.Image = Global.QuackGames.My.Resources.Resources.favorite_icon
        Me.FavoritosToolStripMenuItem.Name = "FavoritosToolStripMenuItem"
        Me.FavoritosToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.FavoritosToolStripMenuItem.Text = "Favoritos"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Image = CType(resources.GetObject("BibliotecaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'VenderToolStripMenuItem
        '
        Me.VenderToolStripMenuItem.Image = CType(resources.GetObject("VenderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        Me.VenderToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.VenderToolStripMenuItem.Text = "Vender"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Image = Global.QuackGames.My.Resources.Resources.login
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'HistoricoToolStripMenuItem
        '
        Me.HistoricoToolStripMenuItem.Name = "HistoricoToolStripMenuItem"
        Me.HistoricoToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.HistoricoToolStripMenuItem.Text = "Histórico"
        '
        'img_jogo
        '
        Me.img_jogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_jogo.Location = New System.Drawing.Point(12, 226)
        Me.img_jogo.Name = "img_jogo"
        Me.img_jogo.Size = New System.Drawing.Size(172, 227)
        Me.img_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo.TabIndex = 3
        Me.img_jogo.TabStop = False
        '
        'frm_historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 593)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_historico_compra)
        Me.Controls.Add(Me.lbl_forma)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.lbl_ano)
        Me.Controls.Add(Me.lbl_nomec)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_jogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_jogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_nomec As Label
    Friend WithEvents lbl_ano As Label
    Friend WithEvents lbl_genero As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_forma As Label
    Friend WithEvents cmb_historico_compra As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_descricao As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_logo As ToolStripButton
    Friend WithEvents btn_perfil As ToolStripDropDownButton
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavoritosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoToolStripMenuItem As ToolStripMenuItem
End Class
