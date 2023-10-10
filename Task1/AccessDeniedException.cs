using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Определяемый пользователем класс обработки исключения "Доступ запрещен"
    /// По ключу "Date" можно получить время возникновения исключения
    /// </summary>
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException() { SetAdditionData(); }

        public AccessDeniedException(string message) : base(message) { SetAdditionData(); }

        public AccessDeniedException(string message, Exception inner) : base(message, inner) { SetAdditionData(); } //Конструктор для обработки внутренних исключений

        private void SetAdditionData()
        {
            this.Data.Add("Date", DateTime.Now);
        }
    }
}
