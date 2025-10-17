using System;

class ColaImpresion
{
    static void Main()
    {
        // Declaramos un arreglo para almacenar los nombres de los documentos
        string[] cola = new string[100]; 
        int inicio = 0; // índice del primer documento
        int fin = 0;    // índice donde se insertará el siguiente documento

        Console.WriteLine("Simulación de Cola de Impresión");
        Console.WriteLine("Ingrese nombres de documentos (escriba 'fin' para terminar):");

        while (true)
        {
            string documento = Console.ReadLine();

            if (documento.ToLower() == "fin")
                break;

            if (fin < cola.Length)
            {
                cola[fin] = documento;
                fin++;
            }
            else
            {
                Console.WriteLine("La cola está llena. No se pueden agregar más documentos.");
                break;
            }
        }

        // Mostrar la cola completa
        Console.WriteLine("\nOrden de impresión:");
        if (inicio == fin)
        {
            Console.WriteLine("No hay documentos en la cola.");
        }
        else
        {
            for (int i = inicio; i < fin; i++)
            {
                Console.WriteLine($"- {cola[i]}");
            }
        }

        // Atender el primer documento
        if (inicio < fin)
        {
            Console.WriteLine($"\nImprimiendo documento: {cola[inicio]}");
            inicio++; // simulamos el dequeue
        }

        // Mostrar los documentos restantes
        Console.WriteLine("\nDocumentos restantes en la cola:");
        if (inicio == fin)
        {
            Console.WriteLine("No hay documentos pendientes.");
        }
        else
        {
            for (int i = inicio; i < fin; i++)
            {
                Console.WriteLine($"- {cola[i]}");
            }
        }
    }
}