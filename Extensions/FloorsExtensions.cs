using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Extensions
{
    public static class FloorsExtensions
    {
        /// <summary>
        /// Определяет вверх или вниз
        /// </summary>
        /// <param name="currentFloor">Текущий этаж</param>
        /// <param name="requredFloor">Выбранный этаж</param>
        /// <returns></returns>
        public static ElevatorAction GetAction(this Floors currentFloor, Floors requredFloor)
        {
            return ((int)currentFloor) > (int)requredFloor ? ElevatorAction.Down : ElevatorAction.Up;
        }
        /// <summary>
        /// Определяет кол-во пролетов для движения
        /// </summary>
        /// <param name="currentFloor">Текущий этаж</param>
        /// <param name="requredFloor">След. этаж</param>
        /// <returns></returns>
        public static int GetLevel(this Floors currentFloor, Floors requredFloor)
        {
            return Math.Abs((int)currentFloor - (int)requredFloor);
        }
    }
}
