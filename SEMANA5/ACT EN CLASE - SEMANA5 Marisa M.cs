using System;

class Program
{
    static void Main() {
        int x = 10;
        double y = 25;
        double z = x + y;
        
        int w = 4;
        double a = y / w;
        double b = y / w; 
        double c = y % w; 

        Console.WriteLine("Suma: "+ z);
        Console.WriteLine("Division a: "+ a);
        Console.WriteLine("Division b: "+ b);
        Console.WriteLine("Modulo c: "+ c);
    }
}