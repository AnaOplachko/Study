using System.Collections;
using System.Globalization;

namespace A01._2

{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> _head;
        public LinkedListNode<T> _tail;

        public int Count
        {
            get;
            private set;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
        

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            LinkedListNode<T> temp = _head;

            _head = node;

            _head.Next = temp;

            if (Count == 0)
            {
                _tail = _head;
            }
            else
            {
                temp.Previous = _head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                _head = node;
            }

            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;

            Count++;
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }

                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
            
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                _head = _head.Next;
                Count--;

                if (Count == 0)
                {
                    _tail = null;
                }

                else
                {
                    _head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }

                else
                {
                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;
                }

                Count--;
            }
        }

        public void AddAfter(T item, int index)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            LinkedListNode<T> current = _head;

            int i = 0;

            while (current != null && i != index)
            {
                i++;
                current = current.Next;
            }

            if (current == null)
                return;

            LinkedListNode<T> temp = current.Next;
            current.Next = node;
            temp.Previous = node;

            node.Next = temp;
            node.Previous = current;

            Count++;
        }

        public void Counter()
        {
            Console.WriteLine("Count = {0}", Count);
            Console.WriteLine();
        }
    }

    class Program
    {

        public static void Display(LinkedList<int> nums, string record)
        {
            Console.WriteLine(record);
            
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }
        
        static void Main()
        {
            LinkedList<int> instance = new LinkedList<int>();

            Random randomNum = new Random();
            
            var elementsQuantity = 10;
            
            for (int i = 0; i < elementsQuantity; i++)
            {
                instance.AddLast(randomNum.Next(0,100));
            }
            
            Display(instance, "add");
            instance.Counter();

            Console.WriteLine();

            var index = 5;
            var count = 0;

            do
            {
                instance.AddAfter(randomNum.Next(0,100), index - 1);
                count++;
                index++;
                
            } while (count < 3);

            Display(instance, "add after 5th");
            instance.Counter();

            instance.AddFirst(randomNum.Next(0,100));
            Display(instance, "add first");
            instance.Counter();
            
            instance.AddLast(randomNum.Next(0,100));
            Display(instance, "add last");
            instance.Counter();
            
            foreach (var item in instance)
            {
                instance.Remove(item);
            }
        
            Display(instance, "remove");
            instance.Counter();
        }
    }
}