using System;
using System.Collections.Generic;

namespace trab1
{
    public class MenuPrincipal : Menu
    {
        static ConsoleKeyInfo opcao;
        string modelo;
        int flag = 0;
        static List<Veiculo> listVei = new List<Veiculo>();
    
        public void Limpar()
        {
            Console.Clear();
        }
        private void Incluir()
        {
            Veiculo veiculo = new Veiculo();
            Console.WriteLine("Cadastro!");
            Console.WriteLine("Marca: ");
            veiculo.SetMarca(Console.ReadLine());
            Console.WriteLine("Modelo: ");
            veiculo.SetModelo(Console.ReadLine());
            Console.WriteLine("Preço: ");
            veiculo.SetValor(Convert.ToDouble(Console.ReadLine()));
            listVei.Add(veiculo);

        }

        private void Alterar()
        {
            Console.WriteLine("Informe o Modelo para Consulta!");
            modelo = Console.ReadLine();
            flag = 0;
            foreach (Veiculo veic in listVei)
            {
                 if (veic.GetModelo() == modelo)
                {
                    flag = 1;
                    Console.WriteLine("Marca: " + veic.GetMarca());
                    Console.WriteLine("Nova Marca");
                    veic.SetMarca(Console.ReadLine());
                    Console.WriteLine("Modelo: " + veic.GetModelo());
                    Console.WriteLine("Novo Modelo");
                    veic.SetModelo(Console.ReadLine());
                    Console.WriteLine("Preço: " + veic.GetPreco());
                    Console.WriteLine("Novo Preço");
                    veic.SetValor(Convert.ToDouble(Console.ReadLine()));
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Modelo não encontrado!");
            }

            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();

        }
       
        private void Excluir()
        {
            Console.WriteLine("Informe o Modelo para Excluir!");
            modelo = Console.ReadLine();
            flag = 0;
            foreach (Veiculo veic in listVei)
            {
                if (veic.GetModelo() == modelo)
                {
                    flag = 1;       
                }
            }
            
            if (flag == 1)
            {
                listVei.RemoveAll(x => x.GetModelo() == modelo);
                Console.WriteLine("Veículo Excluído!");
            }
            else
            {
                Console.WriteLine("Modelo não encontrado!");
            }

            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();
        }
   
        private void Consultar()
        {
            Console.WriteLine("Informe o Modelo para Consulta!");
            modelo = Console.ReadLine();
            flag = 0;
            foreach (Veiculo veic in listVei)
            {
                if (veic.GetModelo() == modelo)
                {
                    flag = 1;
                    Console.WriteLine("Marca: " + veic.GetMarca());
                    Console.WriteLine("Modelo: " + veic.GetModelo());
                    Console.WriteLine("Preço: " + veic.GetPreco());
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Modelo não encontrado!");
            }

            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();
        }

        private void ListarTodos()
        {

            foreach (Veiculo veic in listVei)
            {
                Console.WriteLine("Marca: "+veic.GetMarca());
                Console.WriteLine("Modelo: " + veic.GetModelo());
                Console.WriteLine("Preço: " + veic.GetPreco());
                Console.WriteLine(" ");
            }
            Console.WriteLine("Voltar para o Menu <ENTER>!");
            opcao = Console.ReadKey();
        }

        public override void Home()
        {
            Console.WriteLine(" --------------------");
            Console.WriteLine("| 0 - Home           |");
            Console.WriteLine("| 1 - Incluir        |");
            Console.WriteLine("| 2 - Alterar        |");
            Console.WriteLine("| 3 - Excluir        |");
            Console.WriteLine("| 4 - Consultar      |");
            Console.WriteLine("| 5 - Listar Todos   |");
            Console.WriteLine(" --------------------");
        }
 
        public override void NextPage(int opcao)
        {
            Limpar();
            if (opcao == 1)
            {
                Incluir();
            }
            else if (opcao == 2)
            {
                Alterar();
            }
            else if (opcao == 3)
            {
                Excluir();
            }
            else if (opcao == 4)
            {
                Consultar();
            }
            else if (opcao == 5)
            {
                ListarTodos();
            }
        }
    }
}
