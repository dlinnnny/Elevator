using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    /// <summary>
    /// Тип Направления движени лифта
    /// </summary>
    public enum ElevatorAction
    {
        /// <summary>
        /// Вверх
        /// </summary>
        Up,
        /// <summary>
        /// Вниз
        /// </summary>
        Down
    }

    /// <summary>
    /// Тип этажей
    /// </summary>
    public enum Floors
    {
        /// <summary>
        /// Первый этаж
        /// </summary>
        First = 1,
        /// <summary>
        /// Второй этаж
        /// </summary>
        Second = 2,
        /// <summary>
        /// Третий этаж
        /// </summary>
        Third = 3
    }
}
