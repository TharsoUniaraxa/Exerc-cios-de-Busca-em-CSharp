//2- Contagem de Ocorrências: Modifique o algoritmo de busca sequencial para contar quantas vezes um número aparece no array

using System.Diagnostics.Contracts;

static int contar(int[] array, int nprocurado)
{
    int contagem = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] == nprocurado)
            contagem++;

    return contagem;
}

int[] n = new int[] { 2, 5, 7, 4, 2, 5, 7, 8, 7 };
int nprocurado = 7;

int contagem = contar(n, nprocurado);

Console.WriteLine($"o numero {nprocurado} apareceu {contagem} vezes no array.");
