using System; 

class URI {

    static void Main(string[] args) { 
        int N, horas, minutos;
        
        N = int.Parse(Console.ReadLine());
        
        minutos = N/60;
        N %= 60;
        horas = minutos/60;
        minutos%=60;
        
        
        
        Console.WriteLine($"{horas}:{minutos}:{N}");

    }

}