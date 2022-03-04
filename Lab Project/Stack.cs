using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project
{
    public class Stack
    {
        public int[] stack = new int[4];
        public int[] stack2 = new int[4];
        public int n = -1, n1 = -1;
        public int element;
        public void Push(int value)
        {
            if (n >= 5)
            {
            }
            else
            {
                n++;
                stack[n] = value;
            }
        }
        public void Pop()
        {
            if (n <= -1)
            {
            }
            else
            {
                n--;
            }
        }

        public void Push1(int value1)
        {
            if (n1 >= 5)
            {
            }
            else
            {
                n1++;
                stack2[n1] = value1;
            }
        }

        public void Pop1()
        {
            if (n1 <= -1)
            {
            }
            else
            {
                n1--;
            }
        }

        public void selectionsort()
        {
            int position, j, swap, i;
            for (i = 0; i <= n1; i++)
            {
                position = i;
                for (j = i + 1; j <= n1; j++)
                {
                    if (stack2[position] > stack2[j])
                        position = j;
                }
                if (position != i)
                {
                    swap = stack2[i];
                    stack2[i] = stack2[position];
                    stack2[position] = swap;
                }
            }
        }
    }
}
