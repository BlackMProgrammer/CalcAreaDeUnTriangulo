using System;

namespace CalcAreaDeUnTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base de el triangulo: ");
            string valbase = Console.ReadLine();
            int base1 = Convert.ToInt32(valbase);

            Console.WriteLine("Ingrese la altura de el triangulo: ");
            string valaltura = Console.ReadLine();
            int altura = Convert.ToInt32(valaltura);

            Console.WriteLine("El area del triangulo es :{0}", (base1 * altura) / 2);
  
        }
    }
}
