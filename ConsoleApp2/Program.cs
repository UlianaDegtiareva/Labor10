using ClassLibraryLaba10;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace laba10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Plants[] plantsArray = new Plants[20]; //массив для 1 части
            for (int i = 0; i < 5; i++)
            {
                Plants p = new Plants();
                p.RandomInit();
                plantsArray[i] = p;
            }
            for (int i = 5; i < 10; i++)
            {
                Flowers f = new Flowers();
                f.RandomInit();
                plantsArray[i] = f;
            }
            for (int i = 10; i < 15; i++)
            {
                Trees t = new Trees();
                t.RandomInit();
                plantsArray[i] = t;
            }
            for (int i = 15; i < 20; i++)
            {
                Rose r = new Rose();
                r.RandomInit();
                plantsArray[i] = r;
            }
            IInit[] inits = new IInit[25]; //массив для 2 части
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                Plants p = new Plants();
                count++;
                p.RandomInit();
                inits[i] = p;
            }
            for (int i = 5; i < 10; i++)
            {
                Flowers f = new Flowers();
                count++;
                f.RandomInit();
                inits[i] = f;
            }
            for (int i = 10; i < 15; i++)
            {
                Trees t = new Trees();
                count++;
                t.RandomInit();
                inits[i] = t;
            }
            for (int i = 15; i < 20; i++)
            {
                Rose r = new Rose();
                count++;
                r.RandomInit();
                inits[i] = r;
            }
            for (int i = 20; i < 25; i++)
            {
                Post post = new Post();
                count++;
                post.RandomInit();
                inits[i] = post;
            }
            Plants[] plantsArray1 = new Plants[20]; //массив для 3 части
            for (int i = 0; i < 5; i++)
            {
                Plants p = new Plants();
                p.RandomInit();
                plantsArray1[i] = p;
            }
            for (int i = 5; i < 10; i++)
            {
                Flowers f = new Flowers();
                f.RandomInit();
                plantsArray1[i] = f;
            }
            for (int i = 10; i < 15; i++)
            {
                Trees t = new Trees();
                t.RandomInit();
                plantsArray1[i] = t;
            }
            for (int i = 15; i < 20; i++)
            {
                Rose r = new Rose();
                r.RandomInit();
                plantsArray1[i] = r;
            }
            int answer;
            do
            {
                Console.WriteLine("------------- ГЛАВНОЕ МЕНЮ -------------");
                Console.WriteLine("1. I часть ");
                Console.WriteLine("2. II часть ");
                Console.WriteLine("3. III часть ");
                Console.WriteLine("4. Выход ");
                answer = InputAnswer();
                switch (answer) 
                {
                    case 1:
                        {
                            int answer2;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Сформирован массив из элементов класса Plants ");
                                Console.WriteLine("1. Печать массива при помощи виртуальной функции ");
                                Console.WriteLine("2. Печать массива при помощи не виртуальной функции ");
                                Console.WriteLine("3. Назад");
                                answer2 = InputAnswer();
                                switch (answer2)
                                {
                                    case 1:
                                        {
                                            foreach (Plants item in plantsArray)
                                            {
                                                item.Show();
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            foreach (Plants item in plantsArray)
                                            {
                                                item.Print();
                                            }
                                            break;
                                        }
                                    case 3: { break; }
                                    default:
                                        {
                                            Console.WriteLine("Неправильно задан пункт меню");
                                            break;
                                        }
                                }
                            } while (answer2 != 3);
                            break;
                        }
                    case 2:
                        {
                            int answer2;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Выполнение запросов ");
                                Console.WriteLine("1. Розы без шипов");
                                Console.WriteLine("2. Самое низкое дерево");
                                Console.WriteLine("3. Цветы с запахом");
                                Console.WriteLine("4. Назад");
                                answer2 = InputAnswer();
                                switch (answer2)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("РОЗЫ БЕЗ ШИПОВ : ");
                                            PrintThornlessRoses(plantsArray);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("САМОЕ НИЗКОЕ ДЕРЕВО: ");
                                            PrintShortestTree(plantsArray);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("ЦВЕТЫ С ЗАПАХОМ: ");
                                            PrintFlowers(plantsArray);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 4: { break; }
                                    default:
                                        {
                                            Console.WriteLine("Неправильно задан пункт меню");
                                            break;
                                        }
                                }
                            } while (answer2 != 4);
                            break;
                        }
                    case 3:
                        {
                            int answer2;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("1. Массив из элементов класса Plants и Post");
                                Console.WriteLine("2. Работа с массивом из элементов класса Plants");
                                Console.WriteLine("3. Клонирование и Копирование");
                                Console.WriteLine("4. Назад");
                                answer2 = InputAnswer();
                                switch (answer2)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Массив из элементов класса Plants и Post");
                                            foreach (var item in inits)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine($"Количество созданных объектров = {count}");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            int answer3;
                                            do
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Работа с массивом из элементов класса Plants");
                                                Console.WriteLine("1. Печать массива");
                                                Console.WriteLine("2. Сортировка массива по названиям растений");
                                                Console.WriteLine("3. Бинарный поиск элемента: 12(id), Мох синего цвета в отсортированном массиве");
                                                Console.WriteLine("4. Сортровка массива по цветам (длине строки)");
                                                Console.WriteLine("5. Бинарный поиск элемента: 12(id), Водросль фиолетового цвета в отсортированном массиве");
                                                Console.WriteLine("6. Назад ");
                                                answer3 = InputAnswer();
                                                switch (answer3)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Массив из элементов класса Plants и ему производных по названиям растений: ");
                                                            foreach (Plants item in plantsArray1)
                                                            {
                                                                Console.WriteLine(item);
                                                            }
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Отсортированный массив с элементами класса Plants и ему производными по названиям растений: ");
                                                            Console.WriteLine();
                                                            Plants plantrose = new Plants("Папоротник", "Синий", 12);
                                                            plantsArray1[0] = plantrose;
                                                            Array.Sort(plantsArray1);
                                                            foreach (Plants item in plantsArray1)
                                                            {
                                                                Console.WriteLine(item);
                                                            }
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine($"Бинарный поиск элемента: 12(id), папоротник синего цвета");
                                                            Console.WriteLine();
                                                            int pos1 = Array.BinarySearch(plantsArray1, new Plants("Папоротник", "Синий", 12));
                                                            if (pos1 < 0) Console.WriteLine("Нет такого элемента");
                                                            else Console.WriteLine($"Элемент: 12(id), папоротник синего цвета находится на {pos1 + 1} позиции");
                                                            Console.WriteLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Отсортированный массив с элементами класса Plants и ему производными по цветам (длине цвета): ");
                                                            Console.WriteLine();
                                                            Plants plantmoh = new Plants("Мох", "Фиолетовый", 12);
                                                            plantsArray1[1] = plantmoh;
                                                            Array.Sort(plantsArray1, new SortByColor());
                                                            foreach (Plants item in plantsArray1)
                                                            {
                                                                Console.WriteLine(item);
                                                            }
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine($"Бинарный поиск элемента: 12(id), Мох фиолетового цвета");
                                                            Console.WriteLine();
                                                            int pos2 = Array.BinarySearch(plantsArray1, new Plants("Мох", "Фиолетовый", 12), new SortByColor());
                                                            if (pos2 < 0) Console.WriteLine("Нет такого элемента");
                                                            else Console.WriteLine($"Элемент: 12(id), Мох фиолетового цвета находится на {pos2 + 1} позиции");
                                                            Console.WriteLine();
                                                            break;
                                                        }
                                                    case 6: { break; }
                                                    default:
                                                        {
                                                            Console.WriteLine("Неправильно задан пункт меню");
                                                            break;
                                                        }
                                                }
                                            } while (answer3 != 6);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Plants plantsforcopy = new Plants();
                                            plantsforcopy.RandomInit();
                                            Console.WriteLine("Исходный эдемент для копирования и клонирования");
                                            Console.WriteLine(plantsforcopy);
                                            Plants copy = plantsforcopy.ShallowCopy() as Plants;
                                            Console.WriteLine($" Копия - {copy}");
                                            Plants clon = plantsforcopy.Clone() as Plants;
                                            Console.WriteLine($" Копия - {clon}");

                                            Console.WriteLine();
                                            Console.WriteLine();

                                            Console.WriteLine("После изменения: ");
                                            copy.Name = "copy" + plantsforcopy.Name;
                                            copy.id.number = 100;
                                            clon.Name = "clon" + plantsforcopy.Name;
                                            clon.id.number = 200;
                                            Console.WriteLine("Исходный элемент - " + plantsforcopy);
                                            Console.WriteLine("Копия - " + copy);
                                            Console.WriteLine("Клон - " + clon);
                                            break;
                                        }
                                    case 4: { break; }
                                    default:
                                        {
                                            Console.WriteLine("Неправильно задан пункт меню");
                                            break;
                                        }
                                }
                            } while (answer2 != 4);
                            break;
                        }
                    case 4:
                        { break; }
                    default:
                        {
                            Console.WriteLine("Неправильно задан пункт меню");
                            break;
                        }
                }

            } while (answer != 4);
        }
        static int InputAnswer()
        {
            int answer;
            bool Ok;
            do
            {
                string buf = Console.ReadLine();
                Ok = int.TryParse(buf, out answer);
                if (!Ok)
                {
                    Console.WriteLine("Неправильно выбран пункт меню. Повторите ввод");
                }
            } while (!Ok);
            return answer;
        }
        public static void PrintThornlessRoses(Plants[] array)
        {
            foreach (Plants plant in array)
            {
                if (plant is Rose rose && rose.Thorns == false)
                {
                    Console.WriteLine($"Название: {rose.Name}, Цвет: {rose.Color}, Запах: {rose.Flavor}");
                }
            }
        }
        public static void PrintShortestTree(Plants[] array)
        {
            Trees[] shortestTrees = new Trees[4]; // Массив для хранения деревьев с минимальной высотой
            double shortestHeight = 11;
            int count = 0; // Для отслеживания количества деревьев с минимальной высотой
            foreach (Plants plant in array)
            {
                if (plant is Trees tree)
                {
                    if (tree.Height < shortestHeight)
                    {
                        shortestHeight = tree.Height;
                        count = 1;
                        shortestTrees[0] = tree;
                    }
                    else if (tree.Height == shortestHeight)
                    {
                        shortestTrees[count] = tree;
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Название: {shortestTrees[i].Name}, Цвет: {shortestTrees[i].Color}, Высота: {shortestTrees[i].Height} метров");
                }
            }
            else
            {
                Console.WriteLine("Нет информации о самых низких деревьях.");
            }
        }
        public static void PrintFlowers(Plants[] arr)
        {
            foreach (Plants plant in arr)
            {
                if (plant is Flowers flower)
                {
                    Console.WriteLine($"Название - {flower.Name}, запах - {flower.Flavor}");
                }
            }
        }
    }
}
