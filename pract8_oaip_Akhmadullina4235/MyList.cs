using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8_oaip_Akhmadullina4235
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] items;
        private int count;

        public int Count => count;

        public MyList(int capacity = 4)
        {
            items = new T[capacity];
            count = 0;
        }

        private void EnsureCapacity()
        {
            if (count >= items.Length)
            {
                T[] newArray = new T[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                    newArray[i] = items[i];

                items = newArray;
            }
        }

        public void Add(T item) //dobav
        {
            EnsureCapacity();
            items[count] = item;
            count++;
        }

        public void Insert(int index, T item) //vstav v opred poz
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            EnsureCapacity();

            for (int i = count; i > index; i--)
                items[i] = items[i - 1];

            items[index] = item;
            count++;
        }

        public void AddRange(MyList<T> otherList) //spiso dryg
        {
            foreach (var item in otherList)
                Add(item);
        }

        public void InsertRange(int index, MyList<T> otherList)
        {
            foreach (var item in otherList)
            {
                Insert(index, item);
                index++;
            }
        }

        public void RemoveAt(int index) //delete
        {
            if (index < 0 || index >= count)
            {
                return;
            }
              
            for (int i = index; i < count - 1; i++)
                items[i] = items[i + 1];

            count--;
        }

        public void RemoveLast()
        {
            if (count > 0)
                count--;
        }

        public void RemoveRange(int firstIndex, int secondIndex) //del diapozon
        {
            for (int i = secondIndex; i >= firstIndex; i--)
                RemoveAt(i);
        }

        public void Clear()
        {
            count = 0;
        }

        public T Get(int index) //vozvr
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            return items[index];
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
                if (match(items[i]))
                    return items[i];

            return default(T);
        }

        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++) // s dva konza
            {
                T temp = items[i];
                items[i] = items[count - i - 1];
                items[count - i - 1] = temp;
            }
        }

        public void Sort(int index)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    int result = items[j].ToString().CompareTo(items[j + 1].ToString());

                    if ((index == 1 && result > 0) || (index == 0 && result < 0))
                    {
                        T temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }

        public void Distinct() //dele dybl
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (items[i].Equals(items[j]))
                    {
                        RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return items[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}   