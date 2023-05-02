using System;

class Program
{
    static void Main() {
        //entradas
        string nombre;
        int edad;
        
        
        Console.WriteLine("Ingrese su nombre ");
        nombre = Console.ReadLine();

        //si el nombre viene vacío, muestra error, sino da la bienvenida
        //Validar 
        if (nombre==""){
        Console.WriteLine("No increso nombre valido");

        }else{
        Console.WriteLine("Bienvenid@ "+nombre); // la entrada es el nombre
        }
        
        do {
            Console.Write("Ingrese su edad: ");
            
            if (!int.TryParse(Console.ReadLine(), out edad)) {
                Console.WriteLine("Error");
            } else if (edad <= 0 || edad > 100) {
                Console.WriteLine("Error");
            }
        } while (edad <= 0 || edad > 100);

            Console.WriteLine($"Su edad es: {edad}.");
        
    }
}