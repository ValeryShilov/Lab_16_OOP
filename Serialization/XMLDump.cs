using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_16_OOP.Serialization
{
    public class XMLDump<T> : ISerialization<T> where T : class
    {
        public T Load(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }

        public void Save(string filePath, T serializationObj)
        {
            XmlSerializer serializer = new XmlSerializer(serializationObj.GetType());
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, serializationObj);
            }
        }

        public async void SaveAsync(string filePath, T collection)
        {
            await Task.Run(() => Save(filePath, collection));
        }
    }
}