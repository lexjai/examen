using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            int[] valores = {5,3,11,15};
            Console.WriteLine(sistema.multiplosArray(valores));
            Console.WriteLine(sistema.multiplo(11));
        }
    }
}
