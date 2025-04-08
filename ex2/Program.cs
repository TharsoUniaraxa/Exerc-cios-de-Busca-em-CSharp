//2- Contagem de Ocorrências: Modifique o algoritmo de busca sequencial para contar quantas vezes um número aparece no array

static int ContaOcorrencias(int[] array, int elemento)
{
    int contador = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
            contador++;
    }
    return contador;
}
