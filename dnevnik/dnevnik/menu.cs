using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnevnik
{
    class menu
    {
        public int selectedIndex;
        public List<Notes> taskList;

        public menu(List<Notes> taskList)
        {
            this.taskList = taskList;
            selectedIndex = 0;
        }

        public void DrawMenu(DateTime date)
        {
            taskList = Program.SortByDate(date);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(date);
                for (var i = 0; i < taskList.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{taskList[i].name}");
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                var input = Console.ReadKey();

                if (input.Key is ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                    taskList = Program.SortByDate(date);
                }

                if (input.Key is ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                    taskList = Program.SortByDate(date);
                }

                if (input.Key is ConsoleKey.DownArrow)
                {
                    if (selectedIndex < taskList.Count - 1) selectedIndex++;
                }

                if (input.Key is ConsoleKey.UpArrow)
                {
                    if (selectedIndex > 0) selectedIndex--;
                }

                if (input.Key is ConsoleKey.Enter)
                {
                    Console.Clear();
                    Program.ViewTaskDetails(selectedIndex);
                    Console.ReadKey();
                }

                if (input.Key is ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
