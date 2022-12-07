Public Class frm_gerenciar

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
        frm_cadastro.TabControl1.SelectedIndex = 0
        frm_cadastro_conta.Show()
        Me.Hide()
    End Sub

    Private Sub GerenciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarToolStripMenuItem.Click
        Me.Hide()
        frm_cadastro.TabControl1.SelectedIndex = 1
        frm_cadastro.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Banco_dados\cadastro.mdb")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class