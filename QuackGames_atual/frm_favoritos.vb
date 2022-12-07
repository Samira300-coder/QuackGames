Public Class frm_favoritos

    Private Sub frm_favoritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_favoritos()
        BackColor = Color.White
        ToolStrip1.ForeColor = Color.DarkOrange
        ToolStrip1.BackColor = Color.White
        modo_escuro()

        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False
            Else
                HistóricoToolStripMenuItem.Visible = False
                btn_comprar_item.Visible = False
                btn_remover_item.Visible = False
            End If
        End If

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

    Private Sub cmb_favoritos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_favoritos.SelectedIndexChanged
        Try
            'If IsNothing(cmb_historico_compra.DataSource) Then
            'MsgBox("Selecione qual jogo deseja pesquisar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            'Else

            sql = "select * from tb_jogo where nome_jogo='" & cmb_favoritos.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_nome.Text = rs.Fields(1).Value
                lbl_ano.Text = rs.Fields(3).Value
                lbl_genero.Text = rs.Fields(4).Value
                lbl_nomec.Text = rs.Fields(2).Value
                lbl_valor.Text = rs.Fields(6).Value
                img_jogo.Load(rs.Fields(5).Value)
            End If
            'End If
        Catch ex As Exception
            MsgBox("Algo deu errado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_remover_item_Click(sender As Object, e As EventArgs) Handles btn_remover_item.Click
        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                        "Jogo: " & lbl_nome.Text & " dos seus favoritos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            sql = "delete * from tb_favoritos where jogo= '" & lbl_nome.Text & "' And cpf ='" & frm_comprar.lbl_cpf.Text & "'"
            rs = db.Execute(sql)
            carregar_dados()
        End If
        lbl_nome.Text = "."
        lbl_ano.Text = "."
        lbl_genero.Text = "."
        lbl_nomec.Text = "."
        lbl_valor.Text = "."
        img_jogo.Load(Application.StartupPath & "\Foto_jogo\tela_branca.jpeg")

    End Sub

    Private Sub btn_comprar_item_Click_1(sender As Object, e As EventArgs) Handles btn_comprar_item.Click
        frm_comprar.lbl_nome.Text = lbl_nome.Text
        frm_comprar.Show()
    End Sub

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.Show()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        frm_biblioteca.ShowDialog()
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
            frm_login.Show()
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