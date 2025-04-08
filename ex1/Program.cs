//1- Básico: Implemente um algoritmo que realize uma busca sequencial em um array de inteiros e retorne o índice do elemento encontrado

static int buscar(int[] array, int valor)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == valor)
            return i;

    return -1;
}

int[] n = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int valor = 30;
int busca = buscar(n, valor);

if (busca >= 0)
{
    Console.WriteLine($"o valor {valor} achado na busca {busca}.");
}
else
{
    Console.WriteLine("valor não achado.");
}
