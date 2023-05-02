using System;

class libro{
    int codigo = 1068823;
    int paginas; 
    string titulo;
    bool leido;
    int faltantes; 
    int paginasLeidas;
    double porciento;
    
    //Leer 
    public void leerPaginas(cantPag){
        
        paginasLeidas = paginasLeidas + cantPag;
        faltantes = paginas - paginasLeidas;
        
        if (paginasLeidas == paginas){
            
            Console.WriteLine(" ERROR: Ya no hay más páginas por leer ");
        }
        
        
    }
    //Porcentaje  
    public double obtenerPorcentaje(){
        double porcentaje = ((double)faltantes/paginas)*100;
        
        porciento = porcentaje;
        return porcentaje;
        
        
    }
    //Paginas 
    public int obtenerPagina(){
        int PaginaActual = paginas - (paginas - paginasLeidas)
        return paginaActual;
        
        
    }
    //Datos del libro  
    public void mostrarLibro(){
        string texto = codigo+" nombre: "+titulo+" cantidad de paginas: "+(faltantes-pagina)+"porcentaje de lectura: "+obtenerPorcentaje()+"%";
        Console.WriteLine(texto);
        
        
    }
    //Leido o no leido 
    public void obtenerEstado(int x){
        leido = true; 
        paginas = x; 
        faltantes = paginas;
        if (){
            
        }
         
    }
    
    //constrcutor
    public Libro(int elCodigo, int elTitulo, int CantPaginas){
        codigo = elCodigo;
        titulo = elTitulo;
        leido = false;
        faltantes = 0;
    }
    
    
{
    public static void Main() {
        Console.WriteLine("Ingrese cantidad de paginas");
        int can = Convert.ToInt32(Console.ReadLine());
        string option = "";
        Libro pag = new Libro(1, can);
        
    
    }
}