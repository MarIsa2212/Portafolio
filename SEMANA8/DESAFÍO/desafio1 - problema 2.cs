using System;

class Program
{
    static void Main() {
        
        const int numEmpleados = 3;
        const double tarifaHora = 15.50;
        double total = 0;

        for (int i = 1; i <= numEmpleados; i++) {
            Console.WriteLine($"Empleado {i}");

            int totalHoras = 0;

            for (int j = 1; j <= 5; j++) {
                Console.Write($"Ingrese el numero de horas por día {j}: ");
                int hora = int.Parse(Console.ReadLine());
                totalHoras += hora;
            }

            double pagoSem = totalHoras * tarifaHora;
            total += pagoSem;

            Console.WriteLine($"Pago semanal: {pagoSem:C2}");
            Console.WriteLine();
        }

        Console.WriteLine($"Total para {numEmpleados} empleados: {total:C2}");
    }


    
}