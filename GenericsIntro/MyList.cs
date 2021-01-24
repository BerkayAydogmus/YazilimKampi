using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//Type ın T si
    {
        T[] items;
        public MyList() //ctor yaz tab tab yap -constructor
        {
            items = new T[0];

        }
        public void Add(T item)
        {
            T[] tempArray = items;  //TempArray= geçiçi dizi ( temporary array in kısaltması )

            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


        }

    }


}
