
namespace ProjetoFinal
{
    partial class FormSolicitacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolicitacoes));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvSolicitacao = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCircuito = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTorre = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtAndar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAtividade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFuncional = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHora2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.ComboBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRelogio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(23, 17);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 27);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvSolicitacao
            // 
            this.dgvSolicitacao.AllowUserToAddRows = false;
            this.dgvSolicitacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacao.Location = new System.Drawing.Point(33, 267);
            this.dgvSolicitacao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSolicitacao.Name = "dgvSolicitacao";
            this.dgvSolicitacao.RowHeadersWidth = 62;
            this.dgvSolicitacao.RowTemplate.Height = 33;
            this.dgvSolicitacao.Size = new System.Drawing.Size(1244, 240);
            this.dgvSolicitacao.TabIndex = 36;
            this.dgvSolicitacao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(637, 234);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 27);
            this.btnExcluir.TabIndex = 82;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(542, 234);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 27);
            this.btnSalvar.TabIndex = 81;
            this.btnSalvar.Text = "Novo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(731, 234);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(448, 234);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 27);
            this.btnConsultar.TabIndex = 80;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCircuito
            // 
            this.txtCircuito.Location = new System.Drawing.Point(584, 92);
            this.txtCircuito.Margin = new System.Windows.Forms.Padding(2);
            this.txtCircuito.Name = "txtCircuito";
            this.txtCircuito.Size = new System.Drawing.Size(146, 27);
            this.txtCircuito.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(287, 51);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(105, 27);
            this.txtid.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Circuito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Torre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nº ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(417, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(443, 41);
            this.label8.TabIndex = 37;
            this.label8.Text = "Gerenciamento de Solicitações";
            // 
            // txtTorre
            // 
            this.txtTorre.FormattingEnabled = true;
            this.txtTorre.Items.AddRange(new object[] {
            "WMS",
            "AE",
            "Co",
            "OS",
            "EV",
            "CEA"});
            this.txtTorre.Location = new System.Drawing.Point(396, 155);
            this.txtTorre.Name = "txtTorre";
            this.txtTorre.Size = new System.Drawing.Size(103, 28);
            this.txtTorre.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(396, 124);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(103, 27);
            this.txtHora.TabIndex = 27;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(350, 127);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(42, 20);
            this.lblTimer.TabIndex = 41;
            this.lblTimer.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(396, 92);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(103, 27);
            this.txtData.TabIndex = 26;
            // 
            // txtAndar
            // 
            this.txtAndar.FormattingEnabled = true;
            this.txtAndar.Items.AddRange(new object[] {
            "15º",
            "14º",
            "13º",
            "12º",
            "11º",
            "10º",
            "9º",
            "8º",
            "7º",
            "6º",
            "5º",
            "4º",
            "3º",
            "2º",
            "2I",
            "1º",
            "1I",
            "0",
            "PM",
            "PT",
            "PG",
            "1ºSS",
            "2ºSS",
            "3ºSS",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "-7"});
            this.txtAndar.Location = new System.Drawing.Point(396, 187);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(103, 28);
            this.txtAndar.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Andar";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(584, 124);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 27);
            this.txtUsuario.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Usuario";
            // 
            // txtAtividade
            // 
            this.txtAtividade.Location = new System.Drawing.Point(584, 188);
            this.txtAtividade.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(146, 27);
            this.txtAtividade.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Atividade";
            // 
            // txtFuncional
            // 
            this.txtFuncional.Location = new System.Drawing.Point(584, 156);
            this.txtFuncional.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncional.Name = "txtFuncional";
            this.txtFuncional.Size = new System.Drawing.Size(146, 27);
            this.txtFuncional.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 159);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Funcional";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(804, 191);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(146, 27);
            this.txtTempo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data 2";
            // 
            // txtHora2
            // 
            this.txtHora2.Location = new System.Drawing.Point(804, 127);
            this.txtHora2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHora2.Name = "txtHora2";
            this.txtHora2.Size = new System.Drawing.Size(146, 27);
            this.txtHora2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Hora 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(735, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.FormattingEnabled = true;
            this.txtEmpresa.Items.AddRange(new object[] {
            "ITAU",
            "CUSHMAN",
            "JOHNSON CONTROLS",
            ""});
            this.txtEmpresa.Location = new System.Drawing.Point(804, 94);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(146, 28);
            this.txtEmpresa.TabIndex = 34;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(804, 160);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(146, 27);
            this.txtData2.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-65, -153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1584, 834);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // txtRelogio
            // 
            this.txtRelogio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRelogio.Location = new System.Drawing.Point(417, 54);
            this.txtRelogio.Margin = new System.Windows.Forms.Padding(2);
            this.txtRelogio.Name = "txtRelogio";
            this.txtRelogio.Size = new System.Drawing.Size(443, 30);
            this.txtRelogio.TabIndex = 85;
            // 
            // FormSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 518);
            this.Controls.Add(this.txtRelogio);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHora2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAtividade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFuncional);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtTorre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSolicitacao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCircuito);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSolicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvSolicitacao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCircuito;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtTorre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox txtAndar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAtividade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFuncional;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtEmpresa;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtRelogio;
    }
}