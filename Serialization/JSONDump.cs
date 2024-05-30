using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab_16_OOP.Serialization
{
    public class JSONDump<T> : ISerialization<T> where T : class
    {
        JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };
        public T Load(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return (T)JsonConvert.DeserializeObject(json, settings);
        }

        public void Save(string filePath, T serializationObj)
        {
            string json = JsonConvert.SerializeObject(serializationObj, settings);
            File.WriteAllText(filePath, json);
        }

        public async void SaveAsync(string filePath, T collection)
        {
            await Task.Run(() => Save(filePath, collection));
        }
    }
}