namespace jogosdenumeros
{
    partial class frmJogodeNumeros
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnTentativas = new System.Windows.Forms.Button();
            this.lblAbaixoBotao = new System.Windows.Forms.Label();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Red;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 100);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(150, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Boas vindas ao meu jogo de números";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Red;
            this.lblSubtitulo.Location = new System.Drawing.Point(194, 119);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(412, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "10 tentativas! Insira um número de 1 até 100";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Location = new System.Drawing.Point(350, 155);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroInserido.TabIndex = 2;
            this.txtNumeroInserido.TextChanged += new System.EventHandler(this.txtNumeroInserido_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(193, 396);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(414, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // btnTentativas
            // 
            this.btnTentativas.BackColor = System.Drawing.Color.Red;
            this.btnTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativas.ForeColor = System.Drawing.Color.White;
            this.btnTentativas.Location = new System.Drawing.Point(312, 213);
            this.btnTentativas.Name = "btnTentativas";
            this.btnTentativas.Size = new System.Drawing.Size(176, 67);
            this.btnTentativas.TabIndex = 5;
            this.btnTentativas.Text = "Tentar";
            this.btnTentativas.UseVisualStyleBackColor = false;
            this.btnTentativas.Click += new System.EventHandler(this.btnTentativas_Click);
            // 
            // lblAbaixoBotao
            // 
            this.lblAbaixoBotao.AutoSize = true;
            this.lblAbaixoBotao.Location = new System.Drawing.Point(193, 365);
            this.lblAbaixoBotao.Name = "lblAbaixoBotao";
            this.lblAbaixoBotao.Size = new System.Drawing.Size(155, 13);
            this.lblAbaixoBotao.TabIndex = 2;
            this.lblAbaixoBotao.Text = "Veja quantas tentativas restam:";
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTentativas.Location = new System.Drawing.Point(354, 359);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(30, 24);
            this.lblNumeroTentativas.TabIndex = 6;
            this.lblNumeroTentativas.Text = "10";
            // 
            // frmJogodeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroTentativas);
            this.Controls.Add(this.lblAbaixoBotao);
            this.Controls.Add(this.btnTentativas);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmJogodeNumeros";
            this.Text = "Jogo de Números";
            this.Load += new System.EventHandler(this.frmJogodeNumeros_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnTentativas;
        private System.Windows.Forms.Label lblAbaixoBotao;
        private System.Windows.Forms.Label lblNumeroTentativas;
    }
}

