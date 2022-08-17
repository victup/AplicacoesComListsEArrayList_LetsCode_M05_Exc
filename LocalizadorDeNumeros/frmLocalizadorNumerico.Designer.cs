namespace LocalizadorDeNumeros
{
    partial class frmLocalizadorNumerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizadorNumerico));
            this.lblInsiraNumero = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbNumeroProcurado = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOpcLocalizarNumero = new System.Windows.Forms.Button();
            this.lblNumeroProcurado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsiraNumero
            // 
            this.lblInsiraNumero.AutoSize = true;
            this.lblInsiraNumero.Location = new System.Drawing.Point(192, 106);
            this.lblInsiraNumero.Name = "lblInsiraNumero";
            this.lblInsiraNumero.Size = new System.Drawing.Size(182, 15);
            this.lblInsiraNumero.TabIndex = 0;
            this.lblInsiraNumero.Text = "Acrescente Números na ArrayList";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(315, 124);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 35);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumero.Location = new System.Drawing.Point(176, 125);
            this.txbNumero.MaxLength = 10;
            this.txbNumero.Multiline = true;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(133, 34);
            this.txbNumero.TabIndex = 2;
            // 
            // txbNumeroProcurado
            // 
            this.txbNumeroProcurado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumeroProcurado.Location = new System.Drawing.Point(197, 126);
            this.txbNumeroProcurado.MaxLength = 10;
            this.txbNumeroProcurado.Multiline = true;
            this.txbNumeroProcurado.Name = "txbNumeroProcurado";
            this.txbNumeroProcurado.Size = new System.Drawing.Size(91, 34);
            this.txbNumeroProcurado.TabIndex = 3;
            this.txbNumeroProcurado.Visible = false;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(294, 126);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 34);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Visible = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 15;
            this.lbResultado.Location = new System.Drawing.Point(174, 189);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(224, 184);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Visible = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(4, 9);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(68, 60);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 6;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("xiaowei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(61, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 60);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Localizador\r\nNumerico";
            // 
            // btnOpcLocalizarNumero
            // 
            this.btnOpcLocalizarNumero.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOpcLocalizarNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpcLocalizarNumero.Location = new System.Drawing.Point(161, 165);
            this.btnOpcLocalizarNumero.Name = "btnOpcLocalizarNumero";
            this.btnOpcLocalizarNumero.Size = new System.Drawing.Size(244, 50);
            this.btnOpcLocalizarNumero.TabIndex = 8;
            this.btnOpcLocalizarNumero.Text = "Quero Localizar Um \r\nNumero Na Lista";
            this.btnOpcLocalizarNumero.UseVisualStyleBackColor = false;
            this.btnOpcLocalizarNumero.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeroProcurado
            // 
            this.lblNumeroProcurado.AutoSize = true;
            this.lblNumeroProcurado.Location = new System.Drawing.Point(153, 106);
            this.lblNumeroProcurado.Name = "lblNumeroProcurado";
            this.lblNumeroProcurado.Size = new System.Drawing.Size(260, 15);
            this.lblNumeroProcurado.TabIndex = 9;
            this.lblNumeroProcurado.Text = "Digite um número para trazer os seus endereços";
            this.lblNumeroProcurado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("xiaowei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(169, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(224, 16);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "O número se encontra nas posições: ";
            this.lblResultado.Visible = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Gold;
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReiniciar.Location = new System.Drawing.Point(209, 375);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(148, 37);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.Text = "Reiniciar Localizador";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // frmLocalizadorNumerico
            // 
            this.AcceptButton = this.btnOpcLocalizarNumero;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnOpcLocalizarNumero);
            this.Controls.Add(this.lblNumeroProcurado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txbNumeroProcurado);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblInsiraNumero);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.Name = "frmLocalizadorNumerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizador Numérico";
            this.Load += new System.EventHandler(this.frmLocalizadorNumerico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsiraNumero;
        private Button btnInserir;
        private TextBox txbNumero;
        private TextBox txbNumeroProcurado;
        private Button btnProcurar;
        private ListBox lbResultado;
        private PictureBox pctLogo;
        private Label lblTitulo;
        private Button btnOpcLocalizarNumero;
        private Label lblNumeroProcurado;
        private Label lblResultado;
        private Button btnReiniciar;
    }
}