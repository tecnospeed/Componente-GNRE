namespace DemonstracaoGNRE_C_Sharp
{
    partial class FormEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.tbEmailRemetente = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmailDestinatario = new System.Windows.Forms.TextBox();
            this.tbPorta = new System.Windows.Forms.TextBox();
            this.tbTimeOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProtocoloRNRe = new System.Windows.Forms.TextBox();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTextoEmail = new System.Windows.Forms.RichTextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.cbAutenticacao = new System.Windows.Forms.CheckBox();
            this.cbComHTML = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DemonstracaoGNRE_C_Sharp.Properties.Resources.Lgo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 331);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail Remetente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail Destinatário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Porta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(172, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time Out";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(533, 284);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbSMTP
            // 
            this.tbSMTP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSMTP.Location = new System.Drawing.Point(12, 25);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(267, 22);
            this.tbSMTP.TabIndex = 9;
            this.tbSMTP.Text = "smtp.gmail.com";
            // 
            // tbEmailRemetente
            // 
            this.tbEmailRemetente.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbEmailRemetente.Location = new System.Drawing.Point(12, 73);
            this.tbEmailRemetente.Name = "tbEmailRemetente";
            this.tbEmailRemetente.Size = new System.Drawing.Size(267, 22);
            this.tbEmailRemetente.TabIndex = 10;
            this.tbEmailRemetente.Text = "@gmail.com.br";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbUsuario.Location = new System.Drawing.Point(12, 127);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(267, 22);
            this.tbUsuario.TabIndex = 11;
            this.tbUsuario.Text = "@gmail.com.br";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbSenha.Location = new System.Drawing.Point(12, 166);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(267, 22);
            this.tbSenha.TabIndex = 12;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbEmailDestinatario
            // 
            this.tbEmailDestinatario.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbEmailDestinatario.Location = new System.Drawing.Point(12, 210);
            this.tbEmailDestinatario.Name = "tbEmailDestinatario";
            this.tbEmailDestinatario.Size = new System.Drawing.Size(267, 22);
            this.tbEmailDestinatario.TabIndex = 13;
            this.tbEmailDestinatario.Text = "@gmail.com.br";
            // 
            // tbPorta
            // 
            this.tbPorta.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbPorta.Location = new System.Drawing.Point(12, 255);
            this.tbPorta.Name = "tbPorta";
            this.tbPorta.Size = new System.Drawing.Size(100, 22);
            this.tbPorta.TabIndex = 14;
            this.tbPorta.Text = "587";
            this.tbPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimeOut
            // 
            this.tbTimeOut.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbTimeOut.Location = new System.Drawing.Point(165, 255);
            this.tbTimeOut.Name = "tbTimeOut";
            this.tbTimeOut.Size = new System.Drawing.Size(114, 22);
            this.tbTimeOut.TabIndex = 15;
            this.tbTimeOut.Text = "60000";
            this.tbTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nº Recibo GNR-e";
            // 
            // tbProtocoloRNRe
            // 
            this.tbProtocoloRNRe.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbProtocoloRNRe.Location = new System.Drawing.Point(312, 25);
            this.tbProtocoloRNRe.Name = "tbProtocoloRNRe";
            this.tbProtocoloRNRe.Size = new System.Drawing.Size(131, 22);
            this.tbProtocoloRNRe.TabIndex = 17;
            this.tbProtocoloRNRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAssunto
            // 
            this.tbAssunto.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbAssunto.Location = new System.Drawing.Point(312, 73);
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(183, 22);
            this.tbAssunto.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(309, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Assunto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mensagem";
            // 
            // tbTextoEmail
            // 
            this.tbTextoEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.tbTextoEmail.Location = new System.Drawing.Point(312, 150);
            this.tbTextoEmail.Name = "tbTextoEmail";
            this.tbTextoEmail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbTextoEmail.Size = new System.Drawing.Size(303, 128);
            this.tbTextoEmail.TabIndex = 22;
            this.tbTextoEmail.Text = "";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(442, 284);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(85, 23);
            this.btnEnviarEmail.TabIndex = 23;
            this.btnEnviarEmail.Text = "Enviar eMail";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // cbAutenticacao
            // 
            this.cbAutenticacao.AutoSize = true;
            this.cbAutenticacao.BackColor = System.Drawing.Color.Transparent;
            this.cbAutenticacao.Location = new System.Drawing.Point(312, 111);
            this.cbAutenticacao.Name = "cbAutenticacao";
            this.cbAutenticacao.Size = new System.Drawing.Size(98, 17);
            this.cbAutenticacao.TabIndex = 24;
            this.cbAutenticacao.Text = "Autenticação ?";
            this.cbAutenticacao.UseVisualStyleBackColor = false;
            // 
            // cbComHTML
            // 
            this.cbComHTML.AutoSize = true;
            this.cbComHTML.BackColor = System.Drawing.Color.Transparent;
            this.cbComHTML.Location = new System.Drawing.Point(442, 111);
            this.cbComHTML.Name = "cbComHTML";
            this.cbComHTML.Size = new System.Drawing.Size(119, 17);
            this.cbComHTML.TabIndex = 25;
            this.cbComHTML.Text = "Corpo com HTML ?";
            this.cbComHTML.UseVisualStyleBackColor = false;
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(627, 314);
            this.Controls.Add(this.cbComHTML);
            this.Controls.Add(this.cbAutenticacao);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.tbTextoEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.tbProtocoloRNRe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTimeOut);
            this.Controls.Add(this.tbPorta);
            this.Controls.Add(this.tbEmailDestinatario);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbEmailRemetente);
            this.Controls.Add(this.tbSMTP);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmail";
            this.Text = "FormEmail";
            this.Load += new System.EventHandler(this.FormEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.TextBox tbEmailRemetente;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmailDestinatario;
        private System.Windows.Forms.TextBox tbPorta;
        private System.Windows.Forms.TextBox tbTimeOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbProtocoloRNRe;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox tbTextoEmail;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.CheckBox cbAutenticacao;
        private System.Windows.Forms.CheckBox cbComHTML;
    }
}