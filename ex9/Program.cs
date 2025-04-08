//9- Busca com Sentinela: Implemente a busca sequencial com um sentinela (adicionando o elemento buscado no final do array para evitar verificações extras)

static int BuscaComSentinela(int[] array, int elemento)
{
    int n = array.Length;
    int[] novoArray = new int[n + 1];
    Array.Copy(array, novoArray, n);
    novoArray[n] = elemento;

    int i = 0;
    while (novoArray[i] != elemento)
    {
        i++;
    }
    return i == n ? -1 : i;
}
