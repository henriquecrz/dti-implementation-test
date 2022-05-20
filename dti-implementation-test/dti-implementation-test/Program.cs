using Application;
using System;
using System.Collections.Generic;
using Utils;

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

            var petshops = GetPetshops(input);

            ShowPetshopsBudget(petshops);
            ShowBestPetshop(petshops);

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

        private static List<IPetshop> GetPetshops(Input input) =>
            new()
            {
                new MeuCaninoFelizPetshop("Meu Canino Felix", 2000, input),
                new VaiRexPetshop("Vai Rex", 1700, input),
                new ChowChawgasPetshop("Chow Chawgas", 800, input)
            };

        private static void ShowPetshopsBudget(IEnumerable<IPetshop> petshops)
        {
            Console.WriteLine();

            foreach (var petshop in petshops)
            {
                Console.WriteLine(petshop);
            }
        }

        private static void ShowBestPetshop(IEnumerable<IPetshop> petshops)
        {
            var bestPetshop = petshops.GetBestPetshop();

            var message = bestPetshop is null ?
                Message.NO_REGISTERED_PETSHOPS :
                $"\nA melhor escolha de petshop é o {bestPetshop}.";

            Console.WriteLine(message);
        }
    }
}
