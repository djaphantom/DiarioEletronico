
namespace UIPrincipal
{
    partial class FormCadastroDeNota
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_AlunoLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            System.Windows.Forms.Label id_TurmaLabel;
            System.Windows.Forms.Label notaAlunoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.notaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.id_TurmaTextBox = new System.Windows.Forms.TextBox();
            this.notaAlunoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            id_TurmaLabel = new System.Windows.Forms.Label();
            notaAlunoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(12, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataSource = typeof(Model.Nota);
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(149, 49);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 3;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(152, 68);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 4;
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(149, 129);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 5;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(152, 145);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 6;
            // 
            // id_TurmaLabel
            // 
            id_TurmaLabel.AutoSize = true;
            id_TurmaLabel.Location = new System.Drawing.Point(9, 118);
            id_TurmaLabel.Name = "id_TurmaLabel";
            id_TurmaLabel.Size = new System.Drawing.Size(52, 13);
            id_TurmaLabel.TabIndex = 7;
            id_TurmaLabel.Text = "Id Turma:";
            // 
            // id_TurmaTextBox
            // 
            this.id_TurmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "Id_Turma", true));
            this.id_TurmaTextBox.Location = new System.Drawing.Point(12, 145);
            this.id_TurmaTextBox.Name = "id_TurmaTextBox";
            this.id_TurmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TurmaTextBox.TabIndex = 8;
            // 
            // notaAlunoLabel
            // 
            notaAlunoLabel.AutoSize = true;
            notaAlunoLabel.Location = new System.Drawing.Point(265, 129);
            notaAlunoLabel.Name = "notaAlunoLabel";
            notaAlunoLabel.Size = new System.Drawing.Size(63, 13);
            notaAlunoLabel.TabIndex = 9;
            notaAlunoLabel.Text = "Nota Aluno:";
            // 
            // notaAlunoTextBox
            // 
            this.notaAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notaBindingSource, "NotaAluno", true));
            this.notaAlunoTextBox.Location = new System.Drawing.Point(272, 145);
            this.notaAlunoTextBox.Name = "notaAlunoTextBox";
            this.notaAlunoTextBox.Size = new System.Drawing.Size(79, 20);
            this.notaAlunoTextBox.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 187);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroDeNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 222);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(notaAlunoLabel);
            this.Controls.Add(this.notaAlunoTextBox);
            this.Controls.Add(id_TurmaLabel);
            this.Controls.Add(this.id_TurmaTextBox);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormCadastroDeNota";
            this.Text = "FormCadastroDeNota";
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource notaBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.TextBox id_TurmaTextBox;
        private System.Windows.Forms.TextBox notaAlunoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
    }
}