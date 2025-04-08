//2- Verificação de Existência: Dado um array ordenado, crie um programa que informe se um número existe ou não na lista, sem precisar retornar o índice

static bool temlista(int[] array, int nprocurado)
{
    int inicio = 0;
    int fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] == nprocurado)
            return true;
        else if (array[meio] < nprocurado)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    return false;
}

int[] n = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
int nprocurado = 11;

bool tem = temlista(n, nprocurado);

if (tem)
    Console.WriteLine($"O número {nprocurado} está na lista.");
else
    Console.WriteLine($"O número {nprocurado} não está na lista.");
