Imports System.Net.Mail
Imports Microsoft.Win32
Imports System.Threading

Public Class frm_comprar
    Private Sub fmr_comprar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

        BackColor = Color.White
        ToolStrip1.ForeColor = Color.Orange
        ToolStrip1.BackColor = Color.White
        modo_escuro()

        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False
            Else
                HistóricoToolStripMenuItem.Visible = False
            End If
        End If

        sql = "select * from tb_jogo where jogo = '" & lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            lbl_nome.Text = rs.Fields(1).Value
            lbl_valor.Text = rs.Fields(6).Value
            img_jogo.Load(rs.Fields(5).Value)

        End If

        sql = "select * from tb_cadastro where email='" & lbl_email.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            lbl_cpf.Text = rs.Fields(0).Value
            lbl_nome_usuario.Text = rs.Fields(2).Value
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

    Private Sub btn_ok_Click(sender As Object, e As EventArgs)
        Try
            resp = MsgBox("Confirmar pagamento no valor de " + vbNewLine &
                    "R$ " & lbl_valor.Text & " , no jogo: " & lbl_nome.Text & ".", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CERTEZA?")
            If resp = vbYes Then
                sql = "select * from tb_compra where (jogo= '" & lbl_nome.Text & "' and cpf='" & lbl_cpf.Text & "')"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Jogo " & lbl_nome.Text & " já comprado no CPF: " & lbl_cpf.Text & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tb_compra (jogo, valor, forma, img_jogo, data, cpf) values ('" & lbl_nome.Text & "', '" & lbl_valor.Text & "', '" & cmb_pgto.Text & "', " &
                        "'" & jogo & "', '" & DateTime.Now & "', '" & lbl_cpf.Text & "')"
                    rs = db.Execute(UCase(sql))
                    Thread.Sleep(1500)
                    enviar_email_compra()
                    MsgBox("Compra realizada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    frm_principal.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRO!! Compra não realizada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
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

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        Me.Hide()
        frm_historico.Show()
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

    Private Sub btn_ok_Click_1(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            resp = MsgBox("Confirmar pagamento no valor de " + vbNewLine &
                    "R$ " & lbl_valor.Text & " , no jogo: " & lbl_nome.Text & ".", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CERTEZA?")
            If resp = vbYes Then
                sql = "select * from tb_compra where (jogo= '" & lbl_nome.Text & "' and cpf='" & lbl_cpf.Text & "')"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Jogo " & lbl_nome.Text & " já comprado no CPF: " & lbl_cpf.Text & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tb_compra (jogo, valor, forma, img_jogo, data, cpf) values ('" & lbl_nome.Text & "', '" & lbl_valor.Text & "', '" & cmb_pgto.Text & "', " &
                        "'" & jogo & "', '" & DateTime.Now & "', '" & lbl_cpf.Text & "')"
                    rs = db.Execute(UCase(sql))
                    Thread.Sleep(1500)
                    enviar_email_compra()
                    MsgBox("Compra realizada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    frm_principal.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRO!! Compra não realizada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTT   FIM TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
End Class