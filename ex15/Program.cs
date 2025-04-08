//5- Menor Número Maior que X: Dado um array ordenado e um número X, encontre o menor número maior que X na lista

int[] dadosOrdenados = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o número que deseja inserir: ");
int valorNovo = int.Parse(Console.ReadLine());

int indiceInsercao = CalcularPosicaoInsercao(dadosOrdenados, valorNovo);

Console.WriteLine("O número deve ser inserido na posição: " + indiceInsercao);

static int CalcularPosicaoInsercao(int[] vetor, int elemento)
{
    int esquerda = 0;
    int direita = vetor.Length;

    while (esquerda < direita)
    {
        int centro = (esquerda + direita) / 2;

        if (vetor[centro] < elemento)
            esquerda = centro + 1;
        else
            direita = centro;
    }

    return esquerda;
}
