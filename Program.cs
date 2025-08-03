using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RealizarOperacion(Sumar);
                break;
            case 2:
                RealizarOperacion(Restar);
                break;
            case 3:
                RealizarOperacion(Multiplicar);
                break;
            case 4:
                RealizarOperacion(Dividir);
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    static void RealizarOperacion(Func<double, double, double> operacion)
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = operacion(num1, num2);
        Console.WriteLine("El resultado es: " + resultado);
    }

    static double Sumar(double a, double b) => a + b;
    static double Restar(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b) => a / b;
}