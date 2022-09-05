using System;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManage stockManage = new StockManage();
            stockManage.stockAccount();
            stockManage.transaction();
        }
    }
}