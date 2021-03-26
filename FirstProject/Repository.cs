using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Repository<T> where T : IEntity, new()
    {
        private List<T> data = new List<T>();

        public void AddElement(T element)
        {
            var newElement = new T();
            newElement.Id = 23;

            if (element != null)
            {
                Console.WriteLine(element.Id);
                data.Add(element);
            }
        }

        public T GetElementById(int id)
        {
            var element = data.FirstOrDefault(e => e.Id == id);
            return element;
        }

        public T GetElement(int index)
        {
            if (index < data.Count)
            {
                return data[index];
            }
            else
            {
                return default;
            }
        }
    }

    public class Repository<TKey, TValue>
        //where TKey : class
        //where TValue : new()
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        public void AddElement(TKey key, TValue element)
        {
            if (element != null)
            {
                data.Add(key, element);
            }
        }

        public TValue GetElement(TKey key)
        {
            if (data.TryGetValue(key, out TValue result))
            {
                return result;
            }
            else
            {
                return default;
            }
        }
    }
}
