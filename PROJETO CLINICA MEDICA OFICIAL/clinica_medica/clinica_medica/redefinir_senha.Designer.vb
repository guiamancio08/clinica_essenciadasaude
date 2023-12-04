<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class redefinir_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(redefinir_senha))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_senha_atual = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_senha_nova = New System.Windows.Forms.Label()
        Me.txt_senha_nova = New System.Windows.Forms.TextBox()
        Me.lbl_rsenha = New System.Windows.Forms.Label()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_senha_stat = New System.Windows.Forms.Label()
        Me.chk_senha = New System.Windows.Forms.CheckBox()
        Me.btn_confirmar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_confirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.sair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 49)
        Me.Panel1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(158, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 35)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "REDEFINIÇÃO DE SENHA"
        '
        'sair
        '
        Me.sair.Image = CType(resources.GetObject("sair.Image"), System.Drawing.Image)
        Me.sair.Location = New System.Drawing.Point(541, 12)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(31, 31)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sair.TabIndex = 17
        Me.sair.TabStop = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_cpf.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(12, 64)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(116, 23)
        Me.lbl_cpf.TabIndex = 27
        Me.lbl_cpf.Text = "CPF DA CONTA :"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(129, 63)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(97, 23)
        Me.txt_cpf.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "SENHA ATUAL :"
        '
        'txt_senha_atual
        '
        Me.txt_senha_atual.BackColor = System.Drawing.Color.White
        Me.txt_senha_atual.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_atual.Location = New System.Drawing.Point(129, 98)
        Me.txt_senha_atual.Name = "txt_senha_atual"
        Me.txt_senha_atual.Size = New System.Drawing.Size(146, 23)
        Me.txt_senha_atual.TabIndex = 30
        Me.txt_senha_atual.UseSystemPasswordChar = True
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_nome.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(12, 181)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(138, 23)
        Me.lbl_nome.TabIndex = 31
        Me.lbl_nome.Text = "NOME DO CLIENTE:"
        Me.lbl_nome.Visible = False
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Enabled = False
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(12, 212)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(528, 23)
        Me.txt_nome.TabIndex = 32
        Me.txt_nome.Visible = False
        '
        'lbl_senha_nova
        '
        Me.lbl_senha_nova.AutoSize = True
        Me.lbl_senha_nova.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_senha_nova.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.lbl_senha_nova.Location = New System.Drawing.Point(12, 283)
        Me.lbl_senha_nova.Name = "lbl_senha_nova"
        Me.lbl_senha_nova.Size = New System.Drawing.Size(104, 23)
        Me.lbl_senha_nova.TabIndex = 33
        Me.lbl_senha_nova.Text = "NOVA SENHA :"
        Me.lbl_senha_nova.Visible = False
        '
        'txt_senha_nova
        '
        Me.txt_senha_nova.BackColor = System.Drawing.Color.White
        Me.txt_senha_nova.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_nova.Location = New System.Drawing.Point(12, 309)
        Me.txt_senha_nova.Name = "txt_senha_nova"
        Me.txt_senha_nova.Size = New System.Drawing.Size(146, 23)
        Me.txt_senha_nova.TabIndex = 34
        Me.txt_senha_nova.UseSystemPasswordChar = True
        Me.txt_senha_nova.Visible = False
        '
        'lbl_rsenha
        '
        Me.lbl_rsenha.AutoSize = True
        Me.lbl_rsenha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_rsenha.Font = New System.Drawing.Font("Sitka Banner", 12.0!)
        Me.lbl_rsenha.Location = New System.Drawing.Point(318, 283)
        Me.lbl_rsenha.Name = "lbl_rsenha"
        Me.lbl_rsenha.Size = New System.Drawing.Size(122, 23)
        Me.lbl_rsenha.TabIndex = 35
        Me.lbl_rsenha.Text = "REPETIR SENHA :"
        Me.lbl_rsenha.Visible = False
        '
        'txt_rsenha
        '
        Me.txt_rsenha.BackColor = System.Drawing.Color.White
        Me.txt_rsenha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha.Location = New System.Drawing.Point(322, 309)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.Size = New System.Drawing.Size(146, 23)
        Me.txt_rsenha.TabIndex = 36
        Me.txt_rsenha.UseSystemPasswordChar = True
        Me.txt_rsenha.Visible = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(401, 380)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(152, 52)
        Me.btn_salvar.TabIndex = 37
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        Me.btn_salvar.Visible = False
        '
        'lbl_senha_stat
        '
        Me.lbl_senha_stat.AutoSize = True
        Me.lbl_senha_stat.Location = New System.Drawing.Point(13, 335)
        Me.lbl_senha_stat.Name = "lbl_senha_stat"
        Me.lbl_senha_stat.Size = New System.Drawing.Size(0, 13)
        Me.lbl_senha_stat.TabIndex = 39
        Me.lbl_senha_stat.Visible = False
        '
        'chk_senha
        '
        Me.chk_senha.AutoSize = True
        Me.chk_senha.BackColor = System.Drawing.SystemColors.Control
        Me.chk_senha.Location = New System.Drawing.Point(164, 313)
        Me.chk_senha.Name = "chk_senha"
        Me.chk_senha.Size = New System.Drawing.Size(74, 17)
        Me.chk_senha.TabIndex = 40
        Me.chk_senha.Text = "Ver senha"
        Me.chk_senha.UseVisualStyleBackColor = False
        Me.chk_senha.Visible = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(355, 77)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(34, 34)
        Me.btn_confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_confirmar.TabIndex = 38
        Me.btn_confirmar.TabStop = False
        '
        'redefinir_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 458)
        Me.Controls.Add(Me.chk_senha)
        Me.Controls.Add(Me.lbl_senha_stat)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.txt_rsenha)
        Me.Controls.Add(Me.lbl_rsenha)
        Me.Controls.Add(Me.txt_senha_nova)
        Me.Controls.Add(Me.lbl_senha_nova)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_senha_atual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "redefinir_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "redefinir_senha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_confirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents sair As PictureBox
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_senha_atual As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_senha_nova As Label
    Friend WithEvents txt_senha_nova As TextBox
    Friend WithEvents lbl_rsenha As Label
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_senha_stat As Label
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents btn_confirmar As PictureBox
End Class
