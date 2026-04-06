using pract8_oaip_Akhmadullina4235;
using System;

class Program
{
    static void Main()
    {
        MyList<Restaurant> restaurants = new MyList<Restaurant>();

        while (true)
        {
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("1 - Добавить ресторан");
            Console.WriteLine("2 - Показать список");
            Console.WriteLine("3 - Вставить ресторан по индексу");
            Console.WriteLine("4 - Удалить по индексу");
            Console.WriteLine("5 - Удалить последний");
            Console.WriteLine("6 - Найти ресторан");
            Console.WriteLine("7 - Развернуть список");
            Console.WriteLine("8 - Сортировка");
            Console.WriteLine("9 - Удалить дубликаты");
            Console.WriteLine("10 - Очистить список");
            Console.WriteLine("0 - Выход");

            Console.Write("Выберите пункт: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
                {
                }

            if (choice == 1)
            {
                Console.Write("Название ресторана: ");
                string rName = Console.ReadLine();

                Console.Write("№ блюда: ");
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                }

                Console.Write("Название блюда: ");
                string name = Console.ReadLine();

                Console.Write("Категория: ");
                string cat = Console.ReadLine();

                Console.Write("Цена: ");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                }

                Console.Write("Ингредиенты: ");
                string ing = Console.ReadLine();

                Dish dish = new Dish(num, name, cat, price, ing);
                Restaurant r = new Restaurant(rName, dish);

                restaurants.Add(r);

                Console.WriteLine("Добавлено");
            }

            else if (choice == 2)
            {
                Console.WriteLine("\nСписок ресторанов:");
                restaurants.Print();
            }

            else if (choice == 3)
            {
                Console.Write("Введите индекс: ");
                int index;
                  while (!int.TryParse(Console.ReadLine(), out index))
                {
                }

                Console.Write("Название ресторана: ");
                string rName = Console.ReadLine();

                Console.Write("№ блюда: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Название блюда: ");
                string name = Console.ReadLine();

                Console.Write("Категория: ");
                string cat = Console.ReadLine();

                Console.Write("Цена: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Ингредиенты: ");
                string ing = Console.ReadLine();

                Dish dish = new Dish(num, name, cat, price, ing);
                Restaurant r = new Restaurant(rName, dish);

                restaurants.Insert(index, r);

                Console.WriteLine("Вставлено");
            }

            else if (choice == 4)
            {
                Console.Write("Введите индекс: ");
                int index = int.Parse(Console.ReadLine());

                restaurants.RemoveAt(index);

                Console.WriteLine("Удалено");
            }

            else if (choice == 5)
            {
                restaurants.RemoveLast();

                Console.WriteLine("Последний элемент удалён.");
            }

            else if (choice == 6)
            {
                Console.Write("Введите название ресторана: ");
                string name = Console.ReadLine();

                var result = restaurants.Find(r => r.Name == name);

                if (result != null)
                    Console.WriteLine(result);
                else
                    Console.WriteLine("Не найдено");
            }

            else if (choice == 7)
            {
                restaurants.Reverse();
                Console.WriteLine("Список развернут.");
            }

            else if (choice == 8)
            {
                Console.WriteLine("1 - По возрастанию");
                Console.WriteLine("0 - По убыванию");

                int type = int.Parse(Console.ReadLine());

                restaurants.Sort(type);

                Console.WriteLine("Сортировка выполнена.");
            }

            else if (choice == 9)
            {
                restaurants.Distinct();

                Console.WriteLine("Дубликаты удалены.");
            }

            else if (choice == 10)
            {
                restaurants.Clear();

                Console.WriteLine("Список очищен.");
            }

            else if (choice == 0)
            {
                break;
            }
        }
    }
}