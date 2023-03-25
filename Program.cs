using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_RAMS_1018822
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Laboratorio 10");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Multiplicación");
                Console.WriteLine("3. Raíz Cuadrada");
                Console.WriteLine("4. Porcentaje de un número ingresado");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese la opción deseada: ");
                int opcion;
                string lol = Console.ReadLine();

                if (!int.TryParse(lol, out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:

                        int a, b, c;
                        Console.Clear();
                        Console.WriteLine("Suma");
                        Console.Write("Ingrese el primer número: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el tercer número: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado es: " + Suma(a, b, c));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Multiplicación");
                        Console.Write("Ingrese el primer número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado es:" + Multiplicacion(num1, num2));
                        break;
                    case 3:
                        int n1;
                        Console.Clear();
                        Console.WriteLine("Raíz Cuadrada");
                        Console.Write("Ingrese un número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("El resultado es: " + Raiz(n1));
                        break;
                    case 4:
                        int numero1, numero2;
                        Console.Clear();
                        Console.WriteLine("Porcentaje");
                        Console.Write("Ingrese un número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el porcentaje que desea: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado es: " + Porcentaje(numero1, numero2));
                        break;
                    case 5:
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (continueProgram)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        static int Suma(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
        static double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }
        static double Porcentaje(double numero1, double numero2)
        {
            return (numero1 / 100) * numero2;
        }

    }
}
