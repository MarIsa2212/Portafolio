using System;

class Program
{
    static void Main() {
        
        int nVentas;
        double montoVentas, totalVentas = 0, over1300Amount = 0, between300and1300Amount = 0, under300Amount = 0;
        int over1300Count = 0, between300and1300Count = 0, under300Count = 0;

        Console.Write("Ingrese el numero de ventas: ");
        nVentas = int.Parse(Console.ReadLine());

        for (int i = 0; i < nVentas; i++) {
            Console.Write($"Enter the amount of sale {i + 1}: ");
            montoVentas = double.Parse(Console.ReadLine());
            totalVentas += montoVentas;

            if (montoVentas > 1300) {
                over1300Count++;
                over1300Amount += montoVentas;
            } else if (montoVentas > 300) {
                between300and1300Count++;
                between300and1300Amount += montoVentas;
            } else {
                under300Count++;
                under300Amount += montoVentas;
            }
        }

        Console.WriteLine($"Numero de ventas mayor que Q1300: {over1300Count}");
        Console.WriteLine($"Monto total vendido mayor a Q1300: {over1300Amount:C2}");
        Console.WriteLine($"Número de ventas entre Q300 y Q1300: {between300and1300Count}");
        Console.WriteLine($"Monto total vendido entre Q300 y Q1300: {between300and1300Amount:C2}");
        Console.WriteLine($"Número de ventas menores a Q300: {under300Count}");
        Console.WriteLine($"Monto total vendido por debajo de Q300: {under300Amount:C2}");
        Console.WriteLine($"Cantidad total vendida en general: {totalVentas:C2}");
    }

}