using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizadorDeNumeros
{
    public partial class frmLocalizadorNumerico : Form
    {
        ArrayList Numeros { get; set; } = new ArrayList();

        public frmLocalizadorNumerico()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if(validaNumero(txbNumero.Text))
            {
                Numeros.Add(double.Parse(txbNumero.Text.Replace('.', ',')));
            }
            else
            {
                lblInsiraNumero.Text = "Valor inválido. Apenas numeros.";
            }

            txbNumero.Text = String.Empty;
             
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();    

            if(validaNumero(txbNumeroProcurado.Text))
            {
                retornaCoordenadaDoNumero(Numeros, double.Parse(txbNumeroProcurado.Text.Replace('.',',')), lbResultado);
                lblResultado.Visible = true;
                lbResultado.Visible = true;
                btnReiniciar.Visible = true;
               
            }
            else
            {
                lblNumeroProcurado.Text = "Valor inválido. Apenas numeros.";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbNumero.Text = String.Empty;
            btnOpcLocalizarNumero.Visible = false;

            lblInsiraNumero.Visible = false;
            txbNumero.Visible = false;
            btnInserir.Visible = false;
            lblNumeroProcurado.Visible = true;
            txbNumeroProcurado.Visible = true;
            btnProcurar.Visible = true;    
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Numeros.Clear();
            lblInsiraNumero.Visible = true;
            txbNumero.Visible = true;
            btnInserir.Visible = true;
            btnOpcLocalizarNumero.Visible = true;
            txbNumeroProcurado.Text = String.Empty;


            btnReiniciar.Visible = false;
            lblNumeroProcurado.Visible= false;
            txbNumeroProcurado.Visible= false;
            btnProcurar.Visible=false;
            lbResultado.Visible = false;
            lblResultado.Visible = false;
        }

        private void frmLocalizadorNumerico_Load(object sender, EventArgs e)
        {
            btnInserir.TabStop = false;
            btnOpcLocalizarNumero.TabStop = false;
            btnProcurar.TabStop = false;
            btnReiniciar.TabStop = false;
        }

        private void retornaCoordenadaDoNumero(ArrayList array, double numero, ListBox lista)
        {
            string coordenas = "";

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].Equals(numero))
                {
                    lista.Items.Add($"Posição: {i}");
                }
            }
        }

        private bool validaNumero(string valor)
        {
            string entrada = valor.Replace('.', ',');

            bool numeroValido = false;

            var entradaValida = new Regex(@"(\d{1,3}(\.|\d{3})*|\d+)");

            if (entradaValida.IsMatch(entrada))
            {

                numeroValido = true;
            }

            return numeroValido;
        }
    }
}
