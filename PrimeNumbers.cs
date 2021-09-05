using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class PrimeNumbers
    {
    
        public int i,j;
        public bool flag;

        public void DisplayPrimNumbers(int min, int max)
        {
            for( i = min;  i <= max;  i ++)
            {
                if(i ==1 || i == 0)
                
                    continue;
                
                flag = true;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)

                    Console.WriteLine(i);
            }
           
            
            
        }

    }
}
