namespace Triangulos.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Insira o valor do primeiro lado do triângulo (X)");
            triangulo.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado do triângulo (Y)");
            triangulo.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado do triângulo (Z)");
            triangulo.Z = int.Parse(Console.ReadLine());

            triangulo.CalcularTriangulo(triangulo.X, triangulo.Y, triangulo.Z);

            Console.ReadKey();
        }
    }
}
