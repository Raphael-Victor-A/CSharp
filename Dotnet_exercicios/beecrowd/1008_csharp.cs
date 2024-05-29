using System; 

class URI {

    static void Main(string[] args) { 

        int horasTrabalhadas, numeroFunc;
        double valorHora;
        
        
        
        numeroFunc = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        valorHora = double.Parse(Console.ReadLine());
        
        Console.WriteLine("NUMBER = "+ numeroFunc);
        Console.WriteLine("SALARY = U$ "+ (horasTrabalhadas * valorHora).ToString("0.00"));
        
        
    }

}