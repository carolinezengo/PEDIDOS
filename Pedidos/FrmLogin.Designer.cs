namespace Pedidos
{
    partial class FrmLogin
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
            BtnEntrar = new Button();
            BtnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtUsuario = new TextBox();
            TxtSenha = new TextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // BtnEntrar
            // 
            BtnEntrar.Location = new Point(50, 99);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(75, 23);
            BtnEntrar.TabIndex = 0;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(131, 99);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 1;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(84, 34);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 5;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(84, 61);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(100, 23);
            TxtSenha.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.login;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Location = new Point(215, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.UseWaitCursor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 214);
            Controls.Add(groupBox1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSair);
            Controls.Add(BtnEntrar);
            Name = "FrmLogin";
            Text = "Efetuar Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEntrar;
        private Button BtnSair;
        private Label label1;
        private Label label2;
        private Label label3;

        private TextBox TxtUsuario;
        private TextBox TxtSenha;
        private GroupBox groupBox1;
    }
}