using System;
using System.Collections.Generic;
using System.Text;

namespace myDictionaryHW
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TKey[] _tempKey;
        TValue[] _value;
        TValue[] _tempValue;
        //constructor
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            foreach (var checkvalue in _key)
            {
                if (checkvalue.Equals(key))
                {
                    throw new ArgumentException("Same key-value was used before!");
                }
            }

            _tempValue = _value;
            _value = new TValue[_value.Length + 1];
            _tempKey = _key;
            _key = new TKey[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

        }
        public int Count
        {
            get { return _key.Length; }
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = Array.IndexOf(_key, key);
                return _value[index];
            }
        }

    }
}
