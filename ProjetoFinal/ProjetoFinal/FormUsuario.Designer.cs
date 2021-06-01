
namespace ProjetoFinal
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.ComboBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(153, 90);
            this.txtmatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(146, 27);
            this.txtmatricula.TabIndex = 6;
            this.txtmatricula.TextChanged += new System.EventHandler(this.txtmatricula_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(153, 120);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(146, 27);
            this.txtnome.TabIndex = 7;
            // 
            // txtcargo
            // 
            this.txtcargo.FormattingEnabled = true;
            this.txtcargo.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.txtcargo.Location = new System.Drawing.Point(358, 87);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(146, 28);
            this.txtcargo.TabIndex = 8;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(358, 118);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(146, 27);
            this.txtsenha.TabIndex = 9;
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado"});
            this.txtstatus.Location = new System.Drawing.Point(571, 86);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(146, 28);
            this.txtstatus.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(571, 117);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 27);
            this.txtemail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(234, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gerenciamento de Usuários";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(234, 179);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 27);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(517, 179);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(328, 179);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 27);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Novo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(423, 179);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 27);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(32, 231);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 62;
            this.dgvUsuario.RowTemplate.Height = 33;
            this.dgvUsuario.Size = new System.Drawing.Size(775, 262);
            this.dgvUsuario.TabIndex = 18;
            this.dgvUsuario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEnter);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(10, 10);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 27);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-373, -165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1584, 834);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 504);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox txtcargo;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}