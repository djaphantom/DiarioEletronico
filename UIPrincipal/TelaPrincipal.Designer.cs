
namespace UIPrincipal
{
    partial class TelaPrincipal
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
            this.buttonAluno = new System.Windows.Forms.Button();
            this.buttonAgentePedagogico = new System.Windows.Forms.Button();
            this.buttonProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAluno
            // 
            this.buttonAluno.Location = new System.Drawing.Point(15, 63);
            this.buttonAluno.Name = "buttonAluno";
            this.buttonAluno.Size = new System.Drawing.Size(122, 58);
            this.buttonAluno.TabIndex = 0;
            this.buttonAluno.Text = "Acesso Aluno";
            this.buttonAluno.UseVisualStyleBackColor = true;
            // 
            // buttonAgentePedagogico
            // 
            this.buttonAgentePedagogico.Location = new System.Drawing.Point(97, 150);
            this.buttonAgentePedagogico.Name = "buttonAgentePedagogico";
            this.buttonAgentePedagogico.Size = new System.Drawing.Size(123, 57);
            this.buttonAgentePedagogico.TabIndex = 1;
            this.buttonAgentePedagogico.Text = "Agente Pedagógico";
            this.buttonAgentePedagogico.UseVisualStyleBackColor = true;
            // 
            // buttonProfessor
            // 
            this.buttonProfessor.Location = new System.Drawing.Point(171, 63);
            this.buttonProfessor.Name = "buttonProfessor";
            this.buttonProfessor.Size = new System.Drawing.Size(123, 58);
            this.buttonProfessor.TabIndex = 2;
            this.buttonProfessor.Text = "Acesso Professor";
            this.buttonProfessor.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 237);
            this.Controls.Add(this.buttonProfessor);
            this.Controls.Add(this.buttonAgentePedagogico);
            this.Controls.Add(this.buttonAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAluno;
        private System.Windows.Forms.Button buttonAgentePedagogico;
        private System.Windows.Forms.Button buttonProfessor;
    }
}

