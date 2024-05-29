using System; 

class URI {

    static void Main(string[] args) { 

        string nome;
        double salarioFixo, montante;
        
        nome = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine());
        montante = double.Parse(Console.ReadLine());
        
        // 15% = 0,15
        
        Console.WriteLine("TOTAL = R$ "+ (salarioFixo + (montante * 0.15)).ToString("00.00"));
    }

}