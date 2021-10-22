using System;

namespace ConsoleApplication1
{
    class CircularQueue
    {
        private int [] readonly ele;
        private int front;
        private int rear;
        private int readonly max;
        private int count;

        public CircularQueue(int size)
        {
            ele = new int[size];
            front = 0 ;
            rear  = -1;
            max   = size;
            count = 0;
        }

        public void insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = item;

                count++;
            }
        }

        public void delete()
        { 
            if(count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count==0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (i = front;j<count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);

                    i = (i+1)%max;
                    j++;
                    
                }
            }
        }
    }

    protected class Program
    {
        static void Main()
        {
            
            CircularQueue Q = new CircularQueue(5);

            Q.insert(1);
            Q.insert(2);
            Q.insert(3);
            Q.insert(4);
            Q.insert(5);

            Console.WriteLine("Items are : ");
            Q.printQueue();
            
            Q.delete();
            Q.delete();

          
        }
    }
}
