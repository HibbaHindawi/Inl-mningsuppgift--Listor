using System;
using System.Collections.Generic;

namespace Inl_mningsuppgift__Listor
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> minLista = new List<int>();
            minLista.Add(11); minLista.Add(5);
            minLista.Add(12); minLista.Add(3);
            minLista.Add(6); minLista.Add(3);

            minLista.Sort();
            SkrivUt(minLista);

            Console.WriteLine("Största tal: "+Största(minLista));
            Console.WriteLine("Minsta tal: "+Minsta(minLista));
            Console.ReadKey();
        }
        static int Minsta(List<int> listan) {
            int smallest = listan[0];
            for (int i = 1; i < listan.Count; i++){
               if(listan[i] < smallest){
                   smallest = listan[i];
               } 
            }
            return smallest;
        }
        static int Största(List<int> listan) {
            int biggest = listan[0];
            for (int i = 1; i < listan.Count; i++){
               if(listan[i] > biggest){
                   biggest = listan[i];
               } 
            }
            return biggest;
        }
        static void SkrivUt(List<int> listan) {
            foreach(int element in listan){
                Console.WriteLine(element);
            }
        }
    }
}
