//9- Posição da Última Ocorrência: Dado um array ordenado com números repetidos, modifique a busca binária para encontrar a posição da última ocorrência de um número

int[] dados = { 1, 2, 4, 4, 4, 5, 6, 7 };

Console.Write("Digite o número que deseja encontrar: ");
int alvo = int.Parse(Console.ReadLine());

int indiceFinal = BuscarUltimaOcorrencia(dados, alvo);

if (indiceFinal != -1)
    Console.WriteLine("Última ocorrência na posição: " + indiceFinal);
else
    Console.WriteLine("Número não encontrado na lista.");

static int BuscarUltimaOcorrencia(int[] vetor, int valor)
{
    int esquerda = 0;
    int direita = vetor.Length - 1;
    int posicaoEncontrada = -1;

    while (esquerda <= direita)
    {
        int centro = (esquerda + direita) / 2;

        if (vetor[centro] == valor)
        {
            posicaoEncontrada = centro;
            esquerda = centro + 1;
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

    return posicaoEncontrada;
}

