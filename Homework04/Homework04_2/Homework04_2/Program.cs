using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_2
{
    class OrderDetails
    {
        public string number;
        public string item;
        public string costumer;
    }

    class Order
    {
        private OrderDetails details;
        public Order(string number, string item, string costumer)
        {
            details = new OrderDetails
            {
                number = number,
                item = item,
                costumer = costumer
            };
        }
        public void SetData()
        {
            string input = Console.ReadLine();

            int i = 0, j = 0;
            string[] array = new string[100];
            string x = null;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    x = x + input[i];
                }
                else
                {
                    array[j] = x;
                    j++;
                    x = null;
                }
                i++;
            }
            array[j] = x;
            j++;
            details.number = array[0];
            details.item = array[1];
            details.costumer = array[2];
        }
        public string GetNumber()
        {
            return details.number;
        }
        public string GetCostum()
        {
            return details.costumer;
        }
        public string GetItem()
        {
            return details.item;
        }
        public string GetData(int i)
        {
            switch (i)
            {
                case 0:
                    return details.number;
                case 1:
                    return details.number;
                case 2:
                    return details.number;
            }
            return null;
        }
        public void Output()
        {
            Console.WriteLine("Index:" + details.number);
            Console.WriteLine("Item:" + details.item);
            Console.WriteLine("Costumer:" + details.costumer);
        }

    }

    class OrderService
    {
        List<Order> list = new List<Order>();

        public void Add()
        {
            string input = Console.ReadLine();

            int i = 0, j = 0;
            string[] array = new string[100];
            string x = null;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    x = x + input[i];
                }
                else
                {
                    array[j] = x;
                    j++;
                    x = null;
                }
                i++;
            }
            array[j] = x;
            j++;

            list.Add(new Order(array[0], array[1], array[2]));
        }

        public void Find()
        {
            string input;
            input = Console.ReadLine();
            foreach (Order var in list)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        var.Output();
                        break;
                    }
                }
            }
        }


        public void Delete()
        {
            string input = Console.ReadLine();
            foreach (Order var in list)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        list.Remove(var);
                        break;
                    }
                }
            }
        }


        public void Change()
        {
            string input = Console.ReadLine();
            foreach (Order var in list)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        var.SetData();
                        break;
                    }
                }
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            int index = Convert.ToInt32(Console.ReadLine());
            while (index != 0)
            {
                switch (index)
                {
                    case 1:
                        orderService.Add();
                        break;
                    case 2:
                        orderService.Find();
                        break;
                }
                index = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
