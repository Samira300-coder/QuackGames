Imports System.Data.SqlClient

Public Class frm_jogo

    Private Sub frm_jogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        BackColor = Color.White
        ToolStrip1.ForeColor = Color.DarkOrange
        ToolStrip1.BackColor = Color.White
        modo_escuro()
        frm_comprar.lbl_nome.Text = lbl_nome.Text

        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False
            Else
                HistóricoToolStripMenuItem.Visible = False
                FavoritosToolStripMenuItem.Visible = False
                btn_favoritar.Visible = False
                btn_comprar.Visible = False
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


    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        Try
            sql = "select * from tb_jogo where nome_jogo='" & lbl_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                With frm_comprar
                    .img_jogo.Load(rs.Fields(5).Value)
                    .lbl_nome.Text = rs.Fields(1).Value
                    .lbl_valor.Text = rs.Fields(6).Value
                    .img_jogo.Load(rs.Fields(5).Value)
                End With
                Me.Hide()
                frm_comprar.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Algo deu errado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub


    Private Sub btn_favoritar_Click(sender As Object, e As EventArgs) Handles btn_favoritar.Click
        Try
            resp = MsgBox("Deseja favoritar o jogo " + vbNewLine &
                     "" & lbl_nome.Text & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Somente favoritar? Depois compra ;3")
            If resp = vbYes Then
                sql = "select * from tb_favoritos where (jogo= '" & lbl_nome.Text & "' and cpf='" & frm_comprar.lbl_cpf.Text & "')"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Jogo já favoritado no seu CPF", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tb_favoritos (jogo, nome_criador, valor, ano, genero, cpf) values ('" & lbl_nome.Text & "', '" & lbl_nomec.Text & "', '" & lbl_valor.Text & "', " &
                        "'" & lbl_ano.Text & "','" & lbl_genero.Text & "', '" & frm_comprar.lbl_cpf.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Jogo favoritado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.ShowDialog()
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.ShowDialog()
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
            frm_login.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_logo_Click(sender As Object, e As EventArgs) Handles btn_logo.Click
        Me.Hide()
        frm_principal.Show()
    End Sub

    Private Sub lbl_nome_TextChanged(sender As Object, e As EventArgs) Handles lbl_nome.TextChanged
        Try
            sql = "select * from tb_jogo where nome_jogo='" & lbl_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_nomec.Text = rs.Fields(2).Value
                lbl_ano.Text = rs.Fields(3).Value
                lbl_genero.Text = rs.Fields(4).Value
                lbl_valor.Text = rs.Fields(6).Value
                lbl_descricao.Text = rs.Fields(7).Value
                img_jogo.Load(rs.Fields(5).Value)
            End If
        Catch ex As Exception
            MsgBox("Algo deu errado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTT   FIM TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
End Class