using System;

class Program
{
    static void Main()
    {
        int continuar = 1;
        while (continuar == 1)
        {
            PedirOperacion();
            int operacion= ValidarOperacion();
            int num1=IngresarNumero(1);
            int num2=IngresarNumero(2);
            RealizarCalculo(operacion,num1,num2);
            continuar= RepetirCalculo();
        }
    }
    static void PedirOperacion()
    {
       Console.Clear();
            Console.WriteLine("=== Calculadora Basica ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
    }

    static int ValidarOperacion(){
    int operacion;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out operacion) && operacion >= 1 && operacion <= 4)
            {
                return operacion;
            }
            Console.WriteLine("Opción inválida. Intente nuevamente:");
            Console.Write("Seleccione una opcion (1-4): ");
        }
    }

    static int IngresarNumero(int numero){
        int valor;
        while (true)
        {
            Console.Write($"Ingrese el valor del número {numero}: ");
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                return valor;
            }
            Console.WriteLine("Entrada inválida. Intente de nuevo.");
        }
    }

    static void RealizarCalculo(int operacion,int num1,int num2){
        double resultado;
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
    }
    static int RepetirCalculo(){
        Console.WriteLine("\n¿Desea realizar otro calculo?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            if (!int.TryParse(Console.ReadLine(), out int continuar) || (continuar != 1 && continuar != 2))
            {
                Console.WriteLine("Entrada no válida. Se finalizara el programa.");
                continuar = 2;
            }
            return continuar;
    }
}
