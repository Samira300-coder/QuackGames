Public Class frm_biblioteca
    Private Sub dgv_b_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_b.CellContentClick
        Try
            With dgv_b
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_joguinho = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_jogo where nome_jogo='" & aux_joguinho & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then

                        With frm_jogo
                            .lbl_nome.Text = rs.Fields(1).Value
                            .lbl_nomec.Text = rs.Fields(2).Value
                            .lbl_ano.Text = rs.Fields(3).Value
                            .lbl_genero.Text = rs.Fields(4).Value
                            .lbl_valor.Text = rs.Fields(6).Value
                            .lbl_descricao.Text = rs.Fields(7).Value
                            .img_jogo.Load(rs.Fields(5).Value)
                        End With
                        carregar_biblioteca()
                        Me.Hide()
                        frm_jogo.Show()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_biblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_biblioteca()
        conectar_banco()
        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False
            Else
                FavoritosToolStripMenuItem.Visible = False
                HistóricoToolStripMenuItem.Visible = False
            End If
        End If

        BackColor = Color.White
        ToolStrip1.ForeColor = Color.Orange
        ToolStrip1.BackColor = Color.White
        modo_escuro()

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

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.Show()
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.Show()
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        Me.Hide()
        frm_historico.ShowDialog()
    End Sub

    Private Sub VenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderToolStripMenuItem.Click
        Me.Hide()
        frm_vender.Show()
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