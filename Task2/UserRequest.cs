using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Делегат обработчика завершения ввода пользователем
    /// </summary>
    /// <param name="array">строковый массив для обработки</param>
    /// <param name="sortType">Тип сортировки массива</param>
    public delegate void InputCompletedHandler(string[] array, SortType sortType);

    /// <summary>
    /// Класс обработки запроса действия от пользователя - издателя события eventInputCompleted
    /// </summary>
    public class UserRequest
    {
        /// <summary>
        /// Определение события eventInputCompleted для делегата InputCompletedHandler
        /// </summary>
        public event InputCompletedHandler? eventInputCompleted;

        /// <summary>
        /// Дефолтный конструктор класса
        /// </summary>
        public UserRequest() { }

        /// <summary>
        /// Метода запроса действия от пользователя
        /// </summary>
        /// <param name="array_param">Строковый массив, на которым будет производиться действие</param>
        public void DoRequest(string[] array_param)
        {
            Console.Write("Введите числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А): ");
            int answer = 0;

            do
            {
                try
                {
                    answer = int.Parse(Console.ReadLine());
                    if (answer != 1 & answer != 2) { throw new IncorrectInputValueException("Допускается ввод или 1, или 2"); }

                    switch (answer)
                    { 
                        case 1:
                            eventInputCompleted?.Invoke(array_param, SortType.SortByAsc); //Вызов события
                            break; 
                        case 2:
                            eventInputCompleted?.Invoke(array_param, SortType.SortByDesc); //Вызов события
                            break;
                    }
                }
                catch (IncorrectInputValueException ex) //Отработка пользовательского исключения (введено некорректное число)
                {
                    ShowErrorMessage(ex.Message);
                }

                catch (Exception ex) //Перехват других возможных исключений, в т. ч. ввода строки вместо числа
                {
                    ShowErrorMessage(ex.Message);
                }
            } while (answer != 1 & answer != 2);
        }

        /// <summary>
        /// Метод вывода сообщения на консоль
        /// </summary>
        /// <param name="message">Выводимое сообщение</param>
        private void ShowErrorMessage(string message)
        {
            Console.WriteLine($"\nНекорректный ввод - {message}");
        }
    }
}
