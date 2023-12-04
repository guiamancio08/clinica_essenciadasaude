Imports System.ComponentModel.Design
Imports System.Diagnostics.Eventing
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Runtime.Remoting

Public Class Form1

    Private Sub lbl_cadastro_Click(sender As Object, e As EventArgs) Handles lbl_cadastro.Click
        Form2.ShowDialog() 'chamar o formulario sobre o cadastro
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco() 'conectar o banco
        txt_login.Text = ""
        txt_senha.Text = ""
        txt_login.Focus()
        formatar_senha()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'usar o CPF e a senha para chamar o form
        If txt_login.Text = "" Or (txt_senha.Text = "" Or txt_senha.Text = "Senha") Then
            MsgBox("Preencha todos os campos para logar no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            formatar_form1()
        Else
            sql = "select * from tb_usuarios where cpf ='" & txt_login.Text & "' and senha ='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                nome_paciente = rs.Fields(1).Value
                nome_medico = rs.Fields(1).Value
                sql = "select * from tipo_conta where cpf ='" & txt_login.Text & "'"
                rs = db.Execute(sql)
                Dim tipo_conta As String = rs.Fields(1).Value
                If tipo_conta = "CLIENTE" Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Paciente.Show()
                    Me.Close()
                    Form2.Hide()
                ElseIf tipo_conta = "MÉDICO" Then
                    MsgBox("Bem vindo doutor(a)!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    medico.Show()
                    Me.Close()
                    Form2.Hide()
                ElseIf tipo_conta = "ADMINISTRADOR" Then
                    MsgBox("Bem vindo administrador", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    administrador.Show()
                    Me.Close()
                    Form2.Hide()
                Else
                    MsgBox("Problema no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            Else
                MsgBox("Credenciais não encontradas no sistema!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                formatar_form1()
            End If

        End If





    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        chk_senha.Visible = true
        Try
            If txt_senha.Text = "Senha" Then
                txt_senha.Text = ""
                txt_senha.PasswordChar = "•"
                txt_senha.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox("Erro ao executar função!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resp = MsgBox("Deseja realmente fechar o sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            txt_login.Clear()
            txt_senha.Clear()
            txt_login.Focus()
        End If
    End Sub

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked Then
            If txt_senha.Text <> "Senha" Then
                txt_senha.PasswordChar = ""
            End If
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        redefinir_senha.Show()
        Me.Hide()
    End Sub
End Class

