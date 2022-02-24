using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programm
    {
        static void Main(string[] args)
        {
            HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
            // вернёт 12
            // потому что касса одна и все клиенты обслуживаются по очереди
            HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
            // вернёт 10
            // потому что кассы две и последние 3 человека закончат быстрее чем первый
            HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
            // Вернёт 12
        }
    }


    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
          int x, i;
          int count = 0;
          int ind = n - 1;
          int[] cassa = new int[n];

          for (i = 0; i < n; i++)
           {
            cassa[i] = customers[i];
           }

           while (true)
            {
              for (i = 0; i < n; i++)
                {
                 cassa[i] -= 1;
                 count += 1;
                 if (cassa[i] == 0)
                  {
                    if (customers.Length - 1 <= ind && cassa.Max() == 0)
                     {
                       while (count % n != 0)
                        {
                          count += 1;
                        }
                       x = count / n;
                       Console.WriteLine(x);
                        
                       return count/n;
                        
                        }
                        else if (ind < customers.Length - 1)
                        {
                            cassa[i] = customers[ind + 1];
                            ind += 1;
                        }
                    }
                }
            }
        }
    }
}
