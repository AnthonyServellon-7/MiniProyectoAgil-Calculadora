using System;

namespace CalculadoraAgil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora Ágil ---");
            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma es: {num1 + num2}");
        }
    }
}