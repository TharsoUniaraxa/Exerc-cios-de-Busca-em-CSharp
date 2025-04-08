//3- Busca em Lista de Strings: Dado um array de nomes, crie uma função que recebe um nome e retorna o índice onde ele está localizado

static int buscar(string[] lista, string nome)
{
    for (int i = 0; i < lista.Length; i++)
        if (lista[i] == nome)
            return i;

    return -1;
}

string[] n = new string[] { "Gabriel", "João", "Tharso", "Marcus" };
string nprocurado = "Gabriel";
int indice = buscar(n, nprocurado);

if (indice >= 0)
    Console.WriteLine($"nome {nprocurado} achado no índice {indice}.");
else
    Console.WriteLine($"nome {nprocurado} não achado na lista.");
