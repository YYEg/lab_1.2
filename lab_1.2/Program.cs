namespace FirstApplication
{

    public class Logic
    {
        public static int[] FillArray(int arraySize)
        {
            int[] numbersArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива:");
                var arrEl = int.Parse(Console.ReadLine());
                numbersArray[i] = arrEl;
            }
            return numbersArray;
        }
        public static string Check(int[] numbersArray)
        {
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
            //НАЧАЛО взаимодейтсвия с пользователем
            Console.WriteLine("Введите колличество членов массива:");
            var arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива");

            int[] numbersArray = Logic.FillArray(arraySize);

            Console.WriteLine("Ваш массив:");
            foreach (var el in numbersArray)
            {
                Console.WriteLine(el);

            }
            //КОНЕЦ взаимодействия с пользователем

            //НАЧАЛО логики
            var outMessage = Logic.Check(numbersArray);
            //КОНЕЦ логики

            //НАЧАЛО взаимодейтсвия с пользователем
            Console.WriteLine(outMessage);
            Console.ReadLine();
            //КОНЕЦ взаимодейтсвия с пользователем
        }
    }
}

