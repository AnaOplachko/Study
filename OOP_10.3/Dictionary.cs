using System.Threading.Channels;

namespace OOP_10._3
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] key = new TKey[7];
        private TValue[] value = new TValue[7];

        public MyDictionary()
        {
            //я не знаю что сюда писать
        }
       
    
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + value[i];
                }
    
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
    
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                {
                    return "Попытка обращения за пределы массива";
                }
            }
        }
    }

    
}

/*public class MyDictionary<TKey, TValue>
    {
        private TKey[] key = new TKey[5];
        private TValue[] value = new TValue[5];
    
        public MyDictionary()
        {
            key[0] = "книга";
            value[0] = "book";
            key[1] = "ручка";
            value[1] = "pen";
            key[2] = "солнце";
            value[2] = "sun";
            key[3] = "яблоко";
            value[3] = "apple";
            key[4] = "стол";
            value[4] = "table";
        }
    
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + value[i];
                }
    
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
    
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                {
                    return "Попытка обращения за пределы массива";
                }
            }
        }
    }
    */
