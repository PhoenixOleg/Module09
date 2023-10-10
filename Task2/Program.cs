namespace Task2
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Модуль 9. Задание 2\n");
            //Массив фамилий. Для упрощения опаределяем в коде, а не вводом. Допустимо по условиям задачи
            string[] familyArray = new string[5]
            { "Иванов", "Петров", "Сидоров", "Кузнецов", "Анисимов" };

            UserRequest userRequest = new UserRequest();
            userRequest.eventInputCompleted += UserRequest_InputCompleted; //Подписываемся на событие (которое может быть определено и в чужом коде), 
                                                                           //определяя его обработчик UserRequest_InputCompleted в нашем коде

            Console.WriteLine("Массив до сортировки:");
            ShowArrayContent(familyArray);
            Console.WriteLine();

            userRequest.DoRequest(familyArray);


            Console.WriteLine("\nНажмите любую клавишу для завершения");
            Console.ReadKey (); 
        }

        private static void UserRequest_InputCompleted(string[] array, SortType sortType)
        {
            Console.WriteLine("\nМассив после сортировки:");
            ShowArrayContent(ArrayAction.Sort(array, sortType));
        }

        private static void ShowArrayContent(string[] array) 
        { 
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}