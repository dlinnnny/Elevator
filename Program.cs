using System;
using System.Threading;

namespace Elevator
{
    class Programm
    {
        public static int x = 60;
        public static int y = 17;
        public static int cursorX = 30, cursorY = 11;
        public static int statusFlour;

        static void Main()
        {
            Screen();
            Random();
            
            while (true)
            {
                SetButtons();
            }

        }//Main()

        static void Screen()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
            Console.Write(
                "============================================================" +
                "=                           =                 =            =" +
                "=                           =                 =            =" +
                "=                           =                 =            =" +
                "=                 3ий этаж  =                 =            =" +
                "=                           = =============== =            =" +
                "=                           =                 =            =" +
                "=                           =                 =            =" +
                "=                 2ой этаж  =                 =            =" +
                "=                           =                 =            =" +
                "=                           = =============== =            =" +
                "=                           =                 =            =" +
                "=                           =                 =            =" +
                "=                 1ый этаж  =                 =            =" +
                "=                           =                 =            =" +
                "= ==========================================================");

        }//Screen()

        static void SetButtons()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 2);
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.D1 && statusFlour == 2 || key == ConsoleKey.NumPad1 && statusFlour == 2)
            {
                Down();
                ShowElivator1Flour();
            }//Key1

            else if (key == ConsoleKey.D1 && statusFlour == 3 || key == ConsoleKey.NumPad1 && statusFlour == 3)
            {
                for (int i = statusFlour; i != 1; i--)
                {
                    Down();
                }
                ShowElivator1Flour();
            }//Key1

            else if (key == ConsoleKey.D2 && statusFlour == 3 || key == ConsoleKey.NumPad2 && statusFlour == 3)
            {
                Down();
                ShowElivator2Flour();
            }//Key2

            else if (key == ConsoleKey.D2 && statusFlour == 1 || key == ConsoleKey.NumPad2 && statusFlour == 1)
            {
                Up();
                ShowElivator2Flour();
            }//Key2

            else if (key == ConsoleKey.D3 && statusFlour == 2 || key == ConsoleKey.NumPad3 && statusFlour == 2)
            {
                Up();
                ShowElivator3Flour();
            }//Key3

            else if (key == ConsoleKey.D3 && statusFlour == 1 || key == ConsoleKey.NumPad3 && statusFlour == 1)
            {
                for (int i = statusFlour; i != 3; i++)
                {
                    Up();
                }
                ShowElivator3Flour();
            }//Key3
        }//SetButtons()

        static void Random()
        {
            var rnd = new Random();
            int index = rnd.Next(1, 4);
            
            if (index == 1)
            {
                ShowElivator1Flour();
                Programm.statusFlour = 1;
            }
            else if (index == 2)
            {
                ShowElivator2Flour();
                Programm.statusFlour = 2;
            }
            else
            {
                ShowElivator3Flour();
                Programm.statusFlour = 3;
            }
        }//Random()

        static void Timer()
        {
            Thread.Sleep(500);
        }//Timer()

        static void ShowElivator1Flour()
        {
            cursorX = 30;
            cursorY = 11;
            
            Console.Clear();
            Console.ResetColor();
            Screen();
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY);
            Console.ForegroundColor = ConsoleColor.Red;
            Cabin();
            Programm.statusFlour = 1;

        }//ShowElivator1Flour()
         
        static void ShowElivator2Flour()
        {
            Programm.cursorX = 30;
            Programm.cursorY = 6;

            Console.Clear();
            Console.ResetColor();
            Screen();
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY);
            Console.ForegroundColor = ConsoleColor.Red;
            Cabin();
            Programm.statusFlour = 2;

        }//ShowElivator2Flour()

        static void ShowElivator3Flour()
        {
            Programm.cursorX = 30;
            Programm.cursorY = 1;

            Console.Clear();
            Console.ResetColor();
            Screen();
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY);
            Console.ForegroundColor = ConsoleColor.Red;
            Programm.statusFlour = 3;
            Cabin();

        }//ShowElivator3Flour()

        static void Cabin()
        {
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY);
            Console.WriteLine(new string('*', 15));
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY+1);
            Console.WriteLine(new string('*', 15));
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY+2);
            Console.WriteLine(new string('*', 15));
            Console.SetCursorPosition(Programm.cursorX, Programm.cursorY+3);
            Console.WriteLine(new string('*', 15));
        }//Cabin

        static void Up()
        {
            for (int i = 5; i != 0; i--)
            {
                Console.Clear();
                Console.ResetColor();
                Screen();
                cursorY -= 1;
                Console.SetCursorPosition(cursorX, cursorY );
                Console.ForegroundColor = ConsoleColor.Red;
                Cabin();
                Timer();
            }
        }//Up()

        static void Down()
        {
            for (int i = 0; i != 5; i++)
            {
                Console.Clear();
                Console.ResetColor();
                Screen();
                cursorY += 1;
                Console.SetCursorPosition(cursorX, cursorY);
                Console.ForegroundColor = ConsoleColor.Red;
                Cabin();
                Timer();
            }
        }//Down()
    }
}