
namespace UIPrincipal
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogoM = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuarioLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSenhaLogo = new System.Windows.Forms.PictureBox();
            this.CBMostra_senha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenhaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(514, 155);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(94, 27);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuário";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(518, 180);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(313, 29);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(518, 238);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(313, 29);
            this.textBoxSenha.TabIndex = 7;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(514, 213);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(82, 27);
            this.labelSenha.TabIndex = 6;
            this.labelSenha.Text = "Senha";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(567, 326);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(143, 36);
            this.buttonEntrar.TabIndex = 8;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSair.BackgroundImage")));
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(819, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(25, 25);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Aqua;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(473, 438);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 13;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogoM
            // 
            this.pictureBoxLogoM.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxLogoM.Location = new System.Drawing.Point(549, 60);
            this.pictureBoxLogoM.Name = "pictureBoxLogoM";
            this.pictureBoxLogoM.Size = new System.Drawing.Size(204, 54);
            this.pictureBoxLogoM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoM.TabIndex = 14;
            this.pictureBoxLogoM.TabStop = false;
            // 
            // pictureBoxUsuarioLogo
            // 
            this.pictureBoxUsuarioLogo.Location = new System.Drawing.Point(482, 180);
            this.pictureBoxUsuarioLogo.Name = "pictureBoxUsuarioLogo";
            this.pictureBoxUsuarioLogo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuarioLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuarioLogo.TabIndex = 15;
            this.pictureBoxUsuarioLogo.TabStop = false;
            // 
            // pictureBoxSenhaLogo
            // 
            this.pictureBoxSenhaLogo.Location = new System.Drawing.Point(482, 233);
            this.pictureBoxSenhaLogo.Name = "pictureBoxSenhaLogo";
            this.pictureBoxSenhaLogo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSenhaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSenhaLogo.TabIndex = 16;
            this.pictureBoxSenhaLogo.TabStop = false;
            // 
            // CBMostra_senha
            // 
            this.CBMostra_senha.AutoSize = true;
            this.CBMostra_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMostra_senha.Location = new System.Drawing.Point(705, 269);
            this.CBMostra_senha.Name = "CBMostra_senha";
            this.CBMostra_senha.Size = new System.Drawing.Size(155, 27);
            this.CBMostra_senha.TabIndex = 17;
            this.CBMostra_senha.Text = "Mostra Senha";
            this.CBMostra_senha.UseVisualStyleBackColor = true;
            this.CBMostra_senha.CheckedChanged += new System.EventHandler(this.CBMostra_senha_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 438);
            this.Controls.Add(this.CBMostra_senha);
            this.Controls.Add(this.pictureBoxSenhaLogo);
            this.Controls.Add(this.pictureBoxUsuarioLogo);
            this.Controls.Add(this.pictureBoxLogoM);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonSair);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(847, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(847, 438);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenhaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogoM;
        private System.Windows.Forms.PictureBox pictureBoxUsuarioLogo;
        private System.Windows.Forms.PictureBox pictureBoxSenhaLogo;
        private System.Windows.Forms.CheckBox CBMostra_senha;
    }
}