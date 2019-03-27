using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemonstracaoGNRE_C_Sharp
{
    public partial class FormEmail : Form
    {
        private string _Recibo;

        FormGnrePrincipal FormPrincipal = new FormGnrePrincipal(); 
        
        public FormEmail(string _Recibo)
        {
            InitializeComponent();
            this._Recibo = _Recibo;
            tbProtocoloRNRe.Text = _Recibo;            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormEmail_Load(object sender, EventArgs e)
        {
            if (FormPrincipal._spdGNReX.ServidorSmtp != null)
            {
                tbSMTP.Text = FormPrincipal._spdGNReX.ServidorSmtp;
                tbEmailRemetente.Text = FormPrincipal._spdGNReX.EmailRemetente;
                tbUsuario.Text = FormPrincipal._spdGNReX.UsuarioEmail;
                tbSenha.Text = FormPrincipal._spdGNReX.SenhaEmail;
                tbEmailDestinatario.Text = FormPrincipal._spdGNReX.EmailDestinatario;
                tbAssunto.Text = FormPrincipal._spdGNReX.AssuntoEmail;
                tbTextoEmail.Text = FormPrincipal._spdGNReX.MensagemEmail;
                tbPorta.Text = FormPrincipal._spdGNReX.PortaEmail.ToString();
                tbTimeOut.Text = FormPrincipal._spdGNReX.TimeOut.ToString();

                if (FormPrincipal._spdGNReX.AutenticacaoEmail == true)
                {
                    cbAutenticacao.Checked = true;
                }
                else
                {
                    cbAutenticacao.Checked = false;
                }

                if (FormPrincipal._spdGNReX.ConteudoHtmlEmail == true)
                {
                    cbComHTML.Checked = true;
                }
                else
                {
                    cbComHTML.Checked = false;
                }
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (_Recibo == "")
            {
                MessageBox.Show("Informe o Número do recibo! ");
            }
            else
            {
                FormPrincipal._spdGNReX.ServidorSmtp = tbSMTP.Text;
                FormPrincipal._spdGNReX.EmailRemetente = tbEmailRemetente.Text;
                FormPrincipal._spdGNReX.UsuarioEmail = tbUsuario.Text;
                FormPrincipal._spdGNReX.SenhaEmail = tbSenha.Text;
                FormPrincipal._spdGNReX.EmailDestinatario = tbEmailDestinatario.Text;
                FormPrincipal._spdGNReX.AssuntoEmail = tbAssunto.Text;
                FormPrincipal._spdGNReX.MensagemEmail = tbTextoEmail.Text;
                FormPrincipal._spdGNReX.PortaEmail = Convert.ToInt32(tbPorta.Text);
                FormPrincipal._spdGNReX.TimeOut = Convert.ToInt32(tbTimeOut.Text);

                if (cbAutenticacao.Checked == true)
                {
                    FormPrincipal._spdGNReX.AutenticacaoEmail = true;
                }
                else
                {
                    FormPrincipal._spdGNReX.AutenticacaoEmail = false;
                }

                if (cbComHTML.Checked == true)
                {
                    FormPrincipal._spdGNReX.ConteudoHtmlEmail = true;
                }
                else
                {
                    FormPrincipal._spdGNReX.ConteudoHtmlEmail = false;
                }

           // https://ciranda.me/tsdn/base-de-conhecimento/post/componente-gnre-enviar-guia-por-email
                FormPrincipal._spdGNReX.EnviarEmailGnre(tbProtocoloRNRe.Text, tbEmailDestinatario.Text);
            }
        }
    }
}
