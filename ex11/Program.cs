//1- Básico: Implemente a busca binária em um array ordenado de inteiros e retorne o índice do número procurado

static int BuscaBinaria(int[] array, int elemento)
{
    int inicio = 0, fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == elemento)
            return meio;
        if (array[meio] < elemento)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }
    return -1;
}
