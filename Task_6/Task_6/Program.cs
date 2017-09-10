using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Программа выстраивает последовательность чисел по формуле из задания
по трём первым элементам.
Сколько элементов в последовательности нужно постороить?");
            // сколько элементов должно быть в последовательности, плюс три заданные элементы
            int N = Convert.ToInt16(Console.ReadLine())+3;
            // массив для хранения элементов
            double[] MasDouble = new Double[N];
            Console.WriteLine("Введите последовательно три первых элемента через -Enter");
            MasDouble[0] = Convert.ToDouble(Console.ReadLine());
            MasDouble[1] = Convert.ToDouble(Console.ReadLine());
            MasDouble[2] = Convert.ToDouble(Console.ReadLine());

            int Counter = 0;
            double Sum = 0;
            for (int i = 3; Counter<N; i++ )
            {
                if (Counter<3)
                {
                    MasDouble[i] = 2 * Math.Abs(MasDouble[i - 1] - MasDouble[i - 2]) + MasDouble[i - 3];
                }
                else
                {
                    for (int j = 0; i< Counter+3; j++)
                    {

                    }
                }
            }

        }
    }
}
