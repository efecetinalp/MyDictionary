using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<Tkey, Tvalue>
    {
        KeyValuePair<Tkey, Tvalue>[] _items;

        public MyDictionary()
        {
            _items = new KeyValuePair<Tkey, Tvalue>[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            KeyValuePair<Tkey, Tvalue>[] tempArray = _items;
            _items = new KeyValuePair<Tkey, Tvalue>[_items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            _items[_items.Length - 1] = new KeyValuePair<Tkey, Tvalue>(key, value);
        }

        public void List()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }
    }
}
