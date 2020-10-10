using dti_implementation_test.Application;
using dti_implementation_test.Utils;
using System;
using System.Collections.Generic;

namespace dti_implementation_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = FillInput();
            List<PetShop> petShops = CreatePetShops(input);
            Catalog catalog = FillCatalog(petShops);

            WriteBestPetShop(catalog);

            Console.ReadKey();
        }

        static List<PetShop> CreatePetShops(Input input)
        {
            MeuCaninoFeliz meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Felix", 2000, input);
            VaiRex vaiRex = new VaiRex("Vai Rex", 1700, input);
            ChowChawgas chowChawgas = new ChowChawgas("Chow Chawgas", 800, input);
            List<PetShop> petShops = new List<PetShop>
            {
                meuCaninoFeliz,
                vaiRex,
                chowChawgas
            };

            return petShops;
        }

        static Catalog FillCatalog(List<PetShop> petShops)
        {
            Catalog catalog = new Catalog();

            foreach (PetShop petShop in petShops)
            {
                catalog.AddPetShop(petShop);
            }

            return catalog;
        }

        static Input FillInput()
        {
            bool isParseSuccess;
            DateTime date;
            int smallDogs;
            int largeDogs;

            do
            {
                Console.Write(Label.DATE_INPUT);
                isParseSuccess = DateTime.TryParse(Console.ReadLine(), out date);

                if (!isParseSuccess)
                {
                    Console.Clear();
                    Console.WriteLine(Message.DATE_INVALID_VALUE);
                }
            } while (!isParseSuccess);

            do
            {
                Console.Write(Label.SMALL_DOG_INPUT);
                isParseSuccess = int.TryParse(Console.ReadLine(), out smallDogs);

                if (!isParseSuccess || smallDogs < 0)
                {
                    Console.Clear();

                    Console.WriteLine(Message.DOG_INVALID_VALUE);
                }
            } while (!isParseSuccess);

            do
            {
                Console.Write(Label.LARGE_DOG_INPUT);
                isParseSuccess = int.TryParse(Console.ReadLine(), out largeDogs);

                if (!isParseSuccess || smallDogs < 0)
                {
                    Console.Clear();
                    Console.WriteLine(Message.DOG_INVALID_VALUE);
                }
            } while (!isParseSuccess);

            return new Input(date, smallDogs, largeDogs);
        }

        static void WriteBestPetShop(Catalog catalog)
        {
            PetShop bestPetShop = catalog.GetBestPetShop();

            string message = (bestPetShop is null) ?
                Message.NO_REGISTERED_PET_SHOPS :
                $"\nThe better pet shop choice is {bestPetShop.Name}.\nThe better price is {bestPetShop.Amount:C}.";

            Console.WriteLine(message);
        }
    }
}
