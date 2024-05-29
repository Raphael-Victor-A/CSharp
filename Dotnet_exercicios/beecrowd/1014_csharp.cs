using System; 

class URI {

    static void Main(string[] args) { 

        int X;
        double Y;
        
        X = int.Parse(Console.ReadLine());
        Y = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"{(X/Y).ToString("0.000")} km/l");

    }

}