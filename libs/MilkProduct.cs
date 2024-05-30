﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_16_OOP
{
    
    [Serializable]
    public class MilkProduct : Product, IInit, ICloneable, IComparable
    {
        private double fatContent;

        public double FatContent
        {
            get => fatContent;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка, жирность не может быть меньше 0");
                }
                else
                    fatContent = value;
            }
        }

        public MilkProduct() : base()
        {
            fatContent = 0;
        }

        public MilkProduct(string name, double price, double weight, int expirationDate, double fatContent)
            : base(name, price, weight, expirationDate)
        {
            FatContent = fatContent;
        }

        public MilkProduct(MilkProduct milkProduct)
        {
            milkProduct.Name = this.Name;
            milkProduct.Price = this.Price;
            milkProduct.Weight = this.Weight;
            milkProduct.ExpirationDate = this.ExpirationDate;
            milkProduct.FatContent = this.FatContent;
        }

        public override string GetString()
        {
            return base.GetString() + $" Жирность: {FatContent} %";
        }

        public override void Show()
        {
            Console.WriteLine(GetString());
        }

        public void MilkShow()
        {
            Console.WriteLine("Название товара: " + Name);
            Console.WriteLine("Цена товара: " + Price);
            Console.WriteLine("Вес товара: " + Weight);
            Console.WriteLine($"Годен до {ExpirationDate}");
            Console.WriteLine($"Жирность: {FatContent} %");
        }

        public override void Init()
        {
            base.Init();
            FatContent = Menu.ReadDouble("Введите процент жирности", "Процент должен быть от 1 до 100", "->", 1, 100);
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            FatContent = Math.Round(rnd.NextDouble() * 100, 1);
        }

        public override object Clone()
        {
            return new MilkProduct() { Name = Name, Price = Price, Weight = Weight, ExpirationDate = ExpirationDate, FatContent = FatContent};
        }

        public override MilkProduct ShallowCopy()
        {
            return (MilkProduct)MemberwiseClone();
        }

        public override string ToString()
        {
            return GetString();
        }

        public override string ToFullString()
        {
            return base.ToFullString() + $"|Жирность: {FatContent}";
        }
    }
}
