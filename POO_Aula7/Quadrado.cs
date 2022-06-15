using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula7
{
    public class Quadrado : CalcularArea
    {
        public decimal Lado { get; set; }

        public override string CalcularAr()
        {
            var area = Lado * Lado;
            return $"{aArea} quadrado de lado {Lado} é {area}";
        }

    }
}
