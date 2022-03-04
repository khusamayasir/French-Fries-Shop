using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project
{
    public class Queue
    {
        public string[] record = new string[5];
        public int i = 0;
        public int front = 0;
        public int rear = 0;
        public int max = 5;

        public int insertQ(string noplate)
        {
            if (rear == max - 1)
            {
                return rear;
            }
            else
            {
                record[rear] = noplate;
                ++rear;
                return rear;
            }
        }

        public int dequeue()
        {
            if (front == rear)
            {
                return front;
            }
            else
            {
                return front;
            }
        }

        public string printQueue()
        {
            string text;

            if (front == rear)
            {
                text = "Queue is Empty";
                return text;
            }
            else
            {
                text = record[front];
                return text;
            }
        }
    }
}
