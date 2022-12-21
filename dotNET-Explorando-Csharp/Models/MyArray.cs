using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class MyArray<T>
    {
        private static int capacity = 10;
        private int counter = 0;
        private T[] array = new T[10];


        public void AddElementArray(T element)
        {
            if (counter + 1 < 11)
            {
                array[counter] = element;
            }
            counter++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}