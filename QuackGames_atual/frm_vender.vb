Public Class frm_vender

    Private Sub frm_vender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_jogo()
        carregar_ano_vender()
        carregar_g()
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

        BackColor = Color.White
        TabPage1.BackColor = Color.White
        TabPage2.BackColor = Color.White
        ToolStrip1.ForeColor = Color.Orange
        ToolStrip1.BackColor = Color.White

        modo_escuro()
        VenderToolStripMenuItem.Visible = False


        sql = "select * from tb_login where usuario='" & frm_perfil_conta.lbl_nome.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nome_criador.Text = rs.Fields(1).Value
            If rs.Fields(5).Value = "USUÁRIO" Then
                VenderToolStripMenuItem.Visible = False
            Else
                FavoritosToolStripMenuItem.Visible = False
                HistóricoToolStripMenuItem.Visible = False
            End If
        End If

    End Sub


    Sub modo_escuro()
        If frm_perfil_conta.CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.TabPage1.BackColor = Color.Black
            Me.TabPage2.BackColor = Color.Black
            Me.ToolStrip1.BackColor = Color.Black
            Me.ToolStrip1.ForeColor = Color.Orange

        Else
            Me.BackColor = Color.White
            Me.TabPage1.BackColor = Color.White
            Me.TabPage2.BackColor = Color.White
            Me.ToolStrip1.ForeColor = Color.Orange
            Me.ToolStrip1.BackColor = Color.White

        End If
    End Sub



    Private Sub dgv_jogo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jogo.CellContentClick
        Try
            With dgv_jogo
                If .CurrentRow.Cells(5).Selected = True Then
                    aux_jogo = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_jogo where nome_jogo='" & aux_jogo & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'explore aba de dados pessoais 
                        txt_jogo.Text = rs.Fields(0).Value
                        txt_nome_jogo.Text = rs.Fields(1).Value
                        txt_nome_criador.Text = rs.Fields(2).Value
                        cmb_ano_vender.Text = rs.Fields(3).Value
                        cmb_genero_vender.Text = rs.Fields(4).Value
                        img_jogo.Load(rs.Fields(5).Value)
                        txt_valor.Text = rs.Fields(6).Value
                        txt_descricao.Text = rs.Fields(7).Value

                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_jogo = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "JOGO: " & aux_jogo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_jogo where nome_jogo= '" & aux_jogo & "'"
                        rs = db.Execute(sql)
                        carregar_jogo()
                    End If
                    txt_jogo.Clear()
                    txt_nome_jogo.Clear()
                    'txt_nome_criador.Clear()
                    cmb_ano_vender.Text = String.Empty
                    cmb_genero_vender.Text = String.Empty
                    txt_valor.Clear()
                    txt_descricao.Clear()
                    img_jogo.Load(Application.StartupPath & "\Foto_jogo\add.png")
                    txt_jogo.Focus()
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_vender_Click(sender As Object, e As EventArgs) Handles btn_vender.Click
        Try
            If txt_jogo.Text = "" Or
                txt_nome_jogo.Text = "" Or
                txt_nome_criador.Text = "" Or
                cmb_ano_vender.Text = "" Or
                cmb_genero_vender.Text = "" Or
                txt_valor.Text = "" Or
                txt_descricao.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            sql = "select * from tb_jogo where jogo='" & txt_jogo.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                'MsgBox("Jogo já cadastrado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                sql = "update tb_jogo set nome_jogo='" & txt_nome_jogo.Text & "', " &
                                "nome_criador='" & txt_nome_criador.Text & "', " &
                                "ano='" & cmb_ano_vender.Text & "', genero='" & cmb_genero_vender.Text & "', " &
                                "img_jogo='" & jogo & "', valor='" & txt_valor.Text & "', " &
                                "descricao='" & txt_descricao.Text & "' where jogo='" & txt_jogo.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_jogo.Clear()
                txt_nome_jogo.Clear()
                'txt_nome_criador.Clear()
                cmb_ano_vender.Text = String.Empty
                cmb_genero_vender.Text = String.Empty
                txt_valor.Clear()
                txt_descricao.Clear()
                img_jogo.Load(Application.StartupPath & "\Foto_jogo\add.png")
                txt_jogo.Focus()

            Else
                sql = "insert into tb_jogo values ('" & txt_jogo.Text & "', " &
                            "'" & txt_nome_jogo.Text & "', '" & txt_nome_criador.Text & "', " &
                            "'" & cmb_ano_vender.Text & "', '" & cmb_genero_vender.Text & "', '" & jogo & "', " &
                            "'" & txt_valor.Text & "', '" & txt_descricao.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Jogo cadastrado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                enviar_email_venda()
                carregar_jogo()
            End If
            txt_jogo.Clear()
            txt_nome_jogo.Clear()
            'txt_nome_criador.Clear()
            cmb_ano_vender.Text = String.Empty
            cmb_genero_vender.Text = String.Empty
            txt_valor.Clear()
            txt_descricao.Clear()
            img_jogo.Load(Application.StartupPath & "\Foto_jogo\add.png")
            txt_jogo.Focus()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar jogo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_jogo_Click(sender As Object, e As EventArgs) Handles img_jogo.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Foto_jogo\"
                .ShowDialog()
                jogo = .FileName
                img_jogo.Load(jogo)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Try
            Dim bgbrush As Brush 'cor do fundo
            Dim foreColorBrush As Brush 'Cor da fonte
            Dim font As Font

            If e.Index = TabControl1.SelectedIndex Then
                'Mudar aparência do tabcontrol selecionado
                font = New Font(e.Font, FontStyle.Bold)
                bgbrush = New System.Drawing.SolidBrush(Color.Black)
                foreColorBrush = Brushes.Orange
            Else
                'Mudar aparencia dos tab controls
                font = New Font(e.Font, FontStyle.Regular)
                bgbrush = New SolidBrush(Color.White)
                foreColorBrush = New SolidBrush(Color.Orange)
            End If

            'Alinhamento do texto
            Dim tabName = TabControl1.TabPages(e.Index).Text
            Dim sf As StringFormat = New StringFormat
            sf.Alignment = StringAlignment.Center

            'preencher tab selecionada
            e.Graphics.FillRectangle(bgbrush, e.Bounds)

            Dim r As Rectangle = e.Bounds
            r = New Rectangle(r.X, r.Y + 3, r.Width + 3, r.Height - 3)

            e.Graphics.DrawString(tabName, font, foreColorBrush, r, sf)

            sf.Dispose() 'liberar os recursos
            If e.Index = TabControl1.SelectedIndex Then
                bgbrush.Dispose()
            Else
                bgbrush.Dispose()
                foreColorBrush.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        Me.Hide()
        frm_perfil_conta.Show()
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        Me.Hide()
        frm_historico.ShowDialog()
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

    Private Sub btn_logo_Click_1(sender As Object, e As EventArgs) Handles btn_logo.Click
        Me.Hide()
        frm_principal.Show()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        frm_biblioteca.ShowDialog()
    End Sub

    Private Sub FavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritosToolStripMenuItem.Click
        Me.Hide()
        frm_favoritos.Show()
    End Sub
End Class