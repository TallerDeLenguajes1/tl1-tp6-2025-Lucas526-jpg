using System;

class Program
{
    static void Main()
    {
        int continuar = 1;

        while (continuar == 1)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora Basica ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una opcion (1-4): ");

            if (!int.TryParse(Console.ReadLine(), out int operacion) || operacion < 1 || operacion > 4)
            {
                Console.WriteLine("Opcion invalida.");
                return;
            }

            Console.Write("Ingrese el valor del numero 1: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Entrada inválida para número 1.");
                return;
            }

            Console.Write("Ingrese el valor del numero 2: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Entrada invalida para número 2.");
                return;
            }

            int resultado;
            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    else
                    {
                        double division = (double)num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {division}");
                    }
                    break;
            }

            Console.WriteLine("\n¿Desea realizar otro calculo?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            if (!int.TryParse(Console.ReadLine(), out continuar) || (continuar != 1 && continuar != 2))
            {
                Console.WriteLine("Entrada no válida. Se finalizara el programa.");
                continuar = 2;
            }
        }
    }
}
