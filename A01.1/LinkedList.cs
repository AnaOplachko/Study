using System.Collections;

namespace A01._1;

public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> _head;
        public LinkedListNode<T> _tail;

        public int Count
        {
            get;
            private set;
        }

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public void RemoveEveryFive()
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            int i = 0;

            if (Count >= 5) //count не уменьшается!!!!!!!!!!!!!!!!!!!!!!!!!!!
            {
                while (current != null)
                {
                    if ((i + 1) % 5 == 0)
                    {
                        Console.WriteLine(current.Value);
                        previous.Next = current.Next;
                        Count--;
                    }

                    previous = current;
                    current = current.Next;
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Less then 5 elements in list");
            }
                
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
                    }

                    else
                    {
                        _head = _head.Next;

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

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

    }