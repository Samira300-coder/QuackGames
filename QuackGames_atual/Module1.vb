Imports System.Net.Mail
Imports System.Text.RegularExpressions

Module Module1
    Public fottinho, diretorio, jogo, sql, aux_cpf, aux_nome, aux_jogo, aux_joguinho, resp, nome_jogo As String
    Public valor_jogo, fottle, imagem, nominho, email, img As String
    Public tipousuario = "USUÁRIO"
    Public tipocriador = "CRIADOR"
    Public cont, nova_senha As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\Banco_dados\cadastro.mdb"
    Public id_usuario As String



    Sub dados_do_usuario()
        sql = "select * From tb_cadastro where (nome='" & frm_login.txt_usuario.Text & "' Or email='" & frm_login.txt_usuario.Text & "')"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            With frm_perfil_conta
                .lbl_nome.Text = rs.Fields(1).Value
                .txt_nome.Text = rs.Fields(2).Value
                .img_foto.Load(rs.Fields(11).Value)
            End With
            With frm_comprar
                .lbl_email.Text = rs.Fields(2).Value
                .lbl_cpf.Text = rs.Fields(0).Value
                .lbl_nome_usuario.Text = rs.Fields(2).Value
            End With
        End If
    End Sub

    Sub dados_do_criador()
        sql = "Select * From tb_cadastro_criador where (nome='" & frm_login.txt_usuario.Text & "' Or email='" & frm_login.txt_usuario.Text & "')"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            With frm_perfil_conta
                .lbl_nome.Text = rs.Fields(1).Value
                .txt_nome.Text = rs.Fields(2).Value
                .img_foto.Load(rs.Fields(11).Value)
            End With
        End If
    End Sub

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco) 'string de conexão do access
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            cont = 1
            With frm_cadastro.dgv_dados
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

    Sub carregar_dados_criador()
        Try
            sql = "select * from tb_cadastro_criador order by nome asc"
            rs = db.Execute(sql)
            cont = 1
            With frm_cadastro.dgv_dadosc
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

    Sub carregar_jogo()
        Try
            cont = 1
            sql = "select * from tb_jogo where nome_criador='" & frm_perfil_conta.lbl_nome.Text & "' order by ano desc"
            rs = db.Execute(sql)
            With frm_vender.dgv_jogo
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_biblioteca()
        Try
            cont = 1
            sql = "select * from tb_jogo order by nome_jogo desc"
            rs = db.Execute(sql)
            With frm_biblioteca.dgv_b
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(6).Value, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo()
        Try
            With frm_cadastro.cmb_tipo.Items
                .Add("NOME")
                .Add("CPF")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_g()
        Try
            With frm_vender.cmb_genero_vender.Items
                .Add("Ação")
                .Add("Aventura")
                .Add("Romance")
                .Add("RPG")
                .Add("Casuais")
                .Add("Esportes")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_ano_vender()
        Try
            With frm_vender.cmb_ano_vender.Items
                .Add("2022")
                .Add("2021")
                .Add("2020")
                .Add("2019")
                .Add("2018")
                .Add("2017")
                .Add("2016")
                .Add("2015")
                .Add("2014")
                .Add("2013")
                .Add("2012")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_historico()
        Try
            sql = "select jogo from tb_compra where cpf='" & frm_comprar.lbl_cpf.Text & "'"
            rs = db.Execute(sql)
            With frm_historico.cmb_historico_compra.Items
                Do While (Not rs.EOF)
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_favoritos()
        Try
            sql = "select jogo from tb_favoritos where cpf='" & frm_comprar.lbl_cpf.Text & "'"
            rs = db.Execute(sql)
            With frm_favoritos.cmb_favoritos.Items
                Do While (Not rs.EOF)
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub enviar_email()

        'qnd a pessoa se cadastra no frm_cadastro_conta

        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("quackgames.oficial@gmail.com", "vvewhtmweuhxmtfg")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("quackgames.oficial@gmail.com")
                    email.To.Add(frm_cadastro.lbl_email.Text)
                    email.Subject = "Bem-vindo(a) " & frm_cadastro.txt_nome.Text & " ao Quack Games!"
                    email.IsBodyHtml = True
                    email.Body = "Olá querido(a) Gamer! Seja bem-vindo ao Quack Games, a mais nova plataforma de compra e venda de jogos!" + vbNewLine &
    "Atenciosamente, Equipe Quack."

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Erro: Email não enviado! Tente novamente....")
        End Try
    End Sub

    Sub enviar_email_compra()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("quackgames.oficial@gmail.com", "vvewhtmweuhxmtfg")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("quackgames.oficial@gmail.com")
                    email.To.Add(frm_comprar.lbl_email.Text)
                    email.Subject = "Olá " & frm_perfil_conta.lbl_nome.Text & ", sua compra no Quack Games foi um sucesso!"
                    email.IsBodyHtml = True
                    email.Body = "Olá querido(a) Gamer! Sua compra foi realizada com sucesso!" + vbNewLine &
                    " A compra do jogo " & frm_jogo.lbl_nome.Text & ", " + vbNewLine &
                    " no valor de R$ " & frm_jogo.lbl_valor.Text & " foi bem sucedida! " + vbNewLine &
                    " Atenciosamente, Equipe Quack."

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Erro: Email não enviado! Tente novamente....")
        End Try
    End Sub

    Sub enviar_email_criador()

        'qnd o criador se cadastra no frm_cadastro_conta

        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("quackgames.oficial@gmail.com", "vvewhtmweuhxmtfg")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("quackgames.oficial@gmail.com")
                    email.To.Add(frm_cadastro.lbl_email.Text)
                    email.Subject = "Bem-vindo(a) " & frm_cadastro.txt_nome.Text & " ao Quack Games!"
                    email.IsBodyHtml = True
                    email.Body = "Olá querido(a) Criador! Seja bem-vindo ao Quack Games, a mais nova plataforma de compras e vendas de jogos!" + vbNewLine &
                     "Atenciosamente, Equipe Quack."

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            'MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Erro: Email não enviado! Tente novamente....")
        End Try
    End Sub

    Sub enviar_email_venda()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("quackgames.oficial@gmail.com", "vvewhtmweuhxmtfg")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("quackgames.oficial@gmail.com")
                    email.To.Add(frm_comprar.lbl_email.Text)
                    email.Subject = "Olá " & frm_cadastro.txt_nome.Text & ", seu jogo foi cadastrado no Quack Games!"
                    email.IsBodyHtml = True
                    email.Body = "Olá querido(a) Gamer! Seu jogo foi colocado à venda com sucesso!" + vbNewLine &
                     " Agora é só esperar que o jogo " & frm_vender.txt_nome_jogo.Text & " vai ser um sucesso!" + vbNewLine &
                     "Desejamos a você Boa Sorte!" + vbNewLine &
                     "Atenciosamente, Equipe Quack."

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            ' MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Erro: Email não enviado! Tente novamente....")
        End Try
    End Sub

    Sub enviar_email_nova_senha()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("quackgames.oficial@gmail.com", "vvewhtmweuhxmtfg")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("quackgames.oficial@gmail.com")
                    email.To.Add(frm_nova_senha.txt_email.Text)
                    email.Subject = "Olá " & frm_cadastro.txt_nome.Text & " , sua senha no Quack Games foi alterada!"
                    email.IsBodyHtml = True
                    email.Body = "Olá querido(a) Usuário! Sua senha foi redefinida, e aqui está: " & nova_senha & ", lembre-se bem dela!" + vbNewLine &
                    "Atenciosamente, Equipe Quack."

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            'MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Erro: Email não enviado! Tente novamente....")
        End Try
    End Sub

End Module