//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    public class SingleResponsibility
//    {
//        static void Main(string[] args)
//        {
//            Console.ReadLine();
//        }
//    }
//    class Customer
//    {
//        private FileLogger obj = new FileLogger();
//        public void Add()
//        {
//            try
//            {
//                // Database code goes here
//            }
//            catch (Exception ex)
//            {
//                //System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());// do not do this
//                obj.Handle(ex.ToString()); //do this
//            }
//        }
//    }
//    class FileLogger
//    {
//        public void Handle(string error)
//        {
//            System.IO.File.WriteAllText(@"c:\Error.txt", error);
//        }
//    }
//}
