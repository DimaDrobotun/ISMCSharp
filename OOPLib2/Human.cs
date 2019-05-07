using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Human
    {
        protected string name;
        protected string surname;
        protected int birthday;
        protected int birthmonth;
        protected int birthyear;

        public void Setname(string Newname)
        {
            name = Newname;
        }
        public string Getname()
        {
            return name;
        }

        public void Setsurname(string Newsurname)
        {
            surname = Newsurname;
        }
        public string GetSurname()
        {
            return surname;
        }

        public void Setbirthday(int Newbirthday)
        {
            birthday = Newbirthday;
        }
        public int Getbirthday()
        {
            return birthday;
        }

        public void Setbirthmonth(int Newbirthmonth)
        {
            birthmonth = Newbirthmonth;
        }
        public int Getbirthmonth()
        {
            return birthmonth;
        }

        public void Setbirthyear(int Newbirthyear)
        {
            birthyear = Newbirthyear;
        }
        public int Getbirthyear()
        {
            return birthyear;
        }

        public Human()
        {
            name = "Dima";
            surname = "Drobotun";
            birthday = 24;
            birthmonth = 03;
            birthyear = 2000;
        }

        public Human(string inputname, string inputsurname)
        {
            name = inputname;
            surname = inputsurname;
            birthday = 01;
            birthmonth = 04;
            birthyear = 2001;
        }

        public Human(string inputnames, string inputsurnames, int inputday, int inputmonth, int inputyear)
        {
            name = inputnames;
            surname = inputsurnames;
            if (inputmonth > 0 && inputmonth <= 12)
            {
                birthmonth = inputmonth;
            }

            if (birthmonth == 1|| birthmonth==3|| birthmonth==5|| birthmonth==7|| birthmonth==8|| birthmonth==10|| birthmonth==12)
            {
                if(inputday>0 && inputday<=31)
                {
                    birthday = inputday;
                }
            }

            else if (birthmonth == 4 || birthmonth == 6 || birthmonth == 9 || birthmonth ==11)
            {
                if (inputday > 0 && inputday <= 30)
                {
                    birthday = inputday;
                }
            }

            else if (birthmonth == 2)
            {
                if (inputday > 0 && inputday <= 29)
                {
                    birthday = inputday;
                }
            }

            birthyear = inputyear;
        }
        public Human(Human inputobject)
        {
            name = inputobject.name;
            surname = inputobject.surname;
            birthday = inputobject.birthday;
            birthmonth = inputobject.birthmonth;
            birthyear = inputobject.birthyear;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Iмя:" + name + ", прiзвище:" + surname);
            Console.WriteLine("Дата народження:" + birthday + "." + birthmonth + "." + birthyear);

        }
    }
}
