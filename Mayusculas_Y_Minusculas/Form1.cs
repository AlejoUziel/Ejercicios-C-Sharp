namespace Mayusculas_Y_Minusculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Convertir();
        }
        public void Convertir()
        {
            string textoMinusculas= boxMinusculas.Text;
            boxMayusculas.Text = textoMinusculas.ToUpper();
        }
        private void Limpiar()
        {
            string limpiar = "";
            boxMayusculas.Text = limpiar;
            boxMinusculas.Text = limpiar;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}