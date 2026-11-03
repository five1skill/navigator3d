using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Navigator
{
    private List<Room> _rooms = new List<Room>();
    public virtual List<Room> Rooms
    {
        get { return _rooms; }
        set { _rooms = value; }
    }

    public virtual void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public virtual Room FindRoom(string number)
    {
        foreach (Room room in Rooms)
        {
            if (room.Number == number)
            {
                return room;
            }
        }
        return null;
    }

    public virtual string BuildRoute(Room from, Room to)
    {
        StringBuilder route = new StringBuilder();
        route.AppendLine("Старт: " + from.FullName + ", " + from.Location);

        if (from.Building != to.Building)
        {
            route.AppendLine("1. Выйти из корпуса " + from.Building + " и пройти в корпус " + to.Building);
        }

        if (from.Floor < to.Floor)
        {
            route.AppendLine("2. Подняться с " + from.Floor + " на " + to.Floor + " этаж");
        }
        else if (from.Floor > to.Floor)
        {
            route.AppendLine("2. Спуститься с " + from.Floor + " на " + to.Floor + " этаж");
        }

        route.AppendLine("3. Пройти до " + to.FullName);
        route.AppendLine("Финиш: " + to.FullName + ", " + to.Location);
        return route.ToString();
    }
    public virtual Room FindRoomByName(string name)
    {
        foreach (Room room in Rooms)
        {
            if (room.Name.ToLower().Contains(name.ToLower()))
                return room;
        }
        return null;
    }
}

