//6- Inserção Ordenada: Use a busca binária para determinar onde um número deveria ser inserido em um array ordenado para manter a ordem

static int novaposicao(int[] array, int valor)
{
    int inicio = 0;
    int fim = array.Length;

    while (inicio < fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] < valor)
            inicio = meio + 1;
        else
            fim = meio;
    }

    return inicio;
}

int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int novon = 10;
int posicao = novaposicao(n, novon);

Console.WriteLine($"o número {novon} deve estar na posição {posicao}");
