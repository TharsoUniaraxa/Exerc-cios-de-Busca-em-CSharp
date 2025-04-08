//1- Básico: Implemente um algoritmo que realize uma busca sequencial em um array de inteiros e retorne o índice do elemento encontrado

static int BuscaSequencial(int[] array, int elemento)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
            return i;
    }
    return -1;
}
