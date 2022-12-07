

Public Class frm_principal
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carregar_genero()
        'carregar_ano()
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


    End Sub


    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.Show()
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.ShowDialog()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        frm_biblioteca.ShowDialog()
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTT   FIM TOOLSTRIP TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT



    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If txt_busca.Text = "" Then

            img_jogo.Load(Application.StartupPath & "\Foto_jogo\GTA.jpg")
            lbl_nome.Text = "Grand Theft Auto"

            lbl_nome2.Visible = True
            img_jogo2.Visible = True

            lbl_nome3.Visible = True
            img_jogo3.Visible = True

            lbl_nome4.Visible = True
            img_jogo4.Visible = True

            lbl_nome5.Visible = True
            img_jogo5.Visible = True

            lbl_nome6.Visible = True
            img_jogo6.Visible = True

            lbl_nome7.Visible = True
            img_jogo7.Visible = True

            lbl_nome8.Visible = True
            Img_jogo8.Visible = True

            lbl_nome9.Visible = True
            img_jogo9.Visible = True

            lbl_nome10.Visible = True
            img_jogo10.Visible = True

            Label1.Visible = True
            Label2.Visible = True

        End If

        Try
            sql = "select * from tb_jogo where nome_jogo='" & txt_busca.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                img_jogo.Load(rs.Fields(5).Value)
                lbl_nome.Text = rs.Fields(1).Value

                lbl_nome2.Visible = False
                img_jogo2.Visible = False

                lbl_nome3.Visible = False
                img_jogo3.Visible = False

                lbl_nome4.Visible = False
                img_jogo4.Visible = False

                lbl_nome5.Visible = False
                img_jogo5.Visible = False

                lbl_nome6.Visible = False
                img_jogo6.Visible = False

                lbl_nome7.Visible = False
                img_jogo7.Visible = False

                lbl_nome8.Visible = False
                Img_jogo8.Visible = False

                lbl_nome9.Visible = False
                img_jogo9.Visible = False

                lbl_nome10.Visible = False
                img_jogo10.Visible = False

                Label1.Visible = False
                Label2.Visible = False


            End If

        Catch ex As Exception
            MsgBox("Erro ao encontrar jogo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub img_jogo_Click(sender As Object, e As EventArgs) Handles img_jogo.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo2_Click(sender As Object, e As EventArgs) Handles img_jogo2.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome2.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo3_Click(sender As Object, e As EventArgs) Handles img_jogo3.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome3.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo4_Click(sender As Object, e As EventArgs) Handles img_jogo4.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome4.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo5_Click(sender As Object, e As EventArgs) Handles img_jogo5.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome5.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo6_Click(sender As Object, e As EventArgs) Handles img_jogo6.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome6.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo7_Click(sender As Object, e As EventArgs) Handles img_jogo7.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome7.Text))
        Me.Hide()
        frm_jogo.Show()
    End Sub

    Private Sub Img_jogo8_Click(sender As Object, e As EventArgs) Handles Img_jogo8.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome8.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo9_Click(sender As Object, e As EventArgs) Handles img_jogo9.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome9.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub img_jogo10_Click(sender As Object, e As EventArgs) Handles img_jogo10.Click
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome10.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT


    Private Sub lbl_nome2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome2.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome2.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome3.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome3.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome4.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome4.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome5.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome5.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome6.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome6.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome7.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome7.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome8.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome8.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome9.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome9.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub lbl_nome10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome10.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome10.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        Me.Hide()
        frm_historico.ShowDialog()

    End Sub

    Private Sub lbl_nome_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nome.LinkClicked
        frm_jogo.lbl_nome.Text = (UCase(lbl_nome.Text))
        Me.Hide()
        frm_jogo.ShowDialog()
    End Sub
End Class