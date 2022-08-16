
namespace UIPrincipal
{
    partial class FormAgentePedagogico
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
            System.Windows.Forms.Label nomeAgenteLabel;
            System.Windows.Forms.Label senhaLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.agentePedagogicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeAgenteTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            nomeAgenteLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentePedagogicoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 131);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomeAgenteLabel
            // 
            nomeAgenteLabel.AutoSize = true;
            nomeAgenteLabel.Location = new System.Drawing.Point(160, 131);
            nomeAgenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeAgenteLabel.Name = "nomeAgenteLabel";
            nomeAgenteLabel.Size = new System.Drawing.Size(99, 17);
            nomeAgenteLabel.TabIndex = 3;
            nomeAgenteLabel.Text = "Nome Agente:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(19, 228);
            senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(54, 17);
            senhaLabel.TabIndex = 5;
            senhaLabel.Text = "Senha:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(22, 152);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(138, 25);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Text = "0";
            // 
            // agentePedagogicoBindingSource
            // 
            this.agentePedagogicoBindingSource.DataSource = typeof(Model.AgentePedagogico);
            // 
            // nomeAgenteTextBox
            // 
            this.nomeAgenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "NomeAgente", true));
            this.nomeAgenteTextBox.Location = new System.Drawing.Point(163, 152);
            this.nomeAgenteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeAgenteTextBox.Name = "nomeAgenteTextBox";
            this.nomeAgenteTextBox.Size = new System.Drawing.Size(635, 25);
            this.nomeAgenteTextBox.TabIndex = 4;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(22, 249);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(303, 25);
            this.senhaTextBox.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(32, 570);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(162, 48);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(381, 570);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(162, 48);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(202, 570);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(162, 48);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "&Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 49);
            this.panel1.TabIndex = 57;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(223, 3);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(342, 33);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Novo Agente Pedagogico";
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sair.Location = new System.Drawing.Point(636, 570);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(162, 48);
            this.btn_sair.TabIndex = 58;
            this.btn_sair.Text = "&Retornar";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.Location = new System.Drawing.Point(329, 249);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(469, 25);
            this.textBoxUsuario.TabIndex = 60;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(325, 221);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(121, 17);
            this.labelUsuario.TabIndex = 59;
            this.labelUsuario.Text = "Nome de Usuario";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 27);
            this.panel2.TabIndex = 61;
            // 
            // FormAgentePedagogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeAgenteLabel);
            this.Controls.Add(this.nomeAgenteTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgentePedagogico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Agente Pedagogico";
            ((System.ComponentModel.ISupportInitialize)(this.agentePedagogicoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentePedagogicoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeAgenteTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panel2;
    }
}