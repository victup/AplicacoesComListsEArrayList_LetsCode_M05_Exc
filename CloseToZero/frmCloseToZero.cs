using System.Text.RegularExpressions;

namespace CloseToZero
{
    public partial class frmCloseToZero : Form
    {
        public List<int> Numeros { get; set; } = new List<int>();
        public frmCloseToZero()
        {
            InitializeComponent();
        }

        private void btnInserirNaLista_Click(object sender, EventArgs e)
        {
            if (validaNumero(txbEntradaNumero.Text))
            {
                int valor = int.Parse(txbEntradaNumero.Text);
                lbListaNumerica.Items.Add(valor);
                Numeros.Add(valor);
            }
            else
            {
                MessageBox.Show("Apenas numeros inteiros são validos. ");
            }

            txbEntradaNumero.Text = String.Empty;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lblTituloResultado.Visible = true;
            lblResultado.Visible = true;
            btnResultado.Visible = false;
            btnLimpar.Visible = true;

            lblResultado.Text = encontraNumeroMaisProximoDeZero(Numeros);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblTituloResultado.Visible = false;
            lblResultado.Visible = false;
            btnResultado.Visible = true;
            btnLimpar.Visible = false;


            Numeros.Clear();
            lbListaNumerica.Items.Clear();
        }

        private bool validaNumero(string num)
        {
            bool resultado = false;

            Regex rx = new Regex(@"[0-9]");

            if (rx.IsMatch(num))
            {
                resultado = true;

            }

            return resultado;
        }

        private string encontraNumeroMaisProximoDeZero(List<int> lista)
        {
            string resultado = "";            
            int numeroProxZeroNegativo = 0;
            int numeroProxZeroPositivo = 0;
            int diferencaPositvoPraZero = 0;
            int diferencaNegitvoPraZero = 0;

            for (int i = 0; i < lista.Count; i++)
            {

                if (i == 0)
                {
                    numeroProxZeroPositivo = lista[i];
                }

                if(numeroProxZeroNegativo == 0 && lista[i] < 0)
                {
                    numeroProxZeroNegativo = lista[i];
                }


                if (i > 0 && lista[i] >= 0 && lista[i] < numeroProxZeroPositivo )
                {
                    numeroProxZeroPositivo = lista[i];
                }

                if (i > 0 && lista[i] < 0  && lista[i] > numeroProxZeroNegativo )
                {
                    numeroProxZeroNegativo = lista[i];
                }

            }

            diferencaNegitvoPraZero = -(0 - numeroProxZeroNegativo);
            diferencaPositvoPraZero = -(0 - numeroProxZeroPositivo);

            if (numeroProxZeroNegativo == -numeroProxZeroPositivo)
            {
                
                resultado = "Nenhum";
            }
            else
            {
                if (diferencaPositvoPraZero == 0)
                {
                    resultado = diferencaPositvoPraZero.ToString();
                }
                else
                if (diferencaPositvoPraZero > diferencaNegitvoPraZero && diferencaNegitvoPraZero != 0)
                    {
                        resultado = numeroProxZeroNegativo.ToString();
                    }              
                   else
                    {
                        resultado = numeroProxZeroPositivo.ToString();
                    }
            }
        
            return resultado;

        }
        
    }
}