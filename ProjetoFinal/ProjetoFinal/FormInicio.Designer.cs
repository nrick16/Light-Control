
namespace ProjetoFinal
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutos.Location = new System.Drawing.Point(415, 218);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(109, 27);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Solicitações";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.Location = new System.Drawing.Point(415, 187);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(109, 27);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(415, 269);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 27);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(288, 107);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(18, 25);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(275, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(299, 341);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(24, 18);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "00";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 458);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
    }
}