namespace FirstApplication
{
        
    public class Logic
    {
        public static string Check(List<int> list)
        {
            string outMessage = "";
            bool IsPositive = true;
            if (list[0] < 0)
            {
                IsPositive = false;
            }
            int changeCounter = 0;
            foreach (var checkEl in list)
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

            List<int> list = new List<int>(arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите {i+1} элемент массива:");
                var listEl = int.Parse(Console.ReadLine());
                list.Add(listEl);
            }

            Console.WriteLine("Ваш массив:");
            foreach (var el in list)
            {
                Console.WriteLine(el);
                
            }
            //КОНЕЦ взаимодействия с пользователем

            //НАЧАЛО логики
            var outMessage = Logic.Check(list);
            //КОНЕЦ логики
                            
            //НАЧАЛО взаимодейтсвия с пользователем
            Console.WriteLine(outMessage);
            Console.ReadLine();
            //КОНЕЦ взаимодейтсвия с пользователем
        }
    }
}

