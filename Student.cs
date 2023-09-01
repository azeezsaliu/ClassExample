using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Student
    {
        /*
        private int id;
        private string name;

        private static int classNo;
        */

        public int Id { get; set; }
        public string Name { get; set; }
        public static int ClassNo { get; set; }


        public Student()
        {

        }

        public Student(int id, string name, int classNo)
        {
            this.Id = id;
            this.Name = name;
            Student.ClassNo = classNo;
        }

        public void SaveRecord(int id, string name, int classNo)
        {
            this.Id = id;
            this.Name = name;
            Student.ClassNo = classNo;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Id: {0}, Name: {1}, ClassNo: {2}", this.Id, Name, Student.ClassNo);
        }

        /*
        public string Name
        {
            get
            {

                return name;
            }
            set
            {
                name = value;
            }
        }
        */
        /*
        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
        */
        private bool IsValid(int idValus)
        {
            if(idValus != 0)
            {
                return true;
            }
            return false;
        }

        public static void ChangeClassNo(int classNo)
        {
            Student.ClassNo = classNo;
        }

        ~Student()
        {
            Console.WriteLine("{0}, Is destroyed", Name);
        }

    }
}
