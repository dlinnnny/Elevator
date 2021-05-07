using Elevator.Extensions;
using System;
using System.Threading;

namespace Elevator
{
    class Programm
    {
        public static int x = 60;//магическое число 1
        public static int y = 17;//магическое число 2
        public static int cursorX = 30, cursorY = 11;
        public static Floors statusFlour;//текущий этаж
        public static string Overlap = "=                           = =============== =            =";

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main()
        {
            DisplayScreen();
            ShowElivatorFloor((Floors)new Random().Next(1, 4));
            while (true)
            {
                try
                {
                    SetButtons();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Отображаем экран на консоли
        /// </summary>
        static void DisplayScreen()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
            Console.Write("============================================================");
            Console.Write("=                           =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write("=                 3ий этаж  =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write(Overlap);
            Console.Write("=                           =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write("=                 2ой этаж  =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write(Overlap);
            Console.Write("=                           =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write("=                 1ый этаж  =                 =            =");
            Console.Write("=                           =                 =            =");
            Console.Write("============================================================");
        }

        /// <summary>
        /// Передвигаем лифт в зависимости от нажатой кнопки
        /// </summary>
        static void SetButtons()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 2);
            var nextFloor = Console.ReadKey().Key.AsFloor();
            switch (Programm.statusFlour.GetAction(nextFloor))
            {
                case ElevatorAction.Down:
                    Down(Programm.statusFlour.GetLevel(nextFloor));
                    break;
                case ElevatorAction.Up:
                    Up(Programm.statusFlour.GetLevel(nextFloor));
                    break;
            }
            Programm.statusFlour = nextFloor;
        }

        /// <summary>
        /// Задержка двидения лифта
        /// </summary>
        static void WaitTimer()
        {
            Thread.Sleep(500);
        }

        /// <summary>
        /// Получает значение курсора по оси Y в зависимости от заданного этажа
        /// </summary>
        /// <param name="flour">Этаж для которого задается курсор</param>
        /// <returns>Значение курсора.</returns>
        static int GetCursorYByFlour(Floors flour)
        {
            switch (flour)
            {
                case Floors.First: return 11;
                case Floors.Second: return 6;
                case Floors.Third: return 1;
                default: break;
            }
            return 11;
        }

        /// <summary>
        /// Отоюражаем лифт в зависимости от заданного этажа
        /// </summary>
        /// <param name="flour"></param>
        static void ShowElivatorFloor(Floors flour)
        {
            Programm.cursorY = GetCursorYByFlour(flour);
            Console.Clear();
            Console.ResetColor();
            DisplayScreen();
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY);
            Console.ForegroundColor = ConsoleColor.Red;
            Programm.statusFlour = flour;
            Cabin();
        }

        /// <summary>
        /// Вообще ХЗ что тут происходит :)
        /// </summary>
        static void Cabin()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(Programm.cursorX, Programm.cursorY + i);
                Console.WriteLine(new string('*', 15));
            }
        }

        /// <summary>
        /// Поднимает лифт на заданное количество этажей
        /// </summary>
        /// <param name="levels">Кол-во этажей</param>
        static void Up(int levels = 1)
        {
            for (int level = 0; level < levels; level++)
                for (int i = 5; i != 0; i--)
                {
                    Console.Clear();
                    Console.ResetColor();
                    DisplayScreen();
                    cursorY -= 1;
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Cabin();
                    OverlapChange();
                    WaitTimer();
                }
        }

        /// <summary>
        /// Опускает лифт на заданное количество этажей
        /// </summary>
        /// <param name="levels">Кол-во этажей</param>
        static void Down(int levels = 1)
        {
            for (int level = 0; level < levels; level++)
                for (int i = 0; i != 5; i++)
                {
                    Console.Clear();
                    Console.ResetColor();
                    DisplayScreen();
                    cursorY += 1;
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Cabin();
                    OverlapChange();
                    WaitTimer();
                }
        }

        /// <summary>
        /// Неизвестная мне фигнюшка :)
        /// </summary>
        static void OverlapChange()
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, 5);
            Console.Write(Overlap);
            Console.SetCursorPosition(0, 10);
            Console.Write(Overlap);
        }

    }
}