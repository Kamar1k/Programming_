using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс валидации
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает максимально допустимую длину maxLength
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="maxLength">Максимально допустимая длина строки</param>
        /// <param name="propertyname">Наименование свойства, которое проверяется</param>
        /// <exception cref="ArgumentException">Ошибка выбрасывается, если длина строки превышает максимально допустимую длину</exception>
        public static void AssertStringOnlengs(string value, int maxLength, string propertyname)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{(propertyname)} должен быть меньше ({maxLength}) символов в длинну");
            }
        }

        /// <summary>
        /// Проверяет, что значение находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="min">Минимальное допустимое значение</param>
        /// <param name="max">Максимальное допустимое значение</param>
        /// <param name="propertyName">Наименование свойства, которое проверяется</param>
        /// <exception cref="ArgumentException">Ошибка выбрасывается, если значение выходит за пределы заданного диапазона</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"{(propertyName)} должен быть больше {(min)} меньше {(max)} символов в длинну");
            }
        }
    }
}
