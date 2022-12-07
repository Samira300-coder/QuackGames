Imports System.Xml
Imports System.Diagnostics

Public Class frm_perfil_conta

    Private Sub frm_perfil_conta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        BackColor = Color.White
        ToolStrip1.ForeColor = Color.Orange
        ToolStrip1.BackColor = Color.White

        txt_nome.Text = lbl_nome.Text


        ' Try
        If frm_login.txt_usuario.Text = "admin" Then
            lbl_nome.Text = "Adm"
            TabPage2.Visible = False
            Exit Sub
        End If

        sql = "select * from tb_login where usuario='" & lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nome.Text = rs.Fields(1).Value
            txt_senha.Text = rs.Fields(3).Value
            txt_email.Text = rs.Fields(2).Value

            If rs.Fields(5).Value = "USUÁRIO" Then
                sql = "select * from tb_cadastro where email='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_fone.Text = rs.Fields(9).Value
                    txt_data.Value = rs.Fields(1).Value
                    img_fottle.Load(rs.Fields(11).Value)
                    img_foto.Load(rs.Fields(11).Value)
                End If
            Else
                sql = "select * from tb_cadastro_criador where email='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_fone.Text = rs.Fields(9).Value
                    txt_data.Value = rs.Fields(1).Value
                    img_fottle.Load(rs.Fields(11).Value)
                    img_foto.Load(rs.Fields(11).Value)
                End If
            End If

        End If

        sql = "select * from tb_login where usuario='" & lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                btn_relat.Visible = False
                VenderToolStripMenuItem.Visible = False
            Else
                HistóricoToolStripMenuItem.Visible = False
                FavoritosToolStripMenuItem.Visible = False
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            BackColor = Color.Black
            TabPage1.BackColor = Color.Black
            TabPage2.BackColor = Color.Black
            ToolStrip1.BackColor = Color.Black
            ToolStrip1.ForeColor = Color.Orange

        Else
            BackColor = Color.White
            TabPage1.BackColor = Color.White
            TabPage2.BackColor = Color.White
            ToolStrip1.ForeColor = Color.Orange
            ToolStrip1.BackColor = Color.White

        End If
    End Sub


    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Try
            Dim bgbrush As Brush 'cor do fundo
            Dim foreColorBrush As Brush 'Cor da fonte
            Dim font As Font

            If e.Index = TabControl1.SelectedIndex Then
                'Mudar aparência do tabcontrol selecionado
                font = New Font(e.Font, FontStyle.Bold)
                bgbrush = New System.Drawing.SolidBrush(Color.Black)
                foreColorBrush = Brushes.Orange
            Else
                'Mudar aparencia dos tab controls
                font = New Font(e.Font, FontStyle.Regular)
                bgbrush = New SolidBrush(Color.White)
                foreColorBrush = New SolidBrush(Color.Orange)
            End If

            'Alinhamento do texto
            Dim tabName = TabControl1.TabPages(e.Index).Text
            Dim sf As StringFormat = New StringFormat
            sf.Alignment = StringAlignment.Center

            'preencher tab selecionada
            e.Graphics.FillRectangle(bgbrush, e.Bounds)

            Dim r As Rectangle = e.Bounds
            r = New Rectangle(r.X, r.Y + 3, r.Width + 3, r.Height - 3)

            e.Graphics.DrawString(tabName, font, foreColorBrush, r, sf)

            sf.Dispose() 'liberar os recursos
            If e.Index = TabControl1.SelectedIndex Then
                bgbrush.Dispose()
            Else
                bgbrush.Dispose()
                foreColorBrush.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        Me.Hide()
        frm_historico.ShowDialog()
    End Sub

    Private Sub VenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderToolStripMenuItem.Click
        Me.Hide()
        frm_vender.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair? Será necessário logar novamente!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Me.Hide()
            frm_login.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_logo_Click(sender As Object, e As EventArgs) Handles btn_logo.Click
        Me.Hide()
        frm_principal.Show()
    End Sub

    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        Try
            Process.Start(Application.StartupPath & "\Banco_dados\cadastro.mdb")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.ShowDialog()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        frm_biblioteca.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Process.Start("mailto: quackgames.suporte@gmail.com")
        'Process.Start("www.gmail.com")
        'System.Diagnostics.Process.Start(String.Format("mailto:{0}", "quackgames.suporte@gmail.com"))
    End Sub
End Class
