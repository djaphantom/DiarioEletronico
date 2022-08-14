
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
            this.VoltarLongin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VoltarLongin
            // 
            this.VoltarLongin.FlatAppearance.BorderSize = 0;
            this.VoltarLongin.Location = new System.Drawing.Point(642, 492);
            this.VoltarLongin.Name = "VoltarLongin";
            this.VoltarLongin.Size = new System.Drawing.Size(168, 48);
            this.VoltarLongin.TabIndex = 0;
            this.VoltarLongin.Text = "Trocar de Usuário";
            this.VoltarLongin.UseVisualStyleBackColor = true;
            this.VoltarLongin.Click += new System.EventHandler(this.VoltarLongin_Click);
            // 
            // PrincipalAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 552);
            this.Controls.Add(this.VoltarLongin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 373);
            this.Name = "PrincipalAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aréa do Aluno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VoltarLongin;
    }
}