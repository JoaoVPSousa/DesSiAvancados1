// Program.cs
class Program
{
    static List<Professor> professores = new List<Professor>();
    static List<Aluno> alunos = new List<Aluno>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar Professor");
            Console.WriteLine("2. Adicionar Aluno");
            Console.WriteLine("3. Listar Professores");
            Console.WriteLine("4. Listar Alunos");
            Console.WriteLine("5. Remover Professor");
            Console.WriteLine("6. Remover Aluno");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarProfessor();
                    break;
                case "2":
                    AdicionarAluno();
                    break;
                case "3":
                    ListarProfessores();
                    break;
                case "4":
                    ListarAlunos();
                    break;
                case "5":
                    RemoverProfessor();
                    break;
                case "6":
                    RemoverAluno();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarProfessor()
    {
        Console.Write("Nome do Professor: ");
        string? nome = Console.ReadLine();
        
        Console.Write("Idade: ");
        string? idadeInput = Console.ReadLine();
        int idade = idadeInput != null ? int.Parse(idadeInput) : 0;
        
        Console.Write("Disciplina: ");
        string? disciplina = Console.ReadLine();

        if (nome != null && disciplina != null)
        {
            professores.Add(new Professor(nome, idade, disciplina));
            Console.WriteLine("Professor adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: Nome ou disciplina não podem ser nulos.");
        }
    }

    static void AdicionarAluno()
    {
        Console.Write("Nome do Aluno: ");
        string? nome = Console.ReadLine();
        
        Console.Write("Idade: ");
        string? idadeInput = Console.ReadLine();
        int idade = idadeInput != null ? int.Parse(idadeInput) : 0;
        
        Console.Write("Curso: ");
        string? curso = Console.ReadLine();

        if (nome != null && curso != null)
        {
            alunos.Add(new Aluno(nome, idade, curso));
            Console.WriteLine("Aluno adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: Nome ou curso não podem ser nulos.");
        }
    }

    static void ListarProfessores()
    {
        Console.WriteLine("\nLista de Professores:");
        if (professores.Count == 0)
        {
            Console.WriteLine("Nenhum professor cadastrado.");
        }
        else
        {
            foreach (var professor in professores)
            {
                Console.WriteLine(professor.ToString());
            }
        }
    }

    static void ListarAlunos()
    {
        Console.WriteLine("\nLista de Alunos:");
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
        else
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
    }

    static void RemoverProfessor()
    {
        Console.Write("Digite o nome do professor a ser removido: ");
        string? nome = Console.ReadLine();

        if (nome != null)
        {
            Professor? professor = professores.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (professor != null)
            {
                professores.Remove(professor);
                Console.WriteLine("Professor removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Professor não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Nome não pode ser nulo.");
        }
    }

    static void RemoverAluno()
    {
        Console.Write("Digite o nome do aluno a ser removido: ");
        string? nome = Console.ReadLine();

        if (nome != null)
        {
            Aluno? aluno = alunos.Find(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (aluno != null)
            {
                alunos.Remove(aluno);
                Console.WriteLine("Aluno removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Nome não pode ser nulo.");
        }
    }
}