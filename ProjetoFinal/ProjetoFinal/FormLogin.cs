using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoFinal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string sql = "select * from funcionario where matricula='"+ txtUsuario.Text +"' and senha='" + txtSenha.Text + "'";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                Funcionario.matricula = 0;
                Funcionario.nome = "";
                Funcionario.cargo = "";
                Funcionario.status = "";
                Funcionario.email = "";
                if (dr.Read())
                {
                    Funcionario.matricula = (int) dr["matricula"];
                    Funcionario.nome = (String) dr["nome"];
                    Funcionario.cargo = (String) dr["cargo"];
                    Funcionario.status = (String) dr["status"];
                    Funcionario.email = (String) dr["email"];
                }
                comm.Dispose();
                conn.Close();
                if (Funcionario.matricula==0)
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }
                else if (Funcionario.status.Equals("Bloqueado"))
                {
                    MessageBox.Show("Usuário bloqueado pelo administrador!");
                }
                else { 
                    FormInicio NewForm = new FormInicio();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
    }
}
