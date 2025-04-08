//10- Número mais Próximo: Modifique a busca binária para encontrar o número mais próximo de um valor X dentro de um array ordenado

static int NumeroMaisProximo(int[] array, int x)
{
    if (x <= array[0])
        return array[0];
    if (x >= array[array.Length - 1])
        return array[array.Length - 1];

    int inicio = 0, fim = array.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == x)
            return array[meio];
        else if (array[meio] < x)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    if (inicio >= array.Length)
        return array[fim];

    int diff1 = Math.Abs(array[inicio] - x);
    int diff2 = Math.Abs(x - array[fim]);

    return diff1 < diff2 ? array[inicio] : array[fim];
}
