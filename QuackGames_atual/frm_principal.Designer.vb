<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_logo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_perfil = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nome2 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome3 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome4 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome5 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome6 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome7 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome8 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome9 = New System.Windows.Forms.LinkLabel()
        Me.lbl_nome10 = New System.Windows.Forms.LinkLabel()
        Me.img_jogo10 = New System.Windows.Forms.PictureBox()
        Me.img_jogo9 = New System.Windows.Forms.PictureBox()
        Me.Img_jogo8 = New System.Windows.Forms.PictureBox()
        Me.img_jogo7 = New System.Windows.Forms.PictureBox()
        Me.img_jogo6 = New System.Windows.Forms.PictureBox()
        Me.img_jogo5 = New System.Windows.Forms.PictureBox()
        Me.img_jogo4 = New System.Windows.Forms.PictureBox()
        Me.img_jogo3 = New System.Windows.Forms.PictureBox()
        Me.img_jogo2 = New System.Windows.Forms.PictureBox()
        Me.img_jogo = New System.Windows.Forms.PictureBox()
        Me.lbl_nome = New System.Windows.Forms.LinkLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_jogo10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Img_jogo8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_logo, Me.ToolStripLabel1, Me.txt_busca, Me.btn_perfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(892, 31)
        Me.ToolStrip1.TabIndex = 3
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 28)
        Me.ToolStripLabel1.Text = "Buscar:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(300, 31)
        '
        'btn_perfil
        '
        Me.btn_perfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_perfil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaToolStripMenuItem, Me.FavoritosToolStripMenuItem, Me.BibliotecaToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.VenderToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.btn_perfil.Font = New System.Drawing.Font("High Tower Text", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ContaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ContaToolStripMenuItem.Text = "Perfil/Conta"
        '
        'FavoritosToolStripMenuItem
        '
        Me.FavoritosToolStripMenuItem.Image = Global.QuackGames.My.Resources.Resources.favorite_icon
        Me.FavoritosToolStripMenuItem.Name = "FavoritosToolStripMenuItem"
        Me.FavoritosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.FavoritosToolStripMenuItem.Text = "Favoritos"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Image = CType(resources.GetObject("BibliotecaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Image = CType(resources.GetObject("HistóricoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HistóricoToolStripMenuItem.Text = "Histórico"
        '
        'VenderToolStripMenuItem
        '
        Me.VenderToolStripMenuItem.Image = CType(resources.GetObject("VenderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        Me.VenderToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VenderToolStripMenuItem.Text = "Vender"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Image = Global.QuackGames.My.Resources.Resources.login
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(339, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BEST SELLERS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(155, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(569, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ORIGINAIS DOS CRIADORES DO QUACK GAMES:"
        '
        'lbl_nome2
        '
        Me.lbl_nome2.AccessibleName = "lbl_group"
        Me.lbl_nome2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome2.AllowDrop = True
        Me.lbl_nome2.AutoSize = True
        Me.lbl_nome2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome2.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome2.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome2.Location = New System.Drawing.Point(204, 253)
        Me.lbl_nome2.Name = "lbl_nome2"
        Me.lbl_nome2.Size = New System.Drawing.Size(83, 19)
        Me.lbl_nome2.TabIndex = 13
        Me.lbl_nome2.TabStop = True
        Me.lbl_nome2.Text = "Minecraft"
        Me.lbl_nome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome3
        '
        Me.lbl_nome3.AccessibleName = "lbl_group"
        Me.lbl_nome3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome3.AllowDrop = True
        Me.lbl_nome3.AutoSize = True
        Me.lbl_nome3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome3.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome3.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome3.LinkVisited = True
        Me.lbl_nome3.Location = New System.Drawing.Point(378, 253)
        Me.lbl_nome3.Name = "lbl_nome3"
        Me.lbl_nome3.Size = New System.Drawing.Size(89, 19)
        Me.lbl_nome3.TabIndex = 14
        Me.lbl_nome3.TabStop = True
        Me.lbl_nome3.Text = "Overwatch"
        Me.lbl_nome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome3.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome4
        '
        Me.lbl_nome4.AccessibleName = "lbl_group"
        Me.lbl_nome4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome4.AllowDrop = True
        Me.lbl_nome4.AutoSize = True
        Me.lbl_nome4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome4.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome4.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome4.LinkVisited = True
        Me.lbl_nome4.Location = New System.Drawing.Point(544, 253)
        Me.lbl_nome4.Name = "lbl_nome4"
        Me.lbl_nome4.Size = New System.Drawing.Size(124, 19)
        Me.lbl_nome4.TabIndex = 15
        Me.lbl_nome4.TabStop = True
        Me.lbl_nome4.Text = "The Last of Us"
        Me.lbl_nome4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome4.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome5
        '
        Me.lbl_nome5.AccessibleName = "lbl_group"
        Me.lbl_nome5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome5.AllowDrop = True
        Me.lbl_nome5.AutoSize = True
        Me.lbl_nome5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome5.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome5.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome5.LinkVisited = True
        Me.lbl_nome5.Location = New System.Drawing.Point(723, 253)
        Me.lbl_nome5.Name = "lbl_nome5"
        Me.lbl_nome5.Size = New System.Drawing.Size(132, 19)
        Me.lbl_nome5.TabIndex = 16
        Me.lbl_nome5.TabStop = True
        Me.lbl_nome5.Text = "Cyberpunk 2077"
        Me.lbl_nome5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome5.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome6
        '
        Me.lbl_nome6.AccessibleName = "lbl_group"
        Me.lbl_nome6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome6.AllowDrop = True
        Me.lbl_nome6.AutoSize = True
        Me.lbl_nome6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome6.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome6.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome6.LinkVisited = True
        Me.lbl_nome6.Location = New System.Drawing.Point(44, 540)
        Me.lbl_nome6.Name = "lbl_nome6"
        Me.lbl_nome6.Size = New System.Drawing.Size(80, 19)
        Me.lbl_nome6.TabIndex = 25
        Me.lbl_nome6.TabStop = True
        Me.lbl_nome6.Text = "Pato Star"
        Me.lbl_nome6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome6.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome7
        '
        Me.lbl_nome7.AccessibleName = "lbl_group"
        Me.lbl_nome7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome7.AllowDrop = True
        Me.lbl_nome7.AutoSize = True
        Me.lbl_nome7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome7.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome7.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome7.LinkVisited = True
        Me.lbl_nome7.Location = New System.Drawing.Point(203, 540)
        Me.lbl_nome7.Name = "lbl_nome7"
        Me.lbl_nome7.Size = New System.Drawing.Size(84, 19)
        Me.lbl_nome7.TabIndex = 26
        Me.lbl_nome7.TabStop = True
        Me.lbl_nome7.Text = "Psicopato"
        Me.lbl_nome7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome7.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome8
        '
        Me.lbl_nome8.AccessibleName = "lbl_group"
        Me.lbl_nome8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome8.AllowDrop = True
        Me.lbl_nome8.AutoSize = True
        Me.lbl_nome8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome8.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome8.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome8.LinkVisited = True
        Me.lbl_nome8.Location = New System.Drawing.Point(387, 540)
        Me.lbl_nome8.Name = "lbl_nome8"
        Me.lbl_nome8.Size = New System.Drawing.Size(71, 19)
        Me.lbl_nome8.TabIndex = 27
        Me.lbl_nome8.TabStop = True
        Me.lbl_nome8.Text = "Patotive"
        Me.lbl_nome8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome8.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome9
        '
        Me.lbl_nome9.AccessibleName = "lbl_group"
        Me.lbl_nome9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome9.AllowDrop = True
        Me.lbl_nome9.AutoSize = True
        Me.lbl_nome9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome9.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome9.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome9.LinkVisited = True
        Me.lbl_nome9.Location = New System.Drawing.Point(534, 540)
        Me.lbl_nome9.Name = "lbl_nome9"
        Me.lbl_nome9.Size = New System.Drawing.Size(149, 19)
        Me.lbl_nome9.TabIndex = 28
        Me.lbl_nome9.TabStop = True
        Me.lbl_nome9.Text = "Agente Patológico"
        Me.lbl_nome9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome9.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_nome10
        '
        Me.lbl_nome10.AccessibleName = "lbl_group"
        Me.lbl_nome10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome10.AllowDrop = True
        Me.lbl_nome10.AutoSize = True
        Me.lbl_nome10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome10.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome10.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome10.LinkVisited = True
        Me.lbl_nome10.Location = New System.Drawing.Point(735, 540)
        Me.lbl_nome10.Name = "lbl_nome10"
        Me.lbl_nome10.Size = New System.Drawing.Size(96, 19)
        Me.lbl_nome10.TabIndex = 29
        Me.lbl_nome10.TabStop = True
        Me.lbl_nome10.Text = "Patoda vida"
        Me.lbl_nome10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome10.VisitedLinkColor = System.Drawing.Color.Black
        '
        'img_jogo10
        '
        Me.img_jogo10.AccessibleName = "img_group"
        Me.img_jogo10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo10.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo10.Image = CType(resources.GetObject("img_jogo10.Image"), System.Drawing.Image)
        Me.img_jogo10.Location = New System.Drawing.Point(727, 394)
        Me.img_jogo10.Name = "img_jogo10"
        Me.img_jogo10.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo10.TabIndex = 24
        Me.img_jogo10.TabStop = False
        '
        'img_jogo9
        '
        Me.img_jogo9.AccessibleName = "img_group"
        Me.img_jogo9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo9.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo9.Image = CType(resources.GetObject("img_jogo9.Image"), System.Drawing.Image)
        Me.img_jogo9.Location = New System.Drawing.Point(548, 394)
        Me.img_jogo9.Name = "img_jogo9"
        Me.img_jogo9.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo9.TabIndex = 23
        Me.img_jogo9.TabStop = False
        '
        'Img_jogo8
        '
        Me.Img_jogo8.AccessibleName = "img_group"
        Me.Img_jogo8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Img_jogo8.BackColor = System.Drawing.Color.Transparent
        Me.Img_jogo8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Img_jogo8.Image = CType(resources.GetObject("Img_jogo8.Image"), System.Drawing.Image)
        Me.Img_jogo8.Location = New System.Drawing.Point(366, 394)
        Me.Img_jogo8.Name = "Img_jogo8"
        Me.Img_jogo8.Size = New System.Drawing.Size(113, 125)
        Me.Img_jogo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_jogo8.TabIndex = 22
        Me.Img_jogo8.TabStop = False
        '
        'img_jogo7
        '
        Me.img_jogo7.AccessibleName = "img_group"
        Me.img_jogo7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo7.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo7.Image = CType(resources.GetObject("img_jogo7.Image"), System.Drawing.Image)
        Me.img_jogo7.Location = New System.Drawing.Point(185, 394)
        Me.img_jogo7.Name = "img_jogo7"
        Me.img_jogo7.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo7.TabIndex = 21
        Me.img_jogo7.TabStop = False
        '
        'img_jogo6
        '
        Me.img_jogo6.AccessibleName = "img_group"
        Me.img_jogo6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo6.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo6.Image = CType(resources.GetObject("img_jogo6.Image"), System.Drawing.Image)
        Me.img_jogo6.Location = New System.Drawing.Point(27, 394)
        Me.img_jogo6.Name = "img_jogo6"
        Me.img_jogo6.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo6.TabIndex = 20
        Me.img_jogo6.TabStop = False
        '
        'img_jogo5
        '
        Me.img_jogo5.AccessibleName = "img_group"
        Me.img_jogo5.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo5.Image = CType(resources.GetObject("img_jogo5.Image"), System.Drawing.Image)
        Me.img_jogo5.Location = New System.Drawing.Point(727, 110)
        Me.img_jogo5.Name = "img_jogo5"
        Me.img_jogo5.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo5.TabIndex = 19
        Me.img_jogo5.TabStop = False
        '
        'img_jogo4
        '
        Me.img_jogo4.AccessibleName = "img_group"
        Me.img_jogo4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo4.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo4.Image = CType(resources.GetObject("img_jogo4.Image"), System.Drawing.Image)
        Me.img_jogo4.Location = New System.Drawing.Point(548, 110)
        Me.img_jogo4.Name = "img_jogo4"
        Me.img_jogo4.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo4.TabIndex = 18
        Me.img_jogo4.TabStop = False
        '
        'img_jogo3
        '
        Me.img_jogo3.AccessibleName = "img_group"
        Me.img_jogo3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo3.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo3.Image = CType(resources.GetObject("img_jogo3.Image"), System.Drawing.Image)
        Me.img_jogo3.Location = New System.Drawing.Point(366, 110)
        Me.img_jogo3.Name = "img_jogo3"
        Me.img_jogo3.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo3.TabIndex = 17
        Me.img_jogo3.TabStop = False
        '
        'img_jogo2
        '
        Me.img_jogo2.AccessibleName = "img_group"
        Me.img_jogo2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo2.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo2.Image = CType(resources.GetObject("img_jogo2.Image"), System.Drawing.Image)
        Me.img_jogo2.Location = New System.Drawing.Point(185, 110)
        Me.img_jogo2.Name = "img_jogo2"
        Me.img_jogo2.Size = New System.Drawing.Size(113, 125)
        Me.img_jogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo2.TabIndex = 7
        Me.img_jogo2.TabStop = False
        '
        'img_jogo
        '
        Me.img_jogo.AccessibleName = "img_group"
        Me.img_jogo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.img_jogo.BackColor = System.Drawing.Color.Transparent
        Me.img_jogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_jogo.Image = CType(resources.GetObject("img_jogo.Image"), System.Drawing.Image)
        Me.img_jogo.Location = New System.Drawing.Point(27, 110)
        Me.img_jogo.Name = "img_jogo"
        Me.img_jogo.Size = New System.Drawing.Size(111, 125)
        Me.img_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_jogo.TabIndex = 5
        Me.img_jogo.TabStop = False
        '
        'lbl_nome
        '
        Me.lbl_nome.AccessibleName = "lbl_group"
        Me.lbl_nome.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.lbl_nome.AllowDrop = True
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.LinkColor = System.Drawing.Color.Black
        Me.lbl_nome.Location = New System.Drawing.Point(16, 253)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(146, 19)
        Me.lbl_nome.TabIndex = 30
        Me.lbl_nome.TabStop = True
        Me.lbl_nome.Text = "Grand Theft Auto"
        Me.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_nome.VisitedLinkColor = System.Drawing.Color.Black
        '
        'frm_principal
        '
        Me.AccessibleName = "lbl_group"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuackGames.My.Resources.Resources.logo_escuro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 579)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_nome10)
        Me.Controls.Add(Me.lbl_nome9)
        Me.Controls.Add(Me.lbl_nome8)
        Me.Controls.Add(Me.lbl_nome7)
        Me.Controls.Add(Me.lbl_nome6)
        Me.Controls.Add(Me.img_jogo10)
        Me.Controls.Add(Me.img_jogo9)
        Me.Controls.Add(Me.Img_jogo8)
        Me.Controls.Add(Me.img_jogo7)
        Me.Controls.Add(Me.img_jogo6)
        Me.Controls.Add(Me.img_jogo5)
        Me.Controls.Add(Me.img_jogo4)
        Me.Controls.Add(Me.img_jogo3)
        Me.Controls.Add(Me.lbl_nome5)
        Me.Controls.Add(Me.lbl_nome4)
        Me.Controls.Add(Me.lbl_nome3)
        Me.Controls.Add(Me.lbl_nome2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_jogo2)
        Me.Controls.Add(Me.img_jogo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Principal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_jogo10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Img_jogo8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_logo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents btn_perfil As ToolStripDropDownButton
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents img_jogo As PictureBox
    Friend WithEvents img_jogo2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nome2 As LinkLabel
    Friend WithEvents lbl_nome3 As LinkLabel
    Friend WithEvents lbl_nome4 As LinkLabel
    Friend WithEvents lbl_nome5 As LinkLabel
    Friend WithEvents img_jogo3 As PictureBox
    Friend WithEvents img_jogo4 As PictureBox
    Friend WithEvents img_jogo5 As PictureBox
    Friend WithEvents img_jogo6 As PictureBox
    Friend WithEvents img_jogo7 As PictureBox
    Friend WithEvents Img_jogo8 As PictureBox
    Friend WithEvents img_jogo9 As PictureBox
    Friend WithEvents img_jogo10 As PictureBox
    Friend WithEvents lbl_nome6 As LinkLabel
    Friend WithEvents lbl_nome7 As LinkLabel
    Friend WithEvents lbl_nome8 As LinkLabel
    Friend WithEvents lbl_nome9 As LinkLabel
    Friend WithEvents lbl_nome10 As LinkLabel
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavoritosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_nome As LinkLabel
End Class
