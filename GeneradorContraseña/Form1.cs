using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int con = 8;
            const string caracteres = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890-";
            StringBuilder resultado = new StringBuilder();
            Random random = new Random();
            while (0 < con--)
            {
                resultado.Append(caracteres[random.Next(caracteres.Length)]);
            }
            textBox1.Text = resultado.ToString();
        }
    }
}
