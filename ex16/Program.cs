//6- Inserção Ordenada: Use a busca binária para determinar onde um número deveria ser inserido em um array ordenado para manter a ordem

static int InsercaoOrdenada(int[] array, int elemento)
{
    int inicio = 0, fim = array.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] < elemento)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }
    return inicio;
}
