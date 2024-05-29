//Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

using System;

double raio, area;
const double pi = 3.14;

console.WriteLine("Digite o raio do círculo: ");
raio = double.Parse(console.ReadLine());

area = pi * Math.Pow(raio, 2);

console.WriteLine($"A área do círculo é: {area}");