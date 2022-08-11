
namespace UIPrincipal
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.textBox_idAluno = new System.Windows.Forms.TextBox();
            this.labelIdTurma = new System.Windows.Forms.Label();
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textBoxNResponsavel = new System.Windows.Forms.TextBox();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNomero = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.comboBoxTURMA = new System.Windows.Forms.ComboBox();
            this.comboBoxSEXO = new System.Windows.Forms.ComboBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.comboBoxCIDADE = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.cpf_maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNovo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 579);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 46);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(32, 72);
            this.labelid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(62, 18);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "Id Aluno";
            this.labelid.UseMnemonic = false;
            // 
            // textBox_idAluno
            // 
            this.textBox_idAluno.Enabled = false;
            this.textBox_idAluno.Location = new System.Drawing.Point(37, 102);
            this.textBox_idAluno.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_idAluno.Name = "textBox_idAluno";
            this.textBox_idAluno.Size = new System.Drawing.Size(104, 26);
            this.textBox_idAluno.TabIndex = 4;
            this.textBox_idAluno.Text = "0";
            this.textBox_idAluno.TextChanged += new System.EventHandler(this.textBox_idAluno_TextChanged);
            // 
            // labelIdTurma
            // 
            this.labelIdTurma.AutoSize = true;
            this.labelIdTurma.Location = new System.Drawing.Point(155, 72);
            this.labelIdTurma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIdTurma.Name = "labelIdTurma";
            this.labelIdTurma.Size = new System.Drawing.Size(67, 18);
            this.labelIdTurma.TabIndex = 5;
            this.labelIdTurma.Text = "Id Turma";
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(34, 138);
            this.labelNomeAluno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(114, 18);
            this.labelNomeAluno.TabIndex = 7;
            this.labelNomeAluno.Text = "Nome do Aluno";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(37, 167);
            this.textBoxNomeAluno.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(531, 26);
            this.textBoxNomeAluno.TabIndex = 8;
            this.textBoxNomeAluno.TextChanged += new System.EventHandler(this.textBoxNomeAluno_TextChanged);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(37, 227);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(588, 26);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(34, 204);
            this.Endereço.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(191, 18);
            this.Endereço.TabIndex = 9;
            this.Endereço.Text = "Endereço e Complemento";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(32, 326);
            this.labelCidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(60, 18);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(34, 389);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(66, 18);
            this.labelTelefone.TabIndex = 13;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(313, 416);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(344, 26);
            this.textBoxEmail.TabIndex = 16;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(307, 387);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(578, 326);
            this.labelUF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(29, 18);
            this.labelUF.TabIndex = 17;
            this.labelUF.Text = "UF";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(34, 455);
            this.labelDataNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(112, 18);
            this.labelDataNascimento.TabIndex = 19;
            this.labelDataNascimento.Text = "Data de Nasc.:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(307, 455);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(44, 18);
            this.labelSexo.TabIndex = 21;
            this.labelSexo.Text = "Sexo";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(595, 261);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(42, 18);
            this.labelCEP.TabIndex = 23;
            this.labelCEP.Text = "CEP";
            // 
            // textBoxNResponsavel
            // 
            this.textBoxNResponsavel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNResponsavel.Location = new System.Drawing.Point(540, 485);
            this.textBoxNResponsavel.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNResponsavel.Name = "textBoxNResponsavel";
            this.textBoxNResponsavel.Size = new System.Drawing.Size(267, 26);
            this.textBoxNResponsavel.TabIndex = 26;
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(540, 455);
            this.labelResponsavel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(160, 18);
            this.labelResponsavel.TabIndex = 25;
            this.labelResponsavel.Text = "Nome do responsável";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(658, 227);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(138, 26);
            this.textBoxNumero.TabIndex = 28;
            // 
            // labelNomero
            // 
            this.labelNomero.AutoSize = true;
            this.labelNomero.Location = new System.Drawing.Point(655, 203);
            this.labelNomero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomero.Name = "labelNomero";
            this.labelNomero.Size = new System.Drawing.Size(63, 18);
            this.labelNomero.TabIndex = 27;
            this.labelNomero.Text = "Número";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(38, 541);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(378, 26);
            this.textBoxSenha.TabIndex = 30;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(39, 516);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 18);
            this.labelSenha.TabIndex = 29;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSetor.Location = new System.Drawing.Point(37, 290);
            this.textBoxSetor.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(531, 26);
            this.textBoxSetor.TabIndex = 33;
            this.textBoxSetor.TextChanged += new System.EventHandler(this.textBoxSetor_TextChanged);
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(32, 262);
            this.labelSetor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(46, 18);
            this.labelSetor.TabIndex = 32;
            this.labelSetor.Text = "Setor";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(584, 134);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(41, 18);
            this.labelCPF.TabIndex = 35;
            this.labelCPF.Text = "CPF";
            this.labelCPF.UseMnemonic = false;
            // 
            // comboBoxTURMA
            // 
            this.comboBoxTURMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTURMA.FormattingEnabled = true;
            this.comboBoxTURMA.Location = new System.Drawing.Point(151, 102);
            this.comboBoxTURMA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTURMA.Name = "comboBoxTURMA";
            this.comboBoxTURMA.Size = new System.Drawing.Size(165, 26);
            this.comboBoxTURMA.TabIndex = 38;
            // 
            // comboBoxSEXO
            // 
            this.comboBoxSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSEXO.FormattingEnabled = true;
            this.comboBoxSEXO.Location = new System.Drawing.Point(313, 484);
            this.comboBoxSEXO.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSEXO.Name = "comboBoxSEXO";
            this.comboBoxSEXO.Size = new System.Drawing.Size(217, 26);
            this.comboBoxSEXO.TabIndex = 39;
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(582, 353);
            this.comboBoxUF.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(225, 26);
            this.comboBoxUF.TabIndex = 40;
            // 
            // comboBoxCIDADE
            // 
            this.comboBoxCIDADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCIDADE.FormattingEnabled = true;
            this.comboBoxCIDADE.Location = new System.Drawing.Point(37, 353);
            this.comboBoxCIDADE.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCIDADE.Name = "comboBoxCIDADE";
            this.comboBoxCIDADE.Size = new System.Drawing.Size(531, 26);
            this.comboBoxCIDADE.TabIndex = 41;
            this.comboBoxCIDADE.SelectedIndexChanged += new System.EventHandler(this.comboBoxCIDADE_SelectedIndexChanged);
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(588, 290);
            this.maskedTextBoxCEP.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(219, 26);
            this.maskedTextBoxCEP.TabIndex = 49;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(36, 416);
            this.maskedTextBoxTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxTelefone.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(256, 26);
            this.maskedTextBoxTelefone.TabIndex = 50;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefone_MaskInputRejected);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(36, 484);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(256, 26);
            this.maskedTextBoxData.TabIndex = 51;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // cpf_maskedTextBox1
            // 
            this.cpf_maskedTextBox1.Location = new System.Drawing.Point(588, 165);
            this.cpf_maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cpf_maskedTextBox1.Mask = "000.000.000-00";
            this.cpf_maskedTextBox1.Name = "cpf_maskedTextBox1";
            this.cpf_maskedTextBox1.Size = new System.Drawing.Size(219, 26);
            this.cpf_maskedTextBox1.TabIndex = 52;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.Location = new System.Drawing.Point(208, 579);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(108, 46);
            this.buttonNovo.TabIndex = 53;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(688, 579);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(119, 46);
            this.btn_sair.TabIndex = 54;
            this.btn_sair.Text = "S&air";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 49);
            this.panel1.TabIndex = 55;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(7, 3);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(258, 33);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Cadastro de Aluno";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.cpf_maskedTextBox1);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.comboBoxCIDADE);
            this.Controls.Add(this.comboBoxUF);
            this.Controls.Add(this.comboBoxSEXO);
            this.Controls.Add(this.comboBoxTURMA);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNomero);
            this.Controls.Add(this.textBoxNResponsavel);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Controls.Add(this.labelIdTurma);
            this.Controls.Add(this.textBox_idAluno);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.FormCadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBox_idAluno;
        private System.Windows.Forms.Label labelIdTurma;
        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textBoxNResponsavel;
        private System.Windows.Forms.Label labelResponsavel;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNomero;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.ComboBox comboBoxTURMA;
        private System.Windows.Forms.ComboBox comboBoxSEXO;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.ComboBox comboBoxCIDADE;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox cpf_maskedTextBox1;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulo;
    }
}