using System;

class Program{
    static void Main(){
        Console.WriteLine("Ingrese un numero");
        string Entrada= Console.ReadLine() ?? "";
        if (double.TryParse(Entrada,out double numero))
        {
            Console.WriteLine($"numero: {numero}");
            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"El cuadrado: {Math.Pow(numero,2)}");
            Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(numero)}");
            Console.WriteLine($"Seno: {Math.Sin(numero)}");
            Console.WriteLine($"Coseno: {Math.Cos(numero)}");

            int parteEntera = (int)Math.Truncate(numero);
            Console.WriteLine($"Parte entera: {parteEntera}");

            Console.WriteLine("Ingrese el numero a");
            string Num_a=Console.ReadLine() ?? "";
            double.TryParse(Num_a,out double numero1);

            Console.WriteLine("Ingrese el numero b");
            string Num_b=Console.ReadLine() ?? "";
            double.TryParse(Num_b,out double numero2);

            Console.WriteLine($"Maximo: {Math.Max(numero1, numero2)}");
            Console.WriteLine($"Minimo: {Math.Min(numero1, numero2)}");
        }else
        {
            Console.Write("Error");
        }
    }
}