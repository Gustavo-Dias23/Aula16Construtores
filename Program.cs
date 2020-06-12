using System;

namespace Aula16Construstores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto carro = new Produto();

            Produto moto = new Produto(987);
            System.Console.WriteLine("O código desse produto é "+moto.Codigo);

            Produto van = new Produto(321,"Kombi", "Azul", 3);
            System.Console.WriteLine("O código do produto é "+van.Codigo);
            System.Console.WriteLine("O modelo do produto é "+van.Nome);
            System.Console.WriteLine("A cor do produto é "+van.Descricao);
            System.Console.WriteLine("O número desse tipo de produto no estoque é "+van.Estoque);
        }
    }
}
