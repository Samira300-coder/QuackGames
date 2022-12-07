Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class frm_cadastro_conta
    Private Sub frm_cadastro_conta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub chk_visual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visual.CheckedChanged
        Try
            If chk_visual.Checked = True Then
                txt_senha.PasswordChar = ""
                txt_rsenha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
                txt_rsenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_usuario.Text = "" _
               Or txt_email.Text = "" _
               Or txt_senha.Text = "" _
               Or txt_rsenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("As senhas digitadas não conferem!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            sql = "select * from tb_login where usuario='" & txt_usuario.Text & "' or email='" & txt_email.Text & "'"
            rs = db.Execute(sql)

                If rs.EOF = False Then
                    MsgBox("Conta já cadastrada!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    sql = "insert into tb_login (usuario, email, senha, tipo) values ('" & txt_usuario.Text & "', " &
                    "'" & txt_email.Text & "', '" & txt_senha.Text & "','" & cmb_tipo.Text & "')"
                    rs = db.Execute(UCase(sql))
                    'enviar_email()
                    MsgBox("Conta criada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")


                Me.Hide()
                frm_cadastro.Show()




            End If
            txt_usuario.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            txt_rsenha.Clear()
            txt_usuario.Focus()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        If frm_login.txt_usuario.Text <> "admin" Then
            txt_usuario.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            txt_rsenha.Clear()
            txt_usuario.Focus()

            Me.Hide()

            frm_login.Show()
        Else
            txt_usuario.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            txt_rsenha.Clear()
            txt_usuario.Focus()

            Me.Hide()


            frm_gerenciar.Show()
        End If
    End Sub
End Class