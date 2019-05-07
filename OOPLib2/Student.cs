using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Student:Human
    {
        protected int Kurs;
        protected string Group;
        protected string Facultet;
        protected string Zaklad;

        public void SetKurs(int inputkurs)
        {
            Kurs = inputkurs;
        }
        public int GetKurs()
        {
            return Kurs;
        }

        public void SetGroup(string inputGroup)
        {
            Group = inputGroup;
        }
        public string GetGroup()
        {
            return Group;
        }

        public void SetFacultet(string inputFacultet)
        {
            Facultet = inputFacultet;
        }
        public string GetFacultet()
        {
            return Facultet;
        }

        public void SetZaklad(string inputZaklad)
        {
            Zaklad = inputZaklad;
        }
        public string GetZaklad()
        {
            return Zaklad;
        }

        public Student()
        {
            name = "Dima";
            surname = "Drobotun";
            birthday = 20;
            birthmonth = 03;
            birthyear = 2000;
            Kurs = 4;
            Group="P-43";
            Facultet = "Programming engineer";
            Zaklad = "ZTK";
        }

        public Student(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear) : base(inputname, inputsurname, inputday, inputmonth, inputyear)
        {
            Kurs = 4;
            Group = "P-43";
            Facultet = "Programming engineer";
            Zaklad = "ZTK";
        }
        public Student(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear, int inputkurce, string inputgroup, string inputfakultet, string inputzaklad) : base(inputname, inputsurname, inputday, inputmonth, inputyear)
        {
            Kurs = inputkurce;
            Group = inputgroup;
            Facultet = inputfakultet;
            Zaklad = inputzaklad;
        }
        public Student(Student inputobject) : base(inputobject)
        {
            Kurs = inputobject.Kurs;
            Group = inputobject.Group;
            Facultet = inputobject.Facultet;
            Zaklad = inputobject.Zaklad;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Курс:" + Kurs + ", група:" + Group);
            Console.WriteLine("Факультет:" + Facultet + ", назва закладу:" +Zaklad);
        }
    }
}
