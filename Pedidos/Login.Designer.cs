namespace Pedidos
{
    partial class Login
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
            Usuario = new Label();
            label2 = new Label();
            TxtUsuario = new TextBox();
            TxtSenha = new TextBox();
            BntEntrar = new Button();
            BntSair = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(50, 47);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(53, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha :";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(106, 47);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(106, 89);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(100, 23);
            TxtSenha.TabIndex = 3;
            // 
            // BntEntrar
            // 
            BntEntrar.Location = new Point(50, 145);
            BntEntrar.Name = "BntEntrar";
            BntEntrar.Size = new Size(75, 23);
            BntEntrar.TabIndex = 4;
            BntEntrar.Text = "Entrar";
            BntEntrar.UseVisualStyleBackColor = true;
            BntEntrar.Click += BntEntrar_Click;
            // 
            // BntSair
            // 
            BntSair.Location = new Point(141, 145);
            BntSair.Name = "BntSair";
            BntSair.Size = new Size(75, 23);
            BntSair.TabIndex = 5;
            BntSair.Text = "Sair";
            BntSair.UseVisualStyleBackColor = true;
            BntSair.Click += BntSair_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 258);
            Controls.Add(BntSair);
            Controls.Add(BntEntrar);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUsuario);
            Controls.Add(label2);
            Controls.Add(Usuario);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private Label label2;
        private TextBox TxtUsuario;
        private TextBox TxtSenha;
        private Button BntEntrar;
        private Button BntSair;
    }
}