using System; 

class URI {

    static void Main(string[] args) { 

        double raioEsfera;
        
        raioEsfera = double.Parse(Console.ReadLine());
        
        Console.WriteLine("VOLUME = "+ ((4.0/3) *  3.14159 * Math.Pow(raioEsfera,3)).ToString("0.000"));

    }

}