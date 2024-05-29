using System; 

class URI {

    static void Main(string[] args) { 

        int dias, ano, mes;
        
        dias = int.Parse(Console.ReadLine());
        
        
        ano = dias/365;
        dias %= 365;
        
        mes = dias/30;
        dias %=30;
       
        
        
        Console.WriteLine(ano + " ano(s)");
        Console.WriteLine(mes + " mes(es)");
        Console.WriteLine(dias + " dia(s)");
        

    }

}