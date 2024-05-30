using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_OOP
{
    public interface ISerialization<T>
    {
        public void Save(string filePath, T serializationObj);

        public T Load(string filePath);
    }
}
