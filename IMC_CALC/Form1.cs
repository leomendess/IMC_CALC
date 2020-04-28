using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_CALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Peso;

            Peso = float.Parse(textBox1.Text);

           float Altura;

            Altura = float.Parse(textBox2.Text);

        

          float Resultado1;

            Resultado1 = (Altura * Altura);

           float IMC;

           IMC = Peso / Resultado1;

            String IMCCerto;

            IMCCerto = Convert.ToString(IMC);

            MessageBox.Show(IMCCerto);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Altur(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
