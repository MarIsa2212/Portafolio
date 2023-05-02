using System;

class Program
{
    static void Main() {
            //entradas 
            double sueldo;
            double impuestos;
        
            //proceso y salida
            Console.WriteLine("Ingrese su sueldo");
            sueldo = impuestos = Convert.ToDouble(Console.ReadLine());
        
            if (sueldo > 3000){
                Console.WriteLine("Debe abonar impuestos");
            
            
                impuestos = sueldo * 0.05; 
                Console.WriteLine("Debe abonar esta cantidad de impuestos: "+impuestos);
            
            }else {
                Console.WriteLine("No debe abonar");
            }
    }
}