using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // создаем навигатор и несколько помещений вуза
        Navigator navigator = new Navigator();
        navigator.AddRoom(new Room("1101", "Лекционная аудитория", 1, "1"));
        navigator.AddRoom(new Room("3205", "Компьютерный класс", 3, "1"));
        navigator.AddRoom(new Room("2310", "Лаборатория", 2, "2"));

        Room start = navigator.FindRoom("1101");
        Room finish1 = navigator.FindRoom("3205");
        Room finish2 = navigator.FindRoom("2310");

        System.Console.WriteLine(start.FullName);
        System.Console.WriteLine(start.Location);
        System.Console.WriteLine(finish1.FullName);
        System.Console.WriteLine(finish1.Location);
        System.Console.WriteLine(Room.ClassDescription);

        System.Console.WriteLine();
        System.Console.WriteLine(navigator.BuildRoute(start, finish1));
        System.Console.WriteLine(navigator.BuildRoute(start, finish2));

        System.Console.ReadKey();
    }
}
