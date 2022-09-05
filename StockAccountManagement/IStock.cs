using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public interface IStocks
    {
        // declare here 4 methods.
        public void stockAccount();
        public void sell();
        public void buy();
        public void save();

    }
}