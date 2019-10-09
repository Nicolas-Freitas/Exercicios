using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[100];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[10];
            int salasCadastradas = 0;

            string menu;

            do{
            Console.Clear();
            System.Console.WriteLine("Eae meu bom o que você deseja fazer?");
            System.Console.WriteLine("(1) - Cadastrar Aluno");
            System.Console.WriteLine("(2) - Cadastrar Sala");
            System.Console.WriteLine("(3) - Alocar Aluno");
            System.Console.WriteLine("(4) - Remover Aluno");
            System.Console.WriteLine("(5) - Verificar Salas");
            System.Console.WriteLine("(6) - Verificar Alunos");
            System.Console.WriteLine("(0) - Sair");

            menu = Console.ReadLine();

            Aluno aluno = new Aluno ();
            Sala sala = new Sala ();
            switch (menu)
                {
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("Digite o nome do aluno:");
                        aluno.nome = Console.ReadLine();
                        System.Console.WriteLine("Data de Nascimento");
                        aluno.dataNascimento = DateTime.Parse(Console.ReadLine());
                        System.Console.WriteLine("Curso");
                        aluno.curso = Console.ReadLine();
                        System.Console.WriteLine("Sala");
                        aluno.numeroSala = int.Parse(Console.ReadLine());

                        alunos[alunosCadastrados] = aluno;

                        alunosCadastrados++;
                        
                        System.Console.WriteLine ("Parabens seu cadastro foi efetuado com sucesso!");

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case "2":
                        Console.Clear();

                        System.Console.WriteLine("Digite o número da sala:");
                        sala.numeroSala = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Digite a capacidade máxima de alunos nessa sala:");
                        sala.capacidadeTotal = int.Parse(Console.ReadLine());
                        break;
                    case "3":
                        Console.Clear();
                        System.Console.WriteLine("Qual aluno você deseja alocar?");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        System.Console.Write("Digite o nome do aluno que deseja remover:");
                        Console.ReadLine();
                        break;
                    case "5":
                        foreach (var item  in salas){
                            if (item != null) {
                                Console.Clear();

                                System.Console.WriteLine("__________________________________________________________________________________________________");
                                System.Console.WriteLine ($"Nome do aluno: {item.numeroSala}");
                                System.Console.WriteLine ($"Curso: {item.capacidadeTotal}");
                                System.Console.WriteLine("__________________________________________________________________________________________________");
                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "6":
                        foreach (var item  in alunos){
                            if (item != null) {
                                Console.Clear();

                                System.Console.WriteLine("__________________________________________________________________________________________________");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ($"Sala: {item.numeroSala}");
                                System.Console.WriteLine("__________________________________________________________________________________________________");
                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            }
                        }
                        Console.ReadLine();
                        break;
                }
                
            } while (menu != "0");        
        }
    }
}
