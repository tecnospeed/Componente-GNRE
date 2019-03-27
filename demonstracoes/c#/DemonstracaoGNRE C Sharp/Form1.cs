using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GnreX;
using System.Xml;
using System.IO;

namespace DemonstracaoGNRE_C_Sharp
{
    public partial class FormGnrePrincipal : Form
    {
        XmlDocument xDoc = new XmlDocument();

        public GnreX.spdGnreX _spdGNReX = new GnreX.spdGnreX();
        string UFDest, _Recibo;
        public FormGnrePrincipal()
        {
            InitializeComponent();

            _spdGNReX.LoadConfig(Application.StartupPath + @"\gnreConfig.ini");
            cbbCertificado.Text = _spdGNReX.NomeCertificado;      

            string[] certVet = _spdGNReX.ListarCertificados("|").Split('|');
            cbbCertificado.Items.Clear();

            for (int i = 0; i < certVet.Length; i++)
            {
                cbbCertificado.Items.Add(certVet[i]);
            }            
        }

        private void TratarExcecao(Exception ex)
        {
            MessageBox.Show(ex.Message, "Aviso: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmitirGuia_Click(object sender, EventArgs e)
        {
           try
           {//https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-enviar-guia
                if (mmoXML.Text == "")
                {
                    MessageBox.Show("Informe um XML!");
                }
                else
                {
                    xDoc.LoadXml(mmoXML.Text);                    
                    mmoXML.Text = _spdGNReX.EnviarGuia(mmoXML.Text, Application.StartupPath + @"\TX2Complementar.TX2","");//Envia a GNRe com o XMLDestinatário da NFe e o TX2
                    
                  //  mmoXML.Text = _spdGNReX.EnviarGuia(mmoXML.Text,  "");//Envia a GNRe com o XMLDestinatário da NFe e sem o TX2 Complementar
               
                    tbReciboGnre.Text = _spdGNReX.ExtrairNumeroRecibo(mmoXML.Text);  //Captura o protocolo da GNRe
                }
            }
            catch(Exception ex)
            {
                TratarExcecao(ex);
            }
        }

        private void FormGnrePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarXML_Click(object sender, EventArgs e)
        {
            openFileSearch.InitialDirectory = Application.StartupPath;
            openFileSearch.FileName = "";
            openFileSearch.ShowDialog();
            if (System.IO.File.Exists(openFileSearch.FileName))
            {
                mmoXML.Text = System.IO.File.ReadAllText(openFileSearch.FileName);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbCertificado.Items.Clear();
            mmoXML.Text = "";            
            tbReciboGnre.Text = "";
            tbUF.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {//https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-imprimir-gnre
            try
            {
                string GnrAutorizada = System.IO.File.ReadAllText(_spdGNReX.DiretorioXmlGnre + tbReciboGnre.Text + "-gnre.xml");
                _spdGNReX.ImprimirGnre(GnrAutorizada, _spdGNReX.DiretorioTemplates + @"\Impressao\gnre.rtm","","");
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            }
        }

        private void btnConsultarRecibo_Click(object sender, EventArgs e)
        {
            //https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-consultar-recibo
          string teste = _spdGNReX.ConsultaReciboGuia(tbReciboGnre.Text, UFDest,"");
        }

        private void mmoXML_TextChanged(object sender, EventArgs e)
        {
            try
            {
            //Captura dados XML e UF
            XmlDocument xmlDest = new XmlDocument();
            xmlDest.LoadXml(mmoXML.Text);          
                UFDest = xmlDest.GetElementsByTagName("UF").Item(0).InnerText;
                tbUF.Text = UFDest;
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
           Process.Start(@System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\", "//").Remove(0, 7) + "//gnreConfig.ini");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-carregar-configuracoes
            _spdGNReX.LoadConfig(Application.StartupPath + @"\gnreConfig.ini");            
            cbbCertificado.Text = _spdGNReX.NomeCertificado;               
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            //https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-salvar-configuracoes
            _spdGNReX.SaveConfig(Application.StartupPath + @"\gnreConfig.ini");
        }

        private void btnExtrairNRecibo_Click(object sender, EventArgs e)
        {
            //https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-extrair-numero-do-recibo
            tbReciboGnre.Text = _spdGNReX.ExtrairNumeroRecibo(mmoXML.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ciranda.me/tsdn/base-de-conhecimento/post/manual-do-componente-gnre");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tecnospeed.mysuite.com.br/client/chatan.php");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {//https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-visualizar-gnre
            try
            {
                string GnrAutorizada = System.IO.File.ReadAllText(_spdGNReX.DiretorioXmlGnre + tbReciboGnre.Text + "-gnre.xml");
                _spdGNReX.VisualizarGnre(GnrAutorizada, _spdGNReX.DiretorioTemplates + @"\Impressao\gnre.rtm","");
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            }            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {//https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-editar-modelo-de-impressao
            try
            {
                string GnrAutorizada = System.IO.File.ReadAllText(_spdGNReX.DiretorioXmlGnre + tbReciboGnre.Text + "-gnre.xml");
                _spdGNReX.EditarModeloImpressao(GnrAutorizada, _spdGNReX.DiretorioTemplates + @"\Impressao\gnre.rtm","");
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            } 
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {//https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-exportar-gnre
            try
            {
                string GnrAutorizada = System.IO.File.ReadAllText(_spdGNReX.DiretorioXmlGnre + tbReciboGnre.Text + "-gnre.xml");
                _spdGNReX.ExportarGnre(GnrAutorizada, _spdGNReX.DiretorioTemplates + @"\Impressao\gnre.rtm", 
                                                  Application.StartupPath + @"\Impressoes\" + tbReciboGnre.Text + "-gnre.PDF","" );
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            } 
        }

        private void btnConsultarConfigUF_Click(object sender, EventArgs e)
        {
            //https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-consultar-configuracao-da-uf
            mmoXML.Text = _spdGNReX.ConsultaConfigUf(tbUF.Text);
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {//Método que chama o Form de envio de e-mail e já passa o número do Recibo como parâmetro.
            _Recibo = tbReciboGnre.Text;
            FormEmail newForm = new FormEmail(_Recibo);
            newForm.Show();
        }
    }
}
