// See https://aka.ms/new-console-template for more information

internal class Program
{
	public static string[] actions = {
		"Escribir palabras",
		"Eliminar línea",
		"Copiar",
		"Mover"
	};
	
	public static Stack<string> history = new Stack<string>();
	
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
		Console.WriteLine();
	}

	public static void show_history()
	{
		Console.WriteLine("Historial de acciones (más reciente a más antigua)");
		Console.WriteLine("-----------------------------------");
		foreach(string i in history)
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
			history.Push(actions[Convert.ToInt32(Console.ReadLine()) - 1]);
		}
		Console.WriteLine();
		
		show_history();
		Console.WriteLine("Deshaciendo la última acción...");
		history.Pop();	
		show_history();
	}
}
