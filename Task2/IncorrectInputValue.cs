using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс пользовательского исключения некорректного ввода
    /// </summary>
    internal class IncorrectInputValueException : Exception 
    {
        public IncorrectInputValueException() { }

        public IncorrectInputValueException(string message) : base(message) { }

        public IncorrectInputValueException(string message, Exception inner) : base(message, inner) { } //Конструктор для обработки внутренних исключений

    }
}
