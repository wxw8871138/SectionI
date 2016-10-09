using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionI
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = Convert.ToDouble(Console.ReadLine());
            int count1 = 0,count2=0, count3 = 0, count4 = 0, count5 = 0;
            bool needLoop = true;
            while (needLoop)
            {
                if (input > 1.0)
                {
                    input = input - 1.0;
                    count1++;
                    //break;
                }
                else if (input > 0.5)
                {
                    input = input - 0.5;
                    count2++;
                    //break;
                }
                else if (input > 0.2)
                {
                    input = input - 0.2;
                    count3++;
                    //break;
                }
                else if (input > 0.1)
                {
                    input = input - 0.1;
                    count4++;
                    //break;
                }
                else if (input >= 0.05)
                {
                    input = input - 0.05;
                    count5++;
                    //break;
                }
                else
                {
                    needLoop = false;
                }
            }
            Console.WriteLine("{0} 100-cent,{1} 50-cent,{2} 20-cent,{3} 10-cent,{4} 5-cent",count1,count2,count3,count4,count5);
        }
    }
}
