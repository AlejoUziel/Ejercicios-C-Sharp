namespace CalcularNomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = boxNombre.Text;
                string apellido = boxApellidos.Text;


                int dia = int.Parse(boxDiasTrabajados.Text);
                double pago = double.Parse(boxPagoDia.Text);
                double resultado = dia * pago;


                boxResultado.Text = "El pago de " + nombre.ToUpper() + " " + apellido.ToUpper()+ " es de $" + resultado;
            }
            catch
            {
                MessageBox.Show("No haz ingresado informarcion en todos los campos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            string limpiar = "";
            boxNombre.Text = limpiar;
            boxApellidos.Text = limpiar;
            boxPagoDia.Text = limpiar;
            boxResultado.Text = limpiar;
            boxDiasTrabajados.Text= limpiar;

        }

        private void boxResultado_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}