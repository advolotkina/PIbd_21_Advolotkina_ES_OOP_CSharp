
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ULSTU_OOP_SCharp_Lab3
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private Dictionary<int, T> places;
        private T defaultValue;
        private int currentIndex;

        private int maxCount;
        
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if(currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ClassArray(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = sizes;
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for(int i = 0; i < this.places.Count; ++i)
                {
                    if(this.places[thisKeys[i]] is Shark && other.places[thisKeys[i]] is TigerShark)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is TigerShark && other.places[thisKeys[i]] is Shark)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Shark && other.places[thisKeys[i]] is Shark)
                    {
                        return (this.places[thisKeys[i]] is Shark).CompareTo(other.places[thisKeys[i]] is Shark);
                    }
                    if (this.places[thisKeys[i]] is TigerShark && other.places[thisKeys[i]] is TigerShark)
                    {
                        return (this.places[thisKeys[i]] is TigerShark).CompareTo(other.places[thisKeys[i]] is TigerShark);
                    }
                }
            }
            return 0;
        }

        public static int operator +(ClassArray<T> p, T fish)
        {
            var isShark = fish is Shark;
            if(p.places.Count == p.maxCount)
            {
                throw new OceanOverflowExcetion();
            }
            int index = p.places.Count;
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (fish.GetType() == p.places[i].GetType())
                {
                    if (isShark)
                    {
                        if((fish as Shark).Equals(p.places[i]))
                        {
                            throw new OceanAlreadyHaveException();
                        }
                    }else if((fish as TigerShark).Equals(p.places[i])){
                        throw new OceanAlreadyHaveException();
                    }
                }
            }
            if(index != p.places.Count)
            {
                p.places.Add(index, fish);
                return index;
            }
            p.places.Add(p.places.Count, fish);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T fish = p.places[index];
                p.places.Remove(index);
                return fish;
            }
            throw new OceanIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }
        
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

    }
}
