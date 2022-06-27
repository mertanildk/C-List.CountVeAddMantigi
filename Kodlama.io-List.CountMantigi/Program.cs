using System;


namespace Kodlama.io_List.CountMantigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count);
        }
    }
    class MyList<T>
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;

        }
        

        public int Count
        {
            get { return array.Length; }
           
        }


    }
}
