Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frm_historico

    Private Sub frm_historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_historico()
        BackColor = Color.White
        ToolStrip1.ForeColor = Color.DarkOrange
        ToolStrip1.BackColor = Color.White
        modo_escuro()

        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False

            End If
        End If
        FavoritosToolStripMenuItem.Visible = False
    End Sub

    Sub modo_escuro()
        If frm_perfil_conta.CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.ToolStrip1.BackColor = Color.Black
            Me.ToolStrip1.ForeColor = Color.Orange
        Else
            Me.BackColor = Color.White
            Me.ToolStrip1.ForeColor = Color.DarkOrange
            Me.ToolStrip1.BackColor = Color.White
        End If
    End Sub

    Private Sub cmb_historico_compra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_historico_compra.SelectedIndexChanged
        Try
            'If IsNothing(cmb_historico_compra.DataSource) Then
            'MsgBox("Selecione qual jogo deseja pesquisar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            'Else
            sql = "select * from tb_compra where jogo='" & cmb_historico_compra.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_nome.Text = rs.Fields(1).Value
                lbl_valor.Text = rs.Fields(2).Value
                lbl_forma.Text = rs.Fields(3).Value
                lbl_data.Text = rs.Fields(5).Value

            End If

            sql = "select * from tb_jogo where nome_jogo='" & cmb_historico_compra.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_ano.Text = rs.Fields(3).Value
                lbl_genero.Text = rs.Fields(4).Value
                lbl_nomec.Text = rs.Fields(2).Value
                lbl_descricao.Text = rs.Fields(7).Value
                img_jogo.Load(rs.Fields(5).Value)
            End If
            '   End If
        Catch ex As Exception
            MsgBox("Algo deu errado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.Show()
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.Show()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        frm_biblioteca.Show()
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


    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTT   FIM TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
End Class