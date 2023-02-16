namespace Form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttCalculate_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor", "Error");
                txtNum.Focus();
                return;
            }
            int n;

            //Excepciones de error si no son numeros
            try
            {
                n = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception)
            {

                n = 0;
            }

            if (n < 2)
            {
                MessageBox.Show("Debe ingresar un valor mayor o igual a dos (2) ", "Error");
                txtNum.Text = "";
                txtNum.Focus();
                return;
            }

            string fibo = fibonacci(n);
            txtResult.Text = fibo;
        }

        private string fibonacci(int n)
        {
            double a = 0, b = 1, c, i = 2;
            string fibo = String.Format("{0:N0}\t{1:N0}\t", a, b);
            
            //Ciclo While
            while (i <= n)
            {
                c = a + b;
                fibo += String.Format("{0:N0}\t", c);
                a = b;
                b = c;
                i++;
            }
            return fibo;

            throw new NotImplementedException();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
