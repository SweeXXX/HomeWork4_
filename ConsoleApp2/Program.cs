using Home;
using static Home.Library;
using System;

 
namespace Home
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Do5();
            static void Exit(string num)
            {
                if (num.ToLower().Equals("exit") || num.ToLower().Equals("закрыть"))
                {
                    Environment.Exit(0);
                }
            }
            static void Do5()
            {
                try
                {
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0 || num > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(3000);
                        Console.WriteLine("Wrong enter!");
                        Console.ForegroundColor = ConsoleColor.White;
                        string a = Console.ReadLine().ToLower();
                        Exit(a);
                    }
                    else
                    {
                        switch (num)
                        {
                            case (0):
                                Console.WriteLine("######\n#    #\n#    #\n#    #\n######");
                                break;
                            case (1):
                                Console.WriteLine("  #   \n# #   \n  #   \n  #   \n##### ");
                                break;
                            case (2):
                                Console.WriteLine(" #### \n#    #\n   #  \n#     \n######");
                                break;
                            case (3):
                                Console.WriteLine(" #### \n#    #\n   # #\n#    #\n #### ");
                                break;
                            case (4):
                                Console.WriteLine("#    #\n#    #\n######\n     #\n     #");
                                break;
                            case (5):
                                Console.WriteLine("######\n#     \n# ## #\n     #\n######");
                                break;
                            case (6):
                                Console.WriteLine("######\n#     \n# # ##\n#    #\n######");
                                break;
                            case (7):
                                Console.WriteLine("#######\n      #\n    #  \n  #    \n#      ");
                                break;
                            case (8):
                                Console.WriteLine("######\n#    #\n######\n#    #\n######");
                                break;
                            case (9):
                                Console.WriteLine("######\n#    #\n######\n     #\n######");
                                break;
                        }
                        string a = Console.ReadLine().ToLower();
                        Exit(a);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            static void Do3()
            {
                int n=20;
                int[] A = new int[n];
                void Generate(int n, int[] A)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        A[i] = (int)rnd.Next(5, 70);
                    }
                }
                Generate(n, A);
                //A = new int[] { 1,2,3,4,6,5,3,2,1};
                Console.WriteLine(String.Join(" ", A));
                Console.Write("Введите два числа, которые нужно поменять местами ");
                int[] nums = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();
                int i1 = Array.IndexOf(A, nums[0]);
                int i2 = Array.IndexOf(A, nums[1]);
                (A[i1], A[i2]) = (A[i2], A[i1]);
                Console.WriteLine(String.Join(" ", A));
            }
            static void KvUrav(double a, double b, double c)  //1
            {
                /* a,b и c это коэфиценты квадратного уравнения. 
                 * Метод считает корни и печатает их, если дискриминант неотрицательный. 
                 * Если дискриминант отрицательный, то будет исключение.
                 * Если а == 0, то метод посчитает корни как в линейном уравнение.   */
                double des = (b * b) - 4 * a * c;
                if (a != 0)
                {
                    if (des > 0)
                    {
                        Console.WriteLine($"x1 = {(-b + Math.Sqrt(des)) / 2 * a}");
                        Console.WriteLine($"x2 = {(-b - Math.Sqrt(des)) / 2 * a}");
                    }
                    else if (des == 0)
                    {
                        Console.WriteLine($"x = {-b / 2}");
                    }
                    else
                    {
                        Console.WriteLine("Дискриминант отрицательный.");
                        Console.WriteLine("Комплексные корни не умею считать :(");
                        Console.WriteLine("Сам Прогай Такое((");
                    }
                }
                else
                    Console.WriteLine($"x = {-c / b}");// с кайфом;
            }
            static double FindSum(out double srznac, out double proiz, params double[] mas)//4
            {
                double sum = 0;
                double one = 1;
                foreach (var num in mas)
                {
                    sum += num;
                    one *= num;
                }
                proiz = one;
                srznac = sum / mas.Length;
                return sum;
            }
            static void Do2()
            { 
                int partition(int[] array, int start, int end)//7
                {
                    int marker = start;
                    for (int i = start; i <= end; i++)
                    {
                        if (array[i] <= array[end])
                        {
                            //int temp = array[marker]; // swap
                            //array[marker] = array[i];
                            //array[i] = temp;
                            (array[marker], array[i]) = (array[i], array[marker]);
                            marker += 1;
                        }
                    }
                    return marker - 1;
                }
                void quicksort(int[] array, int start, int end)//7
                {
                    if (start >= end)
                    {
                        return;
                    }
                    int pivot = partition(array, start, end);
                    quicksort(array, start, pivot - 1);
                    quicksort(array, pivot + 1, end);
                }
            }
            static void Do1()
            {
                static int GetCountOfMat(Library.GrandFather grandFather, params string[] words)
                {
                    int count = 0;
                    for (int i = 0; i < grandFather.masBr.Length; i++)
                    {
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (grandFather.masBr[i] == words[j])
                            {
                                count++;
                            }
                        }
                    }
                    grandFather.CountOfBruise = count;
                    return grandFather.CountOfBruise;
                }
                GrandFather Oleg = new GrandFather("Oleg", LevelOfGrouchiness.midle, new string[] { "Проститутки!", "Наркоманы", "Гомосеки", "Чудище кучерявое", "Плоскодонка!!!" });
                GrandFather Nikita = new GrandFather("Nikita", LevelOfGrouchiness.high, new string[] { "Плоскодонка!!!", "Наркоманы", "Гомосеки" });
                GrandFather Clown = new GrandFather("Clown", LevelOfGrouchiness.midle, new string[] { "Проститутки!", "Мразь", "Пидорас", "1000-7?" });
                GrandFather Vadim = new GrandFather("Vadim", LevelOfGrouchiness.low, new string[] { "Уйди с моего лайна, чудище", "1000-7?", "Блядина!", "Ты в муте клоун", "Баляяя" });
                GrandFather Vitaly = new GrandFather("Vitaly", LevelOfGrouchiness.midle, new string[] { "Баляяя", "Ты в муте клоун" });
                Console.WriteLine(GetCountOfMat(Oleg, "Проститутки!", "Наркоманы"));

            }
        }
    }
}