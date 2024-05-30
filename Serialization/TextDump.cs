using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_16_OOP
{
    public class TextDump<T> : ISerialization<T> where T : HashTable<Goods>, new()
    {
        public T Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }

            var result = new T();

            /*foreach (string line in File.ReadLines(filePath))
            //{
            //    // Разделяем строку на атрибуты
            //    string[] attributes = line.Split('|');
            //    if (attributes.Length < 2)
            //    {
            //        throw new FormatException("Invalid file format");
            //    }

            //    // Парсим атрибуты элемента
            //    string[] keyAttributes = attributes[0].Split(',');
            //    if (keyAttributes.Length != 2)
            //    {
            //        throw new FormatException("Invalid key format");
            //    }

            //    string[] animalAttributes = attributes[1].Split(',');
            //    if (animalAttributes.Length < 3)
            //    {
            //        throw new FormatException("Invalid animal format");
            //    }

            //    // Получаем значения атрибутов
            //    string keyName = keyAttributes[0].Split(':')[1].Trim();
            //    int keyAge = int.Parse(keyAttributes[1].Split(':')[1].Trim());

            //    string goodsName = animalAttributes[0].Split(':')[1].Trim();
            //    int goodsPrice = int.Parse(animalAttributes[1].Split(':')[1].Trim());
            //    int goodsWeight = int.Parse(Regex.Match(animalAttributes[2].Split(':')[1].Trim(), @"\d+").Value);

            //    List<string> GoodsCheck = new List<string>();
            //    if (animalAttributes.Length > 3)
            //    {
            //        string[] checkAttributes = animalAttributes[3].Split(':');
            //        for (int i = 1; i < checkAttributes.Length; i++)
            //        {
            //            animalCheck.Add(checkAttributes[i].Trim());
            //        }
            //    }
            //    Goods value = new Goods(animalName, animalAge, animalWeight, animalCheck);
            //    result.Add(key, value);
            //}*/

            foreach (string line in File.ReadLines(filePath))
            {
                result.Add(ParseGoods(line));
            }

            static Goods ParseGoods(string input)
            {
                string[] attributes = input.Split('|');
                string type = attributes[attributes.Length - 1].Split(' ')[1].Trim();

                Goods product;
                switch (type)
                {
                    case "Toy":
                        product = new Toy();
                        break;
                    case "Product":
                        product = new Product();
                        break;
                    case "MilkProduct":
                        product = new MilkProduct();
                        break;
                    default:
                        product = new Goods();
                        break;
                }

                foreach (string attribute in attributes)
                {
                    string[] keyValue = attribute.Split(new[] { ": " }, StringSplitOptions.None);
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();

                        switch (key)
                        {
                            case "Название товара":
                                product.Name = value;
                                break;
                            case "Цена товара":
                                product.Price = double.Parse(value, new CultureInfo("ru-RU"));
                                break;
                            case "Вес товара":
                                product.Weight = double.Parse(value, new CultureInfo("ru-RU"));
                                break;
                            default:
                                ParseSpecificAttributes(product, key, value);
                                break;
                        }
                    }
                }

                return product;
            }

            static void ParseSpecificAttributes(Goods product, string key, string value)
            {
                switch (product)
                {
                    case Product prod when key == "Годен до":
                        prod.ExpirationDate = int.Parse(value);
                        break;
                    case Toy toy when key == "Рекомендуемый возраст":
                        toy.RecommendedAge = int.Parse(value);
                        break;
                    case MilkProduct milkProd when key == "Жирность":
                        milkProd.FatContent = double.Parse(value, new CultureInfo("ru-RU"));
                        break;
                }
            }

            return result;
        }

        public void Save(string filePath, T collection)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var element in collection)
                {
                    writer.WriteLine($"{element.ToFullString()}");
                }
            }
        }
        public async Task SaveAsync(string filePath, T collection)
        {
            await Task.Run(() => Save(filePath, collection));
        }
    }
}