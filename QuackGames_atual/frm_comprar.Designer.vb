<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comprar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_comprar))
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.img_jogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_pgto = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_nome_usuario = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_logo = New System.Windows.Forms.ToolStripButton()
        Me.btn_perfil = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_ok = New System.Windows.Forms.Button()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_valor.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.ForeColor = System.Drawing.Color.White
        Me.lbl_valor.Location = New System.Drawing.Point(212, 250)
        Me.lbl_valor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(16, 22)
        Me.lbl_valor.TabIndex = 40
        Me.lbl_valor.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(212, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(212, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Jogo:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_nome.Location = New System.Drawing.Point(212, 96)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(16, 22)
        Me.lbl_nome.TabIndex = 37
        Me.lbl_nome.Text = "."
        '
        'img_jogo
        '
        Me.img_jogo.BackColor = System.Drawing.Color.DimGray
        Me.img_jogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo.Location = New System.Drawing.Point(12, 67)
        Me.img_jogo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.img_jogo.Name = "img_jogo"
        Me.img_jogo.Size = New System.Drawing.Size(178, 208)
        Me.img_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo.TabIndex = 36
        Me.img_jogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(208, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Forma de Pagamento"
        '
        'cmb_pgto
        '
        Me.cmb_pgto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_pgto.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pgto.ForeColor = System.Drawing.Color.White
        Me.cmb_pgto.FormattingEnabled = True
        Me.cmb_pgto.Items.AddRange(New Object() {"PIX", "BOLETO", "CRÉDITO"})
        Me.cmb_pgto.Location = New System.Drawing.Point(210, 171)
        Me.cmb_pgto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_pgto.Name = "cmb_pgto"
        Me.cmb_pgto.Size = New System.Drawing.Size(198, 30)
        Me.cmb_pgto.TabIndex = 33
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(530, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "CPF do comprador:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_cpf.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.Color.White
        Me.lbl_cpf.Location = New System.Drawing.Point(532, 176)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(16, 22)
        Me.lbl_cpf.TabIndex = 41
        Me.lbl_cpf.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(530, 221)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 22)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "E-mail do comprador:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_email.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.White
        Me.lbl_email.Location = New System.Drawing.Point(532, 250)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(16, 22)
        Me.lbl_email.TabIndex = 43
        Me.lbl_email.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(530, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nome do Comprador:"
        '
        'lbl_nome_usuario
        '
        Me.lbl_nome_usuario.AutoSize = True
        Me.lbl_nome_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome_usuario.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_nome_usuario.Location = New System.Drawing.Point(532, 96)
        Me.lbl_nome_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_usuario.Name = "lbl_nome_usuario"
        Me.lbl_nome_usuario.Size = New System.Drawing.Size(16, 22)
        Me.lbl_nome_usuario.TabIndex = 49
        Me.lbl_nome_usuario.Text = "."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_logo, Me.btn_perfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(869, 31)
        Me.ToolStrip1.TabIndex = 50
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
        Me.btn_perfil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaToolStripMenuItem, Me.FavoritosToolStripMenuItem, Me.BibliotecaToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.VenderToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem, Me.SairToolStripMenuItem})
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
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Image = CType(resources.GetObject("HistóricoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(189, 30)
        Me.HistóricoToolStripMenuItem.Text = "Histórico"
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
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(350, 347)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 34)
        Me.btn_ok.TabIndex = 51
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'frm_comprar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 422)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_nome_usuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.img_jogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_pgto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_comprar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compre o jogo!"
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_valor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents img_jogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_pgto As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_nome_usuario As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_logo As ToolStripButton
    Friend WithEvents btn_perfil As ToolStripDropDownButton
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavoritosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_ok As Button
End Class
