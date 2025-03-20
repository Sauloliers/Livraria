using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Livraria
{
    public partial class frmAtendente : UserControl
    {
        public frmAtendente()
        {
            InitializeComponent();
        }
        //Estabelecendo Conexão com banco de dados sql server e instanciando [SqlConnection cn = new SqlConnection();]
        //abaixo falo [@"Data Source=SAULOLIERS\SQLEXPRESS;"] Data Source= logo apos o endereço [integrated security=SSPI] informa que estou usando autenticação do windons ou se não poderia ser atraves de usuario e senha mas não é o caso
        //[initial Catalog=db_livraria] o banco de dados que estou usando -[SqlConnection]-
        SqlConnection cn = new SqlConnection(@"Data Source=SAULOLIERS\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_livraria");

        //[SqlCommand] classe objeto disponível para enviar as instruções(selec, insert,update, delete, etc)
        ////SqlCommand cm = new SqlCommand(); foi posto la em baixo
        //[SqlDataReader] responsavel por receber os dados de uma tabela após execução de um select
        SqlDataReader dt;
        private void desabilitaCampos()
        {
            //[Enabled] é para abilitar o campo, como esta falso desabilita
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnGravar.Enabled = false;  
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
        }
        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();

        }
        private void limparCampos()
        {
            // txtNome.=""; vai falar para deixar vazio, a mesma coisa vale para o txtLogin.Clear();
            txtNome.Text = "";
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Focus();
        }
        private void frmAtendente_Load(object sender, EventArgs e)
        {
            //quando carregar o formulario frmAtendente ele ira chamar a função desabilitaCampo.
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório infoemar o campo NOME.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório infoemar o campo LOGIN.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório infoemar o campo SENHA.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            //[else if (txtSenha.Text.Length < 8)] se o tiver menos de 8 caracteres vai dar mensagem
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo SENHA deve conter no mínimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else 
            {
                try
                {
                    //criamos 3 variáveis para receber o conteúdo dos txt
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    //fazendo um insert into gravando atendente
                    string sql = "insert into tbl_atendente(ds_Login, ds_Senha,nm_Atendente) values(@login,@senha,@atendente)";

                    //(sql,cn) fala que quero executar sql na connection cn ou seja o cn fica valando que está no comando sql que por si joga na conexão aberta com o banco de dados la em cima
                    SqlCommand cm = new SqlCommand(sql, cn);

                    //atribuindo valores
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;

                    //abrindo conexão
                    cn.Open();
                    //[ExecuteNonQuery();] vai executar sem consulta só vai inserir(mas ela faz select, insert, delete, update etc)
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram gravados com sucesso!!!", "Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                catch (Exception erro)
                {
                    //mensagem para o desenvolvedor pois é problema tecnico
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
