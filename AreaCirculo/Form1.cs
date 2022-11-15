namespace AreaCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius, resultadoArea;

            radius = double.Parse(boxRadio.Text);
            resultadoArea = 3.14 * (radius * radius);
            boxArea.Text = Convert.ToString(resultadoArea);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string limpiar = "";
            boxArea.Text = limpiar;
            boxRadio.Text = limpiar;
        }
    }
}