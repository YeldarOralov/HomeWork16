using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFunction
{
    class Program
    {
        static void Main(string[] args)
        {            

            var button = new Button();
            button.Click += ShowText;

            while (true)
            {
                var consoleKey = Console.ReadKey().Key;
                if(consoleKey == ConsoleKey.Spacebar)
                {
                    button.OnClick();
                }
            }
        }
        public static void ShowText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
