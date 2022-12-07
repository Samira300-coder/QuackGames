Public Class fmr_comprar
    Private Sub fmr_comprar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

        Try
            With frm_jogo
                nome_jogo = lbl_nome.Text
                valor_jogo = lbl_valor.Text
                img_jogo.Load(fottle)
            End With

            lbl_nome.Text = nome_jogo
            lbl_valor.Text = valor_jogo
            img_jogo.Load(fottle)
        Catch ex As Exception

        End Try
    End Sub
End Class