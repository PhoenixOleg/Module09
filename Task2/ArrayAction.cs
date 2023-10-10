using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Перечисление типа сортировки
    /// </summary>
    public enum SortType
    {
        SortByAsc = -1 //По возрастанию
       , SortByDesc = 1 //По убыванию
    }

    /// <summary>
    /// Класс действий над массивом. В рамках задание реализован единственный метод сортировки
    /// </summary>
    internal class ArrayAction
    {
        internal ArrayAction() { }

        /// <summary>
        /// Метод сортировки массива
        /// </summary>
        /// <param name="array">Передаваемый строковый массив</param>
        /// <param name="sortType">Тип сортировки</param>
        /// <returns>Возвращаемиое значение в ивде отсортированного массива</returns>
        internal static string[] Sort (string[] array, SortType sortType)
        {
            string[] newArray = (string[])array.Clone(); //Делаем копию (неглубокую) искходного массива, т. к. портить его нас никто не просил
  
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (string.Compare(newArray[i], newArray[j]) != (int)sortType)
                    {
                        var tmp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = tmp;
                    }
                }
            }

            return newArray;
        }
    }
}
