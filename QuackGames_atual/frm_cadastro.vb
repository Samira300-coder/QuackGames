Public Class frm_cadastro
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
        carregar_dados_criador()
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

        lbl_aviso.Visible = False

        lbl_email.Text = frm_cadastro_conta.txt_email.Text

        If frm_login.txt_usuario.Text <> "admin" Then
            btn_relat.Visible = False
            ToolStripButton1.Visible = False
            dgv_dados.Visible = False
            txt_pesquisa.Visible = False
            cmb_tipo.Visible = False
            dgv_dados.Visible = False
            dgv_dadosc.Visible = False
        End If

        BackColor = Color.White
        ToolStrip1.BackColor = Color.White
        ToolStrip1.ForeColor = Color.Orange
        ToolStrip1.BackColor = Color.White

        If frm_login.txt_usuario.Text <> "admin" Then
            btn_voltar.Visible = False
            ToolStripButton1.Visible = False
        Else
            ToolStripButton1.Visible = True
            btn_voltar.Visible = True

        End If

    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select*from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_uf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = "select * from tb_login where (email='" & lbl_email.Text & "') and tipo='" & tipousuario & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "insert into tb_cadastro (CPF, data_nascimento, nome, CEP, endereco, complemento, bairro, cidade, UF, fone, email, foto) values ('" & txt_cpf.Text & "', " &
            "'" & txt_data.Value & "','" & txt_nome.Text & "', '" & txt_cep.Text & "', " &
            "'" & txt_endereco.Text & "', '" & txt_comp.Text & "', '" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
            "'" & txt_uf.Text & "', '" & txt_fone.Text & "', '" & lbl_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                enviar_email()
                MsgBox("Dados pessoais cadastrados com sucesso! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_login.Show()
                frm_login.txt_usuario.Clear()
                frm_login.txt_usuario.Clear()
            End If

            sql = "select * from tb_login where (email='" & lbl_email.Text & "') and tipo='" & tipocriador & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "insert into tb_cadastro_criador (CPF, data_nascimento, nome, CEP, endereco, complemento, bairro, cidade, UF, fone, email, foto) values ('" & txt_cpf.Text & "', " &
           "'" & txt_data.Value & "','" & txt_nome.Text & "', '" & txt_cep.Text & "', " &
           "'" & txt_endereco.Text & "', '" & txt_comp.Text & "', '" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
           "'" & txt_uf.Text & "', '" & txt_fone.Text & "', '" & lbl_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                enviar_email_criador()
                MsgBox("Dados pessoais de CRIADOR cadastrados  com sucesso! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_login.Show()
                frm_login.txt_usuario.Clear()
                frm_login.txt_usuario.Clear()

            End If

            carregar_dados()
            carregar_dados_criador()
            txt_cpf.Clear()
            txt_data.Value = Now
            txt_nome.Clear()
            txt_cep.Clear()
            txt_endereco.Clear()
            txt_comp.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            txt_fone.Clear()
            img_foto.Load(Application.StartupPath & "\Fotos\add_person-icon.png")
            txt_cpf.Focus()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'explore aba de dados pessoais 
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_data.Value = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_fone.Text = rs.Fields(9).Value
                        lbl_email.Text = rs.Fields(10).Value
                        img_foto.Load(rs.Fields(11).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_cadastro where cpf= '" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                        sql = "delete * from tb_login where cpf= '" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            sql = "select * from tb_cadastro where " & cmb_tipo.Text & " like '" & txt_pesquisa.Text & " %'"
            rs = db.Execute(sql)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        txt_cpf.Clear()
        txt_data.Value = Now
        txt_nome.Clear()
        txt_cep.Clear()
        txt_endereco.Clear()
        txt_comp.Clear()
        txt_bairro.Clear()
        txt_cidade.Clear()
        txt_uf.Clear()
        txt_fone.Clear()
        lbl_email.Text = "."
        img_foto.Load(Application.StartupPath & "\Fotos\add_person-icon.png")
        txt_cpf.Focus()
        frm_gerenciar.Show()

    End Sub

    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        Try
            Process.Start(Application.StartupPath & "\Banco_dados\cadastro.mdb")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dadosc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dadosc.CellContentClick
        Try
            With dgv_dadosc
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro_criador where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'explore aba de dados pessoais 
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_data.Value = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_fone.Text = rs.Fields(9).Value
                        lbl_email.Text = rs.Fields(10).Value
                        img_foto.Load(rs.Fields(11).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_cadastro_criador where cpf= '" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados_criador()
                        sql = "delete * from tb_login where email= '" & lbl_email.Text & "'"
                        rs = db.Execute(sql)
                        carregar_dados_criador()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            sql = "update tb_cadastro set data_nascimento='" & txt_data.Value & "', " &
                "nome='" & txt_nome.Text & "', cep='" & txt_cep.Text & "', " &
                "endereco='" & txt_endereco.Text & "',complemento='" & txt_comp.Text & "', bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & "', " &
                "uf='" & txt_uf.Text & "', fone='" & txt_fone.Text & "', email='" & lbl_email.Text & "', " &
                "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados alterados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            carregar_dados()
            Exit Sub
        End If

        sql = "select * from tb_cadastro_criador where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            sql = "update tb_cadastro_criador set data_nascimento='" & txt_data.Value & "', " &
                    "nome='" & txt_nome.Text & "', cep='" & txt_cep.Text & "', " &
                    "endereco='" & txt_endereco.Text & "',complemento='" & txt_comp.Text & "', bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & "', " &
                    "uf='" & txt_uf.Text & "', fone='" & txt_fone.Text & "', email='" & lbl_email.Text & "', " &
                    "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados de CRIADOR alterados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            carregar_dados_criador()
            Exit Sub
        End If
    End Sub

End Class
