//3- Busca em Lista de Strings: Dado um array de nomes, crie uma função que recebe um nome e retorna o índice onde ele está localizado

static int BuscaString(string[] nomes, string nome)
{
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i].Equals(nome, StringComparison.CurrentCultureIgnoreCase))
            return i;
    }
    return -1;
}
