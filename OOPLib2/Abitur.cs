using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Abitur : Human
    {
        protected int ZnoUA;
        protected int ZnoEn;
        protected int ZnoHistory;
        protected double Document;
        protected string Namezaklad;

        public Abitur()
        {
            name = "Dima";
            surname = "Drobotun";
            birthday = 24;
            birthmonth = 03;
            birthyear = 2000;
            ZnoUA = 180;
            ZnoEn = 170;
            ZnoHistory = 190;
            Document = 9.3;
            Namezaklad = "Zhutomyr";
        }
        public Abitur(string inputname, string inputsurname) : base(inputname, inputsurname)
        {
            ZnoUA = 150;
            ZnoEn = 140;
            ZnoHistory = 120;
            Document = 8.3;
            Namezaklad = "Myropil";
        }
        public Abitur(string inputname, string inputsurnamae, int inputday, int inputmonth, int inputyear, int inputua, int inputen, int inputhistory, double inputdocument, string inputnamezaklad) : base(inputname, inputsurnamae, inputday, inputmonth, inputyear)
        {
            name = inputname;
            surname = inputsurnamae;
            birthday = inputday;
            birthmonth = inputmonth;
            birthyear = inputyear;
            ZnoUA = inputua;
            ZnoEn = inputen;
            ZnoHistory = inputhistory;
            Document = inputdocument;
            Namezaklad = inputnamezaklad;
        }
        public Abitur(Abitur inputobject) : base(inputobject)
        {
            ZnoUA = inputobject.ZnoUA;
            ZnoEn = inputobject.ZnoEn;
            ZnoHistory = inputobject.ZnoHistory;
            Document = inputobject.Document;
            Namezaklad = inputobject.Namezaklad;
        }




        public void SetZnoUA(int InputZnoUA)
        {
            if (InputZnoUA >= 100 & InputZnoUA <= 200)
                ZnoUA = InputZnoUA;
        }
        public int GetZnoUA()
        {
            return ZnoUA;
        }

        public void SetZnoEn(int InputZnoEn)
        {
            if (InputZnoEn >= 100 & InputZnoEn <= 200)
                ZnoEn = InputZnoEn;
        }
        public int GetZnoEn()
        {
            return ZnoEn;
        }

        public void SetZnoHistory(int InputZnoHistory)
        {
            if (InputZnoHistory >= 100 & InputZnoHistory <= 200)
                ZnoHistory = InputZnoHistory;
        }
        public int GetZnoHistory()
        {
            return ZnoHistory;
        }

        public void SetDocument(double InputDocument)
        {
            if (InputDocument >= 4 & InputDocument <= 12)
                Document = InputDocument;
        }
        public double GetDocument()
        {
            return Document;
        }

        public void SetNamezaklad(string InputNamezaklad)
        {
            Namezaklad = InputNamezaklad;
        }
        public string GetNamezaklad()
        {
            return Namezaklad;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Українська мова i лiтература:" + ZnoUA);
            Console.WriteLine("Iноземна мова:" + ZnoEn);
            Console.WriteLine("Iсторiя України:" + ZnoHistory);
            Console.WriteLine("Середнiй бал документа:" + Document);
            Console.WriteLine("Назва загальноосвiтнього закладу:" + Namezaklad);
        }
    }
}