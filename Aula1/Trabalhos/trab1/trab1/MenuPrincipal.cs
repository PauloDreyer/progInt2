using System;
using System.Collections.Generic;

namespace trab1
{
    public class MenuPrincipal : Menu
    {
        static String nome;
        static ConsoleKeyInfo opcao;
        static List<String> listPes = new List<String>();

        public void Limpar()
        {
            Console.Clear();
        }

        private void Consultar()
        {
            Console.WriteLine("Informe o Nome para Consulta!");
            nome = listPes.Find(x => x.Contains(Console.ReadLine()));
            if (nome.Length > 0)
            {
                Console.WriteLine(nome);
            }
            else
            {
                Console.WriteLine("Nome não encontrado!");
            }
            
            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();
        }

        private void Incluir()
        {
            Console.WriteLine("Informe o Nome para Incluir!");
            listPes.Add(Console.ReadLine());

        }

        private void Excluir()
        {
            Console.WriteLine("Informe o Nome para Excluir!");
            listPes.Remove(Console.ReadLine());
        }

        private void ListarTodos()
        {
            for (int i = 0; i < listPes.Count; i++)
            {
                Console.WriteLine("Nome: "+listPes[i]);
            }
            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();
        }

        public override void Home()
        {
            Console.WriteLine(" --------------------");
            Console.WriteLine("| 0 - Home           |");
            Console.WriteLine("| 1 - Consultar      |");
            Console.WriteLine("| 2 - Incluir        |");
            Console.WriteLine("| 3 - Excluir        |");
            Console.WriteLine("| 4 - Listar Todos   |");
            Console.WriteLine(" --------------------");
        }

        public override void NextPage(int opcao)
        {
            Limpar();
            if (opcao == 1)
            {
                Consultar();
            }
            else if (opcao == 2)
            {
                Incluir();
            }
            else if (opcao == 3)
            {
                Excluir();
            }
            else if (opcao == 4)
            {
                ListarTodos();
            }
        }

        public override void PrevPage()
        {
            throw new NotImplementedException();
        }

        
    }
}
