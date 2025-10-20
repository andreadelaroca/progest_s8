// See https://aka.ms/new-console-template for more information

internal class Program
{
	public static string[] actions = {
		"Escribir palabras",
		"Eliminar línea",
		"Copiar",
		"Mover"
	};
	
	public static string[] history = new string[255];
	public static int inicio = 0;
	public static int fin = 0;
	// public static Stack<string> history = new Stack<string>();
	
	public static void show_menu()
	{
		Console.WriteLine("Menú de acciones");
		Console.WriteLine("-----------------------------------");
		
		int counter = 1;
		foreach(string i in actions)
		{
			Console.WriteLine($"{counter}. {i}");
			counter++;
		}
		Console.WriteLine($"{counter}. Salir");
		Console.WriteLine();
	}

	public static void show_history()
	{
		Console.WriteLine("Historial de acciones (más reciente a más antigua)");
		Console.WriteLine("-----------------------------------");
		//foreach(string i in history)
		for(int i = fin; i > inicio; i--)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine();
	}

	public static void Main(string[] args)
	{
		show_menu();
		for(int i = 0; i < 5; i++)
		{
			Console.Write("Ingresa el número de una acción: ");
			int num = Convert.ToInt32(Console.ReadLine());
			string action;
			
			if (num == 5)
                break;
			else
				action = actions[num - 1];

            if (fin < history.Length)
            {
                history[fin] = action;
                fin++;
            }
            else
            {
                Console.WriteLine("Se ha alcanzado el límite de acciones. No se pueden realizar más.");
                break;
            }
		}
		Console.WriteLine();
		
		show_history();
		Console.WriteLine("Deshaciendo la última acción...");
		fin--;	
		show_history();
	}
}
