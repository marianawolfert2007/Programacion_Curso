using System;
					
public class Program
{
	public static void Main()
	{
		string[] Nombres = { "Rasputia", "ElPepe", "Alharaca", "Izumi", "Mili" };
		int[] Vidas = { 7, 2, 9, 5, 8 };
		int[] Puntos = { 20, 30, 24, 7, 1 };
		float[] Velocidad = { 20, 25, 19, 22, 80 };
		bool[] TieneLlave = { true, false, false, true, true };
		bool[] EstaEnLaPuerta = { false, true, true, true, false };
		
		int JugadorActual= 3;
		Console.WriteLine("Nombres: " + Nombres[JugadorActual]);
        Console.WriteLine("Vidas: " + Vidas[JugadorActual]);
        Console.WriteLine("Puntos: " + Puntos[JugadorActual]);
	    Console.WriteLine("Velocidad: " + Velocidad[JugadorActual]);
		Console.WriteLine("TieneLlave: " + TieneLlave[JugadorActual]);
		Console.WriteLine("EstaEnLaPuerta: " + EstaEnLaPuerta[JugadorActual]);

	}
}
