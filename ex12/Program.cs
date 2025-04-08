//2- Verificação de Existência: Dado um array ordenado, crie um programa que informe se um número existe ou não na lista, sem precisar retornar o índice

static bool VerificaExistencia(int[] array, int elemento)
{
    return BuscaBinaria(array, elemento) != -1;
}
