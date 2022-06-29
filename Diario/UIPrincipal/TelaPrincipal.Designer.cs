
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
            this.buttonPlanodeAula = new System.Windows.Forms.Button();
            this.buttonLancamentodeNota = new System.Windows.Forms.Button();
            this.buttonLancamentodeFrequência = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlanodeAula
            // 
            this.buttonPlanodeAula.Location = new System.Drawing.Point(12, 83);
            this.buttonPlanodeAula.Name = "buttonPlanodeAula";
            this.buttonPlanodeAula.Size = new System.Drawing.Size(123, 44);
            this.buttonPlanodeAula.TabIndex = 0;
            this.buttonPlanodeAula.Text = "Plano de aula";
            this.buttonPlanodeAula.UseVisualStyleBackColor = true;
            // 
            // buttonLancamentodeNota
            // 
            this.buttonLancamentodeNota.Location = new System.Drawing.Point(12, 159);
            this.buttonLancamentodeNota.Name = "buttonLancamentodeNota";
            this.buttonLancamentodeNota.Size = new System.Drawing.Size(123, 44);
            this.buttonLancamentodeNota.TabIndex = 1;
            this.buttonLancamentodeNota.Text = "Lançamento de nota";
            this.buttonLancamentodeNota.UseVisualStyleBackColor = true;
            // 
            // buttonLancamentodeFrequência
            // 
            this.buttonLancamentodeFrequência.Location = new System.Drawing.Point(166, 83);
            this.buttonLancamentodeFrequência.Name = "buttonLancamentodeFrequência";
            this.buttonLancamentodeFrequência.Size = new System.Drawing.Size(123, 44);
            this.buttonLancamentodeFrequência.TabIndex = 2;
            this.buttonLancamentodeFrequência.Text = "Lançamento de frequência";
            this.buttonLancamentodeFrequência.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonLancamentodeFrequência);
            this.Controls.Add(this.buttonLancamentodeNota);
            this.Controls.Add(this.buttonPlanodeAula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlanodeAula;
        private System.Windows.Forms.Button buttonLancamentodeNota;
        private System.Windows.Forms.Button buttonLancamentodeFrequência;
        private System.Windows.Forms.Button button4;
    }
}

