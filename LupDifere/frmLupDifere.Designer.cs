namespace LupDifere
{
    partial class LupDifere
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LupDifere));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.btnInserirNaLista = new System.Windows.Forms.Button();
            this.txbEntradaNumero = new System.Windows.Forms.TextBox();
            this.lblPreenchaLista = new System.Windows.Forms.Label();
            this.lbListaNumerica = new System.Windows.Forms.ListBox();
            this.btnResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("VECTRO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(73, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lup\r\nDifere";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("VECTRO", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.Location = new System.Drawing.Point(12, 67);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(141, 26);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Encontrando a diferença\r\nentre o maior e o menor";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpar.Location = new System.Drawing.Point(239, 408);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(195, 34);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(255, 476);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 26);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "28";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.AutoSize = true;
            this.lblTituloResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloResultado.Location = new System.Drawing.Point(288, 456);
            this.lblTituloResultado.Name = "lblTituloResultado";
            this.lblTituloResultado.Size = new System.Drawing.Size(76, 20);
            this.lblTituloResultado.TabIndex = 17;
            this.lblTituloResultado.Text = "Resultado";
            this.lblTituloResultado.Visible = false;
            // 
            // btnInserirNaLista
            // 
            this.btnInserirNaLista.Location = new System.Drawing.Point(370, 132);
            this.btnInserirNaLista.Name = "btnInserirNaLista";
            this.btnInserirNaLista.Size = new System.Drawing.Size(64, 34);
            this.btnInserirNaLista.TabIndex = 16;
            this.btnInserirNaLista.Text = "Inserir";
            this.btnInserirNaLista.UseVisualStyleBackColor = true;
            this.btnInserirNaLista.Click += new System.EventHandler(this.btnInserirNaLista_Click);
            // 
            // txbEntradaNumero
            // 
            this.txbEntradaNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbEntradaNumero.Location = new System.Drawing.Point(210, 132);
            this.txbEntradaNumero.Multiline = true;
            this.txbEntradaNumero.Name = "txbEntradaNumero";
            this.txbEntradaNumero.Size = new System.Drawing.Size(154, 34);
            this.txbEntradaNumero.TabIndex = 15;
            // 
            // lblPreenchaLista
            // 
            this.lblPreenchaLista.AutoSize = true;
            this.lblPreenchaLista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreenchaLista.Location = new System.Drawing.Point(261, 108);
            this.lblPreenchaLista.Name = "lblPreenchaLista";
            this.lblPreenchaLista.Size = new System.Drawing.Size(122, 21);
            this.lblPreenchaLista.TabIndex = 14;
            this.lblPreenchaLista.Text = "Preencha a lista";
            // 
            // lbListaNumerica
            // 
            this.lbListaNumerica.FormattingEnabled = true;
            this.lbListaNumerica.ItemHeight = 15;
            this.lbListaNumerica.Location = new System.Drawing.Point(183, 173);
            this.lbListaNumerica.Name = "lbListaNumerica";
            this.lbListaNumerica.Size = new System.Drawing.Size(279, 229);
            this.lbListaNumerica.TabIndex = 13;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(225, 408);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(195, 34);
            this.btnResultado.TabIndex = 20;
            this.btnResultado.Text = "Calcular Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // LupDifere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(645, 570);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTituloResultado);
            this.Controls.Add(this.btnInserirNaLista);
            this.Controls.Add(this.txbEntradaNumero);
            this.Controls.Add(this.lblPreenchaLista);
            this.Controls.Add(this.lbListaNumerica);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "LupDifere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lup Difere";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnLimpar;
        private Label lblResultado;
        private Label lblTituloResultado;
        private Button btnInserirNaLista;
        private TextBox txbEntradaNumero;
        private Label lblPreenchaLista;
        private ListBox lbListaNumerica;
        private Button btnResultado;
    }
}