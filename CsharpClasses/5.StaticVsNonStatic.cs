using System;


namespace SoftwareAndSchoolNamespace
{
    //Extension Methods
    class MainProgram
    {

        static void Main()
        {

            KarthikClass karthik = new KarthikClass("Andhra");

            SoftwareCompany company
                = new SoftwareCompany("10-2-2010");

            //company.hr

            SoftwareCompany.hrsEmployeeCount();

            School.schoolName = "Saraswathi vidaymandir";

            Console.WriteLine(School.schoolName);
        }
    }

    class KarthikClass
    {
        public KarthikClass() { }

        public KarthikClass(int i) {
            Console.WriteLine(i);
        }

        public KarthikClass(string s) {
            Console.WriteLine(s);
        }

        public KarthikClass(int i , string s) { }

    }
    class SoftwareCompany
    {
        public SoftwareCompany()
        {
            //Console.WriteLine("Software company constructor.....");
        }

        public SoftwareCompany(int size)
        {
            Console.WriteLine("Software company constructor.....");
        }
        public SoftwareCompany(string establishDate)
        {
            Console.WriteLine("Software company constructor.....");
        }


        //1. static and nonstatic members
        public string CompanyName;
        public static int FullStackDevelopersCount;

        public static int hrsEmployeeCount()
        {
            return 10;
        }

        //2. whenever anyone want to call your member
        // for the static member not required the instance
        // they can directly call the member.
    }
    static class School
    {

        //public School()
        //{

        //}


        // 1. you have to prepare only static membbers
        // you cannot prepare the non-static members

        public static string schoolName;

    }
    
}
