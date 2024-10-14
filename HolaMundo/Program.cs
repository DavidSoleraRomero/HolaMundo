using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // David Solera Romero - 2º DAM
            // ejercicioUno();
            // ejercicioDos();
            // ejercicioTres();
            // ejercicioCuatro();
            // ejercicioCinco();
            // ejercicioSeis();
            // ejercicioSiete();
            // ejercicioOcho();
            ejercicioNueve();
            ejercicioDiez();
        }

        static void ejercicioUno()
        {
            Console.Write("Primer número: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (numberOne + numberTwo));
            Console.WriteLine("La resta es: " + (numberOne - numberTwo));
            Console.WriteLine("La multiplicación es: " + (numberOne * numberTwo));
            Console.WriteLine("La división es: " + (numberOne / numberTwo));
            Console.WriteLine("El módulo es: " + (numberOne % numberTwo));
        }

        static void ejercicioDos()
        {
            double burguersPrice = 5.5;
            double potatosPrice = 3.5;
            double drinksPrice = 2.5;
            Console.Write("Cantidad de hamburguesas: ");
            int burguers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad de papas: ");
            int potatos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad de bebidas: ");
            int drinks = Convert.ToInt32(Console.ReadLine());
            double totalPrice = (burguers * burguersPrice) + (potatos * potatosPrice) + (drinks * drinksPrice);
            Console.WriteLine($"Cantidad a pagar: {totalPrice}€");
        }
        
        static void ejercicioTres()
        {
            Console.Write("Introduzca un numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Valor absoluto de {number}: " + Math.Abs(number));
            Console.WriteLine($"Potencia al cubo de {number}: " + Math.Pow(number, 3));
            Console.WriteLine($"Raíz cuadrada de {number}: " + Math.Sqrt(number));
            Console.WriteLine($"Seno de {number}: " + Math.Sin(number));
            Console.WriteLine($"Coseno de {number}: " + Math.Cos(number));
            Console.WriteLine($"Número máximo entre {number} y 20: " + Math.Max(number, 20));
            Console.WriteLine($"Número mínimo entre {number} y 5: " + Math.Min(number, 5));
        }

        static void ejercicioCuatro()
        {
            Console.Write("Introduzca un lado del cuadrado: ");
            int squareSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El perímetro del cuadrado es de {squareSide * 4}");
        }

        static void ejercicioCinco()
        {
            Console.Write("Introduzca el primer número: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el tercer número: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el cuarto número: ");
            int numberFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Suma de los dos primeros: {numberOne + numberTwo}");
            Console.WriteLine($"Producto de los dos últimos: {numberThree * numberFour}");
        }

        static void ejercicioSeis()
        {
            Console.Write("Introduzca el primer número: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el tercer número: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el cuarto número: ");
            int numberFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Suma de los números: {numberOne + numberTwo + numberThree + numberFour}");
            Console.WriteLine($"Promedio de los números: {(numberOne + numberTwo + numberThree + numberFour) / 4}");
        }

        static void ejercicioSiete()
        {
            Console.Write("Introduzca el precio del artículo: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca la cantidad de artículos que lleva: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Deberá pagar {price * amount}€");
        }

        static void ejercicioOcho()
        {
            Console.WriteLine("Notas de Desarrollo de Interfaces");
            Console.Write("Nota promedio de tus dos calificaciones parciales: ");
            double noteOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota del examen: ");
            double noteTwo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota del trabajo final: ");
            double noteThree = Convert.ToDouble(Console.ReadLine());
            double finalNote = (noteOne * 0.5) + (noteTwo * 0.3) + (noteThree * 0.2);
            Console.WriteLine($"Tu nota final será de: {finalNote}");
        }

        static void ejercicioNueve()
        {
            Console.WriteLine("Porcentajes de acciones de socios");
            Console.Write("Introduce el dinero que aporta el primer accionista: ");
            double firstShareholder = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el dinero que aporta el segundo accionista: ");
            double secondShareholder = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el dinero que aporta el tercer accionista: ");
            double thirdShareholder = Convert.ToDouble(Console.ReadLine());
            double totalInvestment = firstShareholder + secondShareholder + thirdShareholder;
            Console.WriteLine($"Porcentaje del socio 1: {Math.Round(firstShareholder * 100 / totalInvestment, 2)} aproximadamente");
            Console.WriteLine($"Porcentaje del socio 2: {Math.Round(secondShareholder * 100 / totalInvestment, 2)} aproximadamente");
            Console.WriteLine($"Porcentaje del socio 3: {Math.Round(thirdShareholder * 100 / totalInvestment, 2)} aproximadamente");
        }

        static void ejercicioDiez()
        {

        }
    }
}
