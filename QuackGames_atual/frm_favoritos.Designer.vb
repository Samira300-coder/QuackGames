<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_favoritos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_favoritos))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_nomec = New System.Windows.Forms.Label()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.cmb_favoritos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_jogo = New System.Windows.Forms.PictureBox()
        Me.btn_comprar_item = New System.Windows.Forms.Button()
        Me.btn_remover_item = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_logo = New System.Windows.Forms.ToolStripButton()
        Me.btn_perfil = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(777, 438)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Gênero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(585, 438)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ano"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(714, 283)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nome do criador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(360, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nome do jogo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(360, 438)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 28)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Valor"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome.Location = New System.Drawing.Point(360, 330)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(19, 28)
        Me.lbl_nome.TabIndex = 35
        Me.lbl_nome.Text = "."
        '
        'lbl_nomec
        '
        Me.lbl_nomec.AutoSize = True
        Me.lbl_nomec.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nomec.Location = New System.Drawing.Point(714, 330)
        Me.lbl_nomec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nomec.Name = "lbl_nomec"
        Me.lbl_nomec.Size = New System.Drawing.Size(19, 28)
        Me.lbl_nomec.TabIndex = 36
        Me.lbl_nomec.Text = "."
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_valor.Location = New System.Drawing.Point(360, 482)
        Me.lbl_valor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(19, 28)
        Me.lbl_valor.TabIndex = 37
        Me.lbl_valor.Text = "."
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_ano.Location = New System.Drawing.Point(585, 482)
        Me.lbl_ano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(19, 28)
        Me.lbl_ano.TabIndex = 38
        Me.lbl_ano.Text = "."
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_genero.Location = New System.Drawing.Point(777, 482)
        Me.lbl_genero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(19, 28)
        Me.lbl_genero.TabIndex = 39
        Me.lbl_genero.Text = "."
        '
        'cmb_favoritos
        '
        Me.cmb_favoritos.FormattingEnabled = True
        Me.cmb_favoritos.Location = New System.Drawing.Point(610, 185)
        Me.cmb_favoritos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_favoritos.MaxDropDownItems = 30
        Me.cmb_favoritos.Name = "cmb_favoritos"
        Me.cmb_favoritos.Size = New System.Drawing.Size(400, 28)
        Me.cmb_favoritos.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("High Tower Text", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(42, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(481, 30)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Selecione qual jogo favoritado deseja ver:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(309, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 59)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Jogos Favoritados:"
        '
        'img_jogo
        '
        Me.img_jogo.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo.Location = New System.Drawing.Point(48, 283)
        Me.img_jogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.img_jogo.Name = "img_jogo"
        Me.img_jogo.Size = New System.Drawing.Size(255, 255)
        Me.img_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo.TabIndex = 17
        Me.img_jogo.TabStop = False
        '
        'btn_comprar_item
        '
        Me.btn_comprar_item.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_comprar_item.Font = New System.Drawing.Font("High Tower Text", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btn_comprar_item.Location = New System.Drawing.Point(339, 590)
        Me.btn_comprar_item.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_comprar_item.Name = "btn_comprar_item"
        Me.btn_comprar_item.Size = New System.Drawing.Size(178, 63)
        Me.btn_comprar_item.TabIndex = 47
        Me.btn_comprar_item.Text = "Comprar"
        Me.btn_comprar_item.UseVisualStyleBackColor = False
        '
        'btn_remover_item
        '
        Me.btn_remover_item.BackColor = System.Drawing.Color.DarkRed
        Me.btn_remover_item.Font = New System.Drawing.Font("High Tower Text", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btn_remover_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_remover_item.Location = New System.Drawing.Point(584, 590)
        Me.btn_remover_item.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_remover_item.Name = "btn_remover_item"
        Me.btn_remover_item.Size = New System.Drawing.Size(176, 63)
        Me.btn_remover_item.TabIndex = 48
        Me.btn_remover_item.Text = "Remover "
        Me.btn_remover_item.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_logo, Me.btn_perfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1065, 33)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_logo
        '
        Me.btn_logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_logo.Image = Global.QuackGames.My.Resources.Resources.logo_escuro
        Me.btn_logo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_logo.Name = "btn_logo"
        Me.btn_logo.Size = New System.Drawing.Size(34, 28)
        Me.btn_logo.Text = "Logo"
        '
        'btn_perfil
        '
        Me.btn_perfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_perfil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaToolStripMenuItem, Me.BibliotecaToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.VenderToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.btn_perfil.Image = CType(resources.GetObject("btn_perfil.Image"), System.Drawing.Image)
        Me.btn_perfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_perfil.Name = "btn_perfil"
        Me.btn_perfil.Size = New System.Drawing.Size(42, 28)
        Me.btn_perfil.Text = "Perfil"
        '
        'ContaToolStripMenuItem
        '
        Me.ContaToolStripMenuItem.Image = CType(resources.GetObject("ContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContaToolStripMenuItem.Name = "ContaToolStripMenuItem"
        Me.ContaToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ContaToolStripMenuItem.Text = "Perfil/Conta"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Image = CType(resources.GetObject("BibliotecaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Image = CType(resources.GetObject("HistóricoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HistóricoToolStripMenuItem.Text = "Histórico"
        '
        'VenderToolStripMenuItem
        '
        Me.VenderToolStripMenuItem.Image = CType(resources.GetObject("VenderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        Me.VenderToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.VenderToolStripMenuItem.Text = "Vender"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Image = Global.QuackGames.My.Resources.Resources.login
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'frm_favoritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 682)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_remover_item)
        Me.Controls.Add(Me.btn_comprar_item)
        Me.Controls.Add(Me.cmb_favoritos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.lbl_ano)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.lbl_nomec)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.img_jogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_favoritos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favoritos"
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents img_jogo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_nomec As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents lbl_ano As Label
    Friend WithEvents lbl_genero As Label
    Friend WithEvents cmb_favoritos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_comprar_item As Button
    Friend WithEvents btn_remover_item As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_logo As ToolStripButton
    Friend WithEvents btn_perfil As ToolStripDropDownButton
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
End Class
