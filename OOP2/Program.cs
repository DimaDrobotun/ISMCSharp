using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib2;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] array = new Human[5];
            array[0] = new Human("Svyatoslav", "Ivanov", 02, 04, 2000);
            array[1] = new Abitur("Mukuta", "Vasuluk", 19, 05, 2000, 180, 170, 189, 164.2, "ZTD");
            array[2] = new Student("Sasha", "Golanuzkuy", 04, 05, 2000, 5, "P-33", "Program", "ZTK");
            array[3] = new Teacher("Vasul", "Verastuk", 07, 10, 1989, "Bibliotekar", "Engener", "Ivana Franka");
            array[4] = new User("Vetal", "Verbizkiy", 12, 05, 2000, 1223, 22, 04, 1999, 1232);
            for (int i = 0; i < array.Length; i++)
            {
                array[i].ShowInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
