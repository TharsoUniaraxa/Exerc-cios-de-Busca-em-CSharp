//4- Maior e Menor Elemento: Use busca sequencial para encontrar o maior e o menor número de um array

static void MaiorMenor(int[] array, out int maior, out int menor)
{
    if (array == null || array.Length == 0)
        throw new ArgumentException("Array não pode ser vazio.");

    maior = array[0];
    menor = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maior)
            maior = array[i];
        if (array[i] < menor)
            menor = array[i];
    }
}
