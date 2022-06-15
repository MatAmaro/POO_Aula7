using System;


namespace POO_Aula7
{
    public class Circulo : CalcularArea
    {
        public double Raio { get; set; }
        
        public override string CalcularAr()
        {
            var area = Math.Pow(Raio,2)*Math.PI;
            return $"{aArea} circulo de raio {Raio} é {area:f2}";
        }
    }
}
