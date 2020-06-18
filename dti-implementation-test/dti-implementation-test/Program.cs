using System;
using System.Collections.Generic;

namespace dti_implementation_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Petshop> petshops = CreatePetshops();
            Catalog catalog = FillCatalog(petshops);
            Input input = FillInput();

            // Definindo o melhor custo benefício


            // Output
            Console.WriteLine($"O melhor petshop é o {catalog.GetBestPetshop().Name}.");
            Console.WriteLine($"O melhor preço é {catalog.GetBestPetshop().Amount:C}");

            Console.ReadKey();
        }

        static List<Petshop> CreatePetshops()
        {
            List<Petshop> petshops = new List<Petshop>();

            MeuCaninoFeliz meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Felix", 2000);
            VaiRex vaiRex = new VaiRex("Vai Rex", 1700);
            ChowChawgas chowChawgas = new ChowChawgas("Chow Chawgas", 800);

            petshops.Add(meuCaninoFeliz);
            petshops.Add(vaiRex);
            petshops.Add(chowChawgas);

            return petshops;
        }

        static Catalog FillCatalog(List<Petshop> petshops)
        {
            Catalog catalog = new Catalog();

            foreach (Petshop petshop in petshops)
            {
                catalog.AddPetshop(petshop);
            }

            return catalog;
        }

        static Input FillInput()
        {
            Input input = new Input();

            do
            {
                Console.Write("Informe a data do banho (ex: 3/8/2018): ");
                input.SetDate(Console.ReadLine());

                if (!input.IsParseSuccess)
                {
                    Console.Clear();
                    Console.WriteLine("Data inválida, por favor insira uma data no formato dd-MM-yyyy.");
                }
            } while (!input.IsParseSuccess);

            do
            {
                Console.Write("Informe a quantidade de cães pequenos: ");
                input.SetSmallDogs(Console.ReadLine());

                if (!input.IsParseSuccess)
                {
                    Console.Clear();

                    Console.WriteLine("Valor inválido, por favor insira um número inteiro.");
                }
            } while (!input.IsParseSuccess);

            do
            {
                Console.Write("Informe a quantidade de cães grandes: ");
                input.SetLargeDogs(Console.ReadLine());

                if (!input.IsParseSuccess)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido, por favor insira um número inteiro.");
                }
            } while (!input.IsParseSuccess);

            return input;
        }
    }
}
