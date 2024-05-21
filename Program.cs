using EspacioCalculadora;
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        string comando;
        double numero;

        do
        {
            Console.WriteLine("Ingrese el comando (sumar, restar, multiplicar, dividir, limpiar, salir):");
            comando = Console.ReadLine();

            switch (comando)
            {
                case "sumar":
                    Console.WriteLine("Ingrese el número a sumar:");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Sumar(numero);
                    break;
                case "restar":
                    Console.WriteLine("Ingrese el número a restar:");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Restar(numero);
                    break;
                case "multiplicar":
                    Console.WriteLine("Ingrese el número a multiplicar:");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Multiplicar(numero);
                    break;
                case "dividir":
                    Console.WriteLine("Ingrese el número a dividir:");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Dividir(numero);
                    break;
                case "limpiar":
                    calc.Limpiar();
                    break;
            }

            Console.WriteLine($"Resultado: {calc.Resultado}");

        } while (comando != "salir");
    }
}