using System;

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

 
        // ELECCIÓN DE HERRAMIENTA


        Console.WriteLine("Elige una herramienta:");
        Console.WriteLine("1. Espada");
        Console.WriteLine("2. Bastón");
        Console.WriteLine("3. Arco");
        Console.WriteLine("4. Llave inglesa");
        Console.Write("Escribe el número de tu elección: ");

        int herramienta = int.Parse(Console.ReadLine());

        Console.WriteLine();

 
        // ELECCIÓN DE COLOR


        Console.WriteLine("Elige tu color favorito:");
        Console.WriteLine("1. Azul");
        Console.WriteLine("2. Rojo");
        Console.WriteLine("3. Morado");
        Console.WriteLine("4. Amarillo");
        Console.Write("Escribe el número de tu elección: ");

        int color = int.Parse(Console.ReadLine());

        Console.WriteLine();

  
        // ELECCIÓN SOBRE LA CERVEZA
   

        Console.WriteLine("¿Te gusta la cerveza?");
        Console.WriteLine("1. Si");
        Console.WriteLine("2. No");
        Console.Write("Escribe el número de tu elección: ");

        int te = int.Parse(Console.ReadLine());

        // La respuesta la cerveza (true o false)
        bool leGustaCerveza;

        if (te == 1)
        {
            leGustaCerveza = true;
        }
        else
        {
            leGustaCerveza = false;
        }

        Console.WriteLine(leGustaCerveza);


        // VARIABLES DEL PERSONAJE


        string rol = "";

        int velocidad = 0;
        int fuerza = 0;
        int inteligencia = 0;
        int resistencia = 0;
        int puntos = 0;


        // DETERMINAR EL ROL
      

        // La herramienta
        if (herramienta == 3)
        {
            // El color
            if (color == 1)
            {
                rol = "Explorador";

                velocidad = 90;
                fuerza = 55;
                inteligencia = 70;
                resistencia = 65;
            }
            else
            {
                rol = "Explorador";

                velocidad = 85;
                fuerza = 60;
                inteligencia = 65;
                resistencia = 60;
            }
        }

        // GUERRERO
		// La herramienta
		 // El color
        else if (herramienta == 1 && color == 2)
        {
            rol = "Guerrero";

            velocidad = 50;
            fuerza = 95;
            inteligencia = 40;
            resistencia = 90;
        }

        // MAGO
		 // El color
		// La herramienta
		// Le gusta la cerveza
        else if (herramienta == 2 && (color == 3 || leGustaCerveza))
        {
            rol = "Mago";

            velocidad = 45;
            fuerza = 35;
            inteligencia = 100;
            resistencia = 55;
        }

        // INGENIERO
		 // El color
        else if (herramienta == 4 || color == 4)
        {
            rol = "Ingeniero";

            velocidad = 60;
            fuerza = 55;
            inteligencia = 95;
            resistencia = 75;
        }

        // AVENTURERO
        else if (herramienta == 1 && (leGustaCerveza))
        {
            rol = "Aventurero";

            velocidad = 70;
            fuerza = 65;
            inteligencia = 60;
            resistencia = 70;
        }

       
        // CALCULAR PUNTOS
       
        puntos = velocidad + fuerza + inteligencia + resistencia;

        
        // MOSTRAR RESULTADO
       

        Console.WriteLine("TU PERSONAJE");
        Console.WriteLine();

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Rol: " + rol);
        Console.WriteLine();

        Console.WriteLine("Velocidad: " + velocidad);
        Console.WriteLine("Fuerza: " + fuerza);
        Console.WriteLine("Inteligencia: " + inteligencia);
        Console.WriteLine("Resistencia: " + resistencia);
        Console.WriteLine("Puntos totales: " + puntos);

        Console.WriteLine();

        
        // CONDICIONALES ADICIONALES
      
        if (puntos >= 300)
        {
            Console.WriteLine("Tu personaje tiene estadísticas excelentes.");
        }
        else if (puntos > 250)
        {
            Console.WriteLine("Tu personaje tiene buenas estadísticas.");
        }
        else
        {
            Console.WriteLine("Tu personaje todavía puede mejorar.");
        }

        // Te!
        if (!leGustaCerveza)
        {
            Console.WriteLine("Tu personaje no es fanático de la cerveza.");
        }
        else
        {
            Console.WriteLine("Tu personaje disfruta tomar cerveza.");
        }

        //ETC
        if (velocidad > 80)
        {
            Console.WriteLine("Tu personaje es muy rápido.");
        }

        if (resistencia < 60)
        {
            Console.WriteLine("Tu personaje tiene poca resistencia.");
        }

        Console.WriteLine();
        Console.WriteLine("¡Gracias por crear tu personaje!");
    }
}
