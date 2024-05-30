using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_16_OOP
{
    [XmlInclude(typeof(Product))]
    [XmlInclude(typeof(Toy))]
    [XmlInclude(typeof(MilkProduct))]
    [Serializable]
    public class Goods : IInit, ICloneable, IComparable
    {
        private string name;
        private double price;
        private double weight;
        public string Name { get; set; }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new Exception("Ошибка, цена не может быть меньше 0");
                else
                    price = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new Exception("Ошибка, вес не может быть меньше 0");
                else
                    weight = value;
            }
        }

        public Goods(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public Goods()
        {
            Name = " ";
            Price = 0;
            Weight = 0;
        }

        public Goods(Goods goods)
        {
            Name = goods.Name;
            Price = goods.Price;
            Weight = goods.Weight;
        }

        public void GoodsShow()
        {
            Console.WriteLine(GetString());
        }

        public virtual void Show()
        {
            Console.WriteLine("Название товара: " + Name);
            Console.WriteLine("Цена товара: " + Price);
            Console.WriteLine("Вес товара: " + Weight);
        }

        public virtual string GetString()
        {
            var row = $"Название товара: {Name}";
            return row;
        }

        public void GoodsInit()
        {
            Console.Write("Введите название товара: ");
            Name = Console.ReadLine();
            Price = Menu.ReadDouble("Введите цену товара", "Цена должна быть вещественным неотрицательным числом", "0");
            Weight = Menu.ReadDouble("Введите вес товара", "Вес товара должн быть вещественным неотрицательным числом", "0");
        }

        public virtual void Init()
        {
            Console.Write("Введите название товара: ");
            Name = Console.ReadLine();
            Price = Menu.ReadDouble("Введите цену товара", "Цена должна быть вещественным неотрицательным числом", "0");
            Weight = Menu.ReadDouble("Введите вес товара", "Вес товара должн быть вещественным неотрицательным числом", "0");
        }

        public virtual void RandomInit()
        {
            Random rnd = new Random();
            Name = "Товар_" + rnd.Next(1, 10000);
            Price = Math.Round(rnd.NextDouble() * 100000, 2);
            Weight = Math.Round(rnd.NextDouble() * 100, 2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Goods goods)
            {
                return Name == goods.Name && Price == goods.Price && Weight == goods.Weight;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight);
        }

        public virtual object Clone()
        {
            return new Goods(this);
        }
        public virtual Goods ShallowCopy()
        {
            return (Goods)this.MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;
            else
            {
                var tempGoods = (Goods)obj;
                if (String.Compare(Name, tempGoods.Name) > 0)
                    return 1;
                else if (String.Compare(Name, tempGoods.Name) < 0)
                    return -1;
                if (Price > tempGoods.Price)
                    return 1;
                else if (Price < tempGoods.Price)
                    return -1;
                if (Weight > tempGoods.Weight)
                    return 1;
                if (Weight < tempGoods.Weight)
                    return -1;
                return 0;
            }
        }

        public override string ToString()
        {
            return GetString();
        }

        public virtual string ToFullString()
        {
            return $"Название товара: {Name}|Цена товара: {Price}|Вес товара: {Weight}";
        }
    }
}
