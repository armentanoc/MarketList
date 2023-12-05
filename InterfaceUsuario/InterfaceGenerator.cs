﻿
namespace InterfaceUsuario
{
    using Compartilhado;
    using ConsoleInteraction;
    using System.Globalization;

    public class InterfaceGenerator
    {
        ProductsList productsList = new ProductsList();
        public void Generate()
        {
            Display.Greeting();

            while(true)
            {
                Display.Menu();
                string? choice = Console.ReadLine();
                Console.Clear();
                DetermineChoice(choice, productsList);
            }
        }

        static void DetermineChoice(string? choice, ProductsList productsList)
        {
            switch (choice)
            {
                case "1":
                    AddProduct.TryAddingProduct(productsList);
                    break;
                case "2":
                    RemoveProduct.TryRemovingProduct(productsList);
                    break;
                case "3":
                    Display.Products(productsList.GetList(), "\nLista completa de produtos: \n");
                    break;
                case "4":
                    Display.Products(productsList.GetListInAlfabeticalOrder(), "\nLista completa de produtos em ordem alfabética:\n");
                    break;
                case "5":
                    Console.Write("Digite a primeira letra:\n");
                    char letter = Receive.Letter();
                    Display.Products(productsList.GetProductsThatStartsWith(letter), $"\nLista completa dos produtos que começam com {letter}:\n");
                    break;
                case "6":
                    Console.WriteLine("Programa encerrado.\n");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    break;
            }
        }
    }
}