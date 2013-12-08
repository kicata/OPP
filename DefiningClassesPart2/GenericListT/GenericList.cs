using System;
using System.Linq;
using System.Text;

  //5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
  //  Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
  //  Implement methods for adding element, accessing element by index, removing element by index,
  //  inserting element at given position, clearing the list, finding element by its value and ToString().
  //  Check all input parameters to avoid accessing elements at invalid positions.
  //6.Implement auto-grow functionality: when the internal array is full, create a 
  //  new array of double size and move all elements to it.
  //7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
  //  You may need to add a generic constraints for the type T.


namespace GenericListT
{
    public class GenericList<T>
        where T:IComparable
    {
        private int capacity;   //capacity of list

        private T[] elements;
        private int count;      //count of list-used positions 

        public int Count
        {
            get{ return this.count;}
            set
            {
                if (value<0||value>this.capacity)
                {
                    throw new ArgumentException("Invalid value for GenericList count!");
                }
                this.count=value;
            }
            

        }
        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value <= 0) throw new ArgumentException("Invalid value for GenericList capacity!");
                this.capacity = value;
            }
        }
        //constructor
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            elements = new T[Capacity];
            this.Count = 0;
            
        }
        //indexator
        public T this[int index]
        {
            get
            {
                if (index >= count||index<0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        //methods
        public void Add(T element)
        {
            if (this.Count >= this.Capacity)
            {
                AutoGrow(this.Capacity);
            }
            else
            {
                this.elements[this.Count] = element;
                this.Count++;
            }
        }

        private void AutoGrow(int oldCapacity)
        {
            this.elements=this.elements.Concat(new T[oldCapacity]).ToArray();
            this.Capacity = 2 * oldCapacity;
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("The index must be a positive number!");
            }
            if (index <= this.Count)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                this.Count--;
            }
            else
            {
                throw new ArgumentException("This position is emty!");
            }
        }

        public void InsertAt(int index,T element)
        {
            if (index == this.Capacity)
            {
                AutoGrow(this.Capacity);
            }
            for (int i = this.Count; i >= index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
            this.Count++;

        }
        public int FindByValue(T element)
        {
            return Array.IndexOf(elements, element);
        }
        public void Clear()
        {
            elements = new T[elements.Length];
            count = 0;
        }
        public override string ToString()
        {
            StringBuilder textCollect = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                if (i==this.Count-1)
                {
                    textCollect.Append(this.elements[i]);
                }
                else
                {
                    textCollect.Append(this.elements[i] + ", ");
                }
            }
            return textCollect.ToString();
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            if (this.Count == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T max = this.elements[0];

                for (int i = 1; i < this.count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.elements[i]) < 0)
                    {
                        max = this.elements[i];
                    }
                }

                return max;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }
        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            if (this.Count == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T min = this.elements[0];

                for (int i = 1; i < this.Count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.elements[i]) > 0)
                    {
                        min = this.elements[i];
                    }
                }

                return min;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }
 
    }
}
