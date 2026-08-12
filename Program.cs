using System;

class Program
{
    static void Main(string[] args)
    {

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

        int opcao;

        do
        {
            // Exibição do Menu
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("       SISTEMA DE ALUNOS      ");
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("4 - Exibir média da turma");
            Console.WriteLine("0 - Encerrar");
            Console.WriteLine("==============================");
            Console.Write("Digite a opção desejada: ");

            // Validação simples para garantir que a entrada seja um número
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("-> Executando: Listar alunos...");
                        // Adicione sua lógica aqui
                        break;

                    case 2:
                        Console.WriteLine($"Digite o nome do Aluno que deseja encontrar:");
                        string? nomePesquisa = Console.ReadLine();

                        bool encontrado = false;
                        int posicao = -1;
                        for (int i = 0; i < totalAlunos; i++)
                        {
                            if (nomes[i].Trim().ToLower().Replace(" ", "") == nomePesquisa?.Trim().ToLower().Replace(" ", ""))
                            {
                                encontrado = true;
                                posicao = i;
                                break;
                            }
                        }
                        if (encontrado == true)
                        {
                            Console.WriteLine($"Nome: {nomes[posicao]} | Idade: {idades[posicao]} | Nota 1:{nota1[posicao]} | Nota 2: {nota2[posicao]} |  Média: {medias[posicao]}");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("-> Executando: Exibir aprovados...");
                        // Adicione sua lógica aqui
                        break;

                    case 4:
                        Console.WriteLine("-> Executando: Exibir média da turma...");
                        // Adicione sua lógica aqui
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o sistema. Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha uma opção entre 0 e 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite apenas números.");
                opcao = -1; // Mantém o loop rodando caso digitem letras
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }
}