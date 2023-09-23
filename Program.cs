using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка
{
    internal class Program
    {


        //static void plusnums()
        //{
            //double a;
            //double b;
            //double c;
            //double d = 0;
            //Console.WriteLine("Введите числа");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //string tmpB = Console.ReadLine();
            //b = double.Parse(tmpB);
            //string tmpC = Console.ReadLine();
            //c = double.Parse(tmpC);
            //for (double i = 0; i <= d; i++)

                //if (a > 0)
                //{
                    //Console.WriteLine($"№1 {a}");
                //}
            //else if  (b > 0)
            //{
                //Console.WriteLine($"№1 {b}");
            //}
            //else if  (c > 0)
            //{
                //Console.WriteLine($"№1 {c}");
            //}


            //else
                //{
                    //Console.WriteLine($"-1");
                //}
        //}

          //static void srarif()
        //{
            //double a;
            //double b;
            //double c;
            //double d;
            //double e;
            //double f = 0;
            //Console.WriteLine("Введите числа");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //string tmpB = Console.ReadLine();
            //b = double.Parse(tmpB);
            //string tmpC = Console.ReadLine();
            //c = double.Parse(tmpC);
            //string tmpD = Console.ReadLine();
            //d = double.Parse(tmpD);
            //string tmpE = Console.ReadLine();
            //e = double.Parse(tmpE);
            //for (double i = 0; i <= f; i ++)
            //{
                //f = (a + b + c + d + e) / 5;
                //Console.WriteLine($"Среднее арифметическое = {f}");
            //}

        //}
        
        //static void for12()
        //{
            //double a;
            //double b = 1;
            //Console.WriteLine("Введите число");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //for (double i = 1; i <= a; i ++)
            //{
                //b = b * (1+0.1*i);
                //Console.WriteLine($"Сумма равна = {b}");
            //}
        //}
            //static void for11()
            //{
            //double a;
            //double b = 0;
            //Console.WriteLine("Введите число");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //for (double i = 0; i <= a; i++)
            //{
            //b = (a+i)*(a+i);
            //Console.WriteLine($"Сумма равна = {b}");
            //}



            //}
            //Задача на факториал 
            //static void Факториал()
            //{
            //double a;
            //double s = 1;


            //Console.WriteLine("введите значение а");
            //string w = Console.ReadLine();
            //a = double.Parse(w);

            //for (double i = 1; i <= a; i++)
            //{
            //s *= i;
            //Console.WriteLine($"Факториал числа {a}  = {s}");
            //}
            //}

            //Задача на кратность трём
            //static void кратностьтрём()
            //{
            //for (int i = 1; i <= 50; i++)
            //{
            //if (i % 3 == 0)
            //{
            //Console.WriteLine(i);
            //}
            //}
            //}

            //for7
            //static void for7()
            //{
            //double a;
            //double b;
            //double c = 0;
            //Console.WriteLine("Введите a");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //Console.WriteLine("Введите b");
            //string tmpB = Console.ReadLine();
            //b = double.Parse(tmpB);
            //for (double i = a; i <= b; i++)
            //{
            //c += i;
            //Console.WriteLine($"Сумма чисел от {a} до {i} = {c}");
            //}
            //}

            //for6
            //static void for6()
            //{
            //double a;
            //Console.WriteLine("Введите цену за кг :");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //for (double i = 1.2; i <= 2; i += 0.2)
            //{
            //double c = a * i;
            //Console.WriteLine($"{i} кг конфет стоят {c} рублей");
            //}
            //}

            //for5
            //static void for5()
            //{
            //double a;
            //Console.WriteLine("Введите цену за кг :");
            //string tmpA = Console.ReadLine();
            //a = double.Parse(tmpA);
            //for (double i = 0.1; i <= 1; i += 0.1)
            //{
            //double c = a * i;
            //Console.WriteLine($"{i} кг конфет стоят {c} рублей");
            //}
            //}

            //Задача на Палиндромы
            //static void Palindrom()
            //{
            //int a;
            //int b;
            //int c;
            //int d;

            //Console.WriteLine("Введите число");
            //string tmpA = Console.ReadLine();
            //a = int.Parse(tmpA);
            //b = a % 10;
            //c = a % 100 / 10;
            //d = a / 100;

            //if (b == c && c == d &&  d == b)
            //{
            // Console.WriteLine("Число является палиндромом");
            //}
            //else
            //{
            // Console.WriteLine("Чисор не является палиндромом ");
            //}
            //}

            //Задача на рубли
            //static void rubles()
            //{
            //int a;
            //Console.WriteLine("Введите число");
            //string tmpA = Console.ReadLine();
            //a = int.Parse(tmpA);
            //int desyatki = a / 10 % 10;
            //int edinici = a % 10;
            //if ((desyatki != 1) && (edinici == 1))
            //{
            // Console.WriteLine(a + "Рубль");

            //}
            //else if ((edinici >= 2 && edinici <= 4) && (desyatki != 1))
            //{
            //Console.WriteLine(a + "Рубля");
            //}
            //else
            //{
            //Console.WriteLine(a + "Рублей");
            //}


            //}


            //if 10
            //static void If10()
            //{
            //int a;
            //int b;
            //int c = 0;
            //Console.WriteLine("Введите a и b");
            //string tmpA = Console.ReadLine();
            //string tmpB = Console.ReadLine();
            //a = int.Parse(tmpA);
            //b = int.Parse(tmpB);
            //if (a != b)
            //{
            //Console.WriteLine($"A={c = a + b},B= {c = b + a}");
            //}
            //else
            //{
            //a = 0;
            //b = 0;
            //Console.WriteLine($"A={a}, B={b}");
            //}
            //}

            //if 7
            //static void If7()
            //{
            //int a;
            //int d;
            //Console.WriteLine("введи a");

            //string t = Console.ReadLine();
            //Console.WriteLine("ввести d");
            //string g = Console.ReadLine();
            //a = int.Parse(t);
            //d = int.Parse(g);
            //if (a > d)
            //{
            //Console.WriteLine($" число d {2} ");
            //}
            //else if (d > a)
            //{
            //Console.WriteLine($" число a {1}  ");
            //}
            //else Console.WriteLine("числа равны");
            //}

            //if 4
            //static void If4()
            //{
            //int a;
            //int b;
            //int c;
            //int pos = 0;
            //Console.WriteLine("Введите числа");
            //string tmpA = Console.ReadLine();
            //string tmpB = Console.ReadLine();
            //string tmpC = Console.ReadLine();

            //a = int.Parse(tmpA);
            //b = int.Parse(tmpA);
            //c = int.Parse(tmpA);
            //if (a > 0) pos++;
            //if (b > 0) pos++;
            //if (c > 0) pos++;



            //Console.WriteLine("Положительных= " + pos);
            //}

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
            static void Main(string[] args)
            {
                ();

                Console.ReadKey();



            }
    }
}
