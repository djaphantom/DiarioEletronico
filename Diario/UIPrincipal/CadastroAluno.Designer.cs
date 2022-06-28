
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
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.textBox_idAluno = new System.Windows.Forms.TextBox();
            this.labelIdTurma = new System.Windows.Forms.Label();
            this.textBoxid_Turma = new System.Windows.Forms.TextBox();
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.textBoxDataNasc = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxSexoF_M = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textBoxNResponsavel = new System.Windows.Forms.TextBox();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNomero = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelConformaSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Model.Aluno);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(451, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 30);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(17, 18);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(46, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "Id Aluno";
            this.labelid.UseMnemonic = false;
            // 
            // textBox_idAluno
            // 
            this.textBox_idAluno.Location = new System.Drawing.Point(20, 35);
            this.textBox_idAluno.Name = "textBox_idAluno";
            this.textBox_idAluno.Size = new System.Drawing.Size(59, 20);
            this.textBox_idAluno.TabIndex = 4;
            // 
            // labelIdTurma
            // 
            this.labelIdTurma.AutoSize = true;
            this.labelIdTurma.Location = new System.Drawing.Point(85, 18);
            this.labelIdTurma.Name = "labelIdTurma";
            this.labelIdTurma.Size = new System.Drawing.Size(49, 13);
            this.labelIdTurma.TabIndex = 5;
            this.labelIdTurma.Text = "Id Turma";
            // 
            // textBoxid_Turma
            // 
            this.textBoxid_Turma.Location = new System.Drawing.Point(86, 35);
            this.textBoxid_Turma.Name = "textBoxid_Turma";
            this.textBoxid_Turma.Size = new System.Drawing.Size(62, 20);
            this.textBoxid_Turma.TabIndex = 6;
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(19, 62);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(80, 13);
            this.labelNomeAluno.TabIndex = 7;
            this.labelNomeAluno.Text = "Nome do Aluno";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(20, 79);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(522, 20);
            this.textBoxNomeAluno.TabIndex = 8;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(20, 116);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(522, 20);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Endereço";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(20, 193);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(356, 20);
            this.textBoxCidade.TabIndex = 12;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(17, 179);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(22, 232);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(163, 20);
            this.textBoxTelefone.TabIndex = 14;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(19, 217);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 13;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(191, 232);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(351, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(188, 216);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(382, 193);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(160, 20);
            this.textBoxUF.TabIndex = 18;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(382, 179);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(21, 13);
            this.labelUF.TabIndex = 17;
            this.labelUF.Text = "UF";
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(22, 273);
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(163, 20);
            this.textBoxDataNasc.TabIndex = 20;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(19, 257);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(79, 13);
            this.labelDataNascimento.TabIndex = 19;
            this.labelDataNascimento.Text = "Data de Nasc.:";
            // 
            // textBoxSexoF_M
            // 
            this.textBoxSexoF_M.Location = new System.Drawing.Point(191, 273);
            this.textBoxSexoF_M.Name = "textBoxSexoF_M";
            this.textBoxSexoF_M.Size = new System.Drawing.Size(120, 20);
            this.textBoxSexoF_M.TabIndex = 22;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(188, 257);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 21;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(382, 155);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(160, 20);
            this.textBoxCep.TabIndex = 24;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(382, 139);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 13);
            this.labelCEP.TabIndex = 23;
            this.labelCEP.Text = "CEP";
            // 
            // textBoxNResponsavel
            // 
            this.textBoxNResponsavel.Location = new System.Drawing.Point(20, 313);
            this.textBoxNResponsavel.Name = "textBoxNResponsavel";
            this.textBoxNResponsavel.Size = new System.Drawing.Size(522, 20);
            this.textBoxNResponsavel.TabIndex = 26;
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(17, 297);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(110, 13);
            this.labelResponsavel.TabIndex = 25;
            this.labelResponsavel.Text = "Nome do responsável";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(317, 155);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(60, 20);
            this.textBoxNumero.TabIndex = 28;
            // 
            // labelNomero
            // 
            this.labelNomero.AutoSize = true;
            this.labelNomero.Location = new System.Drawing.Point(314, 139);
            this.labelNomero.Name = "labelNomero";
            this.labelNomero.Size = new System.Drawing.Size(44, 13);
            this.labelNomero.TabIndex = 27;
            this.labelNomero.Text = "Número";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(20, 354);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(208, 20);
            this.textBoxSenha.TabIndex = 30;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(17, 338);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 29;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.Location = new System.Drawing.Point(20, 155);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(291, 20);
            this.textBoxSetor.TabIndex = 33;
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(17, 139);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(32, 13);
            this.labelSetor.TabIndex = 32;
            this.labelSetor.Text = "Setor";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(317, 273);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(224, 20);
            this.textBoxCPF.TabIndex = 34;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(314, 257);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 35;
            this.labelCPF.Text = "CPF";
            this.labelCPF.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 37;
            // 
            // labelConformaSenha
            // 
            this.labelConformaSenha.AutoSize = true;
            this.labelConformaSenha.Location = new System.Drawing.Point(19, 377);
            this.labelConformaSenha.Name = "labelConformaSenha";
            this.labelConformaSenha.Size = new System.Drawing.Size(85, 13);
            this.labelConformaSenha.TabIndex = 36;
            this.labelConformaSenha.Text = "Confirmar Senha";
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelConformaSenha);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNomero);
            this.Controls.Add(this.textBoxNResponsavel);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxSexoF_M);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxDataNasc);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Controls.Add(this.textBoxid_Turma);
            this.Controls.Add(this.labelIdTurma);
            this.Controls.Add(this.textBox_idAluno);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 518);
            this.Name = "FormCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBox_idAluno;
        private System.Windows.Forms.Label labelIdTurma;
        private System.Windows.Forms.TextBox textBoxid_Turma;
        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.TextBox textBoxDataNasc;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBoxSexoF_M;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textBoxNResponsavel;
        private System.Windows.Forms.Label labelResponsavel;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNomero;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelConformaSenha;
    }
}