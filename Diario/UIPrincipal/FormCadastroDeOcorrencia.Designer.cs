
namespace UIPrincipal
{
    partial class FormCadastroDeOcorrencia
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
            System.Windows.Forms.Label descricaoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(24, 57);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataSource = typeof(Model.Ocorrencia);
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(186, 41);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 3;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(189, 57);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 4;
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(323, 41);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 5;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(326, 57);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 6;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(21, 143);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 7;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(24, 159);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(402, 168);
            this.descricaoTextBox.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(24, 355);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroDeOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormCadastroDeOcorrencia";
            this.Text = "FormCadastroDeOcorrencia";
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
    }
}