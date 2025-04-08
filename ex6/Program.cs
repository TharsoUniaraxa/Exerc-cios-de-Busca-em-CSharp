//6- Busca em Lista de Objetos: Dado um array de objetos representando alunos (Nome e Matrícula), implemente uma função que retorne o aluno correspondente a uma matrícula específica

class Program
{
    static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[]
        {
            new Aluno { nome = "João", matricula = "123" },
            new Aluno { nome = "Maria", matricula = "456" },
            new Aluno { nome = "José", matricula = "789" }
        };

        string matriculaachada = "456";
        Aluno alunoachado = buscaralunom(alunos, matriculaachada);

        if (alunoachado is not null)
            Console.WriteLine($"aluno achado: {alunoachado.nome}, Matrícula: {alunoachado.matricula}");
        else
            Console.WriteLine("aluno não achado.");
    }

    static Aluno buscaralunom(Aluno[] alunos, string matricula)
    {
        for (int i = 0; i < alunos.Length; i++)
            if (alunos[i].matricula == matricula)
                return alunos[i];

        return null;
    }
}

class Aluno
{
    public string nome;
    public string matricula;
}
