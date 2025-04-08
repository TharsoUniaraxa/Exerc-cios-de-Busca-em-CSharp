//9- Busca com Sentinela: Implemente a busca sequencial com um sentinela (adicionando o elemento buscado no final do array para evitar verificações extras)

int[] numeros = { 10, 25, 30, 45, 60 };
int alvo = 45;

int posicaoEncontrada = BuscarValor(numeros, alvo);

if (posicaoEncontrada != -1)
{
    Console.WriteLine($"Número {alvo} encontrado na posição {posicaoEncontrada}.");
}
else
{
    Console.WriteLine("Número não encontrado.");
}

static int BuscarValor(int[] vetorOriginal, int elemento)
{
    int tamanho = vetorOriginal.Length;
    int[] vetorComSentinela = new int[tamanho + 1];
    
    vetorComSentinela[tamanho] = elemento;
    Array.Copy(vetorOriginal, vetorComSentinela, tamanho);

    int indice = 0;
    while (vetorComSentinela[indice] != elemento)
    {
        indice++;
    }

    return (indice < tamanho) ? indice : -1;
}
