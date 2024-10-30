﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i += 1)
        {
            answer += 1 / i;
            
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1.0);
            Console.WriteLine(answer);
        }
        answer = Math.Round(answer, 2);
        // end

        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double n = 1;
        if (x == 0) return 0;
        // code here
        for (double i = 1; i <= 9; i += 1)
        {
            answer += Math.Cos(i * x) / n;
            n *= x;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i += 1)
        {
            answer = answer + (p + h * i) * (p + h * i);
        }
        // end
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        const double xh = -4, xk = 4, h = 0.5;
        answer = 0.5 * x * x - 7 * x;
        x = x + h;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int a = 1; a <= 6; a++)
            f = f * a;
        answer = f;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for(int a = 1; a <= 6; a++)
        {
            f = f * a;
            answer += f;
        }   
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double f = 1;
        double c = 1;
        double d = 1;
        // code here;
        for (int a = 1; a <= 6; a += 1)
        {
            f = a * f;
            c = c * (-1);
            d = d * 5;
            answer = answer + c * d / f;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 1; i <= 7; i++)
        {
            answer = answer * 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
        Console.WriteLine();
        // code here
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        for(int i = 0; i <= 10; i++)
        {
            if (y == 0)
            {
                answer = 0;
                break;
            }
            answer = answer + 1 / y;
            y *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1, n2 = 1, n3;
        Console.Write($"{n1} {n2} ");
        for (int i = 3; i <= 8; i++)
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;


        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int a1 = 1;
        int b1 = 1;
        int a2 = 2;
        int b2 = 1;

        for (int i = 3; i <= 5; i++)
        {
            int an = a1 + a2;
            int bn = b1 + b2;

            a1 = a2;
            b1 = b2;
            a2 = an;
            b2 = bn;
        }
        answer = (double)a2 / b2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        BigInteger zerno = 0;
        BigInteger nakletke = 1;
        for(int i = 0; i < 64; i++)
        {
            zerno= zerno + nakletke;
            nakletke *= 2;
        }
        BigInteger mantissa = zerno / 15;
        answer = (double)mantissa;

        while (answer >= 10.0)
        {
            answer = answer / 10.0;
            power++;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int count = 10;
        for (int i = 3; i <= x; i += 3)
        {
            count *= 2;
        }
        answer = count;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        int k = 1;
        while (Math.Abs(Math.Cos(k * x) / Math.Pow(k, 2)) >= 0.0001)
        {
            s += Math.Cos(k * x) / Math.Pow(k, 2);
            k++;
        }
        Console.WriteLine(s);
        answer = s;
        //answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;
        int n = 0;
        double sum = 0;


        if (p == 0)
        {
            Console.WriteLine(answer);
            return answer;
        }

        if (((a + h) < 0) & (h < 0))
        {
            Console.WriteLine(answer);
            return answer;

        }
        else
        {
            while (sum <= p)
            {
                sum += a + n * h;
                n++;
            }
            answer = n - 1;
            Console.WriteLine(answer);
            return answer;
        }

        // end

    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {

        (int, int) answer = (0, 0);
        int quotient = 0;
        int remainder = N;

        if (M == 0)
        {
            Console.WriteLine(answer);
            return answer;
        }
        while (remainder >= M)
        {
            remainder -= M;
            quotient++;
        }
        answer = (quotient, remainder);
        Console.WriteLine(answer);
        return answer;

        // end
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        double probeshal = 10;
        int dny = 0;
        double sam = 0;
        for (double nowden = 0; dny <= 6; dny++)
        {
            nowden = (probeshal * 10) / 100 + probeshal;
            sam += probeshal;
            probeshal = nowden;
        }
        sam = Math.Round(sam, 2);
        answer = sam;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double sam = 0;
        double probeshal = 10;
        int dny = 0;
        double nowden = 0;
        while (sam < 100)
        {
            nowden = (probeshal * 10) / 100 + probeshal;
            sam += probeshal;
            probeshal = nowden;
            dny++;
        }
        Console.WriteLine(dny);
        answer = dny;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double probeshal = 10;
        double newday = 0;
        int dny = 0;
        for (; newday <= 20; dny++)
        {
            newday = (probeshal * 10) / 100 + probeshal;
            probeshal = newday;
            Console.WriteLine(newday);
        }
        Console.WriteLine(dny);
        answer = dny;
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;
        // code here;

        double digit = 0;
        double L = 0.1;
        double Da = Math.Pow(10, -10);

        digit = Math.Log(L / Da, 2);
        digit = Math.Round(digit, 0);
        answer = (int)digit;
        Console.WriteLine(answer);
        return answer;
        // end
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here
        double i = 1;

        double perv = 1;

        double minus = -1;

        double temp = x * x;

        while (Math.Abs(perv) > 0.0001)
        {
            minus = -minus;
            perv = (minus * x * temp) / ((4 * i * i) - 1);
            temp *= x * x;
            i += 1;
            if (Math.Abs(perv) < 0.0001)
            {
                break;
            }
            S += perv;
        }
        y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
        Console.WriteLine($"s = {S}, y = {y}");
        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here
        
        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}