<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medico))
        Me.btn_salvar_med = New System.Windows.Forms.Button()
        Me.dgv_consultas_med = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data_calendario = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_sintomas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_paciente = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_hora = New System.Windows.Forms.ComboBox()
        Me.txt_medico = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        CType(Me.dgv_consultas_med, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salvar_med
        '
        Me.btn_salvar_med.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_salvar_med.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_med.ForeColor = System.Drawing.Color.White
        Me.btn_salvar_med.Location = New System.Drawing.Point(549, 274)
        Me.btn_salvar_med.Name = "btn_salvar_med"
        Me.btn_salvar_med.Size = New System.Drawing.Size(139, 45)
        Me.btn_salvar_med.TabIndex = 35
        Me.btn_salvar_med.Text = "SALVAR"
        Me.btn_salvar_med.UseVisualStyleBackColor = False
        '
        'dgv_consultas_med
        '
        Me.dgv_consultas_med.AllowUserToAddRows = False
        Me.dgv_consultas_med.AllowUserToDeleteRows = False
        Me.dgv_consultas_med.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_consultas_med.BackgroundColor = System.Drawing.Color.White
        Me.dgv_consultas_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultas_med.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.DATA, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_consultas_med.Location = New System.Drawing.Point(328, 383)
        Me.dgv_consultas_med.Name = "dgv_consultas_med"
        Me.dgv_consultas_med.ReadOnly = True
        Me.dgv_consultas_med.RowHeadersWidth = 51
        Me.dgv_consultas_med.Size = New System.Drawing.Size(617, 207)
        Me.dgv_consultas_med.TabIndex = 34
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "MÉDICO"
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
        Me.Column3.HeaderText = "HORA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "SINTOMAS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        Me.Label8.Location = New System.Drawing.Point(543, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 35)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Agenda de Consultas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(534, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 35)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Horário"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(293, 149)
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
        Me.data_calendario.Location = New System.Drawing.Point(283, 193)
        Me.data_calendario.Name = "data_calendario"
        Me.data_calendario.Size = New System.Drawing.Size(163, 27)
        Me.data_calendario.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(534, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 35)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Médico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(821, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 35)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Sintomas"
        '
        'txt_sintomas
        '
        Me.txt_sintomas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sintomas.Location = New System.Drawing.Point(811, 114)
        Me.txt_sintomas.Multiline = True
        Me.txt_sintomas.Name = "txt_sintomas"
        Me.txt_sintomas.Size = New System.Drawing.Size(174, 120)
        Me.txt_sintomas.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(293, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 35)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Paciente"
        '
        'txt_nome_paciente
        '
        Me.txt_nome_paciente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_paciente.Location = New System.Drawing.Point(283, 114)
        Me.txt_nome_paciente.Name = "txt_nome_paciente"
        Me.txt_nome_paciente.Size = New System.Drawing.Size(174, 27)
        Me.txt_nome_paciente.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.sair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(204, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 44)
        Me.Panel2.TabIndex = 23
        '
        'btn_voltar
        '
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(735, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(40, 41)
        Me.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_voltar.TabIndex = 4
        Me.btn_voltar.TabStop = False
        '
        'sair
        '
        Me.sair.Image = CType(resources.GetObject("sair.Image"), System.Drawing.Image)
        Me.sair.Location = New System.Drawing.Point(797, 3)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(40, 38)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sair.TabIndex = 0
        Me.sair.TabStop = False
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
        Me.Panel1.Size = New System.Drawing.Size(204, 602)
        Me.Panel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(88, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Consultas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(101, 14)
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
        'cmb_hora
        '
        Me.cmb_hora.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.Location = New System.Drawing.Point(529, 199)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(181, 29)
        Me.cmb_hora.TabIndex = 36
        '
        'txt_medico
        '
        Me.txt_medico.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_medico.Location = New System.Drawing.Point(529, 114)
        Me.txt_medico.Name = "txt_medico"
        Me.txt_medico.Size = New System.Drawing.Size(174, 27)
        Me.txt_medico.TabIndex = 37
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(764, 274)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(139, 45)
        Me.btn_editar.TabIndex = 38
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Location = New System.Drawing.Point(353, 274)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(139, 45)
        Me.btn_limpar.TabIndex = 39
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1068, 602)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.txt_medico)
        Me.Controls.Add(Me.cmb_hora)
        Me.Controls.Add(Me.btn_salvar_med)
        Me.Controls.Add(Me.dgv_consultas_med)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.data_calendario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_sintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nome_paciente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "medico"
        Me.Text = "medico"
        CType(Me.dgv_consultas_med, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salvar_med As Button
    Friend WithEvents dgv_consultas_med As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents data_calendario As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_sintomas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_paciente As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sair As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmb_hora As ComboBox
    Friend WithEvents txt_medico As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents btn_limpar As Button
End Class
