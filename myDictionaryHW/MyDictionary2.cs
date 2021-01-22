using System;
using System.Collections.Generic;
using System.Text;

namespace myDictionaryHW
{
    class MyDictionary2<TKey, TValue>
    {
        List<TKey> _key = new List<TKey>();
        List<TValue> _value = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            foreach (var checkvalue in _key)
            {
                if (checkvalue.Equals(key))
                {
                    throw new ArgumentException("Same key-value was used before!");
                }
            }
            _key.Add(key);
            _value.Add(value);
        }

        public int Count
        {
            get { return _key.Count; }
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = _key.IndexOf(key);
                return _value[index];
            }
        }



    }
}
