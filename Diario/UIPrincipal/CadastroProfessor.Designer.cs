
namespace UIPrincipal
{
    partial class CadastroProfessor
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
            this.labelCadastroProfessor = new System.Windows.Forms.Label();
            this.labelNomeProfessor = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxNomeDoProfessor = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxIDdoProfessor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCadastroProfessor
            // 
            this.labelCadastroProfessor.AutoSize = true;
            this.labelCadastroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroProfessor.Location = new System.Drawing.Point(172, 9);
            this.labelCadastroProfessor.Name = "labelCadastroProfessor";
            this.labelCadastroProfessor.Size = new System.Drawing.Size(401, 39);
            this.labelCadastroProfessor.TabIndex = 0;
            this.labelCadastroProfessor.Text = "Cadastro de Professores";
            this.labelCadastroProfessor.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNomeProfessor
            // 
            this.labelNomeProfessor.AutoSize = true;
            this.labelNomeProfessor.Location = new System.Drawing.Point(65, 97);
            this.labelNomeProfessor.Name = "labelNomeProfessor";
            this.labelNomeProfessor.Size = new System.Drawing.Size(99, 13);
            this.labelNomeProfessor.TabIndex = 1;
            this.labelNomeProfessor.Text = "Nome Do Professor";
            this.labelNomeProfessor.Click += new System.EventHandler(this.labelNomeProfessor_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(44, 158);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(41, 97);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxNomeDoProfessor
            // 
            this.textBoxNomeDoProfessor.Location = new System.Drawing.Point(65, 113);
            this.textBoxNomeDoProfessor.Name = "textBoxNomeDoProfessor";
            this.textBoxNomeDoProfessor.Size = new System.Drawing.Size(703, 20);
            this.textBoxNomeDoProfessor.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBoxIDdoProfessor
            // 
            this.textBoxIDdoProfessor.Location = new System.Drawing.Point(39, 113);
            this.textBoxIDdoProfessor.Name = "textBoxIDdoProfessor";
            this.textBoxIDdoProfessor.Size = new System.Drawing.Size(20, 20);
            this.textBoxIDdoProfessor.TabIndex = 10;
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIDdoProfessor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxNomeDoProfessor);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelNomeProfessor);
            this.Controls.Add(this.labelCadastroProfessor);
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfessor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastroProfessor;
        private System.Windows.Forms.Label labelNomeProfessor;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxNomeDoProfessor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxIDdoProfessor;
    }
}