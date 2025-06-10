using System;

class Program{
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
        Console.WriteLine("\nDesea realizar otro calculo?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            if (!int.TryParse(Console.ReadLine(), out int continuar) || (continuar != 1 && continuar != 2))
            {
                Console.WriteLine("Entrada no valida. Se finalizara el programa.");
                continuar = 2;
            }
            return continuar;
    }
}}
