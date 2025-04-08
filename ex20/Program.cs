//10- Número mais Próximo: Modifique a busca binária para encontrar o número mais próximo de um valor X dentro de um array ordenado

int[] valores = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o valor de X: ");
int alvo = int.Parse(Console.ReadLine());

int valorMaisProximo = EncontrarValorMaisProximo(valores, alvo);

Console.WriteLine("Número mais próximo de X: " + valorMaisProximo);

static int EncontrarValorMaisProximo(int[] arrayOrdenado, int referencia)
{
    int esquerda = 0;
    int direita = arrayOrdenado.Length - 1;
    int candidato = arrayOrdenado[0];

    while (esquerda <= direita)
    {
        int centro = (esquerda + direita) / 2;

        if (arrayOrdenado[centro] == referencia)
            return arrayOrdenado[centro];

        int diferencaAtual = Math.Abs(arrayOrdenado[centro] - referencia);
        int diferencaCandidato = Math.Abs(candidato - referencia);

        if (diferencaAtual < diferencaCandidato ||
            (diferencaAtual == diferencaCandidato && arrayOrdenado[centro] < candidato))
        {
            candidato = arrayOrdenado[centro];
        }

        if (arrayOrdenado[centro] < referencia)
            esquerda = centro + 1;
        else
            direita = centro - 1;
    }

    return candidato;
}
