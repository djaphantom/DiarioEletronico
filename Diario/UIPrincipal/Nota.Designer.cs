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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.ButonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluirNota = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonAcessarBolitin = new System.Windows.Forms.Button();
            this.notaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarNota = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            id_TurmaLabel = new System.Windows.Forms.Label();
            notaAlunoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(54, 18);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(184, 18);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 3;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(434, 18);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 5;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_TurmaLabel
            // 
            id_TurmaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_TurmaLabel.AutoSize = true;
            id_TurmaLabel.Location = new System.Drawing.Point(307, 18);
            id_TurmaLabel.Name = "id_TurmaLabel";
            id_TurmaLabel.Size = new System.Drawing.Size(52, 13);
            id_TurmaLabel.TabIndex = 7;
            id_TurmaLabel.Text = "Id Turma:";
            // 
            // notaAlunoLabel
            // 
            notaAlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            notaAlunoLabel.AutoSize = true;
            notaAlunoLabel.Location = new System.Drawing.Point(558, 18);
            notaAlunoLabel.Name = "notaAlunoLabel";
            notaAlunoLabel.Size = new System.Drawing.Size(63, 13);
            notaAlunoLabel.TabIndex = 9;
            notaAlunoLabel.Text = "Nota Aluno:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(57, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataSource = typeof(Model.Nota);
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(184, 31);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 4;
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(434, 31);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 6;
            // 
            // id_TurmaTextBox
            // 
            this.id_TurmaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_TurmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Turma", true));
            this.id_TurmaTextBox.Location = new System.Drawing.Point(307, 31);
            this.id_TurmaTextBox.Name = "id_TurmaTextBox";
            this.id_TurmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TurmaTextBox.TabIndex = 8;
            // 
            // notaAlunoTextBox
            // 
            this.notaAlunoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notaAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "NotaAluno", true));
            this.notaAlunoTextBox.Location = new System.Drawing.Point(558, 31);
            this.notaAlunoTextBox.Name = "notaAlunoTextBox";
            this.notaAlunoTextBox.Size = new System.Drawing.Size(112, 20);
            this.notaAlunoTextBox.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.Location = new System.Drawing.Point(16, 380);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonAlterar
            // 
            this.ButonAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButonAlterar.Location = new System.Drawing.Point(97, 380);
            this.ButonAlterar.Name = "ButonAlterar";
            this.ButonAlterar.Size = new System.Drawing.Size(75, 23);
            this.ButonAlterar.TabIndex = 13;
            this.ButonAlterar.Text = "Alterar";
            this.ButonAlterar.UseVisualStyleBackColor = true;
            this.ButonAlterar.Click += new System.EventHandler(this.ButonAlterar_Click);
            // 
            // buttonExcluirNota
            // 
            this.buttonExcluirNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExcluirNota.Location = new System.Drawing.Point(178, 380);
            this.buttonExcluirNota.Name = "buttonExcluirNota";
            this.buttonExcluirNota.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirNota.TabIndex = 14;
            this.buttonExcluirNota.Text = "Excluir ";
            this.buttonExcluirNota.UseVisualStyleBackColor = true;
            this.buttonExcluirNota.Click += new System.EventHandler(this.buttonExcluirNota_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSair.Location = new System.Drawing.Point(618, 380);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 15;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAcessarBolitin
            // 
            this.buttonAcessarBolitin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcessarBolitin.Location = new System.Drawing.Point(393, 380);
            this.buttonAcessarBolitin.Name = "buttonAcessarBolitin";
            this.buttonAcessarBolitin.Size = new System.Drawing.Size(107, 23);
            this.buttonAcessarBolitin.TabIndex = 16;
            this.buttonAcessarBolitin.Text = "Boletim Do Aluno";
            this.buttonAcessarBolitin.UseVisualStyleBackColor = true;
            this.buttonAcessarBolitin.Click += new System.EventHandler(this.buttonAcessarBolitin_Click);
            // 
            // notaDataGridView
            // 
            this.notaDataGridView.AllowUserToAddRows = false;
            this.notaDataGridView.AllowUserToDeleteRows = false;
            this.notaDataGridView.AllowUserToOrderColumns = true;
            this.notaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notaDataGridView.AutoGenerateColumns = false;
            this.notaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.notaDataGridView.DataSource = this.notaBindingSource;
            this.notaDataGridView.Location = new System.Drawing.Point(16, 100);
            this.notaDataGridView.Name = "notaDataGridView";
            this.notaDataGridView.ReadOnly = true;
            this.notaDataGridView.Size = new System.Drawing.Size(677, 262);
            this.notaDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Turma";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Turma";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_Diario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_Diario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NotaAluno";
            this.dataGridViewTextBoxColumn5.HeaderText = "NotaAluno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(16, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscarNota
            // 
            this.buttonBuscarNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarNota.Location = new System.Drawing.Point(609, 65);
            this.buttonBuscarNota.Name = "buttonBuscarNota";
            this.buttonBuscarNota.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarNota.TabIndex = 18;
            this.buttonBuscarNota.Text = "Buscar";
            this.buttonBuscarNota.UseVisualStyleBackColor = true;
            // 
            // CadastroDeNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 422);
            this.Controls.Add(this.buttonBuscarNota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.notaDataGridView);
            this.Controls.Add(this.buttonAcessarBolitin);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluirNota);
            this.Controls.Add(this.ButonAlterar);
            this.Controls.Add(this.buttonSalvar);
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
            this.MinimumSize = new System.Drawing.Size(728, 461);
            this.Name = "CadastroDeNota";
            this.Text = "Nota";
            this.Load += new System.EventHandler(this.Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaDataGridView)).EndInit();
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
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button ButonAlterar;
        private System.Windows.Forms.Button buttonExcluirNota;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAcessarBolitin;
        private System.Windows.Forms.DataGridView notaDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscarNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}