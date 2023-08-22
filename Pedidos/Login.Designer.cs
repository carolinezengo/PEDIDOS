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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(106, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
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
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 258);
            Controls.Add(BntSair);
            Controls.Add(BntEntrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button BntEntrar;
        private Button BntSair;
    }
}