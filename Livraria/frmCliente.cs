using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class frmCliente : UserControl
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void desabilitaCampos()
        {
            //[Enabled] é para abilitar o campo, como esta falso desabilita
            lblCodigo.Visible = false;
            lbl_CodCli.Visible = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskFone.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            cboPessoa.Enabled = false;
            mskCep.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            mskCpf.Enabled = false;
            cboUf.Enabled = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            lblCnpj.Enabled = false;
            mskCnpj.Enabled = false;
        }
        private void habilitaCampos()
        {
            lblCodigo.Visible = false;
            lbl_CodCli.Visible = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskFone.Enabled = true;
            cboPessoa.Enabled = true;
            mskCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            mskCpf.Enabled = true;
            cboUf.Enabled = true;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            lblCnpj.Enabled = true;
            mskCnpj.Enabled = true;
        }
        private void limparCampos()
        {
            // txtNome.=""; vai falar para deixar vazio, a mesma coisa vale para o txtLogin.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskFone.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            mskCpf.Clear();
            cboPessoa.SelectedIndex = -1; //-1 = ao não marcado
            cboUf.SelectedIndex = -1; //-1 = ao não marcado
            txtBuscaCli.Clear();
            dgvCliente.DataSource = null;
            rdbAtivo.Checked = true;
            lblCodigo.Visible = false;
            lbl_CodCli.Visible = false;
        }

        private void manipularDados()
        {
            
        }


        private void cboPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPessoa.SelectedIndex == -1)//se não houver nada selecionado
            {
                lblCnpj.Visible = false;
                mskCnpj.Visible = false;
            }
            else if (cboPessoa.SelectedIndex == -0)//se estiver selecionado pessoa Física 
            {
                lblCnpj.Visible = false;
                mskCnpj.Visible = false;
            }
            else //se não vai está selecionado pessoa juridica
            {
                lblCnpj.Visible = true;
                mskCnpj.Visible = true;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }
    }
}
