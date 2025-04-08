//3- Múltiplos Elementos: Modifique a busca binária para encontrar todas as ocorrências de um número no array

static List<int> BuscaTodosOcorrencias(int[] array, int elemento)
{
    List<int> indices = new List<int>();
    int indice = BuscaBinaria(array, elemento);

    if (indice == -1)
        return indices;

    int i = indice;
    while (i >= 0 && array[i] == elemento)
    {
        indices.Add(i);
        i--;
    }
    i = indice + 1;
    while (i < array.Length && array[i] == elemento)
    {
        indices.Add(i);
        i++;
    }
    indices.Sort();
    return indices;
}
