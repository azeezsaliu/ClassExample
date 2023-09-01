using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ola = new Student();

            Student obi = new Student(1, "Obinna", 4);
            Student kim = new Student(2, "Kimbawa", 6);

            /*
            obi.SaveRecord(1, "Obinna", 4);
            kim.SaveRecord(2, "Kimbawa", 6);
            */

            ola.SaveRecord(3, "honda", 32);

            Student.ChangeClassNo(34);

            obi.DisplayInfo();
            kim.DisplayInfo();

            //obi.SetName("Obinnachukwu");
            obi.Name = "Obinnachukwu";

            string obiName = obi.Name;
            Console.WriteLine("Name from getAccessor: {0}", obiName);



            Console.WriteLine("After name change");
            obi.DisplayInfo();
            kim.DisplayInfo();


            Organisation o = new Organisation();

            Institution inst = new Institution();


        }
    }
}
