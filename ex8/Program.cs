//8- Par ou Ímpar: Modifique a busca sequencial para encontrar o primeiro número par no array

static int BuscaPrimeiroPar(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            return array[i];
    }
    return -1;
}
