using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Extensions
{
    public static class ConsoleKeyExtensions
    {   
        /// <summary>
        /// Определяет этаж в зависимости от нажатой клавишы
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Floors AsFloor(this ConsoleKey key)
        {
            if (key.IsOne()) return Floors.First;
            if (key.IsTwo()) return Floors.Second;
            if (key.IsThree()) return Floors.Third;
            throw new Exception("У НАС ВСЕГО 3 ЭТАЖА БЛДЖАД!!!");
        }
        /// <summary>
        /// Нажали 2?
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsTwo(this ConsoleKey key)
        {
            return key == ConsoleKey.D2 || key == ConsoleKey.NumPad2;
        }
        /// <summary>
        /// Нажали 1?
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsOne(this ConsoleKey key)
        {
            return key == ConsoleKey.D1 || key == ConsoleKey.NumPad1;
        }
        /// <summary>
        /// Нажали 3?
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsThree(this ConsoleKey key)
        {
            return key == ConsoleKey.D3 || key == ConsoleKey.NumPad3;
        }
    }
}
