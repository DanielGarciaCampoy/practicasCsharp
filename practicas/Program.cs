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
            //Practica2();
            //Practica3();
            Practica4();
            //Excepciones();

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

            if (edad >= PUEDE_CONDUCIR)
            {

                Console.Write("¿Tienes carnet? S/N: ");
                string carnet = Console.ReadLine().ToUpper();
                
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
        /**
         Modifica el ejemplo anterior para que lea la respuesta en un método llamado LeerRespuesta con el siguiente funcionamiento:
            - Si se ha introducido N o S devolverá el valor introducido.
            - Mientras no se introduzca N o S mostrará el mensaje “Se debe introducir N o S” y volverá a leer el valor.
                Cuando se introduzca el valor correcto, se devolverá.
         */
        static void Practica3()
        {

            Console.WriteLine("Práctica 3:");

            const string REPETIR_BUCLE = "S";
            string respuesta = string.Empty;

            Console.Write("¿Quieres entrar al bucle? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();
            while (!respuesta.Equals("N"))
            {
                Console.Write("¿Quieres seguir en el bucle? (S/N): ");
                respuesta = Console.ReadLine().ToUpper();
                if (!(respuesta.Equals(REPETIR_BUCLE) || respuesta.Equals("N")))
                {
                    Console.WriteLine("Se debe introducir N o S");
                    respuesta = Console.ReadLine().ToUpper();
                }
            }
            Console.WriteLine("Has salido del bucle");
        }
        #endregion

        #region Practica4
        //Transforma el ejemplo del bucle while (diapositiva 58) para realizarlo con un bucle do-while.
        static void Practica4()
        {
            Console.WriteLine("Práctica 4:");

            const string REPETIR_BUCLE = "S";
            string respuesta = string.Empty;

            Console.Write("¿Quieres entrar al bucle? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();
            if (respuesta.Equals(REPETIR_BUCLE))
            {
                do
                {
                    Console.Write("¿Quieres seguir en el bucle? (S/N): ");
                    respuesta = Console.ReadLine().ToUpper();
                    if (!(respuesta.Equals(REPETIR_BUCLE) || respuesta.Equals("N")))
                    {
                        Console.WriteLine("Se debe introducir N o S");
                        respuesta = Console.ReadLine().ToUpper();
                    }
                } while (!respuesta.Equals("N"));
            }
            Console.WriteLine("Has salido del bucle");
        }
        #endregion

        #region Excepciones

        static void Excepciones()
        {
            try
            {
                Console.WriteLine("Introduce un num:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leido {valor}");
            } 
            catch(FormatException ex)
            {
                Console.WriteLine("El formato del núm no es correcto");
            } 
            catch (OverflowException ex)
            {
                Console.WriteLine("El num introducido es demasiado grande");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin del método");
            }
        }

        #endregion

    }
}
