using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sumPurchase = { 100, 400, 500, 300, 500, 50, 300 };
            int sumMoney = 0;
            Queue<int> purchase = new Queue<int>();

            for (int i=0;i<sumPurchase.Length;i++)
            {
                purchase.Enqueue(sumPurchase[i]);
            }

            while (purchase.Count > 0)
            {
                Console.Clear();
                sumMoney += purchase.Peek();
                Console.WriteLine("Клиент обслужен. Вы получили " + purchase.Peek() + " рублей. Общая сумма - " + sumMoney);
                purchase.Dequeue();
                Console.ReadKey();
            }

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}