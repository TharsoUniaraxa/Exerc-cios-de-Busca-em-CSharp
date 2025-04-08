//10- Palavra em Texto: Crie um programa que recebe um texto e busca uma palavra dentro dele, retornando a posição inicial da palavra se for encontrada

static int BuscaPalavra(string texto, string palavra)
{
    int posicao = -1;
    string[] palavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int indexAcumulado = 0;
    for (int i = 0; i < palavras.Length; i++)
    {
        if (palavras[i].Equals(palavra, StringComparison.CurrentCultureIgnoreCase))
        {
            posicao = indexAcumulado;
            break;
        }
        indexAcumulado += palavras[i].Length + 1;
    }
    return posicao;
}
