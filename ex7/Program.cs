//7- Última Ocorrência: Modifique o algoritmo de busca sequencial para retornar a última ocorrência de um elemento no array

static int BuscaUltimaOcorrencia(int[] array, int elemento)
{
    int indice = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
            indice = i;
    }
    return indice;
}
