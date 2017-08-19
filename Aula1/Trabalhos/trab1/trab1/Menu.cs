using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1
{
    public abstract class Menu : IMenu
    {
        public abstract void Home();
        public abstract void NextPage(int opcao);
        public abstract void PrevPage();
    }
}
