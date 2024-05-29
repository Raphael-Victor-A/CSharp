//Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.

double horas, valorHora, total;



Console.WriteLine("Todo e qualquer valor quebrado use virgula");
Console.ReadLine();

Console.Clear();

Console.WriteLine("Quantos você ganha por hora");
valorHora = double.Parse(Console.ReadLine());
Console.WriteLine("Quantas horas você trabalhou esse mês");
horas = double.Parse(Console.ReadLine());

total = valorHora * horas;

Console.WriteLine($"Esse mês você trabalhou {horas} horas no valor {valorHora} reais");
Console.WriteLine($"O valor faturado esse mês é: {total}");
