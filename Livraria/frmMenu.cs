using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //[Login telaLogin = new Login();] instanciando a janela caso o clique no botão sair dai fecha o programa e  abre o Login 
            Login telaLogin = new Login();
            //[telaLogin.Show();] chamando para abrir Login
            telaLogin.Show();
            //[this.Hide();] ocultar a janela que estava aberta
            this.Hide();
        }

        private void pneMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //quando logar e ir para o frmMenu, vai carregar no lblusuarioLogado a informação que foi dada do login do usuario logado
            lblusuarioLogado.Text = Login.usuario;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente1.BringToFront();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmAtendente1.BringToFront();
        }
    }
}
