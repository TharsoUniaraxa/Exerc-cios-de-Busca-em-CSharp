//8- Posição do Primeiro Elemento: Dado um array ordenado com números repetidos, modifique a busca binária para encontrar a posição da primeira ocorrência de um número

static int PrimeiroIndice(int[] array, int elemento)
{
    int indice = -1;
    int inicio = 0, fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == elemento)
        {
            indice = meio;
            fim = meio - 1;
        }
        else if (array[meio] < elemento)
        {
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }
    return indice;
}
