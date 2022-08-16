
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
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
            this.titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(44, 582);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(162, 48);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelid
            // 
            this.labelid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(39, 53);
            this.labelid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(87, 18);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Id Do Aluno";
            this.labelid.UseMnemonic = false;
            // 
            // textBox_idAluno
            // 
            this.textBox_idAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_idAluno.Enabled = false;
            this.textBox_idAluno.Location = new System.Drawing.Point(44, 83);
            this.textBox_idAluno.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_idAluno.Name = "textBox_idAluno";
            this.textBox_idAluno.Size = new System.Drawing.Size(104, 26);
            this.textBox_idAluno.TabIndex = 1;
            this.textBox_idAluno.Text = "0";
            // 
            // labelIdTurma
            // 
            this.labelIdTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdTurma.AutoSize = true;
            this.labelIdTurma.Location = new System.Drawing.Point(191, 53);
            this.labelIdTurma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIdTurma.Name = "labelIdTurma";
            this.labelIdTurma.Size = new System.Drawing.Size(51, 18);
            this.labelIdTurma.TabIndex = 2;
            this.labelIdTurma.Text = "Turma";
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(41, 119);
            this.labelNomeAluno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(114, 18);
            this.labelNomeAluno.TabIndex = 4;
            this.labelNomeAluno.Text = "Nome do Aluno";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomeAluno.Location = new System.Drawing.Point(44, 148);
            this.textBoxNomeAluno.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(531, 26);
            this.textBoxNomeAluno.TabIndex = 5;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEndereco.Location = new System.Drawing.Point(44, 208);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(588, 26);
            this.textBoxEndereco.TabIndex = 9;
            // 
            // Endereço
            // 
            this.Endereço.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(41, 185);
            this.Endereço.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(191, 18);
            this.Endereço.TabIndex = 8;
            this.Endereço.Text = "Endereço e Complemento";
            // 
            // labelCidade
            // 
            this.labelCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(39, 307);
            this.labelCidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(60, 18);
            this.labelCidade.TabIndex = 16;
            this.labelCidade.Text = "Cidade";
            // 
            // labelTelefone
            // 
            this.labelTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(41, 370);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(66, 18);
            this.labelTelefone.TabIndex = 20;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(320, 397);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(507, 26);
            this.textBoxEmail.TabIndex = 23;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(316, 370);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // labelUF
            // 
            this.labelUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(591, 305);
            this.labelUF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(29, 18);
            this.labelUF.TabIndex = 18;
            this.labelUF.Text = "UF";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(41, 436);
            this.labelDataNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(112, 18);
            this.labelDataNascimento.TabIndex = 24;
            this.labelDataNascimento.Text = "Data de Nasc.:";
            // 
            // labelSexo
            // 
            this.labelSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(314, 436);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(44, 18);
            this.labelSexo.TabIndex = 26;
            this.labelSexo.Text = "Sexo";
            // 
            // labelCEP
            // 
            this.labelCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(591, 243);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(42, 18);
            this.labelCEP.TabIndex = 14;
            this.labelCEP.Text = "CEP";
            // 
            // textBoxNResponsavel
            // 
            this.textBoxNResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNResponsavel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNResponsavel.Location = new System.Drawing.Point(547, 466);
            this.textBoxNResponsavel.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNResponsavel.Name = "textBoxNResponsavel";
            this.textBoxNResponsavel.Size = new System.Drawing.Size(280, 26);
            this.textBoxNResponsavel.TabIndex = 29;
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(547, 436);
            this.labelResponsavel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(160, 18);
            this.labelResponsavel.TabIndex = 28;
            this.labelResponsavel.Text = "Nome do responsável";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumero.Location = new System.Drawing.Point(665, 208);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(162, 26);
            this.textBoxNumero.TabIndex = 11;
            // 
            // labelNomero
            // 
            this.labelNomero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomero.AutoSize = true;
            this.labelNomero.Location = new System.Drawing.Point(662, 184);
            this.labelNomero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomero.Name = "labelNomero";
            this.labelNomero.Size = new System.Drawing.Size(63, 18);
            this.labelNomero.TabIndex = 10;
            this.labelNomero.Text = "Número";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.Location = new System.Drawing.Point(449, 529);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(378, 26);
            this.textBoxUsuario.TabIndex = 33;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(445, 500);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(130, 18);
            this.labelUsuario.TabIndex = 32;
            this.labelUsuario.Text = "Nome de Usuario";
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSetor.Location = new System.Drawing.Point(44, 271);
            this.textBoxSetor.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(531, 26);
            this.textBoxSetor.TabIndex = 13;
            // 
            // labelSetor
            // 
            this.labelSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(41, 244);
            this.labelSetor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(46, 18);
            this.labelSetor.TabIndex = 12;
            this.labelSetor.Text = "Setor";
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(591, 115);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(41, 18);
            this.labelCPF.TabIndex = 6;
            this.labelCPF.Text = "CPF";
            this.labelCPF.UseMnemonic = false;
            // 
            // comboBoxTURMA
            // 
            this.comboBoxTURMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTURMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTURMA.FormattingEnabled = true;
            this.comboBoxTURMA.Location = new System.Drawing.Point(195, 83);
            this.comboBoxTURMA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTURMA.Name = "comboBoxTURMA";
            this.comboBoxTURMA.Size = new System.Drawing.Size(165, 26);
            this.comboBoxTURMA.TabIndex = 3;
            // 
            // comboBoxSEXO
            // 
            this.comboBoxSEXO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSEXO.FormattingEnabled = true;
            this.comboBoxSEXO.Location = new System.Drawing.Point(320, 465);
            this.comboBoxSEXO.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSEXO.Name = "comboBoxSEXO";
            this.comboBoxSEXO.Size = new System.Drawing.Size(217, 26);
            this.comboBoxSEXO.TabIndex = 27;
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(595, 334);
            this.comboBoxUF.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(232, 26);
            this.comboBoxUF.TabIndex = 19;
            // 
            // comboBoxCIDADE
            // 
            this.comboBoxCIDADE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCIDADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCIDADE.FormattingEnabled = true;
            this.comboBoxCIDADE.Location = new System.Drawing.Point(44, 334);
            this.comboBoxCIDADE.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCIDADE.Name = "comboBoxCIDADE";
            this.comboBoxCIDADE.Size = new System.Drawing.Size(531, 26);
            this.comboBoxCIDADE.TabIndex = 17;
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(595, 271);
            this.maskedTextBoxCEP.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(232, 26);
            this.maskedTextBoxCEP.TabIndex = 15;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(43, 397);
            this.maskedTextBoxTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxTelefone.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(256, 26);
            this.maskedTextBoxTelefone.TabIndex = 21;
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxData.Location = new System.Drawing.Point(43, 465);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(256, 26);
            this.maskedTextBoxData.TabIndex = 25;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // cpf_maskedTextBox1
            // 
            this.cpf_maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpf_maskedTextBox1.Location = new System.Drawing.Point(595, 146);
            this.cpf_maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cpf_maskedTextBox1.Mask = "000.000.000-00";
            this.cpf_maskedTextBox1.Name = "cpf_maskedTextBox1";
            this.cpf_maskedTextBox1.Size = new System.Drawing.Size(232, 26);
            this.cpf_maskedTextBox1.TabIndex = 7;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Location = new System.Drawing.Point(215, 582);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(162, 48);
            this.buttonNovo.TabIndex = 35;
            this.buttonNovo.Text = "&Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(652, 587);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(162, 48);
            this.btn_sair.TabIndex = 36;
            this.btn_sair.Text = "&Retornar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(234, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(258, 33);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Cadastro de Aluno";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 49);
            this.panel1.TabIndex = 37;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenha.Location = new System.Drawing.Point(45, 529);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(394, 26);
            this.textBoxSenha.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 509);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Senha do Usuario";
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 658);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
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
            this.MinimumSize = new System.Drawing.Size(851, 691);
            this.Name = "FormCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
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
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label1;
    }
}