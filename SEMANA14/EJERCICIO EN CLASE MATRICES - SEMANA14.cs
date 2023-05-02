// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        int[,] temperaturas = new int[7, 2]; // Matriz para guardar las temperaturas de la mañana y tarde

        // Llenar la matriz con temperaturas aleatorias entre 20 y 40 grados
        Random random = new Random();
        for (int i = 0; i < 7; i++)
        {
            temperaturas[i, 0] = random.Next(20, 41); // Temperatura de la mañana
            temperaturas[i, 1] = random.Next(20, 41); // Temperatura de la tarde
        }

        // Mostrar las temperaturas en una forma entendible
        Console.WriteLine("Temperaturas de la mañana y tarde de los últimos 7 días:");
        Console.WriteLine("Día\tMañana\tTarde");
        for (int i = 0; i < 7; i++)
        {
            string diaSemana = Enum.GetName(typeof(DayOfWeek), i); // Obtener el nombre del día de la semana
            Console.WriteLine($"{diaSemana}\t{temperaturas[i, 0]}\t{temperaturas[i, 1]}");
        }

        // Calcular y mostrar el promedio de temperatura de los últimos 3 días de la mañana
        int promedioMañana = 0;
        for (int i = 4; i < 7; i++) // Los últimos 3 días de la matriz
        {
            promedioMañana += temperaturas[i, 0];
        }
        promedioMañana /= 3;
        Console.WriteLine($"Promedio de temperatura de los últimos 3 días de la mañana: {promedioMañana}");

        // Encontrar el día más caluroso por la tarde y mostrar el día de la semana
        int diaMasCalurosoTarde = 0;
        int temperaturaMasCalurosaTarde = temperaturas[0, 1];
        for (int i = 1; i < 7; i++)
        {
            if (temperaturas[i, 1] > temperaturaMasCalurosaTarde)
            {
                diaMasCalurosoTarde = i;
                temperaturaMasCalurosaTarde = temperaturas[i, 1];
            }
        }
        string diaSemanaMasCalurosoTarde = Enum.GetName(typeof(DayOfWeek), diaMasCalurosoTarde);
        Console.WriteLine($"Día más caluroso por la tarde: {diaSemanaMasCalurosoTarde}");

        // Encontrar el día menos caluroso por la mañana y mostrar el día de la semana
        int diaMenosCalurosoMañana = 0;
        int temperaturaMenosCalurosaMañana = temperaturas[0, 0];
        for (int i = 1; i < 7; i++)
        {
            if (temperaturas[i, 0] < temperaturaMenosCalurosaMañana)
            {
                diaMenosCalurosoMañana = i;
                temperaturaMenosCalurosaMañana = temperaturas[i, 0];
            }
        }
        string diaSemanaMenosCalurosoMañana = Enum.GetName(typeof(DayOfWeek), diaMenosCalurosoMañana);
        Console.WriteLine($"Día menos caluroso por la mañana: {diaSemanaMenosCalurosoMañana}");
        int diass = 0, pro = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int e = 0; e < 2; e++)
            {

                if (temperaturas[i, e] > 30)
                {
                    diass++;
                }

            }
        }
        if (promedioMañana > 30)
        {
            pro++;
        }
        Console.WriteLine("Estas son las veces que la temperatura es mayor a 30 °C: " + diass);
        if (pro == 1)
        {
            Console.WriteLine("La temporada es calurosa");

        }
        else
        {
            Console.WriteLine("La temporada no es calurosa");
        }

        Console.ReadKey();
    }
}

