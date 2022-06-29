
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
            idLabel = new System.Windows.Forms.Label();
            nomeAgenteLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentePedagogicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 21);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(23, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // agentePedagogicoBindingSource
            // 
            this.agentePedagogicoBindingSource.DataSource = typeof(Model.AgentePedagogico);
            // 
            // nomeAgenteLabel
            // 
            nomeAgenteLabel.AutoSize = true;
            nomeAgenteLabel.Location = new System.Drawing.Point(21, 77);
            nomeAgenteLabel.Name = "nomeAgenteLabel";
            nomeAgenteLabel.Size = new System.Drawing.Size(75, 13);
            nomeAgenteLabel.TabIndex = 3;
            nomeAgenteLabel.Text = "Nome Agente:";
            // 
            // nomeAgenteTextBox
            // 
            this.nomeAgenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "NomeAgente", true));
            this.nomeAgenteTextBox.Location = new System.Drawing.Point(24, 93);
            this.nomeAgenteTextBox.Name = "nomeAgenteTextBox";
            this.nomeAgenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeAgenteTextBox.TabIndex = 4;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(157, 77);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 5;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentePedagogicoBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(160, 93);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(24, 150);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FormAgentePedagogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 198);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeAgenteLabel);
            this.Controls.Add(this.nomeAgenteTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormAgentePedagogico";
            this.Text = "-";
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
    }
}