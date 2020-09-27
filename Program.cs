using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
           double ladoA; 
           double ladoB;
           double ladoC;
           double resultadoP;
           double resultadoA;
        
           Console.Write("digite a medida ladoA");
           ladoA = double.Parse(Console.ReadLine());

           Console.Write("digite a medida ladoB");
           ladoB = double.Parse(Console.ReadLine());

           Console.Write("digite a medida ladoC");
           ladoC = double.Parse(Console.ReadLine());
           Console.WriteLine("\n");
           resultadoP = ( ladoA + ladoB + ladoC ) /2;
           resultadoA = ((resultadoP * (resultadoP - ladoA) * (resultadoP - ladoB) *(resultadoP - ladoC)));
           
           Console.WriteLine("semiperimetro = {0}" , resultadoP);
           Console.WriteLine("area = {0} (cm²)" , resultadoA);
           Console.Write("\n");

           Console.WriteLine("pressione Enter para sair!");
           Console.ReadKey();
        }
    }
}
