using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class MyDictionary<KeyType , ValueType>
    {
        KeyType[] keyTypes;
        ValueType[] valueTypes;
        KeyType[] tempKeyTypes;
        ValueType[] tempValueTypes;


        public MyDictionary()
        {
            keyTypes = new KeyType[0];
            valueTypes = new ValueType[0];

        }

        public void Add(KeyType keyType , ValueType valueType)
        {
            tempKeyTypes = keyTypes;
            tempValueTypes = valueTypes;

            keyTypes = new KeyType[keyTypes.Length + 1];
            valueTypes = new ValueType[valueTypes.Length + 1];

            for (int i = 0; i < tempKeyTypes.Length; i++)
            {
                keyTypes[i] = tempKeyTypes[i];
                valueTypes[i] = tempValueTypes[i];
            }
            keyTypes[keyTypes.Length - 1] = keyType;
            valueTypes[valueTypes.Length - 1] = valueType;

        }

        public int Count
        {
            get { return keyTypes.Length; }
        }

        public ValueType[] Value
        {
            get { return valueTypes; }
        }
    }
}
