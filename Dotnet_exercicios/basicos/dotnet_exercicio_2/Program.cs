//Faça um Programa que converta metros para centímetros.

double centimetros, metros;

Console.WriteLine("Digite um valor em centimetros que deseja converter para metros: ");
centimetros = double.Parse(Console.ReadLine());

metros = centimetros /100;

Console.WriteLine($"O valor convertido para metros é: {metros}m.");
