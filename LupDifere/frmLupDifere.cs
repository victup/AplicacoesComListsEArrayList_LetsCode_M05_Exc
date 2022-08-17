using System.Text.RegularExpressions;

namespace LupDifere
{
    public partial class LupDifere : Form
    {

        List<int> Numeros { get; set; } = new List<int>();

        public LupDifere()
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

            lblResultado.Text = diferecaMaiorMenor(Numeros).ToString();
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

        private int diferecaMaiorMenor(List<int> lista)
        {
            int maiorNumero = 0;
            int menorNumero = 0;
            

            for (int i = 0; i < lista.Count; i++)
            {
                if(i > 0)
                {
                   if(lista[i] < menorNumero)
                    {
                        menorNumero = lista[i];
                    }
                   else
                    {
                        maiorNumero = lista[i];
                    }
                 
                }
                else
                {
                    maiorNumero = lista[i];
                    menorNumero = lista[i];
                }
            }

            return maiorNumero - menorNumero;
        }
        
    }
}