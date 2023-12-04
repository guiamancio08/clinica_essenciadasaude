<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrador))
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data_calendario = New System.Windows.Forms.DateTimePicker()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(539, 277)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(139, 45)
        Me.btn_salvar.TabIndex = 35
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.DATA, Me.Column3, Me.Column6, Me.Column5})
        Me.dgv_usuarios.Location = New System.Drawing.Point(293, 380)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.RowHeadersWidth = 51
        Me.dgv_usuarios.Size = New System.Drawing.Size(647, 207)
        Me.dgv_usuarios.TabIndex = 34
        '
        'Column1
        '
        Me.Column1.HeaderText = "USUÁRIO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "EMAIL"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DATA
        '
        Me.DATA.HeaderText = "DATA"
        Me.DATA.Name = "DATA"
        Me.DATA.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "SENHA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(512, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 35)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Lista de Usuários"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(769, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 35)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Data"
        '
        'data_calendario
        '
        Me.data_calendario.CalendarMonthBackground = System.Drawing.Color.White
        Me.data_calendario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_calendario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.data_calendario.Location = New System.Drawing.Point(766, 115)
        Me.data_calendario.Name = "data_calendario"
        Me.data_calendario.Size = New System.Drawing.Size(163, 27)
        Me.data_calendario.TabIndex = 31
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(518, 193)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(181, 29)
        Me.cmb_tipo.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(287, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 35)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Usuário"
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_usuario.Location = New System.Drawing.Point(277, 115)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(174, 27)
        Me.txt_nome_usuario.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.sair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 44)
        Me.Panel2.TabIndex = 23
        '
        'btn_voltar
        '
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(663, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(40, 41)
        Me.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_voltar.TabIndex = 44
        Me.btn_voltar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(731, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'sair
        '
        Me.sair.Image = CType(resources.GetObject("sair.Image"), System.Drawing.Image)
        Me.sair.Location = New System.Drawing.Point(811, 3)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(40, 38)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sair.TabIndex = 0
        Me.sair.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(80, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Administração"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(107, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clínica"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(528, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 35)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tipo de Conta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 613)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(287, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 35)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(277, 195)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(174, 27)
        Me.txt_cpf.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(528, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 35)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(518, 115)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(174, 27)
        Me.txt_email.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(765, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 35)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(766, 195)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(174, 27)
        Me.txt_senha.TabIndex = 41
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(723, 277)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(139, 45)
        Me.btn_editar.TabIndex = 43
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Location = New System.Drawing.Point(347, 277)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(139, 45)
        Me.btn_limpar.TabIndex = 44
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 613)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.data_calendario)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "administrador"
        Me.Text = "administrador"
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salvar As Button
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents data_calendario As DateTimePicker
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sair As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents btn_limpar As Button
End Class
