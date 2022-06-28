
namespace UIPrincipal
{
    partial class FormPlanoDeAula
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
            System.Windows.Forms.Label conteudoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            System.Windows.Forms.Label id_professorLabel;
            this.planoDeAulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conteudoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.id_professorTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            conteudoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            id_professorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeAulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planoDeAulaBindingSource
            // 
            this.planoDeAulaBindingSource.DataSource = typeof(Model.PlanoDeAula);
            // 
            // conteudoLabel
            // 
            conteudoLabel.AutoSize = true;
            conteudoLabel.Location = new System.Drawing.Point(12, 99);
            conteudoLabel.Name = "conteudoLabel";
            conteudoLabel.Size = new System.Drawing.Size(56, 13);
            conteudoLabel.TabIndex = 1;
            conteudoLabel.Text = "Conteudo:";
            // 
            // conteudoTextBox
            // 
            this.conteudoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Conteudo", true));
            this.conteudoTextBox.Location = new System.Drawing.Point(14, 115);
            this.conteudoTextBox.Multiline = true;
            this.conteudoTextBox.Name = "conteudoTextBox";
            this.conteudoTextBox.Size = new System.Drawing.Size(421, 231);
            this.conteudoTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(11, 62);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(36, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(157, 62);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 5;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(212, 59);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 6;
            // 
            // id_professorLabel
            // 
            id_professorLabel.AutoSize = true;
            id_professorLabel.Location = new System.Drawing.Point(322, 58);
            id_professorLabel.Name = "id_professorLabel";
            id_professorLabel.Size = new System.Drawing.Size(65, 13);
            id_professorLabel.TabIndex = 7;
            id_professorLabel.Text = "Id professor:";
            // 
            // id_professorTextBox
            // 
            this.id_professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id_professor", true));
            this.id_professorTextBox.Location = new System.Drawing.Point(393, 55);
            this.id_professorTextBox.Name = "id_professorTextBox";
            this.id_professorTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_professorTextBox.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(15, 359);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(77, 21);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FormPlanoDeAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 392);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(id_professorLabel);
            this.Controls.Add(this.id_professorTextBox);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(conteudoLabel);
            this.Controls.Add(this.conteudoTextBox);
            this.Name = "FormPlanoDeAula";
            this.Text = "FormPlanoDeAula";
            ((System.ComponentModel.ISupportInitialize)(this.planoDeAulaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource planoDeAulaBindingSource;
        private System.Windows.Forms.TextBox conteudoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.TextBox id_professorTextBox;
        private System.Windows.Forms.Button buttonSalvar;
    }
}