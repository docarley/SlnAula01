namespace PrjAula01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            btnLogar = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.Info;
            txtLogin.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(226, 105);
            txtLogin.MaxLength = 11;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(268, 38);
            txtLogin.TabIndex = 0;
            // 
            // btnLogar
            // 
            btnLogar.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogar.Location = new Point(365, 243);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(129, 46);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(130, 108);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(71, 31);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(130, 175);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(76, 31);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Info;
            txtSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(226, 172);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(268, 38);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagem.Location = new Point(255, 338);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(128, 31);
            lblMensagem.TabIndex = 6;
            lblMensagem.Text = "Mensagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(620, 414);
            Controls.Add(lblMensagem);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnLogar);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "Jukas Bank - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Button btnLogar;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblMensagem;
    }
}