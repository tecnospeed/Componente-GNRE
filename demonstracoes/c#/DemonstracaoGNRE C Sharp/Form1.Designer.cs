namespace DemonstracaoGNRE_C_Sharp
{
    partial class FormGnrePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGnrePrincipal));
            this.cbbCertificado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mmoXML = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmitirGuia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReciboGnre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarXML = new System.Windows.Forms.Button();
            this.btnConsultarRecibo = new System.Windows.Forms.Button();
            this.openFileSearch = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnExtrairNRecibo = new System.Windows.Forms.Button();
            this.btnConsultarConfigUF = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnConfigIni = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCertificado
            // 
            this.cbbCertificado.FormattingEnabled = true;
            this.cbbCertificado.Location = new System.Drawing.Point(16, 40);
            this.cbbCertificado.Name = "cbbCertificado";
            this.cbbCertificado.Size = new System.Drawing.Size(527, 21);
            this.cbbCertificado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Certificado Digital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DemonstracaoGNRE_C_Sharp.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mmoXML
            // 
            this.mmoXML.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoXML.Location = new System.Drawing.Point(16, 83);
            this.mmoXML.Name = "mmoXML";
            this.mmoXML.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.mmoXML.Size = new System.Drawing.Size(527, 357);
            this.mmoXML.TabIndex = 4;
            this.mmoXML.Text = "";
            this.mmoXML.TextChanged += new System.EventHandler(this.mmoXML_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "XML NF-e";
            // 
            // btnEmitirGuia
            // 
            this.btnEmitirGuia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirGuia.Location = new System.Drawing.Point(8, 58);
            this.btnEmitirGuia.Name = "btnEmitirGuia";
            this.btnEmitirGuia.Size = new System.Drawing.Size(79, 35);
            this.btnEmitirGuia.TabIndex = 6;
            this.btnEmitirGuia.Text = "Emitir Guia";
            this.btnEmitirGuia.UseVisualStyleBackColor = true;
            this.btnEmitirGuia.Click += new System.EventHandler(this.btnEmitirGuia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbReciboGnre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(557, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // tbUF
            // 
            this.tbUF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbUF.Location = new System.Drawing.Point(217, 29);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(34, 22);
            this.tbUF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF: ";
            // 
            // tbReciboGnre
            // 
            this.tbReciboGnre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReciboGnre.Location = new System.Drawing.Point(72, 29);
            this.tbReciboGnre.Name = "tbReciboGnre";
            this.tbReciboGnre.Size = new System.Drawing.Size(94, 22);
            this.tbReciboGnre.TabIndex = 1;
            this.tbReciboGnre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recibo :";
            // 
            // btnBuscarXML
            // 
            this.btnBuscarXML.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.btnBuscarXML.Location = new System.Drawing.Point(8, 99);
            this.btnBuscarXML.Name = "btnBuscarXML";
            this.btnBuscarXML.Size = new System.Drawing.Size(79, 35);
            this.btnBuscarXML.TabIndex = 8;
            this.btnBuscarXML.Text = "Buscar XML";
            this.btnBuscarXML.UseVisualStyleBackColor = true;
            this.btnBuscarXML.Click += new System.EventHandler(this.btnBuscarXML_Click);
            // 
            // btnConsultarRecibo
            // 
            this.btnConsultarRecibo.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.btnConsultarRecibo.Location = new System.Drawing.Point(93, 58);
            this.btnConsultarRecibo.Name = "btnConsultarRecibo";
            this.btnConsultarRecibo.Size = new System.Drawing.Size(79, 35);
            this.btnConsultarRecibo.TabIndex = 9;
            this.btnConsultarRecibo.Text = "Consultar";
            this.btnConsultarRecibo.UseVisualStyleBackColor = true;
            this.btnConsultarRecibo.Click += new System.EventHandler(this.btnConsultarRecibo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(756, 375);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 26);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(756, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviarEmail);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Controls.Add(this.btnVisualizar);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Location = new System.Drawing.Point(551, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impressão";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(212, 19);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(68, 68);
            this.btnEnviarEmail.TabIndex = 15;
            this.btnEnviarEmail.Text = "Enviar e-mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(114, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 31);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(114, 56);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(92, 31);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(8, 56);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(100, 31);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(8, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 31);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveConfig);
            this.groupBox3.Controls.Add(this.btnExtrairNRecibo);
            this.groupBox3.Controls.Add(this.btnConsultarConfigUF);
            this.groupBox3.Controls.Add(this.btnLoadConfig);
            this.groupBox3.Controls.Add(this.btnConfigIni);
            this.groupBox3.Controls.Add(this.btnBuscarXML);
            this.groupBox3.Controls.Add(this.btnEmitirGuia);
            this.groupBox3.Controls.Add(this.btnConsultarRecibo);
            this.groupBox3.Location = new System.Drawing.Point(551, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 146);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Métodos";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(178, 17);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(79, 35);
            this.btnSaveConfig.TabIndex = 14;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnExtrairNRecibo
            // 
            this.btnExtrairNRecibo.Location = new System.Drawing.Point(178, 60);
            this.btnExtrairNRecibo.Name = "btnExtrairNRecibo";
            this.btnExtrairNRecibo.Size = new System.Drawing.Size(79, 35);
            this.btnExtrairNRecibo.TabIndex = 13;
            this.btnExtrairNRecibo.Text = "Extrair Nº Recibo";
            this.btnExtrairNRecibo.UseVisualStyleBackColor = true;
            this.btnExtrairNRecibo.Click += new System.EventHandler(this.btnExtrairNRecibo_Click);
            // 
            // btnConsultarConfigUF
            // 
            this.btnConsultarConfigUF.Location = new System.Drawing.Point(93, 99);
            this.btnConsultarConfigUF.Name = "btnConsultarConfigUF";
            this.btnConsultarConfigUF.Size = new System.Drawing.Size(79, 35);
            this.btnConsultarConfigUF.TabIndex = 12;
            this.btnConsultarConfigUF.Text = "Consultar Config UF";
            this.btnConsultarConfigUF.UseVisualStyleBackColor = true;
            this.btnConsultarConfigUF.Click += new System.EventHandler(this.btnConsultarConfigUF_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(93, 18);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(79, 33);
            this.btnLoadConfig.TabIndex = 11;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConfigIni
            // 
            this.btnConfigIni.Location = new System.Drawing.Point(8, 17);
            this.btnConfigIni.Name = "btnConfigIni";
            this.btnConfigIni.Size = new System.Drawing.Size(79, 35);
            this.btnConfigIni.TabIndex = 10;
            this.btnConfigIni.Text = "Configurar .INI";
            this.btnConfigIni.UseVisualStyleBackColor = true;
            this.btnConfigIni.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(245, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(298, 18);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Guia de Recolhimento Nacional Eletrnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormGnrePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(847, 456);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mmoXML);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCertificado);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGnrePrincipal";
            this.Text = "Demo GNR-e";
            this.Load += new System.EventHandler(this.FormGnrePrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCertificado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox mmoXML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmitirGuia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarXML;
        private System.Windows.Forms.Button btnConsultarRecibo;
        private System.Windows.Forms.TextBox tbReciboGnre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileSearch;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnExtrairNRecibo;
        private System.Windows.Forms.Button btnConsultarConfigUF;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnConfigIni;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.Label label2;
    }
}

