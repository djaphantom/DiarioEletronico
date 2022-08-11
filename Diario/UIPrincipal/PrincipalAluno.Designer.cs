
namespace UIPrincipal
{
    partial class PrincipalAluno
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
            this.buttonNota = new System.Windows.Forms.Button();
            this.buttonFrequencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSobre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VoltarLongin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNota
            // 
            this.buttonNota.Location = new System.Drawing.Point(30, 27);
            this.buttonNota.Name = "buttonNota";
            this.buttonNota.Size = new System.Drawing.Size(319, 48);
            this.buttonNota.TabIndex = 0;
            this.buttonNota.Text = "Nota";
            this.buttonNota.UseVisualStyleBackColor = true;
            this.buttonNota.Click += new System.EventHandler(this.buttonNota_Click);
            // 
            // buttonFrequencia
            // 
            this.buttonFrequencia.Location = new System.Drawing.Point(30, 91);
            this.buttonFrequencia.Name = "buttonFrequencia";
            this.buttonFrequencia.Size = new System.Drawing.Size(319, 48);
            this.buttonFrequencia.TabIndex = 1;
            this.buttonFrequencia.Text = "Frequência";
            this.buttonFrequencia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNota);
            this.panel1.Controls.Add(this.buttonFrequencia);
            this.panel1.Location = new System.Drawing.Point(22, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 200);
            this.panel1.TabIndex = 2;
            // 
            // labelSobre
            // 
            this.labelSobre.AutoSize = true;
            this.labelSobre.Enabled = false;
            this.labelSobre.Location = new System.Drawing.Point(446, 45);
            this.labelSobre.Name = "labelSobre";
            this.labelSobre.Size = new System.Drawing.Size(79, 23);
            this.labelSobre.TabIndex = 9;
            this.labelSobre.Text = "SOBRE";
            this.labelSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VoltarLongin);
            this.panel4.Location = new System.Drawing.Point(423, 71);
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
            // PrincipalAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.labelSobre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 591);
            this.Name = "PrincipalAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aréa do Aluno";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNota;
        private System.Windows.Forms.Button buttonFrequencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSobre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button VoltarLongin;
    }
}