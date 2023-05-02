using System;

class Program
{
    static void Main() {
        double[] depositos = new double[12];
        double totalAhorrado = 0;

        for (int i = 0; i < 12; i++) {
            Console.Write($"Ingrese el deposito del mes {i + 1}: ");
            depositos[i] = double.Parse(Console.ReadLine());
            totalAhorrado += depositos[i];
        }

        Console.WriteLine($"Total ahorrado en el año: {totalAhorrado:C2}");

        for (int i = 0; i < 12; i++) {
            Console.WriteLine($"Ahorrado en el mes {i + 1}: {depositos[i]:C2}");
        }
    }
}