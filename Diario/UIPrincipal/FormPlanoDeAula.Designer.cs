
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
            this.btn_Retornar = new System.Windows.Forms.Button();
            conteudoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            id_professorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planoDeAulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conteudoLabel
            // 
            conteudoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            conteudoLabel.AutoSize = true;
            conteudoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conteudoLabel.Location = new System.Drawing.Point(16, 84);
            conteudoLabel.Name = "conteudoLabel";
            conteudoLabel.Size = new System.Drawing.Size(73, 18);
            conteudoLabel.TabIndex = 6;
            conteudoLabel.Text = "Conteudo";
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(15, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_DiarioLabel.Location = new System.Drawing.Point(135, 29);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(46, 13);
            id_DiarioLabel.TabIndex = 2;
            id_DiarioLabel.Text = "Id Diario";
            // 
            // id_professorLabel
            // 
            id_professorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_professorLabel.AutoSize = true;
            id_professorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_professorLabel.Location = new System.Drawing.Point(257, 29);
            id_professorLabel.Name = "id_professorLabel";
            id_professorLabel.Size = new System.Drawing.Size(62, 13);
            id_professorLabel.TabIndex = 4;
            id_professorLabel.Text = "Id professor";
            id_professorLabel.Click += new System.EventHandler(this.id_professorLabel_Click);
            // 
            // planoDeAulaBindingSource
            // 
            this.planoDeAulaBindingSource.DataSource = typeof(Model.PlanoDeAula);
            // 
            // conteudoTextBox
            // 
            this.conteudoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conteudoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Conteudo", true));
            this.conteudoTextBox.Location = new System.Drawing.Point(17, 105);
            this.conteudoTextBox.Multiline = true;
            this.conteudoTextBox.Name = "conteudoTextBox";
            this.conteudoTextBox.Size = new System.Drawing.Size(628, 181);
            this.conteudoTextBox.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(18, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(105, 22);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Text = "0";
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(138, 45);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(105, 22);
            this.id_DiarioTextBox.TabIndex = 3;
            // 
            // id_professorTextBox
            // 
            this.id_professorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoDeAulaBindingSource, "Id_professor", true));
            this.id_professorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_professorTextBox.Location = new System.Drawing.Point(260, 45);
            this.id_professorTextBox.Name = "id_professorTextBox";
            this.id_professorTextBox.Size = new System.Drawing.Size(105, 22);
            this.id_professorTextBox.TabIndex = 5;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(18, 296);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(92, 31);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retornar.Location = new System.Drawing.Point(552, 296);
            this.btn_Retornar.Name = "btn_Retornar";
            this.btn_Retornar.Size = new System.Drawing.Size(93, 31);
            this.btn_Retornar.TabIndex = 9;
            this.btn_Retornar.Text = "Retornar";
            this.btn_Retornar.UseVisualStyleBackColor = true;
            this.btn_Retornar.Click += new System.EventHandler(this.btn_Retornar_Click);
            // 
            // FormPlanoDeAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 342);
            this.Controls.Add(this.btn_Retornar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(id_professorLabel);
            this.Controls.Add(this.id_professorTextBox);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(conteudoLabel);
            this.Controls.Add(this.conteudoTextBox);
            this.MinimumSize = new System.Drawing.Size(689, 381);
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
        private System.Windows.Forms.Button btn_Retornar;
    }
}