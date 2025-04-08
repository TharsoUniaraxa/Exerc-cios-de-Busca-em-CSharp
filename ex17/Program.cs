//7- Palavras Ordenadas: Aplique busca binária para procurar palavras dentro de um dicionário ordenado

string[] palavrasOrdenadas = { "abacate", "banana", "cachorro", "dado", "elefante", "foca", "gato" };

Console.Write("Digite a palavra que deseja procurar: ");
string termo = Console.ReadLine();

bool encontrada = VerificarExistenciaPalavra(palavrasOrdenadas, termo);

if (encontrada)
    Console.WriteLine("A palavra existe no dicionário.");
else
    Console.WriteLine("A palavra NÃO existe no dicionário.");

static bool VerificarExistenciaPalavra(string[] colecao, string termoBuscado)
{
    int esquerda = 0;
    int direita = colecao.Length - 1;

    while (esquerda <= direita)
    {
        int centro = (esquerda + direita) / 2;
        int resultadoComparacao = string.Compare(colecao[centro], termoBuscado, StringComparison.OrdinalIgnoreCase);

        if (resultadoComparacao == 0)
            return true;
        else if (resultadoComparacao < 0)
            esquerda = centro + 1;
        else
            direita = centro - 1;
    }

    return false;
}
