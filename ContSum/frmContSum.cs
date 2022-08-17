using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContSum
{
    public partial class lblEntreComValores : Form
    {
        public List<int> ListaNumerica { get; set; } = new();
        public lblEntreComValores()
        {
            InitializeComponent();
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O ContSum um sistema que realiza contagem de números positivos e a soma de números negativos. Não consideramos 0 um valor positivo, nem negativo. ");
        }

        private void btnInserirNaLista_Click(object sender, EventArgs e)
        {
            if(validaNumero(txbEntradaNumero.Text))
            {
                int valor = int.Parse(txbEntradaNumero.Text);
                lbListaNumerica.Items.Add(valor);
                ListaNumerica.Add(valor);
            }
            else
            {
                MessageBox.Show("Apenas numeros inteiros são validos. ");
            }

            txbEntradaNumero.Text = String.Empty;

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lblContPositivos.Visible = true;
            lblResultadoContPositivos.Visible = true;
            lblSomaNegativos.Visible = true;
            lblSomaNegativos.Visible = true;
            lblResultadoSomaNegativos.Visible = true;
            btnResultado.Visible = false;
            btnLimpar.Visible = true;

            imprimeResultado(ListaNumerica, lblResultadoContPositivos, lblResultadoSomaNegativos);

           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblContPositivos.Visible = false;
            lblResultadoContPositivos.Visible = false;
            lblSomaNegativos.Visible = false;
            lblSomaNegativos.Visible = false;
            lblResultadoSomaNegativos.Visible = false;
            btnResultado.Visible = true;
            btnLimpar.Visible = false;

            ListaNumerica.Clear();
            lbListaNumerica.Items.Clear();
        }

        private bool validaNumero(string num)
        {
            bool resultado = false;

            Regex rx = new Regex(@"[0-9]");
          
                if(rx.IsMatch(num))
                {
                    resultado = true;    
                   
                }

            return resultado;
        }

        private int contPositivos(List<int> lista)
        {
            int resultado = 0;

            foreach(var item in lista)
            {
                if(item > 0)
                {
                    resultado++;
                }
            }

            return resultado;
        }
        
        private int somaNegativos(List<int> lista)
        {
            int resultado = 0;

            foreach (var item in lista)
            {
                if(item < 0)
                {
                    resultado += item;
                }
            }

            return resultado;
        }

        private void imprimeResultado(List<int> lista, Label resultadoContPositivos, Label resultadoSomaNegativos)
        {
            resultadoContPositivos.Text = contPositivos(lista).ToString();

            resultadoSomaNegativos.Text = somaNegativos(lista).ToString();
           
        }

      
    }
}
