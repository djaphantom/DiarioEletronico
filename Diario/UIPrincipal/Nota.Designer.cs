namespace UIPrincipal
{
    partial class CadastroDeNota
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_AlunoLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            System.Windows.Forms.Label id_TurmaLabel;
            System.Windows.Forms.Label notaAlunoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.notaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.id_TurmaTextBox = new System.Windows.Forms.TextBox();
            this.notaAlunoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.ButonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluirNota = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonAcessarBolitin = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            id_TurmaLabel = new System.Windows.Forms.Label();
            notaAlunoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(49, 26);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 3;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(257, 26);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 5;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_TurmaLabel
            // 
            id_TurmaLabel.AutoSize = true;
            id_TurmaLabel.Location = new System.Drawing.Point(134, 26);
            id_TurmaLabel.Name = "id_TurmaLabel";
            id_TurmaLabel.Size = new System.Drawing.Size(52, 13);
            id_TurmaLabel.TabIndex = 7;
            id_TurmaLabel.Text = "Id Turma:";
            // 
            // notaAlunoLabel
            // 
            notaAlunoLabel.AutoSize = true;
            notaAlunoLabel.Location = new System.Drawing.Point(393, 26);
            notaAlunoLabel.Name = "notaAlunoLabel";
            notaAlunoLabel.Size = new System.Drawing.Size(63, 13);
            notaAlunoLabel.TabIndex = 9;
            notaAlunoLabel.Text = "Nota Aluno:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(12, 39);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(29, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataSource = typeof(Model.Nota);
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(52, 39);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(79, 20);
            this.id_AlunoTextBox.TabIndex = 4;
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(260, 39);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 6;
            // 
            // id_TurmaTextBox
            // 
            this.id_TurmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Turma", true));
            this.id_TurmaTextBox.Location = new System.Drawing.Point(137, 39);
            this.id_TurmaTextBox.Name = "id_TurmaTextBox";
            this.id_TurmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TurmaTextBox.TabIndex = 8;
            // 
            // notaAlunoTextBox
            // 
            this.notaAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "NotaAluno", true));
            this.notaAlunoTextBox.Location = new System.Drawing.Point(396, 39);
            this.notaAlunoTextBox.Name = "notaAlunoTextBox";
            this.notaAlunoTextBox.Size = new System.Drawing.Size(112, 20);
            this.notaAlunoTextBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 243);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 338);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonAlterar
            // 
            this.ButonAlterar.Location = new System.Drawing.Point(109, 338);
            this.ButonAlterar.Name = "ButonAlterar";
            this.ButonAlterar.Size = new System.Drawing.Size(75, 23);
            this.ButonAlterar.TabIndex = 13;
            this.ButonAlterar.Text = "Alterar";
            this.ButonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirNota
            // 
            this.buttonExcluirNota.Location = new System.Drawing.Point(210, 338);
            this.buttonExcluirNota.Name = "buttonExcluirNota";
            this.buttonExcluirNota.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirNota.TabIndex = 14;
            this.buttonExcluirNota.Text = "Excluir ";
            this.buttonExcluirNota.UseVisualStyleBackColor = true;
            this.buttonExcluirNota.Click += new System.EventHandler(this.buttonExcluirNota_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(435, 338);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 15;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAcessarBolitin
            // 
            this.buttonAcessarBolitin.Location = new System.Drawing.Point(308, 338);
            this.buttonAcessarBolitin.Name = "buttonAcessarBolitin";
            this.buttonAcessarBolitin.Size = new System.Drawing.Size(107, 23);
            this.buttonAcessarBolitin.TabIndex = 16;
            this.buttonAcessarBolitin.Text = "Boletim Do Aluno";
            this.buttonAcessarBolitin.UseVisualStyleBackColor = true;
            // 
            // CadastroDeNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(516, 373);
            this.Controls.Add(this.buttonAcessarBolitin);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluirNota);
            this.Controls.Add(this.ButonAlterar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(notaAlunoLabel);
            this.Controls.Add(this.notaAlunoTextBox);
            this.Controls.Add(id_TurmaLabel);
            this.Controls.Add(this.id_TurmaTextBox);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "CadastroDeNota";
            this.Text = "Nota";
            this.Load += new System.EventHandler(this.Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource notaBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.TextBox id_TurmaTextBox;
        private System.Windows.Forms.TextBox notaAlunoTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button ButonAlterar;
        private System.Windows.Forms.Button buttonExcluirNota;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAcessarBolitin;
    }
}