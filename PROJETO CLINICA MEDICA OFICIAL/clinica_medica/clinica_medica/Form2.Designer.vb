<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.lbl_senha_status = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_tipo_conta = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_senha_stat = New System.Windows.Forms.Label()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_senha = New System.Windows.Forms.CheckBox()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF DO CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(288, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DATA DE NASCIMENTO"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(37, 209)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(105, 23)
        Me.txt_cpf.TabIndex = 4
        '
        'cmb_data
        '
        Me.cmb_data.CalendarMonthBackground = System.Drawing.Color.White
        Me.cmb_data.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data.Location = New System.Drawing.Point(286, 209)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(200, 23)
        Me.cmb_data.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(52, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(52, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SENHA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(307, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "REPETIR SENHA"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(37, 280)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(458, 23)
        Me.txt_email.TabIndex = 9
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.White
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(37, 358)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(146, 23)
        Me.txt_senha.TabIndex = 10
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_rsenha
        '
        Me.txt_rsenha.BackColor = System.Drawing.Color.White
        Me.txt_rsenha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha.Location = New System.Drawing.Point(292, 358)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.Size = New System.Drawing.Size(164, 23)
        Me.txt_rsenha.TabIndex = 11
        Me.txt_rsenha.UseSystemPasswordChar = True
        '
        'lbl_senha_status
        '
        Me.lbl_senha_status.AutoSize = True
        Me.lbl_senha_status.Location = New System.Drawing.Point(23, 295)
        Me.lbl_senha_status.Name = "lbl_senha_status"
        Me.lbl_senha_status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_senha_status.TabIndex = 12
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_salvar.Location = New System.Drawing.Point(341, 411)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(169, 45)
        Me.btn_salvar.TabIndex = 14
        Me.btn_salvar.Text = "CONCLUIR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'lbl_tipo_conta
        '
        Me.lbl_tipo_conta.AutoSize = True
        Me.lbl_tipo_conta.Location = New System.Drawing.Point(2, -1)
        Me.lbl_tipo_conta.Name = "lbl_tipo_conta"
        Me.lbl_tipo_conta.Size = New System.Drawing.Size(38, 13)
        Me.lbl_tipo_conta.TabIndex = 15
        Me.lbl_tipo_conta.Text = "cliente"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(37, 140)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(458, 23)
        Me.txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DO CLIENTE"
        '
        'lbl_senha_stat
        '
        Me.lbl_senha_stat.AutoSize = True
        Me.lbl_senha_stat.Location = New System.Drawing.Point(42, 383)
        Me.lbl_senha_stat.Name = "lbl_senha_stat"
        Me.lbl_senha_stat.Size = New System.Drawing.Size(0, 13)
        Me.lbl_senha_stat.TabIndex = 16
        '
        'sair
        '
        Me.sair.Image = CType(resources.GetObject("sair.Image"), System.Drawing.Image)
        Me.sair.Location = New System.Drawing.Point(492, 10)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(31, 31)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sair.TabIndex = 17
        Me.sair.TabStop = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(432, 9)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(31, 32)
        Me.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.btn_voltar)
        Me.Panel1.Controls.Add(Me.sair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 49)
        Me.Panel1.TabIndex = 25
        '
        'chk_senha
        '
        Me.chk_senha.AutoSize = True
        Me.chk_senha.BackColor = System.Drawing.SystemColors.Control
        Me.chk_senha.Location = New System.Drawing.Point(37, 399)
        Me.chk_senha.Name = "chk_senha"
        Me.chk_senha.Size = New System.Drawing.Size(74, 17)
        Me.chk_senha.TabIndex = 41
        Me.chk_senha.Text = "Ver senha"
        Me.chk_senha.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(535, 487)
        Me.Controls.Add(Me.chk_senha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_senha_stat)
        Me.Controls.Add(Me.lbl_tipo_conta)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.lbl_senha_status)
        Me.Controls.Add(Me.txt_rsenha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_data)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "CADASTRO DE CONTAS"
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents lbl_senha_status As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents lbl_tipo_conta As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_senha_stat As Label
    Friend WithEvents sair As PictureBox
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chk_senha As CheckBox
End Class
