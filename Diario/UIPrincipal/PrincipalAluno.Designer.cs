
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNota
            // 
            this.buttonNota.Location = new System.Drawing.Point(63, 86);
            this.buttonNota.Name = "buttonNota";
            this.buttonNota.Size = new System.Drawing.Size(148, 34);
            this.buttonNota.TabIndex = 0;
            this.buttonNota.Text = "Nota";
            this.buttonNota.UseVisualStyleBackColor = true;
            this.buttonNota.Click += new System.EventHandler(this.buttonNota_Click);
            // 
            // buttonFrequencia
            // 
            this.buttonFrequencia.Location = new System.Drawing.Point(288, 86);
            this.buttonFrequencia.Name = "buttonFrequencia";
            this.buttonFrequencia.Size = new System.Drawing.Size(148, 34);
            this.buttonFrequencia.TabIndex = 1;
            this.buttonFrequencia.Text = "Frequência";
            this.buttonFrequencia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Acesso aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrincipalAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFrequencia);
            this.Controls.Add(this.buttonNota);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNota;
        private System.Windows.Forms.Button buttonFrequencia;
        private System.Windows.Forms.Label label1;
    }
}