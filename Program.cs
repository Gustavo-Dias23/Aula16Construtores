using System;

namespace Aula16Construstores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();

            Produto chinelo = new Produto(987);
            System.Console.WriteLine(chinelo.Codigo);
        }
    }
}
