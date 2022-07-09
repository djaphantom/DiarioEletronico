
namespace UIPrincipal
{
    partial class PrincipalAgente
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
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocorrênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professoresToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(820, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProfessorToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.professoresToolStripMenuItem.Text = "Professor";
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            this.cadastroDeProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessorToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunoToolStripMenuItem,
            this.ocorrênciasToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.alunosToolStripMenuItem.Text = "Aluno";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            this.cadastroDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunoToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeTurmaToolStripMenuItem});
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // cadastroDeTurmaToolStripMenuItem
            // 
            this.cadastroDeTurmaToolStripMenuItem.Name = "cadastroDeTurmaToolStripMenuItem";
            this.cadastroDeTurmaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroDeTurmaToolStripMenuItem.Text = "Cadastro de turma";
            // 
            // ocorrênciasToolStripMenuItem
            // 
            this.ocorrênciasToolStripMenuItem.Name = "ocorrênciasToolStripMenuItem";
            this.ocorrênciasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ocorrênciasToolStripMenuItem.Text = "Ocorrência";
            // 
            // PrincipalAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrincipalAgente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocorrênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeTurmaToolStripMenuItem;
    }
}