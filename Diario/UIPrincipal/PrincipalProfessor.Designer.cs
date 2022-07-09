
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lançarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarOcorrênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarNotaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lançarNotaToolStripMenuItem
            // 
            this.lançarNotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarNotasToolStripMenuItem,
            this.lançarOcorrênciaToolStripMenuItem,
            this.planoDeAulaToolStripMenuItem});
            this.lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            this.lançarNotaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lançarNotaToolStripMenuItem.Text = "Diário";
            this.lançarNotaToolStripMenuItem.Click += new System.EventHandler(this.lançarNotaToolStripMenuItem_Click);
            // 
            // lançarNotasToolStripMenuItem
            // 
            this.lançarNotasToolStripMenuItem.Name = "lançarNotasToolStripMenuItem";
            this.lançarNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarNotasToolStripMenuItem.Text = "Lançar Notas ";
            // 
            // lançarOcorrênciaToolStripMenuItem
            // 
            this.lançarOcorrênciaToolStripMenuItem.Name = "lançarOcorrênciaToolStripMenuItem";
            this.lançarOcorrênciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarOcorrênciaToolStripMenuItem.Text = "Lançar Ocorrência";
            // 
            // planoDeAulaToolStripMenuItem
            // 
            this.planoDeAulaToolStripMenuItem.Name = "planoDeAulaToolStripMenuItem";
            this.planoDeAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planoDeAulaToolStripMenuItem.Text = "Plano de Aula";
            // 
            // PrincipalProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 583);
            this.MinimumSize = new System.Drawing.Size(836, 583);
            this.Name = "PrincipalProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessão do professor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lançarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarOcorrênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeAulaToolStripMenuItem;
    }
}