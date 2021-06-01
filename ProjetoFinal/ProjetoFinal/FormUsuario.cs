using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Novo")
            {
                btnSalvar.Text = "Salvar";
                txtmatricula.Enabled = false;
                txtmatricula.Text = "";
                btnConsultar.Enabled = false;
                return;
            }
            btnConsultar.Enabled = true;
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=crud3manha");
                String sql = "";
                if (txtmatricula.Text == ""){
                    sql = "INSERT INTO `funcionario` (`matricula`, `nome`, `cargo`, `status`, `email`, `senha`) VALUES (NULL, '" + txtnome.Text + "', '" + txtcargo.Text + "', '" + txtstatus.Text + "', '" + txtemail.Text + "', '" + txtsenha.Text + "');";
                }
                else
                {
                    sql = "update funcionario set nome='" + txtnome.Text + "',cargo='" + txtcargo.Text + "',status='" + txtstatus.Text + "',email='" + txtemail.Text + "',senha='" + txtsenha.Text + "' where matricula=" + txtmatricula.Text;
                }
                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                MessageBox.Show("Registro salvo com sucesso!");

                btnConsultar_Click(null,null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Senha";
            column.AutoIncrement = false;
            column.Caption = "Senha";
            column.ReadOnly = false;
            column.Unique = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("matricula");
            dt.Columns.Add("nome");
            dt.Columns.Add("cargo");
            dt.Columns.Add("status");
            dt.Columns.Add("email");
            dt.Columns.Add(column);

            DataRow row;

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string sql = "select * from funcionario";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    row = dt.NewRow();
                    row["matricula"] = dr["matricula"];
                    row["nome"] = dr["nome"];
                    row["cargo"] = dr["cargo"];
                    row["status"] = dr["status"];
                    row["email"] = dr["email"];
                    row["senha"] = dr["senha"];
                    dt.Rows.Add(row);
                }

                dgvUsuario.DataSource = dt;

                comm.Dispose();
                conn.Close();
                if (dt.Rows.Count > 0){
                    btnSalvar.Text = "Salvar";
                    txtmatricula.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
            dgvUsuario.DataSource = dt;
        }

        private void CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtv = (DataGridView)sender;
            if (dtv.CurrentRow != null)
            {
                btnExcluir.Enabled = true;
                txtmatricula.Text = (string)dtv.CurrentRow.Cells[0].Value;
                txtnome.Text = (string)dtv.CurrentRow.Cells[1].Value;
                txtcargo.Text = (string)dtv.CurrentRow.Cells[2].Value;
                txtstatus.Text = (string)dtv.CurrentRow.Cells[3].Value;
                txtemail.Text = (string)dtv.CurrentRow.Cells[4].Value;
                //txtsenha.Text = (string)dtv.CurrentRow.Cells[5].Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   
            FormUsuario NewForm = new FormUsuario();
            NewForm.Show();
            this.Dispose(false);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=crud3manha");
                String sql = "";
                if (txtmatricula.Text != "")
                {
                    sql = "delete from funcionario where matricula=" + txtmatricula.Text;
                }
                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                MessageBox.Show("Registro excluido com sucesso!");

                btnConsultar_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicio NewForm = new FormInicio();
            NewForm.Show();
            this.Dispose(false);
        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
