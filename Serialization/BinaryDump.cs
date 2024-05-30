using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable SYSLIB0011
namespace Lab_16_OOP
{
    public class BinaryDump<T>
    {
        public T Load(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (T)formatter.Deserialize(stream);
            }
        }

        public void Save(string filePath, T serializationObj)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            using (FileStream fileStream = new(filePath, FileMode.Create))
            {
                binFormatter.Serialize(fileStream, serializationObj);
            }
        }

        public async void SaveAsync(string filePath, T collection)
        {
            await Task.Run(() => Save(filePath, collection));
        }
    }
}