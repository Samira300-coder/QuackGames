<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_esqueci = New System.Windows.Forms.LinkLabel()
        Me.btn_logar = New System.Windows.Forms.Button()
        Me.lbl_cadastro = New System.Windows.Forms.LinkLabel()
        Me.chk_visual = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(88, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario ou E-mail"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.Black
        Me.txt_usuario.Font = New System.Drawing.Font("High Tower Text", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.White
        Me.txt_usuario.Location = New System.Drawing.Point(95, 45)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(354, 29)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Black
        Me.txt_senha.Font = New System.Drawing.Font("High Tower Text", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.White
        Me.txt_senha.Location = New System.Drawing.Point(94, 125)
        Me.txt_senha.MaxLength = 15
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(354, 29)
        Me.txt_senha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(90, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha"
        '
        'lbl_esqueci
        '
        Me.lbl_esqueci.AutoSize = True
        Me.lbl_esqueci.Font = New System.Drawing.Font("High Tower Text", 13.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esqueci.ForeColor = System.Drawing.Color.Red
        Me.lbl_esqueci.Location = New System.Drawing.Point(38, 232)
        Me.lbl_esqueci.Name = "lbl_esqueci"
        Me.lbl_esqueci.Size = New System.Drawing.Size(135, 21)
        Me.lbl_esqueci.TabIndex = 4
        Me.lbl_esqueci.TabStop = True
        Me.lbl_esqueci.Text = "Esqueci senha"
        '
        'btn_logar
        '
        Me.btn_logar.BackgroundImage = Global.QuackGames.My.Resources.Resources.preto11
        Me.btn_logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logar.Font = New System.Drawing.Font("High Tower Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logar.Location = New System.Drawing.Point(201, 298)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(146, 46)
        Me.btn_logar.TabIndex = 5
        Me.btn_logar.Text = "LOGAR"
        Me.btn_logar.UseVisualStyleBackColor = True
        '
        'lbl_cadastro
        '
        Me.lbl_cadastro.AutoSize = True
        Me.lbl_cadastro.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cadastro.Location = New System.Drawing.Point(379, 232)
        Me.lbl_cadastro.Name = "lbl_cadastro"
        Me.lbl_cadastro.Size = New System.Drawing.Size(156, 19)
        Me.lbl_cadastro.TabIndex = 6
        Me.lbl_cadastro.TabStop = True
        Me.lbl_cadastro.Text = "Não tenho cadastro"
        '
        'chk_visual
        '
        Me.chk_visual.AutoSize = True
        Me.chk_visual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_visual.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visual.Location = New System.Drawing.Point(172, 197)
        Me.chk_visual.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.chk_visual.Name = "chk_visual"
        Me.chk_visual.Size = New System.Drawing.Size(185, 26)
        Me.chk_visual.TabIndex = 10
        Me.chk_visual.Text = "Visualizar Senha"
        Me.chk_visual.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 357)
        Me.Controls.Add(Me.chk_visual)
        Me.Controls.Add(Me.lbl_cadastro)
        Me.Controls.Add(Me.lbl_esqueci)
        Me.Controls.Add(Me.btn_logar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_esqueci As LinkLabel
    Friend WithEvents btn_logar As Button
    Friend WithEvents lbl_cadastro As LinkLabel
    Friend WithEvents chk_visual As CheckBox
End Class
