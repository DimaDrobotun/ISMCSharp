using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
   public class Teacher:Human
    {
        protected string job;
        protected string cafedra;
        protected string zaklad;

        public void Setjob(string inputjob)
        {
            job = inputjob;
        }
        public string Getjob()
        {
            return job;
        }

        public void Setcafedra(string inputcafedra)
        {
            cafedra = inputcafedra;
        }
        public string Getcafedra()
        {
            return cafedra;
        }

        public void Setzaklad(string inputzaklad)
        {
            zaklad = inputzaklad;
        }
        public string Getzaklad()
        {
            return zaklad;
        }

        public Teacher()
        {
            name = "Taras";
            surname = "Batkovuch";
            birthday = 01;
            birthmonth = 10;
            birthyear = 2000;
            job = "Bibliotekar";
            cafedra = "Bookins";
            zaklad = "ZTK";
        }
        public Teacher(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear) : base(inputname, inputsurname, inputday, inputmonth, inputyear)
        {
            job = "Bibliotekasr";
            cafedra = "Economics";
            zaklad = "ZTK";
        }
        public Teacher(string inputname, string inputsurname, int inputday, int inputmonth, int inputyear, string inputjob, string inputkafedra, string inputzaklad) : base(inputname, inputsurname, inputday, inputmonth, inputyear)
        {
            job = inputjob;
            cafedra = inputkafedra;
            zaklad = inputzaklad;
        }
        public Teacher(Teacher inputobject) : base(inputobject)
        {
            job = inputobject.job;
            cafedra = inputobject.cafedra;
            zaklad = inputobject.zaklad;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Посада:" + job + ", кафедри:" + cafedra + ", навчального закладу:" + zaklad);
        }

    }
}
