//9- Posição da Última Ocorrência: Dado um array ordenado com números repetidos, modifique a busca binária para encontrar a posição da última ocorrência de um número

static int UltimoIndice(int[] array, int elemento)
{
    int indice = -1;
    int inicio = 0, fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == elemento)
        {
            indice = meio;
            inicio = meio + 1;
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
