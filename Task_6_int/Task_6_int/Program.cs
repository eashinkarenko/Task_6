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
            bool ok = false;
            int N = 0;
            while (ok == false)
            {
                try
                {
                    N = Convert.ToInt16(Console.ReadLine());
                    if (N>3)ok = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод...");
                }
            }
            
            // массив для хранения элементов
            int[] MasInt = new int[N];
            ok = false;
            Console.WriteLine("Введите последовательно три первых элемента через -Enter");
            // проверка на ввод первых трёх элементов
            while (ok == false)
            {
                try
                {
                    MasInt[0] = Convert.ToInt16(Console.ReadLine());
                    MasInt[1] = Convert.ToInt16(Console.ReadLine());
                    MasInt[2] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();
                    ok = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод...");
                }
            }

            int Counter = 3;// количество созданных элементов
            int Sum = 0;// сумма элментов последовательности

            // Алгоритм 
            for (int i = 3; i < N ; i++)
            {                
                    for (int j = 0; j < i+1; j++)
                    {
                        Sum += MasInt[j];
                    }

                    if (Sum % 3 == 0)
                    {
                    // элементы кратны трём (их сумма)
                    //printElem
                    Console.WriteLine("Процесс остановлен, так как нашлись первые " + Counter + " элемента(ов), сумма которых кратна Трём");
                    PrintElem(Counter, MasInt);
                    ok = false;
                    break;          
                    }
                    Sum = 0;

                MasInt[i] = 2 * Math.Abs(MasInt[i - 1] - MasInt[i - 2]) + MasInt[i - 3];
                Counter++;
            }

            // просчитаны все элементы последовательности
            if (ok)
            {
                Console.WriteLine("Все элементы просчитаны");
                PrintElem(N, MasInt);
            }
            Console.ReadLine();
        }
    }
}
