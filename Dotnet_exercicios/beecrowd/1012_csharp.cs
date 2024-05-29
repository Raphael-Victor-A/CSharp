using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');
        double A, B, C;
        
        A = double.Parse(input[0]);
        B = double.Parse(input[1]);
        C = double.Parse(input[2]);
        
        
        Console.WriteLine("TRIANGULO: "+((A * C)/2).ToString("0.000"));
        Console.WriteLine("CIRCULO: "+(3.14159 * Math.Pow(C, 2)).ToString("0.000"));
        Console.WriteLine("TRAPEZIO: "+ (((A+B)*C)/2).ToString("0.000"));
        Console.WriteLine("QUADRADO: " + (Math.Pow(B, 2)).ToString("0.000"));
        Console.WriteLine("RETANGULO: " + (A * B).ToString("0.000"));


        
    }

}