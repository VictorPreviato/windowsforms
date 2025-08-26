namespace picturebox
{
    partial class frmPictureBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(12, 22);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(381, 151);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(12, 193);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(381, 143);
            this.pbCidade.TabIndex = 2;
            this.pbCidade.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Brown;
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.Gold;
            this.btnVerImagem.Location = new System.Drawing.Point(97, 361);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(224, 61);
            this.btnVerImagem.TabIndex = 3;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.Location = new System.Drawing.Point(434, 22);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(208, 229);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAnexarImagem.TabIndex = 4;
            this.pbAnexarImagem.TabStop = false;
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.Gold;
            this.btnAnexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.Color.Brown;
            this.btnAnexar.Location = new System.Drawing.Point(477, 269);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(143, 48);
            this.btnAnexar.TabIndex = 5;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.pbAnexarImagem);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pbComputador);
            this.Name = "frmPictureBox";
            this.Text = "PIcture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
        private System.Windows.Forms.Button btnAnexar;
    }
}

