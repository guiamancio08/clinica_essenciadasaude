Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Paciente
    Private Sub Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencher_dgv()
        txt_nome_paciente.Text = nome_paciente
        txt_nome_paciente.Enabled = False
        txt_nome_paciente.Focus()
        Dim rs1 As ADODB.Recordset ' Variável da tabela
        Dim sql1 As String
        ' Limpe a ComboBox antes de preenchê-la para evitar duplicatas.
        cmb_medico.Items.Clear()

        sql1 = "SELECT cpf FROM tipo_conta WHERE tipo = 'MÉDICO'"
        rs1 = db.Execute(sql1)

        ' Certifique-se de fechar o Recordset rs1 quando não for mais necessário.
        While Not rs1.EOF
            Dim cpf As String = rs1.Fields("cpf").Value

            ' Consulta de médico no loop principal para evitar consultas repetidas.
            sql = "SELECT nome FROM tb_usuarios WHERE cpf = '" & cpf & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                Dim nome As String = rs.Fields("nome").Value.ToString()
                cmb_medico.Items.Add(nome)
            End If

            rs.MoveNext()
            rs1.MoveNext()
        End While

        ' Feche o Recordset rs1 e, se necessário, feche a conexão com o banco de dados.
        rs1.Close()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            sql = "select * from tb_consultas where nome_medico = '" + cmb_medico.SelectedItem + "' and data_consulta= '" + data_calendario.Value.Date + "' and horario = '" + cmb_hora.SelectedItem + "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                If txt_nome_paciente.Text = "" Or cmb_medico.Text = "" Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_nome_paciente.Focus()
                ElseIf data_calendario.Value < DateTime.Today Then
                    MsgBox("Dia inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_consulta()
                Else
                    sql = "INSERT INTO tb_consultas (nome_paciente, nome_medico, data_consulta, sintomas, horario) values ('" + txt_nome_paciente.Text + "', '" + cmb_medico.Text + "', '" + data_calendario.Value.Date + "',  '" + txt_sintomas.Text + "' ,'" + cmb_hora.SelectedItem + "' )"
                    rs = db.Execute(sql)
                    MsgBox("Consulta marcada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    preencher_dgv()
                    limpar_consulta()
                    cmb_hora.Items.Clear()
                End If
            Else
                MsgBox("Esse horário/dia já foi marcado por outro usuário, tente marcar outro dia!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Horário indisponível no momento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limpar_consulta()
        End Try
    End Sub


    Private Sub cmb_hora_GotFocus(sender As Object, e As EventArgs) Handles cmb_hora.GotFocus
        Try
            If cmb_hora.Items.Count = 0 Then
                preencher_horarios()
            End If

            sql = "select * from tb_consultas where nome_medico = '" + cmb_medico.SelectedItem + "' and data_consulta = '" + data_calendario.Value.Date + "'"
            rs = db.Execute(sql)
            While Not rs.EOF
                Dim hora_marcada As String = rs.Fields(5).Value.ToString() 'recebe o horário ja marcado

                ' Verificar se o item já existe na ComboBox
                Dim indice As Integer = cmb_hora.FindStringExact(hora_marcada)

                If indice <> -1 Then ' Se o horário já existir na ComboBox
                    ' Adicionar a indicação "(Indisponível)" ao item existente
                    cmb_hora.Items(indice) = cmb_hora.Items(indice).ToString() & "(Indisponível)"
                End If

                rs.MoveNext()
            End While
            rs.Close()
        Catch ex As Exception
            ' Lidar com a exceção (por exemplo, exibir uma mensagem de erro)
            MessageBox.Show($"Erro ao consultar o banco de dados: {ex.Message}")
        End Try
    End Sub


    Private Sub dgv_consultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultas.CellContentClick
        Try

            With dgv_consultas
                If .CurrentRow.Cells(5).Selected Then
                    aux = .CurrentRow.Cells(1).Value
                    aux2 = .CurrentRow.Cells(2).Value
                    aux3 = .CurrentRow.Cells(3).Value
                    resp = MsgBox("Deseja realmente excluir esta consulta?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_consultas where nome_medico = '" + aux + "'and data_consulta= '" + aux2 + "' and horario= '" + aux3 + "'"
                        rs = db.Execute(sql)
                        preencher_dgv()
                        cmb_hora.Items.Clear()
                        preencher_horarios()
                        limpar_consulta()
                    Else
                        Exit Sub
                    End If

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        Application.Exit()
    End Sub

    Private Sub cmb_medico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_medico.SelectedIndexChanged
        cmb_hora.Items.Clear()
        preencher_horarios()
    End Sub

    Private Sub data_calendario_ValueChanged(sender As Object, e As EventArgs) Handles data_calendario.ValueChanged
        cmb_hora.Items.Clear()
        preencher_horarios()

    End Sub

    Private Sub dgv_consultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultas.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgv_consultas.Rows(e.RowIndex)
        cmb_medico.Text = selectedGR.Cells(1).Value
        data_calendario.Value = selectedGR.Cells(2).Value
        cmb_hora.Text = selectedGR.Cells(3).Value
        txt_sintomas.Text = selectedGR.Cells(4).Value
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            If txt_nome_paciente.Text = "" Or cmb_medico.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_nome_paciente.Focus()
            ElseIf data_calendario.Value < DateTime.Today Then
                MsgBox("Dia inválido para a sua consulta!")
                txt_nome_paciente.Focus()
            Else
                sql = "SELECT * FROM tb_consultas WHERE nome_paciente = '" & txt_nome_paciente.Text & "' AND nome_medico = '" & cmb_medico.SelectedItem & "' AND sintomas = '" + txt_sintomas.Text + "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    ' Certifique-se de que o campo ID_CONSULTA existe e é um número inteiro
                    If rs.Fields.Count > 0 AndAlso IsNumeric(rs.Fields(0).Value) Then
                        Dim id_consulta As Integer = CInt(rs.Fields(0).Value)

                        sql = "UPDATE tb_consultas SET " &
                    "nome_medico = '" & cmb_medico.Text & "', " &
                    "data_consulta = '" & data_calendario.Value.Date & "', " &
                    "sintomas = '" & txt_sintomas.Text & "', " &
                    "horario = '" & cmb_hora.SelectedItem & "' " &
                    "WHERE id_consulta = " & id_consulta

                        rs = db.Execute(sql)

                        MsgBox("Consulta atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        preencher_dgv()
                        limpar_consulta()
                        cmb_hora.Items.Clear()
                    Else
                        MsgBox("Ocorreu um problema ao obter o ID da consulta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    MsgBox("Não foi possível encontrar a consulta para atualização.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            End If
        Catch ex As Exception
            MsgBox("Algo no programa deu errado!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_consulta()
    End Sub
End Class
