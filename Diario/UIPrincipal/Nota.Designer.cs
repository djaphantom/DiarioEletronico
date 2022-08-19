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
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.notaAlunoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.ButonAlterar = new System.Windows.Forms.Button();
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
            this.comboBoxALUNO = new System.Windows.Forms.ComboBox();
            this.comboBoxTURMA = new System.Windows.Forms.ComboBox();
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
            idLabel.Location = new System.Drawing.Point(-42, 32);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(24, 18);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(89, 32);
            id_AlunoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(51, 18);
            id_AlunoLabel.TabIndex = 2;
            id_AlunoLabel.Text = "Aluno:";
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(471, 32);
            id_DiarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(55, 18);
            id_DiarioLabel.TabIndex = 6;
            id_DiarioLabel.Text = "Diario:";
            // 
            // id_TurmaLabel
            // 
            id_TurmaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_TurmaLabel.AutoSize = true;
            id_TurmaLabel.Location = new System.Drawing.Point(289, 32);
            id_TurmaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_TurmaLabel.Name = "id_TurmaLabel";
            id_TurmaLabel.Size = new System.Drawing.Size(55, 18);
            id_TurmaLabel.TabIndex = 4;
            id_TurmaLabel.Text = "Turma:";
            // 
            // notaAlunoLabel
            // 
            notaAlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            notaAlunoLabel.AutoSize = true;
            notaAlunoLabel.Location = new System.Drawing.Point(629, 28);
            notaAlunoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notaAlunoLabel.Name = "notaAlunoLabel";
            notaAlunoLabel.Size = new System.Drawing.Size(87, 18);
            notaAlunoLabel.TabIndex = 8;
            notaAlunoLabel.Text = "Nota Aluno:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(-39, 68);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(124, 26);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Text = "0";
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataSource = typeof(Model.Nota);
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(474, 68);
            this.id_DiarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(148, 26);
            this.id_DiarioTextBox.TabIndex = 7;
            // 
            // notaAlunoTextBox
            // 
            this.notaAlunoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notaAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "NotaAluno", true));
            this.notaAlunoTextBox.Location = new System.Drawing.Point(632, 50);
            this.notaAlunoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notaAlunoTextBox.Multiline = true;
            this.notaAlunoTextBox.Name = "notaAlunoTextBox";
            this.notaAlunoTextBox.Size = new System.Drawing.Size(106, 44);
            this.notaAlunoTextBox.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(-27, 641);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(112, 32);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonAlterar
            // 
            this.ButonAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAlterar.Location = new System.Drawing.Point(116, 641);
            this.ButonAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.ButonAlterar.Name = "ButonAlterar";
            this.ButonAlterar.Size = new System.Drawing.Size(112, 32);
            this.ButonAlterar.TabIndex = 13;
            this.ButonAlterar.Text = "Alterar";
            this.ButonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(626, 631);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(112, 32);
            this.buttonSair.TabIndex = 15;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAcessarBolitin
            // 
            this.buttonAcessarBolitin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcessarBolitin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcessarBolitin.Location = new System.Drawing.Point(438, 631);
            this.buttonAcessarBolitin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAcessarBolitin.Name = "buttonAcessarBolitin";
            this.buttonAcessarBolitin.Size = new System.Drawing.Size(160, 32);
            this.buttonAcessarBolitin.TabIndex = 14;
            this.buttonAcessarBolitin.Text = "Boletim Do Aluno";
            this.buttonAcessarBolitin.UseVisualStyleBackColor = true;
            // 
            // notaDataGridView
            // 
            this.notaDataGridView.AllowUserToAddRows = false;
            this.notaDataGridView.AllowUserToDeleteRows = false;
            this.notaDataGridView.AllowUserToOrderColumns = true;
            this.notaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notaDataGridView.AutoGenerateColumns = false;
            this.notaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.notaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.notaDataGridView.DataSource = this.notaBindingSource;
            this.notaDataGridView.Location = new System.Drawing.Point(-39, 173);
            this.notaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.notaDataGridView.Name = "notaDataGridView";
            this.notaDataGridView.ReadOnly = true;
            this.notaDataGridView.RowHeadersWidth = 51;
            this.notaDataGridView.Size = new System.Drawing.Size(777, 425);
            this.notaDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Turma";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Turma";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_Diario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_Diario";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NotaAluno";
            this.dataGridViewTextBoxColumn5.HeaderText = "NotaAluno";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(-39, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscarNota
            // 
            this.buttonBuscarNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarNota.Location = new System.Drawing.Point(632, 132);
            this.buttonBuscarNota.Name = "buttonBuscarNota";
            this.buttonBuscarNota.Size = new System.Drawing.Size(96, 30);
            this.buttonBuscarNota.TabIndex = 11;
            this.buttonBuscarNota.Text = "Buscar";
            this.buttonBuscarNota.UseVisualStyleBackColor = true;
            this.buttonBuscarNota.Click += new System.EventHandler(this.buttonBuscarNota_Click);
            // 
            // comboBoxALUNO
            // 
            this.comboBoxALUNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxALUNO.FormattingEnabled = true;
            this.comboBoxALUNO.Location = new System.Drawing.Point(93, 68);
            this.comboBoxALUNO.Name = "comboBoxALUNO";
            this.comboBoxALUNO.Size = new System.Drawing.Size(183, 26);
            this.comboBoxALUNO.TabIndex = 3;
            // 
            // comboBoxTURMA
            // 
            this.comboBoxTURMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTURMA.FormattingEnabled = true;
            this.comboBoxTURMA.Location = new System.Drawing.Point(292, 68);
            this.comboBoxTURMA.Name = "comboBoxTURMA";
            this.comboBoxTURMA.Size = new System.Drawing.Size(161, 26);
            this.comboBoxTURMA.TabIndex = 5;
            this.comboBoxTURMA.TextChanged += new System.EventHandler(this.comboBoxTURMA_TextChanged_1);
            // 
            // CadastroDeNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 816);
            this.Controls.Add(this.comboBoxTURMA);
            this.Controls.Add(this.comboBoxALUNO);
            this.Controls.Add(this.buttonBuscarNota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.notaDataGridView);
            this.Controls.Add(this.buttonAcessarBolitin);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.ButonAlterar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(notaAlunoLabel);
            this.Controls.Add(this.notaAlunoTextBox);
            this.Controls.Add(id_TurmaLabel);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroDeNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource notaBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.TextBox notaAlunoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button ButonAlterar;
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
        private System.Windows.Forms.ComboBox comboBoxALUNO;
        private System.Windows.Forms.ComboBox comboBoxTURMA;
    }
}