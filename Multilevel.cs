using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{    enum Feedback
    {
        Poor=1,Fair,Good,Excellent
    };
    //base class or parent class
    class department
    {
        //prtotected is used with in the class and only in derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }
        internal department(int Did,string Dname,string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;

        }
        protected internal void DisplayDepartmentinfo()
        {
            Console.WriteLine("Did:{0},Dname{1}",Did,Dname);

        }
        ~department()
        {
            Console.WriteLine("Department Destructor");
        }
        
    }
    //single inheritance
    //child or derived class employee
    class Employee:department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal String Name { get; set; }
        internal String City = "Pune";

        internal Employee(int Eid,string Name,int Did,String Dname,string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        }
        internal void DisplayEmployeeInfo()
        {
            DisplayDepartmentinfo();
            Console.WriteLine("Department City is:{0}", base.City);
            Console.WriteLine("Eid:{0}||Ename:{1}||feedback:{2},Eid,Name,(int)Feedback.Exxcellent");
            Console.WriteLine("Employee City is:{0}", City);

        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");

        }

    }
    class PartTimeEmployee: Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid, string Name, int Did, String Dname, string City, int hoursofwork, int salary) : base(Eid,Name,Did,Dname,City) 
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
           }
        internal int MonthlySalary()
        {
            int payment = hoursofwork * 30 * salary;
            return payment;
        }

        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Destructor");

        }

        class Multilevel
        {//single inheritance
            /*Employee employee=new Employee(1001,"SAI","101","HR","Madurai");
             * employee.DisplayEmployeeinfo();*/
            //error:Since protected
            //employee.DisplayDepartmentinfo();
            PartTimeEmployee pt = new PartTimeEmployee(1001, "SAI", 101, "HR", "Madurai", 67, 200);
            pt.DisplayEmployeeInfo();
            Console.WriteLine("Monthly Salary:{0}",pt,.MonthlySalary());
            GC.Collect();}
    }
}
