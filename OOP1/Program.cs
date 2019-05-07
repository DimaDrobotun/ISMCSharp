using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib1;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //читає з клавіатури дані і повертає масив об’єктів типу Airplane
        static Airplane ReadAirplaneArray()
        {
            int N;
            bool f;
            do
            {
                Console.Write("Введить килькисть елементив:");
                f = int.TryParse(Console.ReadLine(), out N);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введить коректне значення");
                }
            }
            while (!f);

            Airplane[] array = new Airplane[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введить мисто видправлення");
                string mistoStart = Convert.ToString(Console.ReadLine());
                array[i].SetStartCity(mistoStart);

                Console.WriteLine("Введить мисто прибуття");
                string mistoFinish = Convert.ToString(Console.ReadLine());
                array[i].SetFinishCity(mistoFinish);

                Console.WriteLine("Введить час видправленя");
                int mistoStartHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить минути видправлення");
                int mistoStartMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить число видправлення");
                int mistoStartDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить мисяць видправлення");
                int mistoStartMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить рик видправлення");
                int mistoStartYear = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введить час прибуття");
                int mistoEndHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить минути прибуття");
                int mistoEndMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить число прибуття");
                int mistoEndDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить мисяць прибуття");
                int mistoEndMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введить рик прибуття");
                int mistoEndYear = Convert.ToInt32(Console.ReadLine());

                Date NewStartDate = new Date(mistoStartHour, mistoStartMin, mistoStartDay, mistoStartMonth, mistoStartYear);
                array[i].SetStartDate(NewStartDate);

                Date NewEndDate = new Date(mistoEndHour, mistoEndMin, mistoEndDay, mistoEndMonth, mistoEndYear);
                array[i].SetFinishDate(NewEndDate);
                Console.WriteLine("------------------------------------------------------------");
            }
            return array[N];
        }
        // приймає об’єкт типу Airplane і виводить його на екран
        static void PrintAirplane(Airplane obj)
        {
            string start = obj.GetStartCity();
            string finish = obj.GetFinishCity();
            Date datestart = obj.GetStartDate();
            Date datefinish = obj.GetFinishDate();
            int starthour = datestart.GetHours();
            int finishhour = datefinish.GetHours();
            int startminit = datestart.GetMinutes();
            int finishminit = datefinish.GetMinutes();
            int startday = datestart.GetDay();
            int finishday = datefinish.GetDay();
            int startmonth = datestart.GetMonth();
            int finishmonth = datefinish.GetMonth();
            int startyear = datestart.GetYear();
            int finishyear = datefinish.GetYear();
            Console.WriteLine("Видправлення з:" + start + ", та прибуття до:" + finish);

            Console.WriteLine("Час видправлення:" + starthour + " год, та" + startminit + " мин");
            Console.WriteLine("Дата видправлення:" + startday + "." + startmonth + "." + startyear);

            Console.WriteLine("Час прибуття: " + finishhour + " год, та" + finishminit + " мин");
            Console.WriteLine("Дата прибуття: " + finishday + "." + finishmonth + "." + finishyear);
            Console.WriteLine("------------------------------------------------------------");
        }
        // приймає масив об’єктів типу Airplane і виводить його на екран;
        static void PrintAirplanes(Airplane[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string start = array[i].GetStartCity();
                string finish = array[i].GetFinishCity();
                Date datestart = array[i].GetStartDate();
                Date datefinish = array[i].GetFinishDate();
                int starthour = datestart.GetHours();
                int finishhour = datefinish.GetHours();
                int startminit = datestart.GetMinutes();
                int finishminit = datefinish.GetMinutes();
                int startday = datestart.GetDay();
                int finishday = datefinish.GetDay();
                int startmounth = datestart.GetMonth();
                int finishmounth = datefinish.GetMonth();
                int startyear = datestart.GetYear();
                int finishyear = datefinish.GetYear();
                Console.WriteLine("Видправлення з:" + start + ", та прибуття до:" + finish);

                Console.WriteLine("Час видправлення:" + starthour + " год, та" + startminit + " мин");
                Console.WriteLine("Дата видправлення:" + startday + "." + startmounth + "." + startyear);

                Console.WriteLine("Час прибуття: " + finishhour + " год, та" + finishminit + " мин");
                Console.WriteLine("Дата прибуття: " + finishday + "." + finishmounth + "." + finishyear);
                Console.WriteLine("------------------------------------------------------------");
            }
        }
        //приймає масив об’єктів типу Airplane і повертає через out-параметри найбільший та найменший час подорожі.
        static void GetAirplaneInfo(Airplane[] array, out int MinTime, out int MaxTime)
        {
            int[] Timep = new int [array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                Timep[i] = array[i].GetTotalTime();
            }
            int maxtime = int.MinValue;
            int mintime = int.MaxValue;
            for (int i = 0; i < Timep.Length; i++)
            {
                if (Timep[i] < mintime)
                {
                    mintime = Timep[i];
                }
            }
            for (int i = 0; i < Timep.Length; i++)
            {
                if (Timep[i] > maxtime)
                {
                    maxtime = Timep[i];
                }
            }
            MinTime = mintime;
            MaxTime = maxtime;
        }
        //приймає масив об’єктів типу Airplane і сортує його за спаданням дати відправлення;
        static void SortAirplanesByDate(Airplane[] array)
        {
            Airplane Temp;
            DateTime Date1, Date2;

            for (int i = 0; i < array.Length - 1; i++)
            {
                Date1 = new DateTime(array[i].GetStartDate().GetYear(), array[i].GetStartDate().GetMonth(),
                array[i].GetStartDate().GetDay(), array[i].GetStartDate().GetHours(), array[i].GetStartDate().GetMinutes(), 0);

                for (int j = i + 1; j < array.Length; j++)
                {
                    Date2 = new DateTime(array[j].GetStartDate().GetYear(), array[j].GetStartDate().GetMonth(),
                    array[j].GetStartDate().GetDay(), array[j].GetStartDate().GetHours(), array[j].GetStartDate().GetMinutes(), 0);

                    if (Date1 < Date2)
                    {
                        Temp = array[i];
                        array[i] = array[j];
                        array[j] = Temp;
                    }
                }
            }
        }
        //приймає масив об’єктів типу Airplane і сортує його за зростанням часу подорожі.
        static void SortAirplanesByTotalTime(Airplane[] array)
        {
            Airplane Temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].GetTotalTime() > array[j].GetTotalTime())
                    {
                        Temp = array[i];
                        array[i] = array[j];
                        array[j] = Temp;
                    }
                }
            }
        }
    }
}

