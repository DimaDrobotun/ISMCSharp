using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
  public class User : Human
    {
        protected int nomerkvutka;
        protected int kvutokday;
        protected int kvutokmonth;
        protected int kvutokyear;
        protected double vnesok;

        public User()
        {
            name = "Roma";
            surname = "Valerovuch";
            birthday = 04;
            birthmonth = 02;
            birthyear = 2000;
            nomerkvutka = 1001;
            kvutokday = 05;
            kvutokmonth = 06;
            kvutokyear = 2019;
            vnesok = 432.50;
        }
        public User(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear) : base(inputname, inputsurname, inputday, inputmonth, inputyear)
        {
            nomerkvutka = 1112;
            kvutokday = 07;
            kvutokmonth = 05;
            kvutokyear = 2000;
            vnesok = 555.30;
        }
        public User(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear, int inputnomer, int inputdays, int inputmonths, int inputyears, double inputmoney):base(inputname,inputsurname,inputday,inputmonth,inputyear)
        {
            nomerkvutka = inputnomer;
            kvutokday = inputdays;
            kvutokmonth = inputmonths;
            kvutokyear = inputyears;
            vnesok = inputmoney;
        }


        public void Setnomerkvutka(int inputnomerkvutka)
        {
            nomerkvutka = inputnomerkvutka;
        }
        public int Getnomerkvutka()
        {
            return nomerkvutka;
        }
        public void Setkvutokday(int inputday, int inputmonth, int inputyear)
        {
            kvutokday = inputday;
            kvutokmonth = inputmonth;
            kvutokyear = inputyear;
        }
        public int Getkvutokday()
        {
            return kvutokday;
        }
        public int Getkvutokmonth()
        {
            return kvutokmonth;
        }
        public int Getkvutokyear()
        {
            return kvutokyear;
        }
        public void Setvnesok(double inputvnesok)
        {
            vnesok = inputvnesok;
        }
        public double Getvnesok()
        {
            return vnesok;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Читацький квиток:" + nomerkvutka + ", видано " + kvutokday + "." + kvutokmonth + "." + kvutokyear + ", сума внеску " + vnesok + " грн.");
        }
    }
}
