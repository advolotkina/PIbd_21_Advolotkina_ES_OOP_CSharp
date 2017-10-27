
namespace ULSTU_OOP_SCharp_Lab3
{
    class ClassArray<T> where T : IAnimal
    {
        private T[] places;
        private T defaultValue;

        public ClassArray(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new T[sizes];
            for(int i = 0; i < places.Length; i++)
            {
                places[i] = defaultValue;
            }
        }

        public static int operator +(ClassArray<T> p, T fish)
        {
            for(int i = 0; i < p.places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places[i] = fish;
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T fish = p.places[index];
                p.places[index] = p.defaultValue;
                return fish;
            }
            return p.defaultValue;
        }

        private bool CheckFreePlace(int index)
        {
            if(index < 0 || index > places.Length)
            {
                return false;
            }
            if(places[index]== null)
            {
                return true;
            }
            if (places[index].Equals(defaultValue))
            {
                return true;
            }
            return false;
        }

        public T getObject( int ind)
        {
            if(ind > -1 && ind < places.Length)
            {
                return places[ind];
            }
            return defaultValue;
        }
    }
}
