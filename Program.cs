﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Домашка
{
    internal class Program
    {
        /*
         определение метода:
        public static ТипВозвращаемоегоЗначения ИмяМетода(список параметров в виде перечисления объявлений переменных через запятую)
        {
            //тело метода
            //если ТипВозвращаемоегоЗначения не void, то обязательно должен быть return результат;
        }
        public static int GetMax(int[] array)
         
           вызов метода:
           ИмяМетода(); - если нет параметрво
           ИмяМетода(значения без указания типа, через запятую);
           если ТипВозвращаемоегоЗначения не void, то можем присвоить вызов метода какой-то переменной
           int a = GetMax(какой то массив);
           int [] array = new int[5]; 
           for(int i = 0; i < 5; i++){ заполняем массив }
           
            int bb = GetMax(array);                                                                           :)

         */
        public static int[] Array54(int[] array)
        {
            int[] result = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result[count] = array[i];
                    count++;
                }
            }
            int[] B = new int[count];
            Array.Copy(result, B, count);
            return B;

        }



        public static int Array51(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int swap = a[i];
                a[i] = b[i];
                b[i] = swap;
            }
            return a.Length;
            
        }



        public static int Array20(int[] a, int k, int l)
        {
            int count = 0;

            for (int i = k; i <= l; i++)
            {
                count+= a[i];
            }
            return count;
        }


        public static int Array19(int[] a)
        {
            

            for (int i = a.Length-1; i > 0; i--)
            {
                
                if (a[0] < a[i] && a[i] < a[a.Length - 1])
                    return i;
                
            }
            return 0;
        }

        public static int Array7(int[] a)
        {
            var temp = 0;

            for (var i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[a.Length-i-1];
                a[a.Length-i-1] = temp;
     
            }
            
            return temp;
        }


        public static int Array2(int[] a)
        {
            int count = 0;
            a[0] = 1;
            a[1] = 1;

            for (int i = 2; i < a.Length; i++)
            {
               
                a[i] = a[i-1] + a[i-2];  
                count = a[i];
                
            }
            return count;
        }

        public static int Array1(int[] a)
        {
            int count = 0;
          
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 2 * i + 1;
                count = a[i];
            }
            return count;
        }



        //MinMax2
        public static int RectangleMin(int N, int[] a, int[] b)
        {
            int area = a[0] * b[0];
            for (int i = 0; i < N; i++)
            {
                int minarea = a[i] * b[i];
                if (minarea < area)
                    area = minarea;
            }
            return area;
        }
       

        //MinMax4
        public static int GetMin(int index, int[] a)
        {
           
            int minindex  = 0;
            int minvalue = a[0];
            

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minvalue)
                {
                    minindex = i;
                    minvalue = a[i];
                    
                }
  
            }
            return minindex;
            
 
        }
        static void Proc1()
        {
            float A, B;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("A: ");
                A = float.Parse(Console.ReadLine());
                PowerA3(A, out B);
                Console.Write("B: ");
                Console.WriteLine(B);
            }
        }

        static void PowerA3(float A, out float B)
        {
            B = (float)Math.Pow(A, 3);
        }
    

        static void Proc2()
        {
            float A;
            float B;
            float C;
            float D;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("A: ");
                A = float.Parse(Console.ReadLine());
                PowerA3(A, out B, out C, out D);
                Console.Write("B: ");
                Console.WriteLine(B);
                Console.Write("C: ");
                Console.WriteLine(C);
                Console.Write("D: ");
                Console.WriteLine(D);
            }
        }

        static void PowerA3(float A, out float B, out float C, out float D)
        {
            B = (float)Math.Pow(A, 2);
            C = (float)Math.Pow(A, 3);
            D = (float)Math.Pow(A, 4);
        }
    


        static void plusnums()
        {
            double a;
            double b;
            double c;
            double d = 0;
            Console.WriteLine("Введите числа");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            string tmpB = Console.ReadLine();
            b = double.Parse(tmpB);
            string tmpC = Console.ReadLine();
            c = double.Parse(tmpC);
            for (double i = 0; i <= d; i++)

                if (a > 0)
                {
                    Console.WriteLine($"№1 {a}");
                }
                else if (b > 0)
                {
                    Console.WriteLine($"№1 {b}");
                }
                else if (c > 0)
                {
                    Console.WriteLine($"№1 {c}");
                }


                else
                {
                    Console.WriteLine($"-1");
                }
        }

        static void srarif()
        {
            double a;
            double b;
            double c;
            double d;
            double e;
            double f = 0;
            Console.WriteLine("Введите числа");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            string tmpB = Console.ReadLine();
            b = double.Parse(tmpB);
            string tmpC = Console.ReadLine();
            c = double.Parse(tmpC);
            string tmpD = Console.ReadLine();
            d = double.Parse(tmpD);
            string tmpE = Console.ReadLine();
            e = double.Parse(tmpE);
            for (double i = 0; i <= f; i++)
            {
                f = (a + b + c + d + e) / 5;
                Console.WriteLine($"Среднее арифметическое = {f}");
            }

        }

        static void for12()
        {
            double a;
            double b = 1;
            Console.WriteLine("Введите число");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            for (double i = 1; i <= a; i++)
            {
                b = b * (1 + 0.1 * i);
                Console.WriteLine($"Сумма равна = {b}");
            }
        }
        static void for11()
        {
            double a;
            double b = 0;
            Console.WriteLine("Введите число");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            for (double i = 0; i <= a; i++)
            {
                b = (a + i) * (a + i);
                Console.WriteLine($"Сумма равна = {b}");
            }



        }
        static void Факториал()
        {
            double a;
            double s = 1;


            Console.WriteLine("введите значение а");
            string w = Console.ReadLine();
            a = double.Parse(w);

            for (double i = 1; i <= a; i++)
            {
                s *= i;
                Console.WriteLine($"Факториал числа {a}  = {s}");
            }
        }

        static void кратностьтрём()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void for7()
        {
            double a;
            double b;
            double c = 0;
            Console.WriteLine("Введите a");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            Console.WriteLine("Введите b");
            string tmpB = Console.ReadLine();
            b = double.Parse(tmpB);
            for (double i = a; i <= b; i++)
            {
                c += i;
                Console.WriteLine($"Сумма чисел от {a} до {i} = {c}");
            }
        }

        static void for6()
        {
            double a;
            Console.WriteLine("Введите цену за кг :");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            for (double i = 1.2; i <= 2; i += 0.2)
            {
                double c = a * i;
                Console.WriteLine($"{i} кг конфет стоят {c} рублей");
            }
        }

        static void for5()
        {
            double a;
            Console.WriteLine("Введите цену за кг :");
            string tmpA = Console.ReadLine();
            a = double.Parse(tmpA);
            for (double i = 0.1; i <= 1; i += 0.1)
            {
                double c = a * i;
                Console.WriteLine($"{i} кг конфет стоят {c} рублей");
            }
        }

        static void Palindrom()
        {
            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("Введите число");
            string tmpA = Console.ReadLine();
            a = int.Parse(tmpA);
            b = a % 10;
            c = a % 100 / 10;
            d = a / 100;

            if (b == c && c == d && d == b)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Чисор не является палиндромом ");
            }
        }

        static void rubles()
        {
            int a;
            Console.WriteLine("Введите число");
            string tmpA = Console.ReadLine();
            a = int.Parse(tmpA);
            int desyatki = a / 10 % 10;
            int edinici = a % 10;
            if ((desyatki != 1) && (edinici == 1))
            {
                Console.WriteLine(a + "Рубль");

            }
            else if ((edinici >= 2 && edinici <= 4) && (desyatki != 1))
            {
                Console.WriteLine(a + "Рубля");
            }
            else
            {
                Console.WriteLine(a + "Рублей");
            }


        }


        static void If10()
        {
            int a;
            int b;
            int c = 0;
            Console.WriteLine("Введите a и b");
            string tmpA = Console.ReadLine();
            string tmpB = Console.ReadLine();
            a = int.Parse(tmpA);
            b = int.Parse(tmpB);
            if (a != b)
            {
                Console.WriteLine($"A={c = a + b},B= {c = b + a}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"A={a}, B={b}");
            }
        }

        static void If7()
        {
            int a;
            int d;
            Console.WriteLine("введи a");

            string t = Console.ReadLine();
            Console.WriteLine("ввести d");
            string g = Console.ReadLine();
            a = int.Parse(t);
            d = int.Parse(g);
            if (a > d)
            {
                Console.WriteLine($" число d {2} ");
            }
            else if (d > a)
            {
                Console.WriteLine($" число a {1}  ");
            }
            else Console.WriteLine("числа равны");
        }

        static void If4()
        {
            int a;
            int b;
            int c;
            int pos = 0;
            Console.WriteLine("Введите числа");
            string tmpA = Console.ReadLine();
            string tmpB = Console.ReadLine();
            string tmpC = Console.ReadLine();

            a = int.Parse(tmpA);
            b = int.Parse(tmpA);
            c = int.Parse(tmpA);
            if (a > 0) pos++;
            if (b > 0) pos++;
            if (c > 0) pos++;



            Console.WriteLine("Положительных= " + pos);
        }

        //if 2
        //int a;
        //Console.WriteLine("Введите число");
        //string tmpA = Console.ReadLine();
        //a = int.Parse(tmpA);
        //if (a > 0)
        //{
        //a = a + 1;
        //Console.WriteLine($"Число положительное= {a}");

        //}
        //else
        //{
        //a = a - 2;
        //Console.WriteLine($"Число отрицательное= {a}");
        //}

        //Integer 6
        //int a;
        //Console.WriteLine("Введите двузначное число");
        //string tmpA = Console.ReadLine();
        //a = int.Parse(tmpA);
        //Console.WriteLine($"Левая={a / 10}, Правая={a % 10}");  

        //Integer 2
        //double a;
        //Console.WriteLine("Введите массу в кило");
        //string tmpA = Console.ReadLine();
        //a = double.Parse(tmpA);
        //Console.WriteLine($"Полные тонны={a/1000}");

        //Beggin 10
        //double a;
        //double b;
        //Console.WriteLine("Введите A и B");
        //string tmpA = Console.ReadLine();
        //string tmpB = Console.ReadLine();
        //a = double.Parse(tmpA);
        //b = double.Parse(tmpB);
        //Console.WriteLine($"Сумма={(a * a) + (b * b)}, Разность={(a * a) - (b * b)}, Произведение={(a * a) * (b * b)}, Частное={(a * a) / (b * b)}");

        //Beggin 9
        //double a;
        //double b;
        //Console.WriteLine("Введите A и B");
        //string tmpA = Console.ReadLine();
        //string tmpB = Console.ReadLine();
        //a = double.Parse(tmpA);
        //b = double.Parse(tmpB);
        //Console.WriteLine($"Sqrt={Math.Sqrt(a * b)}");

        //Begin 7
        //double r;
        //Console.WriteLine("Введите радиус");
        //string tmpR = Console.ReadLine();
        //r = double.Parse(tmpR);
        //Console.WriteLine($"L={2 * (3.14 * r)}, S={3.14 * (r * r)}");

        //Beggin 5
        //int a;

        //Console.WriteLine("Введите длинну ребра");
        //string tmpA = Console.ReadLine();
        //a = int.Parse(tmpA);
        //Console.WriteLine($"V={a*a*a}, S={6*(a*a)}");

        static double GetRectangleArea(double a, double b)
        {
            double c = a * b;
            return c;
        }

        static void Main(string[] args)
        {
            //     Array 54
            int[] A = {1,2,3,4,5,6,7,8,9,10};
            int[] B = Array54(A);
            Console.WriteLine("Размер массива B ="+ B.Length);

            foreach (int num in B)
            
                Console.WriteLine(num);
            
            




            //      Array 51
            //int[] a = { 1, 2, 3 };
            //int[] b = { 4, 5, 6 };
            //Array51(a, b);
            //foreach (int num in a)
            //Console.WriteLine("= "+ num);
            //foreach (int num in b)
            //Console.WriteLine("="+ num);


            //     Array 20
            //int[] a = {1,2,3,4,5,6,7,8,9,10};
            //int sum = Array20(a, 3, 7);
            //Console.WriteLine("= "+ sum);



            //      Array 19
            //int[] a = {1,2,3,4,5,6,7,8,9,10};
            //int result = Array19(a);

            //Console.WriteLine("= "+ result);


            //     Array 7
            //int[] a = {1,2,3,4,5};

            //Array7(a);
            //foreach (int num in a)
            //{
            //Console.WriteLine("= "+ num);
            //}


            //      Araay2
            //Console.WriteLine("Введите значение N: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < a.Length; i++)
            //a[i] = Array2(a);
            //foreach (int num in a)
            //{
            //Console.WriteLine("= "+ num);
            //}


            //       Array1 
            //Console.WriteLine("Введите значение N: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < a.Length; i++)
            //a[i] = Array1(a);
            //foreach (int num in a)
            //{
            //Console.WriteLine("= "+ num);
            // }



            //       MinMax 4
            //int index = 0;
            //int[] a = new int[5];
            //var generator = new Random();
            //for (int i = 0; i < a.Length; i++)
            //a[i] = generator.Next(100);


            //foreach (int num in a)
            //{
            //Console.WriteLine(" = " + num);
            //}





            //int m = GetMin(index, a);





            //Console.WriteLine("Номер минимального элемента = "+m);


            //       MinMax2
            //int N = 5;
            //int[] a = new int[5];
            //int[] b = new int[5];

            //var generator = new Random();
            //for (int i = 0; i < a.Length; i++)
            //a[i] = generator.Next(100);

            //foreach (int num in a)
            //{
            //Console.WriteLine("A = "+ num);
            //}
            //for (int i = 0; i < b.Length; i++)
            //b[i] = generator.Next(100);

            //foreach (int num in b)
            //{
            //Console.WriteLine("B = "+num);
            //}
            //int m = RectangleMin(N,a,b);

            //Console.WriteLine("Минимальная площадь "+m);



            Console.ReadKey();



        }
    }
}
