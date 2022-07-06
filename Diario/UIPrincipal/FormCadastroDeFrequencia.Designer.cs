
namespace UIPrincipal
{
    partial class FormCadastroDeFrequencia
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label faltasLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_AlunoLabel;
            System.Windows.Forms.Label id_DiarioLabel;
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.frequenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faltasCheckBox = new System.Windows.Forms.CheckBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_AlunoTextBox = new System.Windows.Forms.TextBox();
            this.id_DiarioTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            faltasLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_AlunoLabel = new System.Windows.Forms.Label();
            id_DiarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(134, 9);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 1;
            dataLabel.Text = "Data:";
            // 
            // faltasLabel
            // 
            faltasLabel.AutoSize = true;
            faltasLabel.Location = new System.Drawing.Point(250, 72);
            faltasLabel.Name = "faltasLabel";
            faltasLabel.Size = new System.Drawing.Size(38, 13);
            faltasLabel.TabIndex = 3;
            faltasLabel.Text = "Faltas:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // id_AlunoLabel
            // 
            id_AlunoLabel.AutoSize = true;
            id_AlunoLabel.Location = new System.Drawing.Point(14, 72);
            id_AlunoLabel.Name = "id_AlunoLabel";
            id_AlunoLabel.Size = new System.Drawing.Size(49, 13);
            id_AlunoLabel.TabIndex = 7;
            id_AlunoLabel.Text = "Id Aluno:";
            // 
            // id_DiarioLabel
            // 
            id_DiarioLabel.AutoSize = true;
            id_DiarioLabel.Location = new System.Drawing.Point(134, 72);
            id_DiarioLabel.Name = "id_DiarioLabel";
            id_DiarioLabel.Size = new System.Drawing.Size(49, 13);
            id_DiarioLabel.TabIndex = 9;
            id_DiarioLabel.Text = "Id Diario:";
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Data", true));
            this.dataTextBox.Location = new System.Drawing.Point(137, 25);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 2;
            // 
            // frequenciaBindingSource
            // 
            this.frequenciaBindingSource.DataSource = typeof(Model.Frequencia);
            // 
            // faltasCheckBox
            // 
            this.faltasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.frequenciaBindingSource, "Faltas", true));
            this.faltasCheckBox.Location = new System.Drawing.Point(253, 84);
            this.faltasCheckBox.Name = "faltasCheckBox";
            this.faltasCheckBox.Size = new System.Drawing.Size(104, 24);
            this.faltasCheckBox.TabIndex = 4;
            this.faltasCheckBox.Text = "checkBox1";
            this.faltasCheckBox.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(17, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // id_AlunoTextBox
            // 
            this.id_AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id_Aluno", true));
            this.id_AlunoTextBox.Location = new System.Drawing.Point(17, 88);
            this.id_AlunoTextBox.Name = "id_AlunoTextBox";
            this.id_AlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlunoTextBox.TabIndex = 8;
            // 
            // id_DiarioTextBox
            // 
            this.id_DiarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frequenciaBindingSource, "Id_Diario", true));
            this.id_DiarioTextBox.Location = new System.Drawing.Point(137, 88);
            this.id_DiarioTextBox.Name = "id_DiarioTextBox";
            this.id_DiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DiarioTextBox.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(17, 146);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormCadastroDeFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 181);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(id_DiarioLabel);
            this.Controls.Add(this.id_DiarioTextBox);
            this.Controls.Add(id_AlunoLabel);
            this.Controls.Add(this.id_AlunoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(faltasLabel);
            this.Controls.Add(this.faltasCheckBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Name = "FormCadastroDeFrequencia";
            this.Text = "FormCadastroDeFrequencia";
            ((System.ComponentModel.ISupportInitialize)(this.frequenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource frequenciaBindingSource;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.CheckBox faltasCheckBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_AlunoTextBox;
        private System.Windows.Forms.TextBox id_DiarioTextBox;
        private System.Windows.Forms.Button buttonSalvar;
    }
}