//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples
//{
//    public class OpenForExtentionCloseForModification
//    {
//        static void Main(string[] args)
//        {
//            Customer goldCust = new goldCustomer();
//            Console.WriteLine(goldCust.getDiscount(100));
//            Customer silverCust = new SilverCustomer();
//            Console.WriteLine(silverCust.getDiscount(100));
//            Console.ReadLine();
//        }
//    }

//    ////Do not do this
//    //class Customer
//    //{
//    //    private int _CustType;

//    //    public int CustType
//    //    {
//    //        get { return _CustType; }
//    //        set { _CustType = value; }
//    //    }

//    //    public double getDiscount(double TotalSales)
//    //    {
//    //        if (_CustType == 1)
//    //        {
//    //            return TotalSales - 100;
//    //        }
//    //        else
//    //        {
//    //            return TotalSales - 50;
//    //        }
//    //    }
//    //}

//    class Customer
//    {
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
//    }
//    class goldCustomer : Customer
//    {
//        public override double getDiscount(double TotalSales)
//        {
//            return base.getDiscount(TotalSales) - 100;
//        }
//    }
//}
