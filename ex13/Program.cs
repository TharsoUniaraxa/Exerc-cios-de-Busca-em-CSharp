//3- Múltiplos Elementos: Modifique a busca binária para encontrar todas as ocorrências de um número no array

int[] sequencia = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o número X: ");
int numeroAlvo = int.Parse(Console.ReadLine());

int valorEncontrado = EncontrarMaiorMenorQue(sequencia, numeroAlvo);

if (valorEncontrado == -1)
    Console.WriteLine("Não existe número menor que X na lista.");
else
    Console.WriteLine("Maior número menor que X: " + valorEncontrado);

static int EncontrarMaiorMenorQue(int[] vetor, int limite)
{
    int esquerda = 0;
    int direita = vetor.Length - 1;
    int candidato = -1;

    while (esquerda <= direita)
    {
        int indiceCentral = (esquerda + direita) / 2;

        if (vetor[indiceCentral] < limite)
        {
            candidato = vetor[indiceCentral];
            esquerda = indiceCentral + 1;
        }
        else
        {
            direita = indiceCentral - 1;
        }
    }

    return candidato;
}
