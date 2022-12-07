Imports System.Collections.Concurrent
Imports System.Collections.Specialized
Imports System.ComponentModel.Design
Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        frm_carregando.ShowDialog()
    End Sub
    Private Sub lbl_esqueci_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_esqueci.LinkClicked
        Me.Hide()
        frm_nova_senha.ShowDialog()
    End Sub

    Private Sub lbl_cadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cadastro.LinkClicked
        Me.Hide()
        frm_cadastro_conta.ShowDialog()
    End Sub

    Private Sub chk_visual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visual.CheckedChanged
        Try
            If chk_visual.Checked = True Then
                txt_senha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        Try
            If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
                MsgBox("Conta administrativa logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_cadastro.ToolStripButton1.Visible = True
                frm_gerenciar.Show()
                Exit Sub
            End If

            sql = "select * from tb_login where(email='" & txt_usuario.Text & "' or usuario='" & txt_usuario.Text & "') and senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                If rs.Fields(4).Value = True Then
                    MsgBox("Conta bloqueada! Contate o Administrador através do email: " + vbNewLine &
                        "quackgames.suporte@gmail.com", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    'Compara o txt_usuario, se estiver correto o login e inserir o txt_usuario no formulário de perfil
                    'frm_perfil_conta.txt_email.Text = txt_usuario.Text
                    sql = "select * From tb_login where usuario='" & txt_usuario.Text & "' Or email='" & txt_usuario.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        With frm_perfil_conta
                            .lbl_nome.Text = rs.Fields(1).Value
                        End With
                        With frm_comprar
                            .lbl_email.Text = rs.Fields(2).Value
                        End With

                        sql = "select * From tb_cadastro where email='" & txt_usuario.Text & "' or nome='" & txt_usuario.Text & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            With frm_comprar
                                '.lbl_email.Text = rs.Fields(2).Value
                                .lbl_cpf.Text = rs.Fields(0).Value
                                .lbl_nome_usuario.Text = rs.Fields(2).Value
                            End With
                        End If
                        txt_senha.Text = ""
                        txt_usuario.Text = ""
                        MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_principal.Show()
                        Me.Hide()

                    End If



                    sql = "select * From tb_cadastro where nome='" & txt_usuario.Text & "' Or email='" & txt_usuario.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        With frm_perfil_conta
                            '.lbl_nome.Text = rs.Fields(2).Value
                            ' .txt_nome.Text = rs.Fields(2).Value
                            .img_foto.Load(rs.Fields(11).Value)
                            .txt_fone.Text = rs.Fields(9).Value
                        End With
                        txt_senha.Text = ""
                        txt_usuario.Text = ""
                        MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_principal.Show()
                        Me.Hide()

                    End If

                    sql = "select * From tb_cadastro_criador where nome='" & txt_usuario.Text & "' Or email='" & txt_usuario.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        With frm_perfil_conta
                            ' .lbl_nome.Text = rs.Fields(2).Value
                            .txt_fone.Text = rs.Fields(9).Value
                            '  .txt_nome.Text = rs.Fields(2).Value
                            .img_foto.Load(rs.Fields(11).Value)
                        End With
                        txt_senha.Text = ""
                        txt_usuario.Text = ""
                        MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_principal.ShowDialog()
                        Me.Hide()

                    End If
                End If
            Else
                MsgBox("Conta inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class