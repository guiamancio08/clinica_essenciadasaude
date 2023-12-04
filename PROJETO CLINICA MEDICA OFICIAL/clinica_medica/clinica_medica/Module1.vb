Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports clinica_medica.Paciente

Module Module1
    Public db As ADODB.Connection 'variavel do banco de dados
    Public rs As ADODB.Recordset 'variavel da tabela
    Public aux, aux2, aux3, cpf1 ' As String
    Public sql, nome_paciente, nome_medico As String 'var de query
    Public resp As String 'respostas p/ msgbox
    Public caminho = Application.StartupPath & "\banco\clinica.mdb" 'caminho p/ usar access
    Sub conectar_banco() 'conectar sql server
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=AMC-LAPTOP1;initial catalog=projeto_clinica;trusted_connection=yes;")
            'MsgBox("Conexão Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Conexão Erro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub

    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho)
            MsgBox("Conexão OK", MsgBoxStyle.Information + vbOKOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Conexão Erro", MsgBoxStyle.Critical + vbOKOnly, "AVISO")

        End Try
    End Sub

    Sub limpar_cadastro()
        With Form2
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_rsenha.Clear()
            .txt_nome.Focus()
        End With
    End Sub

    Sub formatar_form1()
        With Form1
            .txt_login.Clear()
            .txt_senha.Text = "Senha"
            .txt_login.Focus()
        End With
    End Sub
    Sub formatar_senha()
        With Form1
            .txt_senha.Text = "Senha"
            .txt_senha.ForeColor = Color.Gray
        End With

    End Sub

    Sub preencher_horarios()
        With Paciente
            ' Define a hora inicial e a hora final
            Dim horaInicial As New TimeSpan(8, 0, 0) ' 8:00 AM
            Dim horaFinal As New TimeSpan(16, 0, 0)  ' 4:00 PM

            ' Define o intervalo de tempo entre os horários (30 minutos)
            Dim intervalo As New TimeSpan(0, 30, 0)

            ' Loop para adicionar os horários à ComboBox
            Dim horaAtual As TimeSpan = horaInicial
            While horaAtual <= horaFinal
                .cmb_hora.Items.Add(horaAtual.ToString("hh\:mm"))
                ' Adiciona o intervalo de tempo para obter o próximo horário
                horaAtual = horaAtual.Add(intervalo)
            End While
        End With
    End Sub

    Sub limpar_consulta()
        With Paciente
            .cmb_medico.Text = ""
            .data_calendario.ResetText()
            .cmb_hora.Text = ""
            .txt_sintomas.Clear()
            .cmb_medico.Focus()
        End With
    End Sub

    Sub limpar_consulta_med()
        With medico
            .txt_nome_paciente.Text = ""
            .data_calendario.ResetText()
            .cmb_hora.Text = ""
            .txt_sintomas.Clear()
            .txt_nome_paciente.Focus()
        End With
    End Sub

    Sub preencher_dgv_medico()
        With medico.dgv_consultas_med
            sql = "select * from tb_consultas where nome_medico = '" + nome_medico + "'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                Dim data_consulta As Date = rs.Fields(3).Value
                If Date.Today <= data_consulta Then
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(4).Value, Nothing)
                End If
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub preencher_dgv()
        With Paciente.dgv_consultas
            sql = "select * from tb_consultas where nome_paciente = '" + nome_paciente + "' order by data_consulta asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                Dim data_consulta As Date = rs.Fields(3).Value
                If Date.Today <= data_consulta Then
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(4).Value, Nothing)
                End If
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub tipo_de_conta()
        With administrador
            .cmb_tipo.Items.Add("Cliente")
            .cmb_tipo.Items.Add("Administrador")
            .cmb_tipo.Items.Add("Médico")
        End With
    End Sub

    Sub preencher_dgv_admin()
        With administrador.dgv_usuarios
            sql = "select * from tb_usuarios order by cpf"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(0).Value, rs.Fields(4).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub preencher_horarios_med()
        With medico
            ' Define a hora inicial e a hora final
            Dim horaInicial As New TimeSpan(8, 0, 0) ' 8:00 AM
            Dim horaFinal As New TimeSpan(16, 0, 0)  ' 4:00 PM

            ' Define o intervalo de tempo entre os horários (30 minutos)
            Dim intervalo As New TimeSpan(0, 30, 0)

            ' Loop para adicionar os horários à ComboBox
            Dim horaAtual As TimeSpan = horaInicial
            While horaAtual <= horaFinal
                .cmb_hora.Items.Add(horaAtual.ToString("hh\:mm"))
                ' Adiciona o intervalo de tempo para obter o próximo horário
                horaAtual = horaAtual.Add(intervalo)
            End While
        End With
    End Sub

    Sub esconder_senha()
        With redefinir_senha
            .txt_senha_atual.Enabled = False
            .txt_cpf.Enabled = False
            .txt_nome.Visible = True
            .txt_senha_nova.Visible = True
            .txt_rsenha.Visible = True
            .lbl_nome.Visible = True
            .lbl_rsenha.Visible = True
            .lbl_senha_nova.Visible = True
            .btn_confirmar.Enabled = False
            .btn_salvar.Visible = True
            .chk_senha.Visible = True
        End With
    End Sub

    Sub limpar_adm()
        With administrador
            .txt_cpf.Clear()
            .txt_email.Clear()
            .cmb_tipo.ResetText()
            .data_calendario.ResetText()
            .txt_senha.Clear()
            .txt_nome_usuario.Clear()
            .txt_nome_usuario.Focus()
        End With

    End Sub
End Module
