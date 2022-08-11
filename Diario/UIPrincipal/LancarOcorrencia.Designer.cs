namespace UIPrincipal
{
    partial class LancarOcorrencia
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_AlunoLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(21, 65);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(24, 81);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(669, 296);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataSource = typeof(Model.Ocorrencia);
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(24, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(141, 19);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 5;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(144, 35);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 6;
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(261, 19);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 7;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(264, 35);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 8;
            // 
            // LancarOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 427);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.MinimumSize = new System.Drawing.Size(744, 466);
            this.Name = "LancarOcorrencia";
            this.Text = "LancarOcorrencia";
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
    }
}