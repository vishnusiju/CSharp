using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            CurentD CD = new CurentD();
            CD.ConCuD();

            CurentQ CQ = new CurentQ();
            CQ.currQ();

            CurentS CS = new CurentS();
            CS.ConCuQ();

            //CurentB CB = new CurentB();
            //CB.ConCuB();
        }

        
    }
}
