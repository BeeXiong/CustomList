using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CList<T> : IEnumerable<T>
    {
        public T[] array;
        public int first { get; set; }
        public int count { get; set; }
        public int capacity { get; set; }
        public T this[int indexer]
        {
            get
            {
                if (indexer >=0 && indexer <= capacity)
                {
                    return array[indexer];
                }
                else
                {
                    throw new System.ArgumentException("Indexer position is out of the bounds of array");
                }          
            }
            set
            {
                if (indexer >= 0 && indexer <= capacity)
                {
                    array[indexer] = value;
                }
                else
                {
                    throw new System.ArgumentException("Indexer position is out of the bounds of array");
                }         
            }
        }  

        public CList()
        {        
            first = 0;
            count = 0; 
            capacity = 10;
            array = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < capacity; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        public static CList<T> operator+ (CList<T> first, CList<T> second)
        {
            for(int i = 0; i < second.count; i++)
            {
                first.Add(second[i]);
            }
            return first;
        }

        public static CList<T> operator- (CList<T> first, CList<T> second)
        {
            CList<T> subtractedList = new CList<T>();

            for (int i = 0; i < second.count; i++)
            {
                for (int j = 0; j< first.count; j++)
                {
                    if (first[j].Equals(second[i]))
                    {
                        first[j] = second[second.count - 1];
                    }
                }            
            }
            for(int i = 0; i < first.count; i++)
            {
                if(first[i].Equals(second[second.count - 1]))
                {
                    //do nothing
                }
                else
                {
                    subtractedList.Add(first[i]);
                }
            }
            return subtractedList;
        }
        
        //.Add()
        public void Add(T value)
        {
            bool isTooSmall;
            isTooSmall = CheckArrayCapacity();
            array = IncreaseArrayCapacity(isTooSmall);
            InsertValue(value);

        }
        public void InsertValue(T value)
        {
            if (first == 0)
            {
                array[0] = value;
                count++;
                first++;
            }
            else
            {
                array[count] = value;
                count++;
            }
        }
        public bool CheckArrayCapacity()
        {
            int capacityChecker;
            capacityChecker= count + 5;
            if (capacityChecker > capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T[] IncreaseArrayCapacity(bool response)
        {
            if (response == true)
            {
                int doubledCapacity;
                T[] largerArray; 
                doubledCapacity = capacity * 2;
                largerArray = new T[doubledCapacity];

                for(int i = 0; i < capacity; i++)
                {
                    largerArray[i] = array[i];
                }

                capacity = doubledCapacity;

                return largerArray;
            }
            else
            {
                return array;
            }
        }
        //.Remove
        public void Remove()
        {
            if (first == 0)
            {
                throw new System.ArgumentException("Cannot accept a Null Reference. List does not have anything in it");
            }
            else
            {
                int lastPosition;
                lastPosition = count;
                count--;
                for (int i = 0; i <= count; i++)
                {
                    array[i] = array[i + 1];
                }
                array[lastPosition] = array[lastPosition + 1];
            }
        }
        public void RemoveAt(int indexer)
        {
            if(first == 0)
            {
                throw new System.ArgumentException("Cannot accept a Null Reference. List does not have anything in it");
            }
            else if(indexer <= count)
            {
                int lastPosition;
                lastPosition = count;
                count--;
                for(int i = indexer; i <= count; i++)
                {
                    array[i] = array[i + 1];
                }
                array[lastPosition] = array[lastPosition + 1];
            }
            else
            {
                throw new System.ArgumentException("Cannot accept a Null Reference. Indexer is out of the bounds of the array");
            }
        }
        public override string ToString()
        {
            T[] parameter = this.array;
            string convertedString;
            convertedString = "";
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sBuilder.Append(parameter[i]);
                if (i < (count - 1))
                {
                    sBuilder.Append(",");
                }
            }
            convertedString = sBuilder.ToString();
            return convertedString;
        }

    }

}
