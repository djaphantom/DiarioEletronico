
namespace UIPrincipal
{
    partial class Ocorrencia
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
            this.labelOcorrencia = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelId_Aluno = new System.Windows.Forms.Label();
            this.label3Ocorrenica = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxId_Aluno = new System.Windows.Forms.TextBox();
            this.textBoxOcorrencia = new System.Windows.Forms.TextBox();
            this.buttonBuscarOcorrencia = new System.Windows.Forms.Button();
            this.buttonNovoO = new System.Windows.Forms.Button();
            this.buttonAlterarO = new System.Windows.Forms.Button();
            this.buttonExcluirO = new System.Windows.Forms.Button();
            this.buttonSairO = new System.Windows.Forms.Button();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOcorrencia
            // 
            this.labelOcorrencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcorrencia.Location = new System.Drawing.Point(0, 0);
            this.labelOcorrencia.Name = "labelOcorrencia";
            this.labelOcorrencia.Size = new System.Drawing.Size(662, 39);
            this.labelOcorrencia.TabIndex = 0;
            this.labelOcorrencia.Text = "Ocorrência";
            this.labelOcorrencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(19, 67);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Id";
            // 
            // labelId_Aluno
            // 
            this.labelId_Aluno.AutoSize = true;
            this.labelId_Aluno.Location = new System.Drawing.Point(57, 67);
            this.labelId_Aluno.Name = "labelId_Aluno";
            this.labelId_Aluno.Size = new System.Drawing.Size(49, 13);
            this.labelId_Aluno.TabIndex = 2;
            this.labelId_Aluno.Text = "Id_Aluno";
            // 
            // label3Ocorrenica
            // 
            this.label3Ocorrenica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3Ocorrenica.AutoSize = true;
            this.label3Ocorrenica.Location = new System.Drawing.Point(122, 67);
            this.label3Ocorrenica.Name = "label3Ocorrenica";
            this.label3Ocorrenica.Size = new System.Drawing.Size(59, 13);
            this.label3Ocorrenica.TabIndex = 3;
            this.label3Ocorrenica.Text = "Ocorrência";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(18, 83);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxId_Aluno
            // 
            this.textBoxId_Aluno.Location = new System.Drawing.Point(58, 83);
            this.textBoxId_Aluno.Name = "textBoxId_Aluno";
            this.textBoxId_Aluno.Size = new System.Drawing.Size(28, 20);
            this.textBoxId_Aluno.TabIndex = 5;
            // 
            // textBoxOcorrencia
            // 
            this.textBoxOcorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOcorrencia.Location = new System.Drawing.Point(125, 82);
            this.textBoxOcorrencia.Name = "textBoxOcorrencia";
            this.textBoxOcorrencia.Size = new System.Drawing.Size(440, 20);
            this.textBoxOcorrencia.TabIndex = 7;
            // 
            // buttonBuscarOcorrencia
            // 
            this.buttonBuscarOcorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarOcorrencia.Location = new System.Drawing.Point(571, 79);
            this.buttonBuscarOcorrencia.Name = "buttonBuscarOcorrencia";
            this.buttonBuscarOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarOcorrencia.TabIndex = 8;
            this.buttonBuscarOcorrencia.Text = "&Buscar";
            this.buttonBuscarOcorrencia.UseVisualStyleBackColor = true;
            this.buttonBuscarOcorrencia.Click += new System.EventHandler(this.buttonBuscarOcorrencia_Click);
            // 
            // buttonNovoO
            // 
            this.buttonNovoO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNovoO.Location = new System.Drawing.Point(18, 395);
            this.buttonNovoO.Name = "buttonNovoO";
            this.buttonNovoO.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoO.TabIndex = 10;
            this.buttonNovoO.Text = "Novo";
            this.buttonNovoO.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarO
            // 
            this.buttonAlterarO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAlterarO.Location = new System.Drawing.Point(99, 395);
            this.buttonAlterarO.Name = "buttonAlterarO";
            this.buttonAlterarO.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarO.TabIndex = 11;
            this.buttonAlterarO.Text = "Alterar";
            this.buttonAlterarO.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirO
            // 
            this.buttonExcluirO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExcluirO.Location = new System.Drawing.Point(180, 395);
            this.buttonExcluirO.Name = "buttonExcluirO";
            this.buttonExcluirO.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirO.TabIndex = 12;
            this.buttonExcluirO.Text = "Excluir";
            this.buttonExcluirO.UseVisualStyleBackColor = true;
            this.buttonExcluirO.Click += new System.EventHandler(this.buttonExcluirO_Click);
            // 
            // buttonSairO
            // 
            this.buttonSairO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSairO.Location = new System.Drawing.Point(571, 395);
            this.buttonSairO.Name = "buttonSairO";
            this.buttonSairO.Size = new System.Drawing.Size(75, 23);
            this.buttonSairO.TabIndex = 13;
            this.buttonSairO.Text = "Sair";
            this.buttonSairO.UseVisualStyleBackColor = true;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataSource = typeof(Model.Ocorrencia);
            // 
            // ocorrenciaDataGridView
            // 
            this.ocorrenciaDataGridView.AutoGenerateColumns = false;
            this.ocorrenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocorrenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ocorrenciaDataGridView.DataSource = this.ocorrenciaBindingSource;
            this.ocorrenciaDataGridView.Location = new System.Drawing.Point(18, 109);
            this.ocorrenciaDataGridView.Name = "ocorrenciaDataGridView";
            this.ocorrenciaDataGridView.Size = new System.Drawing.Size(628, 267);
            this.ocorrenciaDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Diario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Diario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Ocorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 423);
            this.Controls.Add(this.ocorrenciaDataGridView);
            this.Controls.Add(this.buttonSairO);
            this.Controls.Add(this.buttonExcluirO);
            this.Controls.Add(this.buttonAlterarO);
            this.Controls.Add(this.buttonNovoO);
            this.Controls.Add(this.buttonBuscarOcorrencia);
            this.Controls.Add(this.textBoxOcorrencia);
            this.Controls.Add(this.textBoxId_Aluno);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3Ocorrenica);
            this.Controls.Add(this.labelId_Aluno);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelOcorrencia);
            this.MinimumSize = new System.Drawing.Size(670, 411);
            this.Name = "Ocorrencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrencia";
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOcorrencia;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelId_Aluno;
        private System.Windows.Forms.Label label3Ocorrenica;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxId_Aluno;
        private System.Windows.Forms.TextBox textBoxOcorrencia;
        private System.Windows.Forms.Button buttonBuscarOcorrencia;
        private System.Windows.Forms.Button buttonNovoO;
        private System.Windows.Forms.Button buttonAlterarO;
        private System.Windows.Forms.Button buttonExcluirO;
        private System.Windows.Forms.Button buttonSairO;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private System.Windows.Forms.DataGridView ocorrenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}