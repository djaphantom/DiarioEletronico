
namespace UIPrincipal
{
    partial class CadastroProfessor
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
            System.Windows.Forms.Label dataDeNascimentoLabel;
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxNomeDoProfessor = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.labelId_sexo = new System.Windows.Forms.Label();
            this.cpf_maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelCIDADE = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.Sexo_comboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNome = new System.Windows.Forms.Label();
            dataDeNascimentoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDeNascimentoLabel
            // 
            dataDeNascimentoLabel.AutoSize = true;
            dataDeNascimentoLabel.Location = new System.Drawing.Point(18, 383);
            dataDeNascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataDeNascimentoLabel.Name = "dataDeNascimentoLabel";
            dataDeNascimentoLabel.Size = new System.Drawing.Size(158, 18);
            dataDeNascimentoLabel.TabIndex = 46;
            dataDeNascimentoLabel.Text = "Data De Nascimento:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(591, 133);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(41, 18);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF";
            // 
            // textBoxNomeDoProfessor
            // 
            this.textBoxNomeDoProfessor.Location = new System.Drawing.Point(18, 155);
            this.textBoxNomeDoProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeDoProfessor.Name = "textBoxNomeDoProfessor";
            this.textBoxNomeDoProfessor.Size = new System.Drawing.Size(565, 26);
            this.textBoxNomeDoProfessor.TabIndex = 6;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(18, 213);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(565, 26);
            this.textBoxEndereco.TabIndex = 11;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(18, 191);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(76, 18);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.Location = new System.Drawing.Point(592, 213);
            this.textBoxSetor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(235, 26);
            this.textBoxSetor.TabIndex = 16;
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(589, 191);
            this.labelSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(46, 18);
            this.labelSetor.TabIndex = 17;
            this.labelSetor.Text = "Setor";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(18, 347);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(535, 26);
            this.textBoxEmail.TabIndex = 20;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(415, 249);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(38, 18);
            this.labelCEP.TabIndex = 21;
            this.labelCEP.Text = "Cep";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 22;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(666, 249);
            this.labelUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(29, 18);
            this.labelUF.TabIndex = 23;
            this.labelUF.Text = "UF";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(18, 325);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(569, 325);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(66, 18);
            this.labelTelefone.TabIndex = 26;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(294, 383);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 18);
            this.labelSenha.TabIndex = 31;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(297, 405);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(256, 26);
            this.textBoxSenha.TabIndex = 30;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(720, 486);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.Location = new System.Drawing.Point(21, 486);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(108, 35);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(18, 76);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 18);
            this.labelId.TabIndex = 35;
            this.labelId.Text = "Id";
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(18, 98);
            this.textBoxid.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(58, 26);
            this.textBoxid.TabIndex = 36;
            this.textBoxid.Text = "0";
            // 
            // labelId_sexo
            // 
            this.labelId_sexo.AutoSize = true;
            this.labelId_sexo.Location = new System.Drawing.Point(94, 76);
            this.labelId_sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId_sexo.Name = "labelId_sexo";
            this.labelId_sexo.Size = new System.Drawing.Size(44, 18);
            this.labelId_sexo.TabIndex = 38;
            this.labelId_sexo.Text = "Sexo";
            // 
            // cpf_maskedTextBox1
            // 
            this.cpf_maskedTextBox1.Location = new System.Drawing.Point(591, 155);
            this.cpf_maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cpf_maskedTextBox1.Mask = "000.000.000-00";
            this.cpf_maskedTextBox1.Name = "cpf_maskedTextBox1";
            this.cpf_maskedTextBox1.Size = new System.Drawing.Size(236, 26);
            this.cpf_maskedTextBox1.TabIndex = 41;
            // 
            // labelCIDADE
            // 
            this.labelCIDADE.AutoSize = true;
            this.labelCIDADE.Location = new System.Drawing.Point(19, 249);
            this.labelCIDADE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCIDADE.Name = "labelCIDADE";
            this.labelCIDADE.Size = new System.Drawing.Size(60, 18);
            this.labelCIDADE.TabIndex = 14;
            this.labelCIDADE.Text = "Cidade";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(18, 271);
            this.comboBoxCidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(388, 26);
            this.comboBoxCidade.TabIndex = 42;
            // 
            // Sexo_comboBox
            // 
            this.Sexo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo_comboBox.FormattingEnabled = true;
            this.Sexo_comboBox.Location = new System.Drawing.Point(99, 97);
            this.Sexo_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Sexo_comboBox.Name = "Sexo_comboBox";
            this.Sexo_comboBox.Size = new System.Drawing.Size(122, 26);
            this.Sexo_comboBox.TabIndex = 43;
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(668, 271);
            this.comboBoxUF.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(158, 26);
            this.comboBoxUF.TabIndex = 44;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(572, 346);
            this.maskedTextBoxTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxTelefone.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(256, 26);
            this.maskedTextBoxTelefone.TabIndex = 45;
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(22, 405);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(232, 26);
            this.maskedTextBoxData.TabIndex = 47;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(418, 271);
            this.maskedTextBoxCEP.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(242, 26);
            this.maskedTextBoxCEP.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 49);
            this.panel1.TabIndex = 49;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(309, 33);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Cadastro de Professor";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(18, 133);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 18);
            this.labelNome.TabIndex = 50;
            this.labelNome.Text = "Nome";
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(dataDeNascimentoLabel);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.comboBoxUF);
            this.Controls.Add(this.Sexo_comboBox);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.cpf_maskedTextBox1);
            this.Controls.Add(this.labelId_sexo);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.labelCIDADE);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxNomeDoProfessor);
            this.Controls.Add(this.labelCPF);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBoxNomeDoProfessor;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelId_sexo;
        private System.Windows.Forms.MaskedTextBox cpf_maskedTextBox1;
        private System.Windows.Forms.Label labelCIDADE;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.ComboBox Sexo_comboBox;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label labelNome;
    }
}