namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        public class Triangulo
        {
            public int X;
            public int Y;
            public int Z;
            public void CalcularTriangulo(int X, int Y, int Z)
            {
                if (X + Y > Z && X + Z > 2 && Y + Z > X)
                {
                    if (X == Y && Y == Z)
                    {
                        Console.WriteLine("Seu triângulo é equilátero");
                    }
                    else if (X == Y || X == Z || Y == Z)
                    {
                        Console.WriteLine("Seu triângulo é isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Seu triângulo é escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("Triângulo inválido");
                }
            }
        }
    }
}
