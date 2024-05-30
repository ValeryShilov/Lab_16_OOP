using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_OOP
{
    [Serializable]
    public class Product: Goods, IInit, ICloneable, IComparable
    {
        private int expirationDate;

        public int ExpirationDate { get; set; }

        public Product() : base()
        {
            ExpirationDate = new();
        }

        public Product(string name, double price, double weight, int expirationDate) : base(name, price, weight)
        {
            ExpirationDate = expirationDate;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Weight = product.Weight;
            ExpirationDate = product.ExpirationDate;
        }

        public override string GetString()
        {
            return base.GetString() +  $" Годен до {ExpirationDate}";
        }

        public override void Show()
        {
            Console.WriteLine(GetString());
        }

        public void ProductShow()
        {
            Console.WriteLine("Название товара: " + Name);
            Console.WriteLine("Цена товара: " + Price);
            Console.WriteLine("Вес товара: " + Weight);
            Console.WriteLine($"Годен до {ExpirationDate}");
        }

        public override void Init()
        {
            base.Init();
            bool isRead;
            do
            {
                isRead = true;
                Console.WriteLine("Введите дату окончания срока годности");
                int year = Menu.ReadInt("Введите год ", "Год должен быть не меньше текущего", "->", 2023, 3000);
                int month = Menu.ReadInt("Введите номер месяца", "Номер месяца должен быть от 1 до 12", "->", 1, 12);
                int day = Menu.ReadInt("Введите число", "Число должно быть от 1 до 31", "->", 1, 31);
                int ExpirationDate = Menu.ReadInt("Введите число", "Число должно быть от 1 до 31", "->", 1, 31);
            } while (!isRead);
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            ExpirationDate = rnd.Next(1, 100);
        }

        public override object Clone()
        {
            return new Product() { Name = Name, Price = Price, Weight = Weight, ExpirationDate = ExpirationDate};
        }

        public override Product ShallowCopy()
        {
            return (Product)MemberwiseClone();
        }

        public Goods BaseGoods
        {
            get
            {
                return new Goods(Name, Price, Weight);
            }
        }
        public override string ToString()
        {
            return GetString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + HashCode.Combine(ExpirationDate);
        }

        public override string ToFullString()
        {
            return base.ToFullString() + $"|Годен до: {ExpirationDate}";
        }
    }
}
