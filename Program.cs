using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csoportosítás
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string szöveg = "éaoslvnkrhtféakjsdfhvnaédifhvnaédjvndfjvhnaédkfjhvn adkfj sd.kfjhvaékdjhvnsadékfjvn";
            Console.WriteLine("Ez itt a szöveg :" );
            Console.WriteLine(szöveg);
            Console.WriteLine("Melyik akarakterbúől mennyi van? Készíts kimutatást!");
            Dictionary<char, int> kimutatás = new Dictionary<char, int>();
            foreach  (char elem in szöveg)
            {
                if (kimutatás.ContainsKey(elem))
                {
                    kimutatás[elem] += 1;
                }
                else
                {
                    kimutatás[elem] = 1;
                }
            }
            foreach (char karakter in kimutatás.Keys)
            {
                Console.WriteLine($"{karakter}:{kimutatás[karakter]}");
            }
            */
            List<int>számlista = new List<int> { 1, 3, 4, 5, 6, 8, 9, 7, 5, 6, 8, 10, 23, 456, 78, 9, 5, 4, 5, 6, 21, 5 };
            Dictionary<string, int> szótár = new Dictionary<string, int>();
            szótár["páros"] = 0;
            szótár["páratlan"] = 0;
            foreach(int elem in számlista)
            {
                if (elem%2==0)
                {
                    szótár["páros"] += 1;
                }
                else
                {
                    szótár["páratrlan"] += 1;
                }
            }
            foreach (string kulcs in szótár.Keys)
            {
                Console.WriteLine($"{kulcs}:{szótár[kulcs]}");
            }

            Console.ReadKey();
        }
    }
}
