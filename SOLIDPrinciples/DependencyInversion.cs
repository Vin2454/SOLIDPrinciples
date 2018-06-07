//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    public class DependencyInversion
//    {
//        static void Main(string[] args)
//        {
//            Customer obj = new Customer();
//            obj.Add(2);
//            Console.ReadLine();
//        }
//    }

//    class Customer
//    {
//        private ILogger obj;
//        public void Add(int loggingType)
//        {
//            try
//            {
//                // Database code goes here
//            }
//            catch (Exception ex)
//            {
//                if (loggingType == 1)
//                {
//                    obj = new FileLogger();
//                }
//                else
//                {
//                    obj = new EmailLogger();
//                }
//                obj.Handle(ex.Message.ToString());
//            }
//        }
//    }
//    interface ILogger
//    {
//        void Handle(string error);
//    }
//    class FileLogger : ILogger
//    {
//        public void Handle(string error)
//        {
//            System.IO.File.WriteAllText(@"c:\Error.txt", error);
//        }
//    }
//    class EmailLogger : ILogger
//    {
//        public void Handle(string error)
//        {
//            // send errors in email
//        }
//    }
//}
