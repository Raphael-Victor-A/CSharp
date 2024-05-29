using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, Media;
        
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        
        Media = ((A * 3.5) + (B * 7.5)) / 11;
        
        if(Media <= 10){
            Console.WriteLine("MEDIA = "+ Media.ToString("0.00000"));
        }
    }

}