using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo.Operation
{
    public class Modulo
    {
        public static long ModuloSetNumber{get; set;}

        public static long modOf(long a)
        {
            return a % ModuloSetNumber;
        }
    }
}
