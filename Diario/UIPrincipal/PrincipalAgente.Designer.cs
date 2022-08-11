
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
            this.label1 = new System.Windows.Forms.Label();
            this.EventoCadastroAluno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastro_professor = new System.Windows.Forms.Button();
            this.btn_lista_professores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUNO";
            // 
            // EventoCadastroAluno
            // 
            this.EventoCadastroAluno.Location = new System.Drawing.Point(48, 81);
            this.EventoCadastroAluno.Name = "EventoCadastroAluno";
            this.EventoCadastroAluno.Size = new System.Drawing.Size(319, 48);
            this.EventoCadastroAluno.TabIndex = 0;
            this.EventoCadastroAluno.Text = "Cadastro de novo aluno";
            this.EventoCadastroAluno.UseVisualStyleBackColor = true;
            this.EventoCadastroAluno.Click += new System.EventHandler(this.EventoCadastroAluno_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(48, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 200);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(454, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 200);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROFESSOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "TURMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // btn_cadastro_professor
            // 
            this.btn_cadastro_professor.Location = new System.Drawing.Point(454, 81);
            this.btn_cadastro_professor.Name = "btn_cadastro_professor";
            this.btn_cadastro_professor.Size = new System.Drawing.Size(319, 48);
            this.btn_cadastro_professor.TabIndex = 1;
            this.btn_cadastro_professor.Text = "Cadastro de novo Professor";
            this.btn_cadastro_professor.UseVisualStyleBackColor = true;
            this.btn_cadastro_professor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_lista_professores
            // 
            this.btn_lista_professores.Location = new System.Drawing.Point(454, 150);
            this.btn_lista_professores.Name = "btn_lista_professores";
            this.btn_lista_professores.Size = new System.Drawing.Size(319, 48);
            this.btn_lista_professores.TabIndex = 6;
            this.btn_lista_professores.Text = "Lista de professores";
            this.btn_lista_professores.UseVisualStyleBackColor = true;
            // 
            // PrincipalAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.btn_lista_professores);
            this.Controls.Add(this.btn_cadastro_professor);
            this.Controls.Add(this.EventoCadastroAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalAgente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button EventoCadastroAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastro_professor;
        private System.Windows.Forms.Button btn_lista_professores;
    }
}