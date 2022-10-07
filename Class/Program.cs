using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Do1()
            {
                Console.Write("Введите 2 числа: ");
                int[] a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Console.WriteLine("{0} - Максимальный элемент", a.Max());
            }

    
            static void Do2(ref int A, ref int B)
            {
                (B,A) = (A,B);
            }
            //int a = 1;
            //int b = 2;
            //Do2(ref a, ref b;
            static void Do3()
            {
                static int Factorial(int a)
                {
                    if (a == 1) return 1;
                    return a * Factorial(a - 1);
                }
                int num = Convert.ToInt32(Console.ReadLine());
                int m = checked(Factorial(num));
                if (m != 0)                
                    Console.WriteLine("true");               
                else               
                    Console.WriteLine("false");
                
            }
            static int Divider2(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)                   
                        a = a - b;           
                    else                   
                        b = b - a;               
                }
                return a;
            }
            static void Divider3(int a, int b, int c)
            {
                int i;
                bool flag = true;
                for (i = 2; i < 10000; i++)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        flag = true;
                        break;
                    }
                    else
                        continue;
                }
                Console.WriteLine(flag ? $"Меньший делитель: {i}" : $"Число простое") ;
            }
            static void Do5()
            {
                Console.Write("Введите 3 числа: ");
                int[] a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Console.WriteLine(Divider2(a[0], a[1]));
                Divider3(a[0], a[1], a[2]);
            }
            static int Fibonacci(int n)
            {
                if (n == 0 || n == 1) return n;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            static int FastFibonacci(int k)
            {
                int num1 = 1;
                int num2 = 1;
                int num3 = 2;
                for(int i = 1 ; i<k;i++)
                {
                    num1 = num2;
                    int temp = num2;
                    num2 = num3;
                    num3 = num3 + temp;
                }
                return num1;
            }
        }
    }
}