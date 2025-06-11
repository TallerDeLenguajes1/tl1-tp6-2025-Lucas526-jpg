using System;

class Program{
    static void Main(){
        //Obtener la longitud de la cadena y muestre por pantalla. 
        Console.WriteLine("Ingrese un texto");
        string cadena = Console.ReadLine();
        int longitud = cadena.Length;
        Console.WriteLine($"Tamaño: {longitud}");

        //A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas
        Console.WriteLine("Ingrese un texto2");
        string cadena2 = Console.ReadLine();
        string concatena = cadena + " " +  cadena2;
        Console.WriteLine($"Texto concatenado: {concatena}");

        //Extraer una subcadena de la cadena ingresada
        string sub1 = cadena2.Substring(2);
        Console.WriteLine($"subcadena: {sub1}");

        //Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería:  “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.  Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente. Nota: Busque el comportamiento del Método ToString(); 

        // Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla 
        foreach (char c in concatena)
        {
            Console.WriteLine(c);
        } 

        //Buscar la ocurrencia de una palabra determinada en la cadena ingresada 
        Console.WriteLine("Ingrese la palabra a buscar");
        if (concatena.Contains(Console.ReadLine()))
        {
            Console.WriteLine("La palabra ingresada esta en la frase");
        }else
        {
            Console.WriteLine("La palabra ingresada no existe en la frase");
        }

        //Convierta la cadena a mayúsculas y luego a minúsculas. 
        Console.WriteLine($"La frase en mayusculas{concatena.ToUpper()}");
        Console.WriteLine($"La frase en mayusculas{concatena.ToLower()}");
        
    

     
    }
}