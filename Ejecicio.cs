using System;

class Program
{
    static void Main()
    {
        string nombre = "Pepito";
		int vidas = 5;
        float velocidad = 7.2f;
		bool estaEnLaPuerta = true;
		int puntos = 7;
		bool tieneLlave = puntos < 6;
		bool puedeAbrir = tieneLlave && estaEnLaPuerta;
		
		

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Vidas: " + vidas);
        Console.WriteLine("Velocidad: " + velocidad);
	    Console.WriteLine("estaEnLaPuerta: " + estaEnLaPuerta);
		Console.WriteLine("tieneLlave: " + tieneLlave);
		Console.WriteLine("puntos: " +  puntos);
		Console.WriteLine("puedeAbrir: " + tieneLlave);
        vidas = vidas - 1;
		puntos = puntos - 2;
        velocidad = velocidad + 2.0f;
		tieneLlave = puntos < 6;
		puedeAbrir = tieneLlave && estaEnLaPuerta;
		
        Console.WriteLine("Después de jugar:");
        Console.WriteLine("Vidas: " + vidas);
		Console.WriteLine("puntos: " + puntos);
        Console.WriteLine("Velocidad: " + velocidad);
		Console.WriteLine( "puedeAbrir: " + puedeAbrir);
    }
}
