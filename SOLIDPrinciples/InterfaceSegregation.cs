//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    public class InterfaceSegregation
//    {
//        static void Main(string[] args)
//        {
//            Customer cust = new Customer();
//            cust.Add();

//            NewCustomer newCust = new NewCustomer();
//            newCust.Read();
//            Console.ReadLine();
//        }
//    }

//    interface IDatabase
//    {
//        void Add(); // old client are happy with these.
//        //void Read(); // requirement from new clients.
//    }
//    interface IDatabaseV1 : IDatabase
//    {
//        void Read();// Added for new clients.
//    }
//    class Customer : IDatabase
//    {
//        public virtual void Add()
//        {
//            Console.WriteLine("Added for customer");
//        }

//        public void Read()
//        {
//            Console.WriteLine("Read for new Customer");
//        }
//    }
//    class NewCustomer : IDatabase, IDatabaseV1
//    {
//        public virtual void Add()
//        {
//            Console.WriteLine("Added for customer");
//        }

//        public void Read()
//        {
//            Console.WriteLine("Read for new Customer");
//        }
//    }
//}
