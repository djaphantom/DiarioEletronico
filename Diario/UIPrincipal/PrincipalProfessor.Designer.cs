
namespace UIPrincipal
{
    partial class PrincipalProfessor
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
            this.labelNota = new System.Windows.Forms.Label();
            this.labelOcorrencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLancarNota = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPlanoDeAula = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(9, 13);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(41, 18);
            this.labelNota.TabIndex = 1;
            this.labelNota.Text = "Nota";
            // 
            // labelOcorrencia
            // 
            this.labelOcorrencia.AutoSize = true;
            this.labelOcorrencia.Location = new System.Drawing.Point(424, 13);
            this.labelOcorrencia.Name = "labelOcorrencia";
            this.labelOcorrencia.Size = new System.Drawing.Size(85, 18);
            this.labelOcorrencia.TabIndex = 2;
            this.labelOcorrencia.Text = "Ocorrencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plano de Aula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // buttonLancarNota
            // 
            this.buttonLancarNota.Location = new System.Drawing.Point(15, 27);
            this.buttonLancarNota.Name = "buttonLancarNota";
            this.buttonLancarNota.Size = new System.Drawing.Size(319, 48);
            this.buttonLancarNota.TabIndex = 5;
            this.buttonLancarNota.Text = "Lançar nota";
            this.buttonLancarNota.UseVisualStyleBackColor = true;
            this.buttonLancarNota.Click += new System.EventHandler(this.buttonLancarNota_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLancarNota);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 200);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPlanoDeAula);
            this.panel1.Location = new System.Drawing.Point(12, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 200);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(427, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 200);
            this.panel3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPlanoDeAula
            // 
            this.buttonPlanoDeAula.Location = new System.Drawing.Point(15, 45);
            this.buttonPlanoDeAula.Name = "buttonPlanoDeAula";
            this.buttonPlanoDeAula.Size = new System.Drawing.Size(319, 48);
            this.buttonPlanoDeAula.TabIndex = 7;
            this.buttonPlanoDeAula.Text = "Plano De Aula";
            this.buttonPlanoDeAula.UseVisualStyleBackColor = true;
            this.buttonPlanoDeAula.Click += new System.EventHandler(this.buttonPlanoDeAula_Click);
            // 
            // PrincipalProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOcorrencia);
            this.Controls.Add(this.labelNota);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 583);
            this.Name = "PrincipalProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessão do professor";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Label labelOcorrencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLancarNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPlanoDeAula;
    }
}