using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Runtime.Versioning;


namespace Elevator

{
    class Programm
    {

        public static int x = 60;
        public static int y = 16;
        public static string no = " ";
        public static string yes = "=";

        static void Main()
        {

            Screen();
            Random();

            while (true)
            {
                SetButtons();
            }
            
            //Console.ReadLine();
            
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
                "=                 3ий этаж  =                 =            =" +
                "=                           =                 =            =" +
                "=                           = =============== =            =" +
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

        static void ShowElivator1Flour()
        {
            int cursorX = 30, cursorY = 13;
            
            Console.Clear();
            Console.ResetColor();
            Screen();

            for (int i = cursorY; i != 10 - 1; i--)
            {
                Console.SetCursorPosition(cursorX, cursorY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('*', 15));
                cursorY--;
                //Console.ReadKey();
            }

        }//ShowElivator1Flour()

        static void ShowElivator2Flour()
        {

            int cursorX = 30, cursorY = 8;

            Console.Clear();
            Console.ResetColor();
            Screen();

            for (int i = cursorY; i != 6 - 1; i--)
            {

                Console.SetCursorPosition(cursorX, cursorY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('*', 15));
                cursorY--;

                // Console.ReadKey();
            }

        }//ShowElivator2Flour()

        static void ShowElivator3Flour()
        {
            int cursorX = 30, cursorY = 4;

            Console.Clear();
            Console.ResetColor();
            Screen();

            for (int i = cursorY; i < 5 && i != 0; i--)
            {
                Console.SetCursorPosition(cursorX, cursorY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('*', 15));
                cursorY--;

                //Console.ReadKey();
            }

        }//ShowElivator3Flour()

        static void SetButtons()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 2);
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                ShowElivator1Flour();
            }

            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                ShowElivator2Flour();
            }

            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                ShowElivator3Flour();
            }
        }

        static void Random()
        {
            var rnd = new Random();
            int index = rnd.Next(1,4);
            Console.WriteLine(index);
            if (index == 1)
            {
                ShowElivator1Flour();
            }
            else if (index == 2)
            {
                ShowElivator2Flour();
            }
            else
            {
                ShowElivator3Flour();
            }
        }//Random()
    }
}   



