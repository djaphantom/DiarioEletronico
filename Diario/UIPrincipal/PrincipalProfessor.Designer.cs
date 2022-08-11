
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
            this.btn_trocaUsuario = new System.Windows.Forms.Button();
            this.btn_planoDeAula = new System.Windows.Forms.Button();
            this.btn_lancaOcorrencia = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(41, 79);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(61, 18);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "NOTAS";
            // 
            // labelOcorrencia
            // 
            this.labelOcorrencia.AutoSize = true;
            this.labelOcorrencia.Location = new System.Drawing.Point(446, 79);
            this.labelOcorrencia.Name = "labelOcorrencia";
            this.labelOcorrencia.Size = new System.Drawing.Size(114, 18);
            this.labelOcorrencia.TabIndex = 5;
            this.labelOcorrencia.Text = "OCORRÊNCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "PLANO DE AULA";
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
            this.panel2.Location = new System.Drawing.Point(22, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 200);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_planoDeAula);
            this.panel1.Location = new System.Drawing.Point(22, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 200);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_lancaOcorrencia);
            this.panel3.Location = new System.Drawing.Point(423, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 200);
            this.panel3.TabIndex = 1;
            // 
            // btn_trocaUsuario
            // 
            this.btn_trocaUsuario.Location = new System.Drawing.Point(26, 16);
            this.btn_trocaUsuario.Name = "btn_trocaUsuario";
            this.btn_trocaUsuario.Size = new System.Drawing.Size(319, 50);
            this.btn_trocaUsuario.TabIndex = 7;
            this.btn_trocaUsuario.Text = "Trocar de usuário";
            this.btn_trocaUsuario.UseVisualStyleBackColor = true;
            this.btn_trocaUsuario.Click += new System.EventHandler(this.btn_trocaUsuario_Click);
            // 
            // btn_planoDeAula
            // 
            this.btn_planoDeAula.Location = new System.Drawing.Point(30, 16);
            this.btn_planoDeAula.Name = "btn_planoDeAula";
            this.btn_planoDeAula.Size = new System.Drawing.Size(319, 50);
            this.btn_planoDeAula.TabIndex = 8;
            this.btn_planoDeAula.Text = "Elaborar plano de aula";
            this.btn_planoDeAula.UseVisualStyleBackColor = true;
            // 
            // btn_lancaOcorrencia
            // 
            this.btn_lancaOcorrencia.Location = new System.Drawing.Point(26, 28);
            this.btn_lancaOcorrencia.Name = "btn_lancaOcorrencia";
            this.btn_lancaOcorrencia.Size = new System.Drawing.Size(319, 50);
            this.btn_lancaOcorrencia.TabIndex = 9;
            this.btn_lancaOcorrencia.Text = "Lançar ocorrência";
            this.btn_lancaOcorrencia.UseVisualStyleBackColor = true;
            this.btn_lancaOcorrencia.Click += new System.EventHandler(this.btn_lancaOcorrencia_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_trocaUsuario);
            this.panel4.Location = new System.Drawing.Point(423, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 200);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "SOBRE";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.titulo);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 49);
            this.panel5.TabIndex = 56;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(35, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(250, 33);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Área do professor";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrincipalProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOcorrencia);
            this.Controls.Add(this.labelNota);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(842, 608);
            this.Name = "PrincipalProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aréa do Professor";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Button btn_planoDeAula;
        private System.Windows.Forms.Button btn_lancaOcorrencia;
        private System.Windows.Forms.Button btn_trocaUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label titulo;
    }
}