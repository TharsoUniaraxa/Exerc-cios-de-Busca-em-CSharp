//4- Maior Número Menor que X: Dado um array ordenado e um número X, encontre o maior número menor que X na lista

static int MaiorMenorQueX(int[] array, int x)
{
    int resultado = -1;
    int inicio = 0, fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] < x)
        {
            resultado = array[meio];
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }
    return resultado;
}
