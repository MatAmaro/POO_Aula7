using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula7
{
    public class Retangulo : CalcularArea
    {
        public decimal Lado { get; set; }
        public decimal Altura { get; set; }
        public override string CalcularAr()
        {
            var area = Lado * Altura;
            return $"{aArea} retângulo de lado {Lado} e altura {Altura} é {area}";
        }
    }
}
