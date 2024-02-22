using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLaba10
{
    public class Trees : Plants
    {
        static string[] treename = { "Дуб", "Сосна", "Береза", "Ива", "Клен" };
        static string[] colors = { "Красный", "Синий", "Желтый", "Розовый", "Зеленый" };
        static Random rand = new Random();
        protected double height;
        public double Height
        {
            get => height;
            set
            {
                if (value < 0) height = 0;
                else height = value;
            }
        }
        public Trees() : base()
        {
            Height = 0;
        }
        public Trees(string name, string color, double height, int number) : base(name, color, number)
        {
            Height = height;
        }
        public override void Show()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Высота = {Height} метров");
        }
        public override string ToString()
        {
            return base.ToString() + $", высота {Height} м.";
        }
        public new void Print()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Высота = {Height} метров");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите высоту дерева (в метрах):");
            try
            {
                Height = double.Parse(Console.ReadLine());
            }
            catch { Height = 0; }
        }
        public override void RandomInit()
        {
            int treeindex = rand.Next(treename.Length);
            Name = treename[treeindex];
            int colorIndex = rand.Next(colors.Length);
            Color = colors[colorIndex];
            Height = rand.Next(1, 10);
        }
        public override bool Equals(object obj)
        {
            Trees tree = (Trees)obj;
            return Name == tree.Name && Color == tree.Color && Height == tree.Height;
        }
    }
}
