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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.diarioEletronicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diarioEletronicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.Location = new System.Drawing.Point(15, 590);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(138, 47);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExcluir.Location = new System.Drawing.Point(330, 590);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(115, 43);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // button_Alterar
            // 
            this.button_Alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Alterar.Location = new System.Drawing.Point(183, 590);
            this.button_Alterar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(115, 43);
            this.button_Alterar.TabIndex = 3;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = true;
            this.button_Alterar.Click += new System.EventHandler(this.button_Alterar_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Sair.Location = new System.Drawing.Point(705, 590);
            this.button_Sair.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(115, 43);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            // 
            // textBusca
            // 
            this.textBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBusca.Location = new System.Drawing.Point(15, 24);
            this.textBusca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(678, 30);
            this.textBusca.TabIndex = 5;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPesquisar.Location = new System.Drawing.Point(705, 17);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(115, 43);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // diarioEletronicoBindingSource1
            // 
            this.diarioEletronicoBindingSource1.DataSource = typeof(Model.DiarioEletronico);
            // 
            // diarioEletronicoDataGridView
            // 
            this.diarioEletronicoDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diarioEletronicoDataGridView.AutoGenerateColumns = false;
            this.diarioEletronicoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.diarioEletronicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diarioEletronicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.diarioEletronicoDataGridView.DataSource = this.diarioEletronicoBindingSource1;
            this.diarioEletronicoDataGridView.Location = new System.Drawing.Point(15, 89);
            this.diarioEletronicoDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.diarioEletronicoDataGridView.Name = "diarioEletronicoDataGridView";
            this.diarioEletronicoDataGridView.RowHeadersWidth = 51;
            this.diarioEletronicoDataGridView.Size = new System.Drawing.Size(805, 478);
            this.diarioEletronicoDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Disciplina";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_Disciplina";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_Professor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_Professor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id_Turma";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id_Turma";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // DiarioEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 652);
            this.Controls.Add(this.diarioEletronicoDataGridView);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Alterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "DiarioEletronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diarioEletronicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diarioEletronicoBindingSource;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.BindingSource diarioEletronicoBindingSource1;
        private System.Windows.Forms.DataGridView diarioEletronicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}