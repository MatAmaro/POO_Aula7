using System;
 

namespace POO_Aula7
{
    public class Triangulo:CalcularArea
    {
        public decimal Lado { get; set; }
        public decimal Altura { get; set; }
        public override string CalcularAr()
        {
            var area = (Lado * Altura)/2;
            return $"{aArea} triângulo de lado {Lado} e altura {Altura} é {area}";
        }
    }
}
