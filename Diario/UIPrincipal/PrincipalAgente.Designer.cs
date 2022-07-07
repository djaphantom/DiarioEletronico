
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
            this.listaDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professoresToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProfessorToolStripMenuItem,
            this.listaDeProfessoresToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.professoresToolStripMenuItem.Text = "Professore";
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            this.cadastroDeProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessorToolStripMenuItem_Click);
            // 
            // listaDeProfessoresToolStripMenuItem
            // 
            this.listaDeProfessoresToolStripMenuItem.Name = "listaDeProfessoresToolStripMenuItem";
            this.listaDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.listaDeProfessoresToolStripMenuItem.Text = "Lista de professores";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.alunosToolStripMenuItem.Text = "Aluno";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            this.cadastroDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.materiaToolStripMenuItem.Text = "Ocorrência";
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // PrincipalAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalAgente";
            this.ShowIcon = false;
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
        private System.Windows.Forms.ToolStripMenuItem listaDeProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
    }
}