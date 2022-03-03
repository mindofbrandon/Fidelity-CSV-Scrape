using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class StonkData
    {
        private uint acctNum;
        private string symbol;
        private string desc;
        private uint qty;
        private uint lastPrice;
        private int lastPriceChng;
        private uint currPrice;
        private int todayGLDollar;
        private int todayGLPercent;
        private int totalGLDollar;
        private int totalGLPercent;
        private uint percentOfAcct;
        private int costBasis;
        private int costBasisPerShare;
        private string type;

        public StonkData()
        {
            acctNum = 0;
            symbol = "null";
            desc = "null";
            qty = 0;
            lastPrice = 0;
            lastPriceChng = 0;
            currPrice = 0;
            todayGLDollar = 0;
            todayGLPercent = 0;
            totalGLDollar = 0;
            totalGLPercent = 0;
            percentOfAcct = 0;
            costBasis = 0;
            costBasisPerShare = 0;
            type = "null";
        }

        public void SetAcctNum(uint numVal)
        {
            acctNum = numVal;
        }

        public void SetSymbol(string symVal)
        {
            symbol = symVal;
        }
        public void SetDesc(string descVal)
        {
            desc = descVal;
        }
        public void SetQty(uint qtyVal)
        {
            qty = qtyVal;
        }
        public void SetLastPrice(uint lastPriceVal)
        {
            lastPrice = lastPriceVal;
        }

        public void SetLastPriceChng(int lastPriceChngVal)
        {
            lastPriceChng = lastPriceChngVal;
        }
        public void SetCurr(uint currVal)
        {
            currPrice = currVal;
        }
        public void SetTodaysGLDollar(int todayDollarVal)
        {
            todayGLDollar = todayDollarVal;
        }
        public void SetTodayLGPercent(int todayPercentVal)
        {
            todayGLPercent = todayPercentVal;
        }
        public void SetTotalGLDollar(int totalDollarVal)
        {
            totalGLDollar = totalDollarVal;
        }
        public void SetTotalGLPercent(int totalPercentVal)
        {
            totalGLPercent = totalPercentVal;
        }
        public void SetPercentOfAcct(uint percentVal)
        {
            percentOfAcct = percentVal;
        }
        public void SetCostBasis(int costVal)
        {
            costBasis = costVal;
        }
        public void SetCostBasisPerShare(int costPerVal)
        {
            costBasisPerShare = costPerVal;
        }
        public void SetType(string typeVal)
        {
            type = typeVal;
        }
    }

        

}
