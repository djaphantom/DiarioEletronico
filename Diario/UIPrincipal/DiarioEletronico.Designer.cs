namespace UIPrincipal
{
    partial class DiarioEletronico
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
            this.diarioEletronicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diarioEletronicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diarioEletronicoBindingSource
            // 
            this.diarioEletronicoBindingSource.DataSource = typeof(Model.DiarioEletronico);
            // 
            // diarioEletronicoDataGridView
            // 
            this.diarioEletronicoDataGridView.AutoGenerateColumns = false;
            this.diarioEletronicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diarioEletronicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.diarioEletronicoDataGridView.DataSource = this.diarioEletronicoBindingSource;
            this.diarioEletronicoDataGridView.Location = new System.Drawing.Point(2, 49);
            this.diarioEletronicoDataGridView.Name = "diarioEletronicoDataGridView";
            this.diarioEletronicoDataGridView.Size = new System.Drawing.Size(460, 230);
            this.diarioEletronicoDataGridView.TabIndex = 0;
            this.diarioEletronicoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diarioEletronicoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Disciplina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Disciplina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Professor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Professor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_Turma";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_Turma";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 285);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(183, 285);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Excluir";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // button_Alterar
            // 
            this.button_Alterar.Location = new System.Drawing.Point(102, 285);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(75, 23);
            this.button_Alterar.TabIndex = 3;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = true;
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(387, 285);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(397, 20);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(65, 23);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // DiarioEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 317);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Alterar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.diarioEletronicoDataGridView);
            this.Name = "DiarioEletronico";
            this.Text = "DiarioEletronico";
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diarioEletronicoBindingSource;
        private System.Windows.Forms.DataGridView diarioEletronicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}