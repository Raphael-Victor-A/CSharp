using System; 

class URI {

    static void Main(string[] args) { 
        
       string[] input1 = Console.ReadLine().Split(' ');
       int[] codigo = new int[2];
       int[] qntPecas = new int[2];
       double[] valor = new double[2];
       
       codigo[0] = int.Parse(input1[0]); 
       qntPecas[0] = int.Parse(input1[1]); 
       valor[0] = double.Parse(input1[2]);
       
       string[] input2 = Console.ReadLine().Split(' ');
       codigo[1] = int.Parse(input2[0]); 
       qntPecas[1] = int.Parse(input2[1]); 
       valor[1] = double.Parse(input2[2]);
       
       Console.WriteLine("VALOR A PAGAR: R$ " + ((qntPecas[0] * valor[0]) + (qntPecas[1] * valor[1])).ToString("0.00"));
       
    }

}
