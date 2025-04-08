//6- Busca em Lista de Objetos: Dado um array de objetos representando alunos (Nome e Matrícula), implemente uma função
que retorne o aluno correspondente a uma matrícula específica

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Matrícula: {Matricula}";
    }
}

static Aluno BuscaAluno(Aluno[] alunos, int matricula)
{
    foreach (Aluno aluno in alunos)
    {
        if (aluno.Matricula == matricula)
            return aluno;
    }
    return null;
}
