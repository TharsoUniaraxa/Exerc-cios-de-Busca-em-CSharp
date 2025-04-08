//8- Par ou Ímpar: Modifique a busca sequencial para encontrar o primeiro número par no array

int[] numeros = { 11, 8, 16, 1, 55, 17, 8, 20, 13 };
int indicePar = LocalizarPrimeiroPar(numeros);

if (indicePar != -1)
{
    Console.WriteLine($"O primeiro par é {numeros[indicePar]}");
}
else
{
    Console.WriteLine("Não há números pares no array");
}

static int LocalizarPrimeiroPar(int[] lista)
{
    for (int contador = 0; contador < lista.Length; contador++)
    {
        if (lista[contador] % 2 == 0)
        {
            return contador;
        }
    }
    return -1;
}
