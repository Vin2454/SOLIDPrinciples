//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    class LiskovSubstitutionPrincipleProblem
//    {
//        static void Main(string[] args)
//        {
//            List<Customer> Customers = new List<Customer>();
//            Customers.Add(new SilverCustomer());
//            Customers.Add(new Enquiry());

//            foreach (Customer o in Customers)
//            {
//                o.Add();
//            }
//            Console.ReadLine();
//        }
//    }
//    class Customer
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
//    class Enquiry : Customer
//    {
//        public override double getDiscount(double TotalSales)
//        {
//            return base.getDiscount(TotalSales) - 90;
//        }

//        public override void Add()
//        {
//            throw new Exception("Not allowed");
//        }
//    }
//}
