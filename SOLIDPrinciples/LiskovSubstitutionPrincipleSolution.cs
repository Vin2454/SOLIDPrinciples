//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    class LiskovSubstitutionPrincipleSolution
//    {
//        static void Main(string[] args)
//        {
//            List<Customer> Customers = new List<Customer>();
//            Customers.Add(new SilverCustomer());
//            Customers.Add(new Enquiry());//error is at compile time only rather than at runtime.

//            foreach (Customer o in Customers)
//            {
//                o.Add();
//            }
//            Console.ReadLine();
//        }
//    }
//    class Customer: IDiscount, IDatabase
//    {
//        public virtual void Add()
//        {

//        }
//        public virtual double getDiscount(double TotalSales)
//        {
//            return TotalSales;
//        }
//    }
//    class SilverCustomer : Customer
//    {
//        public override double getDiscount(double TotalSales)
//        {
//            return base.getDiscount(TotalSales) - 50;
//        }
//        public override void Add()
//        {
//            Console.WriteLine("Silver Customer");
//        }

//    }
//    class Enquiry : IDiscount
//    {
//        public double getDiscount(double TotalSales)
//        {
//            return TotalSales - 90;
//        }
   
//    }

//    interface IDiscount
//    {
//       double getDiscount(double TotalSales);
//    }


//    interface IDatabase
//    {
//        void Add();
//    }
//}
