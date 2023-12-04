Imports System.Diagnostics.Eventing.Reader

Public Class redefinir_senha
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If txt_cpf.Text = "" Or txt_senha_atual.Text = "" Then
                MsgBox("Preencha todos os campos para mudar a senha!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_cpf.Clear()
                txt_senha_atual.Clear()
                txt_cpf.Focus()
            Else
                sql = "select * from tb_usuarios where cpf = '" + txt_cpf.Text + "' and senha = '" + txt_senha_atual.Text + "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    cpf1 = rs.Fields(0).Value
                    Dim nome As String = rs.Fields(1).Value
                    sql = "select * from tipo_conta where cpf = '" + cpf1 + "'"
                    rs = db.Execute(sql)
                    Dim tipo_conta = rs.Fields(1).Value
                    If tipo_conta = "CLIENTE" Then
                        MsgBox("Credenciais encontradas no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        txt_nome.Text = nome
                        esconder_senha()
                    Else
                        MsgBox("Credenciais desta conta não podem ser mudadas!" & vbNewLine & "Contate um administrador!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    MsgBox("Credenciais não encontradas no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_cpf.Clear()
                    txt_senha_atual.Clear()
                    txt_cpf.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Credenciais não encontradas no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_rsenha.Text = "" Or txt_senha_nova.Text = "" Then
                MsgBox("Preencha todos os campos para mudar a senha!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_rsenha.Clear()
                txt_senha_nova.Clear()
                txt_senha_nova.Focus()
            Else
                If txt_senha_nova.Text <> txt_rsenha.Text Then
                    MsgBox("Senhas não condizentes!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha_nova.Clear()
                    txt_rsenha.Clear()
                    txt_senha_nova.Focus()
                ElseIf txt_senha_nova.TextLength < 6 Then
                    MsgBox("Sua senha é muito pequena!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha_nova.Clear()
                    txt_rsenha.Clear()
                    txt_senha_nova.Focus()
                ElseIf txt_senha_nova.text = txt_senha_atual.text Then
                    MsgBox("Senha igual a cadastrada atualmente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha_nova.Clear()
                    txt_rsenha.Clear()
                    txt_senha_nova.Focus()
                Else
                    sql = "update tb_usuarios set " &
                    "senha = '" & txt_senha_nova.Text & "', " &
                    "rsenha = '" & txt_rsenha.Text & "' " &
                    "WHERE cpf = '" & cpf1 & "'"
                    rs = db.Execute(sql)
                    resp = MsgBox("Senhas alteradas com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Form1.Show()
                        Me.Close()
                    End If
                End If
        Catch ex As Exception
            resp = MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_senha_nova_TextChanged(sender As Object, e As EventArgs) Handles txt_senha_nova.TextChanged
        If txt_senha_nova.Text <> "" Then
            If txt_senha_nova.TextLength >= 6 Then
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

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked Then
            txt_senha_nova.UseSystemPasswordChar = False
            txt_rsenha.UseSystemPasswordChar = False

        Else
            txt_senha_nova.UseSystemPasswordChar = True
            txt_rsenha.UseSystemPasswordChar = True

        End If
    End Sub
End Class