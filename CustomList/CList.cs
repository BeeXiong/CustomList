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

        public void Add(T value)
        {
            bool isTooSmall;
            isTooSmall = checkArrayCapacity();
            array = increaseArrayCapacity(isTooSmall);
            insertValue(value);

        }
        public void insertValue(T value)
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
        public bool checkArrayCapacity()
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
        public T[] increaseArrayCapacity(bool response)
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


    }

}
