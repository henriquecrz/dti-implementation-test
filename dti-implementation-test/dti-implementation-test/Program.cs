using dti_implementation_test.Application;
using dti_implementation_test.Utils;
using System;
using System.Collections.Generic;

namespace dti_implementation_test
{
    public class Program
    {
        private const int EXPECTED_PARAMETERS_NUMBER = 3;
        private const int DATE_ARG_INDEX = 0;
        private const int SMALL_DOG_ARG_INDEX = 1;
        private const int LARGE_DOG_ARG_INDEX = 2;

        public static void Main(string[] args)
        {
            Input input;

            try
            {
                input = CreateInput(args);
            }
            catch (Exception)
            {
                input = CreateInput();
            }

            var petShops = GetPetShops(input);
            var catalog = new Catalog();

            FillCatalog(catalog, petShops);
            ShowBestPetShop(catalog);
            Console.ReadKey();
        }

        private static Input CreateInput(string[] args)
        {
            if (args?.Length < EXPECTED_PARAMETERS_NUMBER ||
                !DateTime.TryParse(args[DATE_ARG_INDEX], out var date) ||
                !int.TryParse(args[SMALL_DOG_ARG_INDEX], out var smallDogs) ||
                !int.TryParse(args[LARGE_DOG_ARG_INDEX], out var largeDogs))
            {
                throw new Exception();
            }

            return new Input(date, smallDogs, largeDogs);
        }

        private static Input CreateInput()
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

        private static List<IPetShop> GetPetShops(Input input)
        {
            var meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Felix", 2000, input);
            var vaiRex = new VaiRex("Vai Rex", 1700, input);
            var chowChawgas = new ChowChawgas("Chow Chawgas", 800, input);

            return new List<IPetShop>
            {
                meuCaninoFeliz,
                vaiRex,
                chowChawgas
            };
        }

        private static void FillCatalog(Catalog catalog, List<IPetShop> petShops) =>
            petShops.ForEach(petShop => catalog.Add(petShop));

        private static void ShowBestPetShop(Catalog catalog)
        {
            var bestPetShop = catalog.GetBestPetShop();
            var message = bestPetShop is null ?
                Message.NO_REGISTERED_PET_SHOPS :
                $"\nThe better pet shop choice is {bestPetShop.Name}.\nThe better price is {bestPetShop.Amount:C}.";

            Console.WriteLine(message);
        }
    }
}
