using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Models
{
   public class GenericList <T>
    {
        private T[] data;
        private int lastPosition = 0;

        public GenericList(int initialCapacity)
        {
            this.data = new T[initialCapacity];
        }

        public void Add(T element)
        {
            if (this.lastPosition == this.data.Length)
            {
                this.AutoGrow();
            }
            this.data[lastPosition] = element;
            this.lastPosition++;
        }

        public T this[int index]
        {
            get {
                if (index > this.lastPosition - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index];
                }
            set { this.data[index] = value; }
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.lastPosition && i < this.data.Length - 2; i++)
            {
                this.data[i] = this.data[i + 1]; 
            }
            this.lastPosition--;
            this.data[lastPosition] = default(T);
        }

        public void Insert (int index, T element)
        {
            if (this.lastPosition == this.data.Length)
            {
                this.AutoGrow();
            }
            for (int i = index; i >= this.lastPosition; i--)
            {
                this.data[i] = this.data[i - 1];

            }
            this.data[index] = element;
            this.lastPosition++;
        }

        public void Clear()
        {
            this.data = new T[this.data.Length];
        }

        public T Min()
        {
            return this.data.Min();
        }

        public T Max()
        {
            return this.data.Max();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.lastPosition; i++)
            {
                sb.Append(this.data[i]);
                if (i < this.lastPosition - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        private void AutoGrow()
        {
            var newDate = new T[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newDate[i] = this.data[i];
            }
            this.data = newDate;
        }
    }
}
