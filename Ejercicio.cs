using System;

public class Program
{
    delegate void Evento();

    static void EncontrarMoneda()
    {
        Console.WriteLine("Encontraste una moneda de oro brillante.");
    }

    static void EncontrarTrampa()
    {
        Console.WriteLine("¡Cuidado! Pisaste una trampa y pierdes 10 de vida.");
    }

    static void EncontrarPocion()
    {
        Console.WriteLine("Encontraste una poción de curación.");
    }
	static void EncontrarUnCofre()
    {
        Console.WriteLine("Encontraste un cofre lleno de cafe.");
    }
		static void EncontrarEnemigo()
    {
        Console.WriteLine("Encontraste una gotica trastornada.");
    }
		static void EncontrarUnAliado()
    {
        Console.WriteLine("Encontraste un gran aliado que es un mago.");
    }
	
    static void EjecutarEventoAleatorio(Evento[] eventos)
    {
        Random rnd = new Random();
        int indice = rnd.Next(eventos.Length);
        eventos[indice]();
    }

    public static void Main()
    {
        Evento[] posibles = { EncontrarMoneda, EncontrarTrampa, EncontrarPocion, EncontrarUnCofre, EncontrarEnemigo, EncontrarUnAliado, EncontrarEnemigo, EncontrarUnAliado };

        Console.WriteLine("Entras al bosque...");
        EjecutarEventoAleatorio(posibles);
    }
}
