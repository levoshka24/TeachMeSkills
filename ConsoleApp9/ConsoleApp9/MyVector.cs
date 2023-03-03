using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ConsoleApp9
{
    class MyVector<T1> 
    {
        private static int ARRAY_SIZE = 4;
        private int count = 1;
        private T1[] Vector;

        public MyVector()
        {
            Vector = new T1[ARRAY_SIZE];
        }

        //число элементов списка
        public int NumberOfElements()
        {
            return Vector.Length;
        }

        
        //Добавить элемент по индексу
        public T1 AddToPosition(T1 elem, int index)
        {
            Resize(count + 3);

            T1 tmp1 = Vector[index];
            T1 tmp2;
            T1 tmp3;

            try { tmp2 = Vector[index + 1]; }
            catch { return default(T1); }

            try { tmp3 = Vector[index + 2]; }
            catch { return default(T1); }

            int i = index;

            for (; i != Vector.Length; i++)
            {
                Vector[i + 1] = tmp1;
                tmp1 = tmp2;
                tmp2 = tmp3;

                try { tmp3 = Vector[i + 3]; }
                catch { break; }
            }

            Vector[index] = elem;
            count++;
            return default(T1);
        }




        
        //прочитать элемент по индексу
        public T1 ReadElement(int index)
        {
            try
            {
                return Vector[index];
            }
            catch
            {
                Console.WriteLine("ERROR. Undefined index.");
                return default(T1);
            }
        }

        //записать элемент по индексу
        public T1 WriteElement(T1 elem, int index)
        {
            try
            {
                Vector[index] = elem; ;
            }
            catch
            {
                Console.WriteLine("ERROR. Undefined index.");
                return default(T1);
            }

            return default(T1);
        }

        //очистить список
        public void DeleteAllElements()
        {
            ARRAY_SIZE = 4;
            Vector = new T1[ARRAY_SIZE];
            count = 0;
        }


        //Увеличение списка.
        private void Resize(int index)
        {
            if (ARRAY_SIZE < index || ARRAY_SIZE == index)
            {
                while (ARRAY_SIZE < index || ARRAY_SIZE == index)
                {
                    NextSize();
                }

                T1[] Garbage = new T1[ARRAY_SIZE];

                for (int i = 0; i < Vector.Length; i++)
                {
                    Garbage[i] = Vector[i];
                }

                Vector = Garbage;
            }
        }

        //Увеличение размера в два раза
        private void NextSize()
        {
            if (ARRAY_SIZE == 0)
            {
                ARRAY_SIZE = 4;
            }

            ARRAY_SIZE *= 2;
        }
    }
}
