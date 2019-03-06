using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardDat
{
    class Program
    {

        static void Main(string[] args)
        {
            //zadan();
            zadan2();
        }

        static void zadan()
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num.ToString().Length];
            int i = 0, s = 0;
            while (num > 0)
            {
                arr[i] = num % 10;
                num /= 10;
                s += arr[i];
                i++;
            }
            Console.WriteLine("Сумма цифр " + s);
            Console.ReadLine();
        }

        static void zadan2()
        {
            Console.WriteLine("Введите ФИО");
            string name =(Console.ReadLine());
            string surname = (Console.ReadLine());
            string fname = (Console.ReadLine());
            Console.WriteLine("здраствуй "+name+" "+surname+" "+fname);
            Console.ReadLine();
        }
    }
}
