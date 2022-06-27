namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4

    }

    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        Operacion operador = Operacion.NoDefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void MandarNumero(string numero)
        {


            CajaResultado.Text += numero;


        } 

        private double Operaciones()
        {
            double resultado = 0;

            switch (operador)
            {

                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor2 - valor1;
                    break;
                case Operacion.Division:
                    if(valor2 == 0)
                    {
                        MessageBox.Show("No es posible dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("8");
            }
            else
            {
                MandarNumero("8");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("9");
            }
            else
            {
                MandarNumero("9");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(CajaResultado.Text != "0")
            {
                MandarNumero("0");
            }
           
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            MandarNumero(".");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("3");
            }
            else
            {
                MandarNumero("3");
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("1");
            }
            else
            {
                MandarNumero("1");
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("6");
            }
            else
            {
                MandarNumero("6");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("4");
            }
            else
            {
                MandarNumero("4");
            }


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("7");
            }
            else
            {
                MandarNumero("7");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            CajaResultado.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("2");
            }
            else
            {
                MandarNumero("2");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text == "0")
            {
                CajaResultado.Clear();
                MandarNumero("5");
            }
            else
            {
                MandarNumero("5");
            }
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            lbHistorial.Text = CajaResultado.Text + operador;
            CajaResultado.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

            
            

       
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if(valor2 == 0)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                lbHistorial.Text += valor2 + "=";
                double resultado = Operaciones();
                valor1 = 0;
                valor2 = 0;
                CajaResultado.Text = Convert.ToString(resultado);

            }
            else
            {
                lbHistorial.Text = CajaResultado.Text + "+";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }
    }
}