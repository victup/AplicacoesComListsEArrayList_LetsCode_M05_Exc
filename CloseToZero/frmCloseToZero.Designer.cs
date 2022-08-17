namespace CloseToZero
{
    partial class frmCloseToZero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloseToZero));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.btnInserirNaLista = new System.Windows.Forms.Button();
            this.txbEntradaNumero = new System.Windows.Forms.TextBox();
            this.lblPreenchaLista = new System.Windows.Forms.Label();
            this.lbListaNumerica = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(191, 358);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(195, 34);
            this.btnResultado.TabIndex = 28;
            this.btnResultado.Text = "Calcular Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpar.Location = new System.Drawing.Point(205, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(195, 34);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(221, 426);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 26);
            this.lblResultado.TabIndex = 26;
            this.lblResultado.Text = "28";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.AutoSize = true;
            this.lblTituloResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloResultado.Location = new System.Drawing.Point(254, 406);
            this.lblTituloResultado.Name = "lblTituloResultado";
            this.lblTituloResultado.Size = new System.Drawing.Size(76, 20);
            this.lblTituloResultado.TabIndex = 25;
            this.lblTituloResultado.Text = "Resultado";
            this.lblTituloResultado.Visible = false;
            // 
            // btnInserirNaLista
            // 
            this.btnInserirNaLista.Location = new System.Drawing.Point(336, 82);
            this.btnInserirNaLista.Name = "btnInserirNaLista";
            this.btnInserirNaLista.Size = new System.Drawing.Size(64, 34);
            this.btnInserirNaLista.TabIndex = 24;
            this.btnInserirNaLista.Text = "Inserir";
            this.btnInserirNaLista.UseVisualStyleBackColor = true;
            this.btnInserirNaLista.Click += new System.EventHandler(this.btnInserirNaLista_Click);
            // 
            // txbEntradaNumero
            // 
            this.txbEntradaNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbEntradaNumero.Location = new System.Drawing.Point(176, 82);
            this.txbEntradaNumero.Multiline = true;
            this.txbEntradaNumero.Name = "txbEntradaNumero";
            this.txbEntradaNumero.Size = new System.Drawing.Size(154, 34);
            this.txbEntradaNumero.TabIndex = 23;
            // 
            // lblPreenchaLista
            // 
            this.lblPreenchaLista.AutoSize = true;
            this.lblPreenchaLista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreenchaLista.Location = new System.Drawing.Point(227, 58);
            this.lblPreenchaLista.Name = "lblPreenchaLista";
            this.lblPreenchaLista.Size = new System.Drawing.Size(122, 21);
            this.lblPreenchaLista.TabIndex = 22;
            this.lblPreenchaLista.Text = "Preencha a lista";
            // 
            // lbListaNumerica
            // 
            this.lbListaNumerica.FormattingEnabled = true;
            this.lbListaNumerica.ItemHeight = 15;
            this.lbListaNumerica.Location = new System.Drawing.Point(149, 123);
            this.lbListaNumerica.Name = "lbListaNumerica";
            this.lbListaNumerica.Size = new System.Drawing.Size(279, 229);
            this.lbListaNumerica.TabIndex = 21;
            // 
            // frmCloseToZero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(577, 477);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTituloResultado);
            this.Controls.Add(this.btnInserirNaLista);
            this.Controls.Add(this.txbEntradaNumero);
            this.Controls.Add(this.lblPreenchaLista);
            this.Controls.Add(this.lbListaNumerica);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "frmCloseToZero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close To Zero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnResultado;
        private Button btnLimpar;
        private Label lblResultado;
        private Label lblTituloResultado;
        private Button btnInserirNaLista;
        private TextBox txbEntradaNumero;
        private Label lblPreenchaLista;
        private ListBox lbListaNumerica;
    }
}