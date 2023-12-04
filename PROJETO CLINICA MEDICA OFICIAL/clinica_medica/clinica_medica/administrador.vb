Public Class administrador
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            sql = "select * from tb_usuarios where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                If txt_nome_usuario.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or cmb_tipo.Text = "" Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                ElseIf data_calendario.Value > DateTime.Today Then
                    MsgBox("Dia inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_nome_usuario.Focus()
                ElseIf txt_senha.TextLength < 6 Then 'Senha menor que 6
                    MsgBox("A senha ficou muito pequena!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha.Clear()
                    txt_senha.Focus()
                Else
                    sql = "INSERT INTO tb_usuarios (cpf, nome, data_nasc, email, senha) VALUES ('" + txt_cpf.Text + "', '" + txt_nome_usuario.Text + "', '" + data_calendario.Value.Date + "', '" + txt_email.Text + "', '" + txt_senha.Text + "')"
                    rs = db.Execute(sql)
                    sql = "insert into tipo_conta (tipo,cpf) values ('" & cmb_tipo.Text & "', " &
                        "'" & txt_cpf.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("CADASTRO COMPLETADO COM SUCESSO!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    preencher_dgv_admin()
                End If
                End If
        Catch ex As Exception
            MsgBox("A conta já existe!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipo_de_conta()
        preencher_dgv_admin()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        Try
            With dgv_usuarios
                If .CurrentRow.Cells(5).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                    aux2 = .CurrentRow.Cells(1).Value
                    aux3 = .CurrentRow.Cells(3).Value
                    resp = MsgBox("Deseja realmente excluir esta consulta?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tipo_conta where cpf = '" + aux3 + "'"
                        rs = db.Execute(sql)
                        sql = "DELETE FROM tb_usuarios WHERE nome = '" + aux + "' AND email = '" + aux2 + "' AND cpf = '" + aux3 + "'"
                        rs = db.Execute(sql)
                        preencher_dgv_admin()
                    Else
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao rodar o programa!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            sql = "SELECT * FROM tb_usuarios WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If txt_nome_usuario.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or cmb_tipo.Text = "" Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                ElseIf data_calendario.Value > DateTime.Today Then
                    MsgBox("Dia inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_nome_usuario.Focus()
                ElseIf txt_senha.TextLength < 6 Then
                    MsgBox("A senha ficou muito pequena!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha.Clear()
                    txt_senha.Focus()
                Else
                ' Atualização na tabela tb_usuarios
                sql = "UPDATE tb_usuarios SET " &
                        "nome = '" & txt_nome_usuario.Text & "', " &
                        "data_nasc = '" & data_calendario.Value.Date & "', " &
                        "email = '" & txt_email.Text & "', " &
                        "senha = '" & txt_senha.Text & "' " &
                        "WHERE cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))

                ' Atualização na tabela tipo_conta
                sql = "UPDATE tipo_conta SET tipo = '" & cmb_tipo.Text & "' WHERE cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))

                MsgBox("CADASTRO ATUALIZADO COM SUCESSO!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                preencher_dgv_admin()
                limpar_adm()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub dgv_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgv_usuarios.Rows(e.RowIndex)
        txt_nome_usuario.Text = selectedGR.Cells(0).Value
        txt_email.Text = selectedGR.Cells(1).Value
        data_calendario.Value = selectedGR.Cells(2).Value
        txt_cpf.Text = selectedGR.Cells(3).Value
        txt_senha.Text = selectedGR.Cells(4).Value

        sql = "select * from tipo_conta where cpf = '" + txt_cpf.Text + "'"
        rs = db.Execute(sql)
        cmb_tipo.Text = rs.Fields(1).Value
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_adm()

    End Sub
End Class