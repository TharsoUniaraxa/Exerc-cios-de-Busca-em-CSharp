//4- Maior Número Menor que X: Dado um array ordenado e um número X, encontre o maior número menor que X na lista

static int maior(int[] array, int x)
{
    int inicio = 0;
    int fim = array.Length - 1;
    int resultado = -1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] < x)
        {
            resultado = array[meio];
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }

    return resultado;
}

int[] n = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
int x = 7;
int resultado = maior(n, x);

if (resultado >= 0)
    Console.WriteLine($"O maior número menor que {x} é {resultado}");
else
    Console.WriteLine($"Não existe número menor que {x}");
