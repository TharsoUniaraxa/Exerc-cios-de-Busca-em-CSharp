//7- Última Ocorrência: Modifique o algoritmo de busca sequencial para retornar a última ocorrência de um elemento no array

int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int nprocurado = 3;

int lugar = Buscar(n, nprocurado);

if (lugar >= 0)
    Console.WriteLine($"ultima ocorrência do valor {nprocurado} está no lugar {lugar}.");
else
    Console.WriteLine("valor não achado");

static int Buscar(int[] array, int valor)
{
    int ultimaPosicao = -1;

    for (int indice = 0; indice < array.Length; indice++)
        if (array[indice] == valor)
            ultimaPosicao = indice;

    return ultimaPosicao;
}
