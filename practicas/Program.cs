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

            //Practica1();
            Practica2();
            //Practica3();

        }

        #region Practica1
        static void Practica1() 
        {

            //ej1
            System.Console.Write("Introduzca la medida del radio: ");
            double radio = Double.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = Math.Pow(radio, 2) * pi;
            Console.WriteLine($"El área del circulo con radio {radio} es: {area}");

        }
        #endregion

        #region Practica2
        static void Practica2() 
        {

            Console.WriteLine("Práctica 2:");

            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.Write("Introduce tu edad, por favor: ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {

                Console.Write("¿Tienes carnet? S/N: ");
                string carnet = Console.ReadLine();
                
                if (carnet.Equals(TIENE_CARNET))
                {
                    Console.WriteLine("Tienes carnet, puedes conducir");
                } else
                {
                    Console.WriteLine("Eres mayor de edad pero no tienes carnet, no puedes conducir");
                }

            } else
            {
                Console.WriteLine("No eres mayor de edad, no puedes conducir");
            }
        
        }
        #endregion

        #region Practica3
        static void Practica3() 
        {



        }
        #endregion

    }
}
