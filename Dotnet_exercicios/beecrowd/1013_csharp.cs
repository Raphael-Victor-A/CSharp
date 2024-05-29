using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');
        int A, B, C;
        
        A = int.Parse(input[0]);
        B = int.Parse(input[1]);
        C = int.Parse(input[2]);
        
        int maiorAB = (A+B+Math.Abs(A-B))/2;
        int maiorC = (maiorAB + C + Math.Abs(maiorAB - C))/2;
        
        Console.WriteLine( maiorC+" eh o maior");
        
    }

}