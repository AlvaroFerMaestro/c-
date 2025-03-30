using System;

class Program
{
    static void Main()
    {
        int x = 5, y = 5; 
        ConsoleKey tecla;

        do
        {
            Console.Clear(); 
            DibujarMapa(x, y); 
             
            tecla = Console.ReadKey(true).Key; 

            // Movimiento del personaje
            if (tecla == ConsoleKey.W && y > 1) y--; 
            if (tecla == ConsoleKey.S && y < 8) y++; 
            if (tecla == ConsoleKey.A && x > 1) x--; 
            if (tecla == ConsoleKey.D && x < 8) x++; 

        } while (tecla != ConsoleKey.Escape); 
    }

    static void DibujarMapa(int px, int py)
    {
        for (int y = 0; y < 10; y++)
            {
            for (int x = 0; x < 10; x++)
            {
                if (x == px && y == py)
                    Console.Write("☺"); 
                else
                    Console.Write("."); 
            }
            Console.WriteLine(); 
        }
        Console.WriteLine("\nUsa W, A, S, D para moverte. Presiona ESC para salir.");
    }
}
