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
        }else
        {
            Console.Write("Error");
        }
    }
}