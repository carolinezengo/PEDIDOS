﻿namespace Pedidos
{
    partial class FrmCadClientes
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
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            TxtEndereco = new TextBox();
            TxtDataNasc = new TextBox();
            TxtCep = new TextBox();
            TxtBairro = new TextBox();
            TxtCidade = new TextBox();
            TxtCpf = new TextBox();
            TxtTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BtnNovo = new Button();
            BtnAlterar = new Button();
            BtnDeletar = new Button();
            BtnSair = new Button();
            label10 = new Label();
            TxtComp = new TextBox();
            BtnGravar = new Button();
            lblMensagem = new Label();
            BtnBuscar = new Button();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(68, 56);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 0;
         
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(68, 106);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(350, 23);
            TxtNome.TabIndex = 1;
           
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(68, 205);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(350, 23);
            TxtEndereco.TabIndex = 2;
          
            // 
            // TxtDataNasc
            // 
            TxtDataNasc.Location = new Point(121, 165);
            TxtDataNasc.Name = "TxtDataNasc";
            TxtDataNasc.Size = new Size(137, 23);
            TxtDataNasc.TabIndex = 3;
            
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(68, 327);
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(100, 23);
            TxtCep.TabIndex = 4;
        
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(68, 243);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(100, 23);
            TxtBairro.TabIndex = 5;
            
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(68, 283);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(182, 23);
            TxtCidade.TabIndex = 6;
          
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(68, 376);
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(190, 23);
            TxtCpf.TabIndex = 7;
           
            // 
            // TxtTel
            // 
            TxtTel.Location = new Point(68, 432);
            TxtTel.Name = "TxtTel";
            TxtTel.Size = new Size(149, 23);
            TxtTel.TabIndex = 8;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 9;
            label1.Text = "Codigo:";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 114);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Nome:";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 11;
            label3.Text = "Data Nascimento:";
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 208);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 12;
            label4.Text = "Rua:";
         
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 243);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 13;
            label5.Text = "Bairro:";
          
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 283);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 14;
            label6.Text = "Cidade:";
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 330);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 15;
            label7.Text = "CEP:";
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 384);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 16;
            label8.Text = "CPF:";
           
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 440);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 17;
            label9.Text = "TEL:";
            
            // 
            // BtnNovo
            // 
            BtnNovo.BackgroundImage = Properties.Resources.New_File_36861;
            BtnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNovo.ImageKey = "New_File_36861.png";
            BtnNovo.Location = new Point(12, 500);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(69, 73);
            BtnNovo.TabIndex = 18;
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += button1_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackgroundImage = Properties.Resources.alterar;
            BtnAlterar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAlterar.Location = new Point(212, 500);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(69, 73);
            BtnAlterar.TabIndex = 20;
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += button3_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackgroundImage = Properties.Resources.Delete;
            BtnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeletar.Location = new Point(274, 500);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(69, 73);
            BtnDeletar.TabIndex = 21;
            BtnDeletar.UseVisualStyleBackColor = true;
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // BtnSair
            // 
            BtnSair.BackgroundImage = Properties.Resources.exit_door;
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Location = new Point(338, 500);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(69, 73);
            BtnSair.TabIndex = 22;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 246);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 24;
            label10.Text = "Complemento:";
         
            // 
            // TxtComp
            // 
            TxtComp.Location = new Point(276, 243);
            TxtComp.Name = "TxtComp";
            TxtComp.Size = new Size(275, 23);
            TxtComp.TabIndex = 23;
          
            // 
            // BtnGravar
            // 
            BtnGravar.BackgroundImage = Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            BtnGravar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGravar.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513.png";
            BtnGravar.Location = new Point(78, 500);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(69, 73);
            BtnGravar.TabIndex = 25;
            BtnGravar.UseVisualStyleBackColor = true;
            BtnGravar.Click += BtnGrava_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(28, 561);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 26;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = Properties.Resources.pesquisa;
            BtnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscar.ImageKey = "pesquisa.png";
            BtnBuscar.Location = new Point(146, 500);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(69, 73);
            BtnBuscar.TabIndex = 27;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // FrmCadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 576);
            Controls.Add(BtnBuscar);
            Controls.Add(lblMensagem);
            Controls.Add(BtnGravar);
            Controls.Add(label10);
            Controls.Add(TxtComp);
            Controls.Add(BtnSair);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtTel);
            Controls.Add(TxtCpf);
            Controls.Add(TxtCidade);
            Controls.Add(TxtBairro);
            Controls.Add(TxtCep);
            Controls.Add(TxtDataNasc);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmCadClientes";
            Text = "Cadastro de Clientes";
            Load += FrmCadClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private TextBox TxtEndereco;
        private TextBox TxtDataNasc;
        private TextBox TxtCep;
        private TextBox TxtBairro;
        private TextBox TxtCidade;
        private TextBox TxtCpf;
        private TextBox TxtTel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button BtnNovo;
        private Button BtnGravar;
        private Button BtnAlterar;
        private Button BtnDeletar;
        private Button BtnSair;
        private Label label10;
        private TextBox TxtComp;
        private Button BtnGrava;
        private Label lblMensagem;
        private Button BtnBuscar;
    }
}