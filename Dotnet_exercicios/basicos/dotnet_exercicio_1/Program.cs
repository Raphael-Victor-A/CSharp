//Faça um Programa que peça as 4 notas bimestrais e mostre a média.

double[] nota = new double[4];
double soma;
double media;

Console.WriteLine("Digite as notas usando virgula para separar os decimais");
Console.ReadLine();


Console.Clear();
Console.WriteLine("Digite a primeira nota: ");
nota[0] = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
nota[1] = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
nota[2] = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota: ");
nota[3] = double.Parse(Console.ReadLine());

soma = nota[0] + nota[1] + nota[2] + nota[3];
media = soma / 4;

Console.WriteLine($"A média do aluno é {media :F2}");