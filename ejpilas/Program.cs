using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Stack<string> numeros = new Stack<string>();
        numeros.Push("uno");
        numeros.Push("dos");
        numeros.Push("tres");
        numeros.Push("cuatro");
        numeros.Push("cinco");

        foreach(string i in numeros)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nPop '{0}'", numeros.Pop());
        Console.WriteLine("Peek: {0}", numeros.Peek());
        Console.WriteLine("Pop '{0}'", numeros.Pop());

        // Copia la pila, usa el método ToArray y el constructor IEnumerable<T>
        Stack<string> arreglo = new Stack<string>(numeros.ToArray());

        Console.WriteLine("\nElementos de la copia:");
        foreach(string i in copia)
        {
            Console.WriteLine(i);
        }

        // Copia la pila a un arreglo con el doble de elementos, inicia en el medio del arreglo
        string[] arreglo2 = new string[numeros.Count * 2];
        numeros.CopyTo(arreglo2, numbers.Count);

        // Create a second stack, using the constructor that accepts an
        // IEnumerable(Of T).
        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach( string number in stack3 )
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
    }
}