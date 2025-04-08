//8- Posição do Primeiro Elemento: Dado um array ordenado com números repetidos, modifique a busca binária para encontrar a posição da primeira ocorrência de um número

int[] dados = { 1, 2, 4, 4, 4, 5, 6, 7 };

Console.Write("Digite o número que deseja encontrar: ");
int alvo = int.Parse(Console.ReadLine());

int indiceInicial = LocalizarPrimeiraOcorrencia(dados, alvo);

if (indiceInicial != -1)
    Console.WriteLine("Primeira ocorrência na posição: " + indiceInicial);
else
    Console.WriteLine("Número não encontrado na lista.");

static int LocalizarPrimeiraOcorrencia(int[] vetor, int valor)
{
    int esquerda = 0;
    int direita = vetor.Length - 1;
    int posicao = -1;

    while (esquerda <= direita)
    {
        int centro = (esquerda + direita) / 2;

        if (vetor[centro] == valor)
        {
            posicao = centro;
            direita = centro - 1;
        }
        else if (vetor[centro] < valor)
        {
            esquerda = centro + 1;
        }
        else
        {
            direita = centro - 1;
        }
    }

    return posicao;
}

