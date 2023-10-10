using System.Runtime.CompilerServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Модуль 9. Задание 1");

            Exception[] exceptions = new Exception[5]
                {
                    new ArgumentException(),
                    new DirectoryNotFoundException(),
                    new FileNotFoundException(),
                    new IndexOutOfRangeException(),
                    new AccessDeniedException("Доступ запрещен"),
                };

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (ArgumentException ex)
                { 
                    ShowErrorMessage(ex.Message); 
                }

                catch (DirectoryNotFoundException ex)
                {
                    ShowErrorMessage(ex.Message);
                }


                catch (FileNotFoundException ex)
                {
                    ShowErrorMessage(ex.Message);
                }

                catch (IndexOutOfRangeException ex)
                {
                    ShowErrorMessage(ex.Message);
                }

                catch (AccessDeniedException ex)
                {
                    ShowErrorMessage(ex.Message);
                    if (ex.Data.Contains("Date"))
                    {
                        Console.WriteLine($"Время возникновения ошибки: {ex?.Data?["Date"]?.ToString()}");
                    }
                }
                catch (Exception ex) //На случай "что-то пошло не по плану"
                {
                    ShowErrorMessage($"Произошло что-то неведомое:\n{ex.Message}");
                }
                finally { Console.WriteLine("\nБлок Finally выполняется всегда и последним"); }
            }
            Console.WriteLine("\nНажмите любую клавишу для завершения");
            Console.ReadKey ();
        }

        /// <summary>
        /// Метод вывода сообщения об ошибке на консоль
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        private static void ShowErrorMessage (string message)
        {
            Console.WriteLine ($"\nПроизошла ошибка \"{message}\"");
        }
    }
}