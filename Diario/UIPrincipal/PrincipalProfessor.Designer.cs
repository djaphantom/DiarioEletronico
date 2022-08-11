
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
            this.buttonLancarNota = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(41, 45);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(76, 23);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "NOTAS";
            // 
            // labelOcorrencia
            // 
            this.labelOcorrencia.AutoSize = true;
            this.labelOcorrencia.Location = new System.Drawing.Point(446, 45);
            this.labelOcorrencia.Name = "labelOcorrencia";
            this.labelOcorrencia.Size = new System.Drawing.Size(143, 23);
            this.labelOcorrencia.TabIndex = 5;
            this.labelOcorrencia.Text = "OCORRÊNCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plano de Aula";
            // 
            // buttonLancarNota
            // 
            this.buttonLancarNota.FlatAppearance.BorderSize = 0;
            this.buttonLancarNota.Location = new System.Drawing.Point(30, 28);
            this.buttonLancarNota.Name = "buttonLancarNota";
            this.buttonLancarNota.Size = new System.Drawing.Size(319, 48);
            this.buttonLancarNota.TabIndex = 0;
            this.buttonLancarNota.Text = "Lançamento de Notas";
            this.buttonLancarNota.UseVisualStyleBackColor = true;
            this.buttonLancarNota.Click += new System.EventHandler(this.buttonLancarNota_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLancarNota);
            this.panel2.Location = new System.Drawing.Point(22, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 200);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 200);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(423, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 200);
            this.panel3.TabIndex = 1;
            // 
            // PrincipalProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOcorrencia);
            this.Controls.Add(this.labelNota);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 583);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 583);
            this.Name = "PrincipalProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aréa do Professor";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Label labelOcorrencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLancarNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;

    }
}