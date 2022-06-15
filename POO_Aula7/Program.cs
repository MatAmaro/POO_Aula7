using POO_Aula7;

Quadrado quadrado = new Quadrado();
Retangulo retangulo = new Retangulo();
Triangulo triangulo = new Triangulo();
Circulo circulo = new Circulo();

Console.WriteLine("Resultado das áreas:");
quadrado.Lado = 5;
Console.WriteLine(quadrado.CalcularAr());

retangulo.Altura = 5;
retangulo.Lado = 4;
Console.WriteLine(retangulo.CalcularAr());

triangulo.Altura = 3;
triangulo.Lado = 2;
Console.WriteLine(triangulo.CalcularAr());

circulo.Raio = 16;
Console.WriteLine(circulo.CalcularAr());


