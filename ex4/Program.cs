//4- Maior e Menor Elemento: Use busca sequencial para encontrar o maior e o menor número de um array

﻿using System.Reflection;

int[] n = { 50, 100, 200, 240, 210, 270 };

int maior = emaior(n);
int menor = emenor(n);

Console.WriteLine($"o maior número é: {maior}");
Console.WriteLine($"o menor número é: {menor}");

int emaior(int[] array)
{
    int maior = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] > maior)
            maior = array[i];

    return maior;
}

int emenor(int[] array)
{
    int menor = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < menor)
            menor = array[i];

    return menor;
}
