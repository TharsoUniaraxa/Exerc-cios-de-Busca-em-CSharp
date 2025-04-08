//5- Elemento Múltiplo de X: Dado um array e um número X, encontre o primeiro número que seja múltiplo de X usando busca sequencial

static int BuscaMultiplo(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % x == 0)
            return array[i];
    }
    return -1;
}
