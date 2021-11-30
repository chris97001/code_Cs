using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Firstday;
            int Firstmonth;
            try
            {
                Console.Write("1月1日星期幾(1~7):");
                Firstday = int.Parse(Console.ReadLine());
                if (Firstday < 1 || Firstday > 7)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
                Console.Write("從幾月開始(1~12):");
                Firstmonth = int.Parse(Console.ReadLine());
                if (Firstmonth < 1 || Firstmonth > 12)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            for (int thisMonth=Firstmonth; thisMonth <= 12; thisMonth++)
            {
                int Day=FirstDayofthisMonth(Firstday, thisMonth);
                Output(Day, thisMonth);
            }
            Console.ReadKey();
        }
        static void Output(int thisDay,int thisMonth)
        {
            switch (thisMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }
            Console.WriteLine("Mon Tue Wen Thu Fri Sat Sun");
            for(int i = 1; i < thisDay; i++)
            {
                Console.Write("    ");
            }
            int DayofthisMonth = 0;
            switch (thisMonth)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    DayofthisMonth = 31;
                    break;
                case 2:
                    DayofthisMonth = 28;
                    break;
                case 4: case 6: case 9: case 11:
                    DayofthisMonth = 30;
                    break;
            }
            for (int i = 1; i <= DayofthisMonth; ++i,++thisDay)
            {
                if (thisDay > 7)
                {
                    Console.WriteLine();
                    thisDay -= 7;
                }
                Console.Write("{0, 3} ", (int)i);
                if (i == DayofthisMonth)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        static int FirstDayofthisMonth(int FirstDay,int thisMonth)
        {
            int Day = FirstDay;
            for(int nowMonth = 1; nowMonth < thisMonth; nowMonth++)
            {
                switch (nowMonth)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        Day += 31;
                        break;
                    case 2:
                        Day += 28;
                        break;
                    case 4: case 6: case 9: case 11:
                        Day += 30;
                        break;
                }
            }
            Day %= 7;
            if (Day == 0) Day = 7;
            return Day;
        }
    }
}
