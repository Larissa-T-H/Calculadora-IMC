using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Aula71_IMC
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text, CultureInfo.InvariantCulture);
            double peso = double.Parse(txtPeso.Text, CultureInfo.InvariantCulture);
            IMC resultado = new IMC();
            resultado.Altura = altura;
            resultado.Peso = peso;
            lblIMC.Text ="Seu IMC: " + resultado.CalcularIMC().ToString("F2", CultureInfo.InvariantCulture);
            txtAltura.Clear();
            txtPeso.Clear();

            double imc = resultado.CalcularIMC();

            if (imc <= 18.5)
            {
                MessageBox.Show("CLASSIFICAÇÃO " +"\n\nMAGREZA");
            }
            else if(imc <= 24.9)
            {
                MessageBox.Show("CLASSIFICAÇÃO " + "\n\nNORMAL");
            }
            else if (imc <= 29.9)
            {
                MessageBox.Show("CLASSIFICAÇÃO " + "\n\nSOBREPESO	I");
            }
            else if (imc <= 39.9)
            {
                MessageBox.Show("CLASSIFICAÇÃO " + "\n\nOBESIDADE II");
            }
            else
            {
                MessageBox.Show("CLASSIFICAÇÃO " + "\n\nOBESIDADE GRAVE III");
            }

        }
    }
}
