using System;

class Program
{
    static void Main() {
        double r = 5;
        double pi = 3.1415;
        Console.WriteLine($"r = {r}");
        Console.WriteLine($"pi = {pi}");
        
        double area; 
        area = pi*(r*r);
        Console.WriteLine($"area = {area}");
    }
}