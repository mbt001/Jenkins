using System;

class Student
{
    public int rollNumber;
    public string name;
    public string dob;
    public static string collegeName;
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.rollNumber = 1;
        s.name = "Andrew";

        Console.WriteLine(s.rollNumber);
        Console.WriteLine(s.name);
    }
}


--------q2------------
namespace Assignment1
{
    class Saledetails
    {
        internal int Salesno;
        int Productno;
        double Price;
        DateTime dateofsale;
        int Qty;
        double TotalAmount;

        Saledetails(int Salesno, int Productno, double Price, DateTime dateofsale, int Qty)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = dateofsale;
            this.Qty = Qty;
        }
        void Sales(int qty, double price)
        {
            double TotalAmount = qty * price;
            Console.WriteLine("Total Amount : {0}", TotalAmount);
        }

        static void display(Saledetails saledetails)
        {
            Console.WriteLine("Sale no " + saledetails.Salesno + " Product no " + saledetails.Productno +
                " Price " + saledetails.Price + " Date of Sale " + (saledetails.dateofsale).ToString("dd/MM/yyyy") +
                " Quantity " + saledetails.Qty);
        }

        public static void Main(String[] args)
        {
            Saledetails s1 = new Saledetails(1, 1000, 60.5, Convert.ToDateTime("25/12/1999"), 2);

            display(s1);
            s1.Sales(2, 60.5);
        }
    }
}





































