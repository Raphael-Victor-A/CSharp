//Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.

using System;

double lado, area, dobroArea;

Console.WriteLine("Usar a virgula caso seja numero flutuante");
Console.ReadLine();

Console.WriteLine("Me diga o valor do lado do seu quadrado");
lado = double.Parse(Console.ReadLine());

area = Math.Pow(lado, 2);
dobroArea = area*2;


Console.WriteLine($"A area do seu quadrado é: {area}");
Console.WriteLine($"E o dobro da area do seu quadrado é: {dobroArea}");
