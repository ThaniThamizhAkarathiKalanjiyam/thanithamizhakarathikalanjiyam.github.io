using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public static class RandomST
    {
        static Random objRandom = new Random();
        public static string Number { get { return objRandom.Next().ToString(); } }
    }
}
