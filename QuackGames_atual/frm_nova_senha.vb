Public Class frm_nova_senha
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If txt_email.Text = "" Then
                MsgBox("Informe o email!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_login where email='" & txt_email.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("Email não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_email.Clear()
                Else
                    Dim random As New Random
                    nova_senha = random.Next(1000, 9999)

                    sql = "update tb_login set senha=" & nova_senha & " where email='" & txt_email.Text & "'"
                    rs = db.Execute(sql)

                    sql = "select email from tb_login where email='" & txt_email.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Senha alterada com sucesso! Sua nova senha é: " & nova_senha & " guarde-a bem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                    enviar_email_nova_senha()
                    txt_email.Clear()
                    txt_email.Focus()
                End If
                frm_login.Show()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_email.Clear()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_login.Show()
    End Sub
End Class