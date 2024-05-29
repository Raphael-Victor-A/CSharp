using System; 

class URI {

    static void Main(string[] args) { 

       double area, π = 3.14159, raio;
       
       raio = double.Parse(Console.ReadLine());
       
       area = (π * Math.Pow(raio, 2));
       
       Console.WriteLine("A="+area.ToString("00.0000"));

    }

}