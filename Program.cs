using System;

class Program{
    static void Main(){
        Console.Write("Ingrese un numero");
        string Entrada= Console.ReadLine() ?? "";
        if (int.TryParse(Entrada,out int numero))
        {
            int nuevoNum = 0;
            while (numero != 0)
            {
                int digito = numero%10;
                nuevoNum=nuevoNum*10 + digito;
                numero = numero/10;
            }
            Console.WriteLine($"el numero resultante es: {nuevoNum}");
        }else
        {
            Console.Write("Error");
        }
    }
}