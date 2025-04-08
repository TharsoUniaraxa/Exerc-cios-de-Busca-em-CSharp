//10- Palavra em Texto: Crie um programa que recebe um texto e busca uma palavra dentro dele, retornando a posição inicial da palavra se for encontrada

static int buscarpalavra(string texto, string palavra)
{
    int limite = texto.Length - palavra.Length;

    for (int i = 0; i <= limite; i++)
        if (texto.Substring(i, palavra.Length) == palavra)
            return i;

    return -1;
}

Console.Write("escreva seu texto: ");
string texto = Console.ReadLine();

Console.Write("escreva a palavra que deseja achar: ");
string palavra = Console.ReadLine();

int posicao = buscarpalavra(texto, palavra);

if (posicao >= 0)
{
    Console.WriteLine($"palavra {palavra} achada na posição {posicao}");
}
else
{
    Console.WriteLine("palavra não achada");
}
