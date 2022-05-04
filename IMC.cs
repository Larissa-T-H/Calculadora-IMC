using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aula71_IMC
{
    internal class IMC
    {
        public double Altura;
        public double Peso;

        public double CalcularIMC()
        {
            return (Peso/ (Altura * Altura));
        }

    }
}
