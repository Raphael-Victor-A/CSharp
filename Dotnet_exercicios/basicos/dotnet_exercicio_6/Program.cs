//Faça um Programa que peça a temperatura em graus Farenheit, transforme e mostre a temperatura em graus Celsius. C = (5 * (F-32) / 9).

using System;

double celsius, fahrenheit;

Console.WriteLine("Para todo e qualquer numero flutuante use virgula");
Console.ReadLine();

Console.WriteLine("Qual temperatura em fahrenheit deseja converter para celsius");
fahrenheit = double.Parse(Console.ReadLine());

celsius = (5* (fahrenheit-32))/9;

Console.WriteLine("Sua temperatura convertida para celsius é: " + celsius);