using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ej1
            System.Console.Write("Introduzca la medida del radio: ");
            double radio = Double.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = Math.Pow(radio, 2) * pi;
            Console.WriteLine($"El área del circulo con radio {radio} es: {area}");

        }
    }
}
