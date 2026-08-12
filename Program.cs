// Arrays para armazenar os dados
string[] nomes = new string[10];
int[] idades = new int[10];
double[] nota1 = new double[10];
double[] nota2 = new double[10];
double[] medias = new double[10];
int totalAlunos = 0;

// ========== CADASTRO (Maria) ==========
Console.WriteLine("=== CADASTRO DE ALUNOS ===\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Aluno " + (i + 1) + ":");

    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();

    Console.Write("Idade: ");
    string entradaIdade = Console.ReadLine();
    while (!int.TryParse(entradaIdade, out idades[i]) || idades[i] <= 0)
    {
        Console.Write("Idade inválida! Digite um número positivo: ");
        entradaIdade = Console.ReadLine();
    }

    Console.Write("Nota 1: ");
    string entradaNota1 = Console.ReadLine();
    while (!double.TryParse(entradaNota1, out nota1[i]) || nota1[i] < 0 || nota1[i] > 10)
    {
        Console.Write("Nota inválida! Digite um valor entre 0 e 10: ");
        entradaNota1 = Console.ReadLine();
    }

    Console.Write("Nota 2: ");
    string entradaNota2 = Console.ReadLine();
    while (!double.TryParse(entradaNota2, out nota2[i]) || nota2[i] < 0 || nota2[i] > 10)
    {
        Console.Write("Nota inválida! Digite um valor entre 0 e 10: ");
        entradaNota2 = Console.ReadLine();
    }

    medias[i] = (nota1[i] + nota2[i]) / 2;
    totalAlunos++;

    Console.WriteLine("Aluno cadastrado com sucesso! Média: " + medias[i].ToString("F2"));
    Console.WriteLine("-------------------------\n");

    if (i < 9)
    {
        Console.Write("Deseja cadastrar mais um aluno? (S/N): ");
        string continuar = Console.ReadLine().ToUpper();
        if (continuar != "S")
        {
            break;
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\nCadastro finalizado! " + totalAlunos + " alunos cadastrados.\n");