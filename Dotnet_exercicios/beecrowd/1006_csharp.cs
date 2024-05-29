using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, C, Media;
        
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());
        
        
        Media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10;
        
        Console.WriteLine("MEDIA = "+ Media.ToString("0.0"));
       
    }

}