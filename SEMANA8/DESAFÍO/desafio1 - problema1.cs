using System;

class Program
{
    static void Main() {
        const int numMeses = 20;
        const double pagoInicial = 10;
        double totalPago = 0;

        double pagoMensual = (Math.Pow(2, numMeses) - 1) / 100;

        Console.WriteLine($"Pago Mensual: {pagoMensual:C2}"); //C2 son dos decimales 

        for (int i = 0; i < numMeses; i++) {
            double pago = pagoInicial * Math.Pow(2, i);
            totalPago += pago;
        }

        Console.WriteLine($"Pago total en {numMeses} meses: {totalPago:C2}");
    }
}