using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número aleatorio entre 1 y 100
        int intento = 0;
        int intentosRealizados = 0;

        Console.WriteLine(" ¡Bienvenido al juego de Adivina el Número!");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100... ¿eres capaz de adivinarlo?");

        while (intento != numeroSecreto)
        {
            Console.Write(" Escribe tu número: ");
            string entrada = Console.ReadLine();

            // Validar que el usuario ingrese un número
            if (!int.TryParse(entrada, out intento))
            {
                Console.WriteLine(" Por favor, ingresa un número válido.");
                continue; // Volver al inicio del bucle
            }

            intentosRealizados++;

            if (intento < numeroSecreto)
                Console.WriteLine(" El número secreto es mayor.");
            else if (intento > numeroSecreto)
                Console.WriteLine(" El número secreto es menor.");
        }

        Console.WriteLine($" ¡Felicidades! Adivinaste el número {numeroSecreto} en {intentosRealizados} intentos.");
        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima! ");
    }
}
