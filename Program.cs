using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84DersGenericClasses // Generics metotlar gibi classlardaki ogelerin tiplerini genellestirmye yarar.
    class Program
    {
        class Dizi<T>
        {
            int index = 0;
            T[] sayilar = new T[10];
            public void ElemanEkle(T eleman)
            {
                sayilar[index++] = eleman;
                // index++;
            }
            public T ElemanGoster(int index)
            {
                return sayilar[index];
            }
            public void ElemanlariGoster()
            {
                foreach (var item in sayilar)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            Dizi<int> intDizi = new Dizi<int>();
            intDizi.ElemanEkle(5);
            intDizi.ElemanlariGoster();
        }
    }
}
