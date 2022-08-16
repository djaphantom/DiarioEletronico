
namespace UIPrincipal
{
    partial class FormCadastroDeFrequencia
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label faltasLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_AlunoLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.frequenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.frequenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_BuscarFrequencia = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.faltasCheckBox = new System.Windows.Forms.CheckBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            faltasLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(460, 73);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(30, 13);
            dataLabel.TabIndex = 14;
            dataLabel.Text = "Data";
            // 
            // faltasLabel
            // 
            faltasLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            faltasLabel.AutoSize = true;
            faltasLabel.Location = new System.Drawing.Point(613, 76);
            faltasLabel.Name = "faltasLabel";
            faltasLabel.Size = new System.Drawing.Size(35, 13);
            faltasLabel.TabIndex = 15;
            faltasLabel.Text = "Faltas";
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(51, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id";
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(195, 76);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(34, 13);
            id_AlunoLabel.TabIndex = 17;
            id_AlunoLabel.Text = "Aluno";
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(323, 75);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(84, 13);
            id_DiarioLabel.TabIndex = 18;
            id_DiarioLabel.Text = "Diario Eletronica";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(192, 443);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(106, 32);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // frequenciaDataGridView
            // 
            this.frequenciaDataGridView.AllowUserToAddRows = false;
            this.frequenciaDataGridView.AllowUserToDeleteRows = false;
            this.frequenciaDataGridView.AllowUserToOrderColumns = true;
            this.frequenciaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequenciaDataGridView.AutoGenerateColumns = false;
            this.frequenciaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.frequenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.frequenciaDataGridView.DataSource = this.frequenciaBindingSource;
            this.frequenciaDataGridView.Location = new System.Drawing.Point(54, 118);
            this.frequenciaDataGridView.Name = "frequenciaDataGridView";
            this.frequenciaDataGridView.ReadOnly = true;
            this.frequenciaDataGridView.Size = new System.Drawing.Size(594, 302);
            this.frequenciaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Diario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Diario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Faltas";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Faltas";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frequenciaBindingSource
            // 
            this.frequenciaBindingSource.DataSource = typeof(Model.Frequencia);
            // 
            // textBox_BuscarFrequencia
            // 
            this.textBox_BuscarFrequencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_BuscarFrequencia.Location = new System.Drawing.Point(54, 39);
            this.textBox_BuscarFrequencia.Name = "textBox_BuscarFrequencia";
            this.textBox_BuscarFrequencia.Size = new System.Drawing.Size(470, 20);
            this.textBox_BuscarFrequencia.TabIndex = 13;
            this.textBox_BuscarFrequencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(564, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(84, 33);
            this.btn_buscar.TabIndex = 14;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Data", true));
            this.dataTextBox.Location = new System.Drawing.Point(463, 92);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 15;
            // 
            // faltasCheckBox
            // 
            this.faltasCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faltasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.frequenciaBindingSource, "Faltas", true));
            this.faltasCheckBox.Location = new System.Drawing.Point(623, 92);
            this.faltasCheckBox.Name = "faltasCheckBox";
            this.faltasCheckBox.Size = new System.Drawing.Size(25, 24);
            this.faltasCheckBox.TabIndex = 16;
            this.faltasCheckBox.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(54, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(89, 20);
            this.idTextBox.TabIndex = 17;
            this.idTextBox.Text = "0";
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(198, 92);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 18;
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(326, 92);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 19;
            // 
            // btn_retornar
            // 
            this.btn_retornar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retornar.Location = new System.Drawing.Point(548, 443);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(100, 32);
            this.btn_retornar.TabIndex = 20;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = true;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(54, 443);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(111, 32);
            this.btn_Excluir.TabIndex = 21;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // FormCadastroDeFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 505);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(faltasLabel);
            this.Controls.Add(this.faltasCheckBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.textBox_BuscarFrequencia);
            this.Controls.Add(this.frequenciaDataGridView);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "FormCadastroDeFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroDeFrequencia";
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.BindingSource frequenciaBindingSource;
        private System.Windows.Forms.DataGridView frequenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox textBox_BuscarFrequencia;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.CheckBox faltasCheckBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_Excluir;
    }
}