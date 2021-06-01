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
    public partial class FormSolicitacoes : Form
    {
        public FormSolicitacoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicio NewForm = new FormInicio();
            NewForm.Show();
            this.Dispose(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRelogio.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToLongDateString();

        }
        //DateTime horario1, horario2;
        //TimeSpan tempo;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (btnSalvar.Text == "Novo")
            {
                btnSalvar.Text = "Salvar";
                txtid.Enabled = false;
                txtid.Text = "";
                btnConsultar.Enabled = false;
                txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
                txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
                /*
                txtHora2.Text = "00:00:00";
                horario1 = DateTime.Parse(txtHora.Text + txtData.Text);
                horario2 = DateTime.Parse(txtHora2.Text + txtData2.Text);
                tempo = horario2 - horario1;

                txtTempo.Text = Convert.ToString(tempo);
                */
                return;
            }
            btnConsultar.Enabled = true;
            
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=crud3manha");
                String sql = "";
                if (txtid.Text == "")
                {
                    sql = "INSERT INTO `solicitacao` (`id`, `data`, `hora`, `torre`, `andar`, `circuito`, `usuario`, `funcional`, `atividade`, `empresa`, `hora2`, `data2`, `tempo`) VALUES (NULL, '" + txtData.Text + "', '" + txtHora.Text + "', '" + txtTorre.Text + "', '" + txtAndar.Text + "', '" + txtCircuito.Text + "', '" + txtUsuario.Text + "', '" + txtFuncional.Text + "', '" + txtAtividade.Text + "', '" + txtEmpresa.Text + "', '" + txtHora2.Text + "', '" + txtData2.Text + "', '" + txtTempo.Text + "');";
                }
                else
                {
                    sql = "update solicitacao set data='" + txtData.Text + "',hora='" + txtHora.Text + "',torre='" + txtTorre.Text + "',andar='" + txtAndar.Text + "',circuito='" + txtCircuito.Text + "',usuario='" + txtUsuario.Text + "',funcional='" + txtFuncional.Text + "',atividade='" + txtAtividade.Text + "',empresa='" + txtEmpresa.Text + "',hora2='" + txtHora2.Text + "',data2='" + txtData2.Text + "',tempo='" + txtTempo.Text + "' where id=" + txtid.Text;
                }
                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                MessageBox.Show("Registro salvo com sucesso!");

                btnConsultar_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Solicitação");
            dt.Columns.Add("Data");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Torre");
            dt.Columns.Add("Andar");
            dt.Columns.Add("Circuito");
            dt.Columns.Add("Usuário");
            dt.Columns.Add("Funcional");
            dt.Columns.Add("Atividade");
            dt.Columns.Add("Empresa");
            dt.Columns.Add("Hora_Termino");
            dt.Columns.Add("Data_Termino");
            dt.Columns.Add("Tempo");

            

            DataRow row;

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string sql = "select * from solicitacao";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    row = dt.NewRow();
                    row["Solicitação"] = dr["id"];
                    row["data"] = dr["data"];
                    row["hora"] = dr["hora"];
                    row["Torre"] = dr["torre"];
                    row["Andar"] = dr["andar"];
                    row["Circuito"] = dr["circuito"];
                    row["Usuário"] = dr["usuario"];
                    row["funcional"] = dr["funcional"];
                    row["Atividade"] = dr["atividade"];
                    row["Empresa"] = dr["empresa"];
                    row["Hora_Termino"] = dr["hora2"];
                    row["Data_Termino"] = dr["data2"];
                    row["Tempo"] = dr["tempo"];
                    dt.Rows.Add(row);
                }

                dgvSolicitacao.DataSource = dt;

                comm.Dispose();
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    btnSalvar.Text = "Salvar";
                    txtid.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
            dgvSolicitacao.DataSource = dt;
        }

        private void CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtv = (DataGridView)sender;
            if (dtv.CurrentRow != null)
            {
                btnExcluir.Enabled = true;
                txtid.Text = (string)dtv.CurrentRow.Cells[0].Value;
                txtData.Text = (string)dtv.CurrentRow.Cells[1].Value;
                txtHora.Text = (string)dtv.CurrentRow.Cells[2].Value;
                txtTorre.Text = (string)dtv.CurrentRow.Cells[3].Value;
                txtAndar.Text = (string)dtv.CurrentRow.Cells[4].Value;
                txtCircuito.Text = (string)dtv.CurrentRow.Cells[5].Value;
                txtUsuario.Text = (string)dtv.CurrentRow.Cells[6].Value;
                txtFuncional.Text = (string)dtv.CurrentRow.Cells[7].Value;
                txtAtividade.Text = (string)dtv.CurrentRow.Cells[8].Value;
                txtEmpresa.Text = (string)dtv.CurrentRow.Cells[9].Value;
                txtHora2.Text = (string)dtv.CurrentRow.Cells[10].Value;
                txtData2.Text = (string)dtv.CurrentRow.Cells[11].Value;
                txtTempo.Text = (string)dtv.CurrentRow.Cells[12].Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormSolicitacoes NewForm = new FormSolicitacoes();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=crud3manha");
                String sql = "";
                if (txtid.Text != "")
                {
                    sql = "delete from solicitacao where id=" + txtid.Text;
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
    }
}
