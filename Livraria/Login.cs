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
//using System.Data.SqlClient; vai permitir que faça a conexão com o banco de dados -[connection]-

namespace Livraria
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //criar duas variáveis statica para que possa usar em outros lugares(formularios)
        public static string usuario;
        public static string codUsuario;

        //Estabelecendo Conexão com banco de dados sql server e instanciando [SqlConnection cn = new SqlConnection();]
        //abaixo falo [@"Data Source=SAULOLIERS\SQLEXPRESS;"] Data Source= logo apos o endereço [integrated security=SSPI] informa que estou usando autenticação do windons ou se não poderia ser atraves de usuario e senha mas não é o caso
        //[initial Catalog=db_livraria] o banco de dados que estou usando -[SqlConnection]-
        SqlConnection cn = new SqlConnection(@"Data Source=SAULOLIERS\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_livraria");

        //[SqlCommand] classe objeto disponível para enviar as instruções(selec, insert,update, delete, etc)
        SqlCommand cm = new SqlCommand();
        //[SqlDataReader] responsavel por receber os dados de uma tabela após execução de um select
        //SqlDataReader dt; foi subistituido pelo SqlDataAdapter abaixo

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtSenha.Text == "")
            {
                //[MessageBox.Show] caixa de mensagem [,"Atenção!!"]Titulo [MessageBoxButtons.OK] butão da mensagem [MessageBoxIcon.Information] icone com logo de informação
                MessageBox.Show("Obrigatório preencher os campos login e senha!","Atenção!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //[cn.Open();] abrir uma coneção com o banco de dados
                    cn.Open();
                    //[cm.CommandText] vai fazer um comando de texto nesse caso um select onde a o login e a senha do banco de dados tem que ser igual ao login e senha digitada pelo usuario
                    //[where ds_Status = 1] pare se logar faz o select para confirmar se existe na tabela e where para o status para ver se esta ativo = "1" senão não loga
                    cm.CommandText = "select * from tbl_atendente where ds_Login= ('" + txtLogin.Text + "') and  ds_Senha =('" + txtSenha.Text + "') and ds_Status = 1";
                    //[cm.Connection = cn;] informa que esse comando de texto acima vai ser usado no cn
                    cm.Connection = cn;
                    //[dt = cm.ExecuteReader();] vai executar o comando cm, o momento em que vai fazer o select no banco e ele retorna na variável dt
                    //dt = cm.ExecuteReader(); foi substituido pelo SqlDataAdapter abaixo

                    //SqlDataAdapter classe (objeto) disponivel para receber os dados de uma tabela após a execução
                    //ele vai receber o comando de texto do cm
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    //[if (dt.HasRows)] pergunta se tem linhas na tabela

                    //para receber a tabela 
                    DataTable dt = new DataTable();

                    //da.Fill(dt); vai preencher o datatable com essa consulta
                    da.Fill(dt);

                    //if (dt.HasRows) seria usado com o camando SqlDataReader dt; mais ele foi substituido pelo SqlDataAdapter da = new SqlDataAdapter(cm);

                    if (dt.Rows.Count > 0) // a contagem de linhas no datatable é maior que zero? ou seja quando ele retornar uma informação do usuario que está logando e tem no banco de dados
                    {
                        //falando que se encontrar na linha [0] e 0 que é sempre o valor da primeira linha, vai falar para pegar e jogar na string usuario o nome do login
                        usuario = dt.Rows[0]["ds_Login"].ToString();
                        codUsuario = dt.Rows[0]["cd_Atendente"].ToString();
                        //[frmMenu menu = new frmMenu();] instanciando a janela caso o logon de certo abre o
                        frmMenu menu = new frmMenu();
                        //[menu.Show();] chamando para abrir frmMenu
                        menu.Show();
                        //[this.Hide();] ocultar a janela que está aberta
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Usuário ou senha inválidos!","Ocorreu erro!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        // [txtLogin.Clear(); txtSenha.Clear();] Clear faz limpesa dos texto para usuário digitar de novo
                        txtLogin.Clear();
                        txtSenha.Clear();
                        //[txtLogin.Focus();] foca o cursor na caixa login
                        txtLogin.Focus();
                    }
                }
                // [catch (Exception erro)] caso de algum erro vai mostra mensagem na tela
                catch (Exception erro)
                {
                    //[MessageBox.Show(erro.Message);]Mensagem para o programador encontrar erro caso ocorra
                    MessageBox.Show(erro.Message);
                    //[cn.Close();] vai fechar o programa
                    cn.Close();
                }
                finally
                {
                    //cn.Close();[finally] se tudo encima der errado e for por outro motivo ele fecha a conexão no finally
                    cn.Close();
                }

            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //[Application.Exit();] sair da app
            Application.Exit();
        }
    }
}
