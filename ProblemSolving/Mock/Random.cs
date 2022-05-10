using System;

namespace HackerRank.Mock
{
    public class RandomPicker<T>
    {
        // represents the current number that you are allowed to pick from
        int _count;
        // array of elements to pick from
        T[] _elements;
        Random random;
        public RandomPicker(T[] elements)
        {
            _elements = elements;
            _count = elements.Length;
            random = new Random();
        }
        public T Pick()
        {
            if (_count == 0) throw new Exception("No Elements to Pick from");
            // generate a random number from 0 till count
            int index = random.Next(0, _count);
            T picked = _elements[index];
            Swap(index, _count - 1);
            _count--;
            return picked;
        }

        private void Swap(int index1, int index2)
        {
            var temp = _elements[index1];
            _elements[index1] = _elements[index2];
            _elements[index2] = temp;
        }
    }
    public class solution
    {
        /*
        public static void Main(string[] args)
        {
            var randomPicker = new RandomPicker<int>(new int[] {4, 4, 2, 4, 2, 5, 7, 3});
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(randomPicker.Pick());
            }

        }
        */

    }
}


