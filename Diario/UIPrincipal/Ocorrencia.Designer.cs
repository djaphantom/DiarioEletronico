
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
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Id";
            // 
            // labelId_Aluno
            // 
            this.labelId_Aluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId_Aluno.AutoSize = true;
            this.labelId_Aluno.Location = new System.Drawing.Point(56, 8);
            this.labelId_Aluno.Name = "labelId_Aluno";
            this.labelId_Aluno.Size = new System.Drawing.Size(49, 13);
            this.labelId_Aluno.TabIndex = 2;
            this.labelId_Aluno.Text = "Id_Aluno";
            // 
            // label3Ocorrenica
            // 
            this.label3Ocorrenica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Ocorrenica.AutoSize = true;
            this.label3Ocorrenica.Location = new System.Drawing.Point(121, 8);
            this.label3Ocorrenica.Name = "label3Ocorrenica";
            this.label3Ocorrenica.Size = new System.Drawing.Size(59, 13);
            this.label3Ocorrenica.TabIndex = 3;
            this.label3Ocorrenica.Text = "Ocorrência";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(17, 24);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 4;
            this.textBoxId.Text = "0";
            // 
            // textBoxId_Aluno
            // 
            this.textBoxId_Aluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId_Aluno.Location = new System.Drawing.Point(57, 24);
            this.textBoxId_Aluno.Name = "textBoxId_Aluno";
            this.textBoxId_Aluno.Size = new System.Drawing.Size(61, 20);
            this.textBoxId_Aluno.TabIndex = 5;
            // 
            // textBoxOcorrencia
            // 
            this.textBoxOcorrencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOcorrencia.Location = new System.Drawing.Point(124, 23);
            this.textBoxOcorrencia.Name = "textBoxOcorrencia";
            this.textBoxOcorrencia.Size = new System.Drawing.Size(440, 20);
            this.textBoxOcorrencia.TabIndex = 7;
            this.textBoxOcorrencia.TextChanged += new System.EventHandler(this.textBoxOcorrencia_TextChanged);
            // 
            // buttonBuscarOcorrencia
            // 
            this.buttonBuscarOcorrencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarOcorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarOcorrencia.Location = new System.Drawing.Point(570, 20);
            this.buttonBuscarOcorrencia.Name = "buttonBuscarOcorrencia";
            this.buttonBuscarOcorrencia.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarOcorrencia.TabIndex = 8;
            this.buttonBuscarOcorrencia.Text = "&Buscar";
            this.buttonBuscarOcorrencia.UseVisualStyleBackColor = true;
            this.buttonBuscarOcorrencia.Click += new System.EventHandler(this.buttonBuscarOcorrencia_Click);
            // 
            // buttonNovoO
            // 
            this.buttonNovoO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNovoO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoO.Location = new System.Drawing.Point(17, 348);
            this.buttonNovoO.Name = "buttonNovoO";
            this.buttonNovoO.Size = new System.Drawing.Size(81, 29);
            this.buttonNovoO.TabIndex = 10;
            this.buttonNovoO.Text = "Novo";
            this.buttonNovoO.UseVisualStyleBackColor = true;
            this.buttonNovoO.Click += new System.EventHandler(this.buttonNovoO_Click);
            // 
            // buttonAlterarO
            // 
            this.buttonAlterarO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAlterarO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarO.Location = new System.Drawing.Point(103, 348);
            this.buttonAlterarO.Name = "buttonAlterarO";
            this.buttonAlterarO.Size = new System.Drawing.Size(81, 29);
            this.buttonAlterarO.TabIndex = 11;
            this.buttonAlterarO.Text = "Alterar";
            this.buttonAlterarO.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirO
            // 
            this.buttonExcluirO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExcluirO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirO.Location = new System.Drawing.Point(188, 348);
            this.buttonExcluirO.Name = "buttonExcluirO";
            this.buttonExcluirO.Size = new System.Drawing.Size(81, 29);
            this.buttonExcluirO.TabIndex = 12;
            this.buttonExcluirO.Text = "Excluir";
            this.buttonExcluirO.UseVisualStyleBackColor = true;
            this.buttonExcluirO.Click += new System.EventHandler(this.buttonExcluirO_Click);
            // 
            // buttonSairO
            // 
            this.buttonSairO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSairO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSairO.Location = new System.Drawing.Point(564, 348);
            this.buttonSairO.Name = "buttonSairO";
            this.buttonSairO.Size = new System.Drawing.Size(81, 29);
            this.buttonSairO.TabIndex = 13;
            this.buttonSairO.Text = "Sair";
            this.buttonSairO.UseVisualStyleBackColor = true;
            this.buttonSairO.Click += new System.EventHandler(this.buttonSairO_Click);
            // 
            // ocorrenciaDataGridView
            // 
            this.ocorrenciaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ocorrenciaDataGridView.AutoGenerateColumns = false;
            this.ocorrenciaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ocorrenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocorrenciaDataGridView.DataSource = this.ocorrenciaBindingSource;
            this.ocorrenciaDataGridView.GridColor = System.Drawing.Color.White;
            this.ocorrenciaDataGridView.Location = new System.Drawing.Point(17, 55);
            this.ocorrenciaDataGridView.Name = "ocorrenciaDataGridView";
            this.ocorrenciaDataGridView.Size = new System.Drawing.Size(628, 281);
            this.ocorrenciaDataGridView.TabIndex = 13;
            // 
            // Ocorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 390);
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
            this.MinimumSize = new System.Drawing.Size(677, 429);
            this.Name = "Ocorrencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrencia";
            this.Load += new System.EventHandler(this.Ocorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
    }
}