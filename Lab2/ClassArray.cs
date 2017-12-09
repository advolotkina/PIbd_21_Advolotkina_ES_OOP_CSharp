
using System.Collections.Generic;

namespace ULSTU_OOP_SCharp_Lab3
{
    class ClassArray<T> where T : IAnimal
    {
        private Dictionary<int, T> places;
        private T defaultValue;

        private int maxCount;

        public ClassArray(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = sizes;
        }

        public static int operator +(ClassArray<T> p, T fish)
        {
            if(p.places.Count == p.maxCount)
            {
                return -1;
            }
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, fish);
                    return i;
                }
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
            return p.defaultValue;
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
