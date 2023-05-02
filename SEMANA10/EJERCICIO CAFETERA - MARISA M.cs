using System;

class cafetera{
    
bool lleno; 
int codigo = 18788;
int capacidad;
int disponibles; 


    //Hacer café 
    public void hacerCafe(int x){
        lleno = true; 
        capacidad = x; 
        disponibles = capacidad; 
    
    }

    //servir taza 
    public void servirTaza(int cantTazas){
        if (disponibles == cantTazas){
            disponibles = disponibles - cantTazas;
        }else{
            Console.WriteLine("no tenemos suficientes tazas disponibles ");
        }
    }

    public double obtenerPorcentaje(){
        double porcentaje = ((double)disponibles/capacidad)*100;
        return porcentaje; 
    }

    //mostrar estado
    public void mostrarEstado(){
        string texto = codigo+" capacidad: "+capacidad+" tazas servidas: "+(capacidad - disponibles)+"porcentaje de disponibilidad: "+obtenerPorcentaje()+"%";
        Console.WriteLine(texto);
    }
    //constructor
    public Cafetera(int elCodigo, int laCapacidad){
        codigo = elCodigo;
        capacidad = laCapacidad;
        lleno = false;
        disponibles = 0;
    }
    
    
    public static void Main() {
        Console.WriteLine("Ingrese capacidad de cafetera");
        int cap = Convert.ToInt32(Console.ReadLine());
        string option = "";
        Cafetera cafe = new Cafetera(1, cap);
        
        cafe.hacerCafe(cap);
        do{
            Console.WriteLine("Cuantas tazas quiere servir?");
            int tz = Convert.ToInt32(Console.ReadLine());
            cafe.servirTaza(tz);
            cafe.mostarEstado();
            
            Console.WriteLine("Desea ingresar más tazas? s/n");
            option = Console.ReadLine();
            
        }while(option == "s");
        
        //cafe.servirTaza(10); //deberia dar error 
        
        
        
    }
        
}