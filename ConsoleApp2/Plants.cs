using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaba10
{
    public class IdNumber
    { 
        public int number;
        public int Number
        {
            get => number;
            set
            {
                if (value < 0) number = 0;
                else number = value;
            }
        }
        public IdNumber(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return number.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is IdNumber n) return this.number == n.number;
            return false;

        }
    }
    public class Plants: IInit, IComparable, ICloneable
    {
        protected string name;
        protected string color;
        public IdNumber id;
        string[] plantname = { "Дерево", "Цветок", "Водоросль", "Мох", "Папортник" };
        string[] colors = { "Красный", "Белый", "Синий", "Желтый", "Розовый", "Зеленый" };
        static Random rand = new Random();
        public string Name
        {
            get => name; set => name = value;
        }

        public string Color
        {
            get => color; set => color = value;
        }

        public Plants()
        {
            Name = "No name";
            Color = "No color";
            id = new IdNumber(1);
        }
        public Plants(string name, string color, int number)
        {
            Name = name;
            Color = color;
            id = new IdNumber(number);
        }

        public virtual void Show()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}");
        }
        public override string ToString()
        {
            return id + " , " + Name + ", " + Color;
        }
        public void Print()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}");
        }
        public virtual void Init()
        {
            Console.WriteLine("Введите id: ");
            try
            {
                id.number = int.Parse(Console.ReadLine());
            }
            catch { id.number = 0; }
            Console.WriteLine("Введите название:");
            Name = Console.ReadLine();

            Console.WriteLine("Введите цвет:");
            Color = Console.ReadLine();
        }
        public virtual void RandomInit()
        {
            int plantIndex = rand.Next(plantname.Length);
            Name = plantname[plantIndex];

            int colorIndex = rand.Next(colors.Length);
            Color = colors[colorIndex];

            id.number = rand.Next(1,100);
        }
        public override bool Equals(object obj)
        {
            Plants plant = (Plants)obj;
            return Name == plant.Name && Color == plant.Color;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            Plants p = obj as Plants;
            return String.Compare(this.Name, p.Name);
        }

        public object Clone()
        {
            return new Plants(Name, Color, id.number);
        }
        public object ShallowCopy()
        { 
            return this.MemberwiseClone();
        }
    }
}
