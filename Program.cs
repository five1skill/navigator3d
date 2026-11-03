using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room
{
    private string _number = "";
    public virtual string Number
    {
        get { return _number; }
        set { _number = value; }
    }

    private string _name = "";
    public virtual string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _floor = 1;
    public virtual int Floor
    {
        get { return _floor; }
        set { _floor = value; }
    }

    private string _building = "";
    public virtual string Building
    {
        get { return _building; }
        set { _building = value; }
    }

    public virtual string FullName
    {
        get
        {
            string fullName = "Ауд. " + Number + " (" + Name + ")";
            return fullName;
        }
    }

    public virtual string Location
    {
        get
        {
            string location = "Корпус " + Building + ", " + Floor + " этаж";
            return location;
        }
    }

    public static string ClassDescription
    {
        get
        {
            return "Класс Room. Хранит данные о помещении вуза.";
        }
    }

    public Room(string number, string name, int floor, string building)
    {
        Number = number;
        Name = name;
        Floor = floor;
        Building = building;
    }
}
