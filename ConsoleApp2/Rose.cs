using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLaba10
{
    public class Rose : Flowers
    {
        static string[] flavors = { "Свежий", "Густой", "Сладкий", "Терпкий", "Душистый" };
        static string[] colors = { "Красный", "Белый", "Синий", "Желтый", "Розовый", "Зеленый" };
        static string[] rosename = { "Красная роза", "Белая роза", "Роза Флорибунда", "Кустовая роза", "Английская роза" };
        static Random rand = new Random();
        public bool Thorns { get; set; }
        public Rose() : base()
        {
            Thorns = false;
        }
        public Rose(string name, string color, string flavor, bool thorns, int number) : base(name, color, flavor, number)
        {
            Thorns = thorns;
        }
        public override void Show()
        {
            if (Thorns == true) { Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Запах - {Flavor}, Есть шипы"); }
            else { Console.WriteLine($"Id =  {id} , Название - {Name}, Цвет - {Color}, Запах - {Flavor}, Шипов нет"); }
        }
        public override string ToString()
        {
            if (Thorns == true)
                return base.ToString() + $", Есть шипы";
            else return base.ToString() + $", Шипов нет";
        }
        public new void Print()
        {
            if (Thorns == true) Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Запах - {Flavor}, Есть шипы");
            else Console.WriteLine($"Id = {id}, Название - {Name}, Цвет - {Color}, Запах - {Flavor}, Шипов нет");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Есть ли шипы у розы? (0 - Шипов нет; 1 - Шипы есть):");
            int inputThorns;
            try
            {
                inputThorns = int.Parse(Console.ReadLine());
            }
            catch
            {
                inputThorns = 0;
            }

            if (inputThorns == 0)
            {
                Thorns = false;
            }
            else
            {
                Thorns = true;
            }
        }
        public override void RandomInit()
        {
            int flowerindex = rand.Next(rosename.Length);
            Name = rosename[flowerindex];
            int colorIndex = rand.Next(colors.Length);
            Color = colors[colorIndex];
            int flavorsindex = rand.Next(flavors.Length);
            Flavor = flavors[flavorsindex];
            int randthorn = rand.Next(2);
            if (randthorn == 0)
            {
                Thorns = false;
            }
            else
            {
                Thorns = true;
            }
        }
        public override bool Equals(object obj)
        {
            Rose rose = (Rose)obj;
            return Name == rose.Name && Color == rose.Color && Flavor == rose.Flavor && Thorns == rose.Thorns;
        }
    }
}
