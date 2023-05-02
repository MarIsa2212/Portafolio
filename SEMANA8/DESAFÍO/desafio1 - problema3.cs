using System;

class Program
{
    static void Main() {
        
        const double valorBillete = 1.00;
        const double valorMoneda = 0.25;
        
        //Billetes
        Console.Write("Ingrese el numero de billetes de Q1: ");
        int billeteQ1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de billetes de Q5: ");
        int billeteQ5 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de billetes de Q10: ");
        int billeteQ10 = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el numero de billetes de Q20: ");
        int billeteQ20 = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el numero de billetes de Q50: ");
        int billeteQ50 = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el numero de billetes de Q100: ");
        int billeteQ100 = int.Parse(Console.ReadLine());
        
        //Monedas
        Console.Write("Ingrese el numero de onedas de 25 centavos: ");
        int c25 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de onedas de 10 centavos: ");
        int c10 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de onedas de 5 centavos: ");
        int c5 = int.Parse(Console.ReadLine());

        

        double totalBilletes = (billeteQ5 * 5 * valorBillete) +
                              (billeteQ10 * 10 * valorBillete) + 
                              (billeteQ20 * 20 * valorBillete) +
                              (billeteQ50 * 50 * valorBillete) +
                              (billeteQ100 * 100 * valorBillete);
        double totalMonedas = (c25 * valorMoneda) +
                            (c10 * 0.10) +
                            (c5 * 0.05) + 
                            (billeteQ1 * valorBillete);
                            
        double total = totalBilletes + totalMonedas;

        Console.WriteLine($"Total en caja: {total:C2}");
    }

}