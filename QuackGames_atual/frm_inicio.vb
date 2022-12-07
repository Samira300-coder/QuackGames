Public Class frm_inicio
    Private Sub frm_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_a()
        carregar_g()
        carregar_entrar()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If cmb_entrar.Text = ("Cadastrar") = True Then
                frm_cadastro.ShowDialog()
                Me.Close()
            ElseIf cmb_entrar.Text = ("Logar") = True Then
                frm_login.ShowDialog()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Class
