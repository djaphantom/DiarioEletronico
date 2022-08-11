
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
            this.labelaAcessoAgente = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomeAgenteLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentePedagogicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 64);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomeAgenteLabel
            // 
            nomeAgenteLabel.AutoSize = true;
            nomeAgenteLabel.Location = new System.Drawing.Point(24, 118);
            nomeAgenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeAgenteLabel.Name = "nomeAgenteLabel";
            nomeAgenteLabel.Size = new System.Drawing.Size(99, 17);
            nomeAgenteLabel.TabIndex = 3;
            nomeAgenteLabel.Text = "Nome Agente:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(24, 174);
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
            this.idTextBox.Location = new System.Drawing.Point(27, 85);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 25);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Text = "0";
            // 
            // nomeAgenteTextBox
            // 
            this.nomeAgenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "NomeAgente", true));
            this.nomeAgenteTextBox.Location = new System.Drawing.Point(27, 139);
            this.nomeAgenteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeAgenteTextBox.Name = "nomeAgenteTextBox";
            this.nomeAgenteTextBox.Size = new System.Drawing.Size(530, 25);
            this.nomeAgenteTextBox.TabIndex = 4;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(27, 195);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(242, 25);
            this.senhaTextBox.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(27, 272);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(133, 30);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(424, 272);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(133, 30);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(168, 272);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(133, 30);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelaAcessoAgente
            // 
            this.labelaAcessoAgente.AutoSize = true;
            this.labelaAcessoAgente.Location = new System.Drawing.Point(24, 9);
            this.labelaAcessoAgente.Name = "labelaAcessoAgente";
            this.labelaAcessoAgente.Size = new System.Drawing.Size(186, 17);
            this.labelaAcessoAgente.TabIndex = 10;
            this.labelaAcessoAgente.Text = "Acesso Agente Pedagogico";
            this.labelaAcessoAgente.Click += new System.EventHandler(this.labelaAcessoAgente_Click);
            // 
            // FormAgentePedagogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 330);
            this.Controls.Add(this.labelaAcessoAgente);
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
            this.MaximumSize = new System.Drawing.Size(593, 369);
            this.MinimumSize = new System.Drawing.Size(593, 369);
            this.Name = "FormAgentePedagogico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.agentePedagogicoBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelaAcessoAgente;
    }
}