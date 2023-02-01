// See https://aka.ms/new-console-template for more information

using System;

public class exercicio_5{
    public static void Main(string[] args){
        int numA, numB;

        Console.Write("\nDigite o primeiro numero: ");
        numA = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o segundo numero: ");
        numB = int.Parse(Console.ReadLine());

        Console.Write("\nO numeros trocados foram foram: \nA: "+numB);
        Console.Write("\nB: "+numA);
    }
}