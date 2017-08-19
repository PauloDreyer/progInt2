using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.ImprimeMsg();

            foreach (var argumento in args)
            {
                console.writeline("o argumento é" + argumento);
            }

            var soma = new Program();
   
            Console.WriteLine(soma.Soma(5, 9));
        }

        public static void ImprimeMsg()
        {
            Console.WriteLine("Hello World!");
        }

        public int Soma(int y, int x)
        {
            return x + y;
        }
    }
}
