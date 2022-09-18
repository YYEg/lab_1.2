using System.Collections.Generic;

namespace FirstApplication
{

    public class Logic
    {
        public static string Check(string inputNumbers)
        {
            char separators = ' ';
            string[] strArray = inputNumbers.Split(separators);
            int[] numbersArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(strArray[i]);
            }
            string outMessage = "";
            bool IsPositive = true;
            if (numbersArray[0] < 0)
            {
                IsPositive = false;
            }
            int changeCounter = 0;
            foreach (var checkEl in numbersArray)
            {
                if ((IsPositive) && (checkEl < 0))
                {
                    changeCounter++;
                    IsPositive = false;
                }
                else if ((!IsPositive) && (checkEl > 0))
                {
                    changeCounter++;
                    IsPositive = true;
                }
            }
            outMessage = $"Знак изменился {changeCounter} раз";
            return outMessage;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //НАЧАЛО взаимодействия с пользователем
            Console.WriteLine("Введите элементы вашего массива через пробел");
            var inputNumbers = Console.ReadLine();
            //КОНЕЦ взаимодействия с пользователем

            //НАЧАЛО логики
            string outMessage = Logic.Check(inputNumbers);
            //КОНЕЦ логики

            //НАЧАЛО взаимодействия с пользователем
            Console.WriteLine(outMessage);
            //КОНЕЦ взаимодействия с пользователем
        }
    }
}

