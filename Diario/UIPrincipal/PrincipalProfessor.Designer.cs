
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
            this.NovaOcorrência = new System.Windows.Forms.Button();
            this.labelSobre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VoltarLongin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(41, 45);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(61, 18);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "NOTAS";
            // 
            // labelOcorrencia
            // 
            this.labelOcorrencia.AutoSize = true;
            this.labelOcorrencia.Location = new System.Drawing.Point(446, 45);
            this.labelOcorrencia.Name = "labelOcorrencia";
            this.labelOcorrencia.Size = new System.Drawing.Size(114, 18);
            this.labelOcorrencia.TabIndex = 5;
            this.labelOcorrencia.Text = "OCORRÊNCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(22, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 200);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NovaOcorrência);
            this.panel3.Location = new System.Drawing.Point(423, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 200);
            this.panel3.TabIndex = 1;
            // 
            // NovaOcorrência
            // 
            this.NovaOcorrência.FlatAppearance.BorderSize = 0;
            this.NovaOcorrência.Location = new System.Drawing.Point(32, 18);
            this.NovaOcorrência.Name = "NovaOcorrência";
            this.NovaOcorrência.Size = new System.Drawing.Size(319, 48);
            this.NovaOcorrência.TabIndex = 0;
            this.NovaOcorrência.Text = "Nova Ocorrência";
            this.NovaOcorrência.UseVisualStyleBackColor = true;
            // 
            // labelSobre
            // 
            this.labelSobre.AutoSize = true;
            this.labelSobre.Enabled = false;
            this.labelSobre.Location = new System.Drawing.Point(446, 286);
            this.labelSobre.Name = "labelSobre";
            this.labelSobre.Size = new System.Drawing.Size(64, 18);
            this.labelSobre.TabIndex = 9;
            this.labelSobre.Text = "SOBRE";
            this.labelSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VoltarLongin);
            this.panel4.Location = new System.Drawing.Point(423, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 200);
            this.panel4.TabIndex = 8;
            // 
            // VoltarLongin
            // 
            this.VoltarLongin.FlatAppearance.BorderSize = 0;
            this.VoltarLongin.Location = new System.Drawing.Point(27, 21);
            this.VoltarLongin.Name = "VoltarLongin";
            this.VoltarLongin.Size = new System.Drawing.Size(319, 48);
            this.VoltarLongin.TabIndex = 0;
            this.VoltarLongin.Text = "Trocar de Usuário";
            this.VoltarLongin.UseVisualStyleBackColor = true;
            this.VoltarLongin.Click += new System.EventHandler(this.VoltarLongin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Plano de aula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrincipalProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.labelSobre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
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
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button NovaOcorrência;
        private System.Windows.Forms.Label labelSobre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button VoltarLongin;
        private System.Windows.Forms.Button button1;
    }
}