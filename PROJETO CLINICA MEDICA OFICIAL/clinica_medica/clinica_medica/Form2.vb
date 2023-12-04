Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        If txt_senha.Text <> "" Then
            If txt_senha.TextLength >= 6 Then
                lbl_senha_stat.Text = "Senha forte"
                lbl_senha_stat.ForeColor = Color.Green
            Else
                lbl_senha_stat.Text = "Senha fraca"
                lbl_senha_stat.ForeColor = Color.Red
            End If
            lbl_senha_stat.Visible = True
        Else
            lbl_senha_stat.Visible = False
        End If

    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        Try
            sql = "select * from tb_usuarios where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                If txt_senha.Text <> txt_rsenha.Text Then 'Senhas diferentes
                    MsgBox("Senhas não condizentes!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha.Clear()
                    txt_rsenha.Clear()
                    txt_senha.Focus()

                ElseIf txt_nome.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or txt_rsenha.Text = "" Then 'Algum campo vazio
                    MsgBox("Preencha todos os campos!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_cadastro()

                ElseIf txt_senha.TextLength < 6 Then 'Senha menor que 6
                    MsgBox("Sua senha é muito pequena!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha.Clear()
                    txt_rsenha.Clear()
                    txt_senha.Focus()

                Else 'Inserir as informações no banco de dados
                    sql = "insert into tb_usuarios values('" & txt_cpf.Text & "', " &
                         "'" & txt_nome.Text & "'," &
                         "'" & cmb_data.Value & "'," &
                         "'" & txt_email.Text & "'," &
                         "'" & txt_senha.Text & "'," &
                         "'" & txt_rsenha.Text & "')"
                    rs = db.Execute(UCase(sql))

                    sql = "insert into tipo_conta (tipo,cpf) values ('" & lbl_tipo_conta.Text & "', " &
                        "'" & txt_cpf.Text & "')"
                    rs = db.Execute(UCase(sql))

                    resp = MsgBox("CADASTRO COMPLETADO COM SUCESSO!!" & vbNewLine & "**Deseja entrar agora no sistema?**", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        Me.Close()
                        With Form1
                            .txt_login.Focus()

                        End With
                    Else
                        limpar_cadastro()
                    End If



                End If
            Else 'Se ja existir um usuario
                resp = MsgBox("Já a um cliente cadastrado com esse CPF!!" & vbNewLine & "**Deseja voltar para realizar o login?**", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ALERTA")
                If resp = MsgBoxResult.Yes Then
                    Me.Hide()
                Else
                    limpar_cadastro()
                End If
            End If
        Catch ex As Exception
            resp = MsgBox("Ouve algum erro no cadastro!!" & vbNewLine & "Deseja tentar novamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = MsgBoxResult.Yes Then
                limpar_cadastro()
            Else
                Application.Exit()
            End If

        End Try
    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        Application.Exit()

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked Then
            txt_senha.UseSystemPasswordChar = False
            txt_rsenha.UseSystemPasswordChar = False
        Else
            txt_rsenha.UseSystemPasswordChar = True
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub
End Class