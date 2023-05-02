using System;

class Program
{
    static void Main() {
        int i = 0;
        i++; // i = i + 1
        Console.WriteLine("i: "+ i);
        ++i;
        Console.WriteLine("i v2: "+ i);
        int val = 10 / i++; //10/2
        Console.WriteLine("val: "+ val);
        Console.WriteLine("i v3: "+ i);

        //operadores logicos
        bool res = 3 < 6; //booleano: o es verdadero o es falso, solo un resultado
        Console.WriteLine("Res: "+res);
        int nota = 90;
        bool res2 = nota > 90 && nota < 100;
        Console.WriteLine("Res2: "+res2);
        bool res3 = 'A' == 'A';
        Console.WriteLine("Res3: "+res3);
    }
}