using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    class Program
    {
        //static ConsoleKeyInfo opcao;
        static ControlaMenu menu = new ControlaMenu();
        static void Main(string[] args)
        {
            ControlaMenu.MenuHome();
        }

        //private static void MenuHome()
        //{
        //    menu.MenuHome();
        //    Program.opcao = Console.ReadKey();
        //    MenuSelecionado(opcao.Key);
        //}

        //private static void MenuSelecionado(ConsoleKey opcao)
        //{
        //    if (opcao == ConsoleKey.D1)
        //    {
        //        menu.NextPage(1);
        //    }
        //    else if(opcao == ConsoleKey.D2){
        //        menu.NextPage(2);
        //    }
        //    else if (opcao == ConsoleKey.D3)
        //    {
        //        menu.NextPage(3);
        //    }

        //    MenuHome();
        //}
    }
}
