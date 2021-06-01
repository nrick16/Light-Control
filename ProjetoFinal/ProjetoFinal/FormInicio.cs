using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            if (!Funcionario.cargo.Equals("Administrador"))
            {
                btnUsuarios.Visible = false;
                
            }
            lblUsuario.Text = "Bem-vindo, " + Funcionario.nome + "!";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario NewForm = new FormUsuario();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormSolicitacoes form_produtos = new FormSolicitacoes();
            form_produtos.Show();
            this.Dispose(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {   
            FormLogin form_produtos = new FormLogin();
            form_produtos.Show();
            this.Dispose(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToLongDateString();
        }
    }
}
