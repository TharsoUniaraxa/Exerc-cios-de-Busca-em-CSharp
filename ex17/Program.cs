//7- Palavras Ordenadas: Aplique busca binária para procurar palavras dentro de um dicionário ordenado

static int BuscaBinariaString(string[] palavras, string palavra)
{
    int inicio = 0, fim = palavras.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        int comparacao = string.Compare(palavras[meio], palavra, StringComparison.CurrentCultureIgnoreCase);

        if (comparacao == 0)
            return meio;
        if (comparacao < 0)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }
    return -1;
}
