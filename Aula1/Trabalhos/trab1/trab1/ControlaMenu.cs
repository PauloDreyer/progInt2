using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    class ControlaMenu
    {
        static MenuPrincipal menu = new MenuPrincipal();
        static ConsoleKeyInfo opcao;

        public static void MenuHome()
        {
            menu.Limpar();
            menu.Home();
            opcao = Console.ReadKey();
            MenuSelecionado(opcao.Key);
        }

        private static void MenuSelecionado(ConsoleKey opcao)
        {
            if (opcao == ConsoleKey.D1)
            {
                menu.NextPage(1);
            }
            else if (opcao == ConsoleKey.D2)
            {
                menu.NextPage(2);
            }
            else if (opcao == ConsoleKey.D3)
            {
                menu.NextPage(3);
            }
            else if (opcao == ConsoleKey.D4)
            {
                menu.NextPage(4);
            }
            else if (opcao == ConsoleKey.D0)
            {
                MenuHome();
            }
            MenuHome();
        }
    }
}
