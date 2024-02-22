using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLaba10
{
    public class Flowers : Plants
    {
        static string[] flowername = { "Роза", "Тюльпан", "Лилия", "Мак", "Астра" };
        static string[] colors = { "Красный", "Белый", "Синий", "Желтый", "Розовый", "Зеленый" };
        static string[] flavors = { "Свежий", "Густой", "Сладкий", "Терпкий", "Душистый" };
        static Random rand = new Random();
        public string Flavor { get; set; }
        public Flowers() : base()
        {
            Flavor = "Нет запаха";
        }
        public Flowers(string name, string color, string flavor, int number) : base(name, color, number)
        {
            Flavor = flavor;
        }
        public override void Show()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Запах - {Flavor}");
        }
        public override string ToString()
        {
            return base.ToString() + $", запах {Flavor}";
        }
        public new void Print()
        {
            Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Запах - {Flavor}");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите запах растения:");
            Flavor = Console.ReadLine();
        }
        public override void RandomInit()
        {
            int flowerindex = rand.Next(flowername.Length);
            Name = flowername[flowerindex];
            int colorIndex = rand.Next(colors.Length);
            Color = colors[colorIndex];
            int flavorsindex = rand.Next(flavors.Length);
            Flavor = flavors[flavorsindex];
        }
        public override bool Equals(object obj)
        {
            Flowers flower = (Flowers)obj;
            return Name == flower.Name && Color == flower.Color && Flavor == flower.Flavor;
        }
    }
}
