using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_int
{
    class Program
    {
        static void PrintElem(int N, int [] mas)
        {
            for (int i = 0; i < N ; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Программа выстраивает последовательность чисел по формуле из задания
по трём первым элементам.
Сколько элементов в последовательности нужно постороить?");
            // сколько элементов должно быть в последовательности, плюс три заданные элементы
            int N = Convert.ToInt16(Console.ReadLine());
            // массив для хранения элементов
            int[] MasInt = new int[N];
            Console.WriteLine("Введите последовательно три первых элемента через -Enter");
            MasInt[0] = Convert.ToInt16(Console.ReadLine());
            MasInt[1] = Convert.ToInt16(Console.ReadLine());
            MasInt[2] = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            int Counter = 3;
            int Sum = 0;
            bool ok = true;
            for (int i = 3; i < N ; i++)
            {                
                    

                    for (int j = 0; j < i+1; j++)
                    {
                        Sum += MasInt[j];
                    }

                    if (Sum % 3 == 0)
                    {

                    //printElem
                    Console.WriteLine("Процесс остановлен, так как нашлись первые " + Counter + " элемента(ов), кратных Трём");
                    PrintElem(Counter, MasInt);
                    ok = false;
                    break;          
                    }
                    Sum = 0;

                MasInt[i] = 2 * Math.Abs(MasInt[i - 1] - MasInt[i - 2]) + MasInt[i - 3];
                Counter++;


            }
            if (ok)
            {
                Console.WriteLine("Все элементы просчитаны");
                PrintElem(N, MasInt);
            }
            Console.ReadLine();
        }
    }
}
