using System;

class Jugador
{
    public string nombre;
    private string rol;
    private int velocidad;
    private int fuerza;
    private int inteligencia;
    private int resistencia;

    public void AsignarPersonaje(string nombreElegido, string herramienta, bool leGustaElTe)
    {
        nombre = nombreElegido;

        if (herramienta == "Mapa")
        {
            rol = "Explorador";
            velocidad = 90;
            fuerza = 50;
            inteligencia = 70;
            resistencia = 60;
        }
        else if (herramienta == "Espada")
        {
            if (leGustaElTe)
            {
                rol = "Guerrero";
                velocidad = 50;
                fuerza = 90;
                inteligencia = 40;
                resistencia = 90;
            }
            else
            {
                rol = "Mago";
                velocidad = 40;
                fuerza = 30;
                inteligencia = 100;
                resistencia = 50;
            }
        }
    }

    public void MostrarPersonaje()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Rol: {rol}");
        Console.WriteLine($"Velocidad: {velocidad}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Inteligencia: {inteligencia}");
        Console.WriteLine($"Resistencia: {resistencia}");
    }
}
					
public class Program
{
	public static void Main()
	{
		 // CREACIÓN DEL PERSONAJE

        Console.WriteLine("CREACIÓN DE TU PERSONAJE");
        Console.WriteLine();

        // El nombre
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hola, " + nombre + "!");
        Console.WriteLine("Vamos a descubrir qué personaje eres.");
        Console.WriteLine();

        //Herramienta
		
		Console.WriteLine("Elige una herramienta:");
        Console.WriteLine("1. Mapa");
        Console.WriteLine("2. Espada");
        Console.Write("Escribe el número de tu elección: ");

		int herramienta = int.Parse(Console.ReadLine());

        Console.WriteLine();
   
		//El te
	   Console.WriteLine("Te gusta el te?:");
		
		
		
	}
}
