using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        // Set та Get методи
        public void SetStartCity(string DateStartCity)
        {
            StartCity = DateStartCity;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetFinishCity(string DateFinishCity)
        {
            FinishCity = DateFinishCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void SetStartDate(Date DateDate)
        {
            StartDate = DateDate;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public void SetFinishDate(Date DateFinishDate)
        {
            FinishDate = DateFinishDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        // Конструктор по замовчуванню
        public Airplane()
        {
            StartCity = "Zhytomyr";
            FinishCity = "Kyiv";
            StartDate = new Date();
            FinishDate= new Date();
        }
        // Конструктор с параметрами 1
        public Airplane(string InputStartCity, string InputFinishCity)
        {
            StartCity = InputStartCity;
            FinishCity = InputFinishCity;
        }
        // Конструктор с параметрами 2
        public Airplane(string InputStartCity, string InputFinishCity, Date InputStartDate, Date InputFinishDate)
        {
            StartCity = InputStartCity;
            FinishCity = InputFinishCity;
            StartDate = InputStartDate;
            FinishDate = InputFinishDate;
        }
        // Конструктор копирование
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        //обраховує сумарний час подорожі у хвилинах
        public int GetTotalTime()
        {
            int Time2 = FinishDate.GetHours();
            int Time1 = StartDate.GetHours();
            int Mint2 = FinishDate.GetMinutes();
            int Mint1 = StartDate.GetMinutes();
            int TimeAndMint = ((Time2 - Time1) * 60) + (Mint2 - Mint1);
            return TimeAndMint;
        }
        //повертає true, якщо відправлення і прибуття в той же день
        public bool IsArrivingToday(Airplane obj)
        {
            int Day1 = obj.StartDate.GetDay();
            int Day2 = obj.FinishDate.GetDay();
            if(Day1==Day2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        // Set та Get методи
        public void SetYear(int DateYear)
        {
            if(DateYear>0)
            {
                Year = DateYear;
            }
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetMonth(int DateMonth)
        {
            if(DateMonth>0 && DateMonth<=12)
            {
                Month = DateMonth;
            }
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetDay(int DateDay)
        {
            if(Month==2)
            {
                if(DateDay>0 && DateDay<=28)
                {
                    Day = DateDay;
                }
            }
            else if (Month == 4 | Month == 6 | Month == 9 | Month == 11)
            {
                if (DateDay > 0 && DateDay <= 30)
                {
                    Day = DateDay;
                }
            }
            else if(Month==1| Month == 3 | Month == 5 | Month == 7 | Month == 8 | Month ==10 | Month == 12)
            {
                if(DateDay>0 && DateDay<=31)
                {
                    Day = DateDay;
                }
            }
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetHours(int DateHours)
        {
            if(DateHours>=0 && DateHours<24)
            {
                Hours = DateHours;
            }
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetMinutes(int DateMinutes)
        {
            if(DateMinutes>=0 && DateMinutes<60)
            {
                Minutes = DateMinutes;
            }
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        // Конструктор по замовчуванню
        public Date()
        {
        Year=2019;
        Month=05;
        Day=01;
        Hours=15;
        Minutes=23;
        }
        // Конструктор с параметрами 1
        public Date(int NowHours=14, int NowMinutes=20)
        {
            Hours = NowHours;
            Minutes = NowMinutes;
        }
        // Конструктор с параметрами 2
        public Date(int NowHours = 10, int NowMinutes = 15, int NowYear= 2020, int NowMonth=01, int NowDay=01)
        {
            Year = NowYear;
            Month = NowMonth;
            Day = NowDay;
            Hours = NowHours;
            Minutes = NowMinutes;
        }
        // Конструктор копирование
        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
    }

}
