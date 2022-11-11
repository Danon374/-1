using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnevnik
{
    class Program
    {
        public static List<Notes> taskList = new List<Notes>();

        static void Main(string[] args)
        {
            Notes Task_1 = new Notes(named: "Пойти погулть", description: "С 12:00 по 17:00" , date: new DateTime(2022, 10, 14));
            Notes Task_2 = new Notes(named: "Сделать домашнее задание", description: "Завершить домашнее задание", date: new DateTime(2022, 10, 14));
            Notes Task_3 = new Notes(named: "Пойти посмотреть фильм", description: "Но лучше сделать домашнее задание!!!", date: new DateTime(2022, 10, 14));
            Notes Task_4 = new Notes(named: "Завершить домашнее задание", description: "Если все дела сделаны, то можно и пойти покушать", date: new DateTime(2022, 10, 15));
            Notes Task_5 = new Notes(named: "Помочь родителям с делами по дому", description: "Сделать уборку в комнате, помыть посуду, пойти за продуктами и купить на мамины деньги шоколадку", date: new DateTime(2022, 10, 15));
            Notes Task_6 = new Notes(named: "Пойти лечь Спать", description: "Сегодня выходной,теперь можно с кайфом откинувшись поспать :3", date: new DateTime(2022, 10, 16));
            taskList.Add(Task_1);
            taskList.Add(Task_2);
            taskList.Add(Task_4);
            taskList.Add(Task_5);
            taskList.Add(Task_6);

            DateTime date = new(2022, 10, 14);

            List<Notes> List = taskList;
            List = taskList.Where(o => o.date == date).ToList();

            var menu = new menu(taskList);
            menu.DrawMenu(date);
        }

        public static void ViewTaskDetails(int Janix)
        {
            int taskID = Janix;

            Console.WriteLine($"===========================|\n" +
                              $"Дата: {taskList.ElementAt(taskID).date}\n" +
                              $"===========================|\n");
            Console.Write($"Поставленная задача: {taskList.ElementAt(taskID).named}\n" +
                          $"Описание: {taskList.ElementAt(taskID).description}");
        }

        public static List<Notes> SortByDate(DateTime date)
        {
            List<Notes> orderedList = taskList;
            orderedList = taskList.Where(o => o.date == date).ToList();

            return orderedList;
        }
    }
}
