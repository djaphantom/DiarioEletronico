
namespace UIPrincipal
{
    partial class CadastroAluno
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
            this.btnInserir = new System.Windows.Forms.Button();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.textBoxDataNasc = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxSexoF_M = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNomero = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Model.Aluno);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(35, 403);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(95, 46);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(32, 32);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(46, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "Id Aluno";
            this.labelid.UseMnemonic = false;
            this.labelid.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_idAluno
            // 
            this.textBox_idAluno.Location = new System.Drawing.Point(35, 49);
            this.textBox_idAluno.Name = "textBox_idAluno";
            this.textBox_idAluno.Size = new System.Drawing.Size(59, 20);
            this.textBox_idAluno.TabIndex = 4;
            // 
            // labelIdTurma
            // 
            this.labelIdTurma.AutoSize = true;
            this.labelIdTurma.Location = new System.Drawing.Point(100, 32);
            this.labelIdTurma.Name = "labelIdTurma";
            this.labelIdTurma.Size = new System.Drawing.Size(49, 13);
            this.labelIdTurma.TabIndex = 5;
            this.labelIdTurma.Text = "Id Turma";
            // 
            // textBoxid_Turma
            // 
            this.textBoxid_Turma.Location = new System.Drawing.Point(101, 49);
            this.textBoxid_Turma.Name = "textBoxid_Turma";
            this.textBoxid_Turma.Size = new System.Drawing.Size(62, 20);
            this.textBoxid_Turma.TabIndex = 6;
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(34, 76);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(80, 13);
            this.labelNomeAluno.TabIndex = 7;
            this.labelNomeAluno.Text = "Nome do Aluno";
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(35, 93);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(522, 20);
            this.textBoxNomeAluno.TabIndex = 8;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(35, 130);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(522, 20);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Endereço";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(35, 207);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(312, 20);
            this.textBoxCidade.TabIndex = 12;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(32, 193);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(37, 246);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(206, 20);
            this.textBoxTelefone.TabIndex = 14;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(34, 231);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 13;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(252, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 20);
            this.textBox4.TabIndex = 16;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(249, 230);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(353, 207);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(203, 20);
            this.textBoxUF.TabIndex = 18;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(350, 193);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(21, 13);
            this.labelUF.TabIndex = 17;
            this.labelUF.Text = "UF";
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(37, 287);
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(144, 20);
            this.textBoxDataNasc.TabIndex = 20;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(34, 271);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(79, 13);
            this.labelDataNascimento.TabIndex = 19;
            this.labelDataNascimento.Text = "Data de Nasc.:";
            // 
            // textBoxSexoF_M
            // 
            this.textBoxSexoF_M.Location = new System.Drawing.Point(188, 287);
            this.textBoxSexoF_M.Name = "textBoxSexoF_M";
            this.textBoxSexoF_M.Size = new System.Drawing.Size(93, 20);
            this.textBoxSexoF_M.TabIndex = 22;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(185, 271);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 21;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(400, 169);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(156, 20);
            this.textBoxCep.TabIndex = 24;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(397, 153);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 13);
            this.labelCEP.TabIndex = 23;
            this.labelCEP.Text = "CEP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 20);
            this.textBox1.TabIndex = 26;
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(32, 311);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(110, 13);
            this.labelResponsavel.TabIndex = 25;
            this.labelResponsavel.Text = "Nome do responsável";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(332, 169);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(60, 20);
            this.textBoxNumero.TabIndex = 28;
            // 
            // labelNomero
            // 
            this.labelNomero.AutoSize = true;
            this.labelNomero.Location = new System.Drawing.Point(329, 153);
            this.labelNomero.Name = "labelNomero";
            this.labelNomero.Size = new System.Drawing.Size(44, 13);
            this.labelNomero.TabIndex = 27;
            this.labelNomero.Text = "Número";
            this.labelNomero.Click += new System.EventHandler(this.labelNomero_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(35, 368);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(208, 20);
            this.textBoxSenha.TabIndex = 30;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(32, 352);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 29;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.Location = new System.Drawing.Point(35, 169);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(291, 20);
            this.textBoxSetor.TabIndex = 33;
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(32, 153);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(32, 13);
            this.labelSetor.TabIndex = 32;
            this.labelSetor.Text = "Setor";
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 600);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNomero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxSexoF_M);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxDataNasc);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBox4);
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
            this.Controls.Add(this.btnInserir);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button btnInserir;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.TextBox textBoxDataNasc;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBoxSexoF_M;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelResponsavel;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNomero;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label labelSetor;
    }
}