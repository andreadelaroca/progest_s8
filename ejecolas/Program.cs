using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> turnos = new Queue<string>();

        turnos.Enqueue("Cliente 1");
        turnos.Enqueue("Cliente 2");
        turnos.Enqueue("Cliente 3");

        Console.WriteLine("Atendiendo a: " + turnos.Dequeue());

        Console.WriteLine("Siguiente en la fila: " + turnos.Peek());
    }
}
