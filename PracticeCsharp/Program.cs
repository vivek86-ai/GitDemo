using System;


namespace PracticeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello welcome to C# world!!");
            Console.WriteLine("Please enter your name?");

            string name = Console.ReadLine();

            //using placeholder
            Console.WriteLine("My name is {0}", name);

            //using Concatenation
            Console.WriteLine("My name is " + name);
            */

            //Program.EvenNumber(30) ----If the EvenNumber method is static, then we can call using Class name directly.

            Program p = new Program();
            //p.Practice1();
            //p.EvenNumber(30);
            //int a = p.Add(4, 6);
            //Console.WriteLine(a);
            /*
            int Sum = 0;
            int Product = 0;
            Calculate(7, 5, out Sum, out Product);
            Console.WriteLine("Sum of number is {0} and Product of number is {1}", Sum, Product);
            */

            /*FTE FullTimeEmployee = new FTE();
            FullTimeEmployee.FirstName = "Vivek";
            FullTimeEmployee.LastName = "Kumar";
            FullTimeEmployee.PrintFullName();
            */


            OptionalParameter opt = new OptionalParameter();


            var varInt = 20;
            var varFloat = 20.1234;
            var varChar = "A";
            var varString = "Vivek";


            dynamic dynamicA = 20;
            dynamic dynamicF = 20.1234;
            dynamic dynamicB = "A";
            dynamic dynamicC = "Vivek";

            Console.WriteLine("20 - treated as --> "+ varInt.GetType());
            Console.WriteLine("20.1234 - treated as --> " + varFloat.GetType());
            Console.WriteLine("A - treated as --> " + varChar.GetType().GetType());
            Console.WriteLine("Vivek - treated as --> " + varString.GetType());

            Console.WriteLine("=========================");

            Console.WriteLine("20 - treated as --> " + dynamicA.GetType());
            Console.WriteLine("20.1234 - treated as --> " + dynamicF.GetType());
            Console.WriteLine("A - treated as --> " + dynamicB.GetType());
            Console.WriteLine("Vivek - treated as --> " + dynamicC.GetType());

            Console.WriteLine("=========================");

            opt.EmployeeDetail(FName:"vivek", PortalId:4444);

        }



        public class OptionalParameter
        {
            public void EmployeeDetail(string FName = "Vivek", string LName = "Kumar", int PortalId = 154014)
            {
                Console.WriteLine("First Name is {0}", FName);
                Console.WriteLine("Last Name is {0}", LName);
                Console.WriteLine("Portal Id is {0}", PortalId);
            }

        }



        public class Employee
            {
            public string FirstName;
            public string LastName;
            public string Email;

            public void PrintFullName()
            {
                Console.WriteLine(FirstName + LastName);
            }
        }

        
        public class FTE : Employee
        {
            public float YearlySal;

        }

        public class Contractors: Employee
        {
            public float HourlySal;
        }


        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;

        }

        public void Practice1()
        {
            string name = "\"Vivek\"";
            Console.WriteLine(name);

        }
        
        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public void EvenNumber(int Target)
        {
            int i = 0;

            while (i <= Target) 
            {
                Console.WriteLine(i);
                i = i + 2;
            }

        }


       
    }
}
