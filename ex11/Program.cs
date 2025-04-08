//1- Básico: Implemente a busca binária em um array ordenado de inteiros e retorne o índice do número procurado

int[] dados = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
int alvo;

Console.Write("Escreva o número que deseja procurar: ");
alvo = int.Parse(Console.ReadLine());

if (VerificarExistencia(dados, alvo))
    Console.WriteLine("O número existe na lista.");
else
    Console.WriteLine("O número não existe.");

static bool VerificarExistencia(int[] vetorOrdenado, int elemento)
{
    int limiteInferior = 0;
    int limiteSuperior = vetorOrdenado.Length - 1;

    while (limiteInferior <= limiteSuperior)
    {
        int pontoMedio = (limiteInferior + limiteSuperior) / 2;

        if (vetorOrdenado[pontoMedio] == elemento)
            return true;
        else if (vetorOrdenado[pontoMedio] < elemento)
            limiteInferior = pontoMedio + 1;
        else
            limiteSuperior = pontoMedio - 1;
    }

    return false;
}
