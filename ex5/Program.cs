//5- Elemento Múltiplo de X: Dado um array e um número X, encontre o primeiro número que seja múltiplo de X usando busca sequencial

int[] n = { 5, 13, 15, 18, 20 };
int x = 3;

int resultado = buscar(n, x);

if (resultado >= 0)
    Console.WriteLine($"o primeiro numero múltiplo de {x} achado no array é {resultado}.");
else
    Console.WriteLine("nenhum numero achado");

static int buscar(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % x == 0)
            return array[i];

    return -1;
}
