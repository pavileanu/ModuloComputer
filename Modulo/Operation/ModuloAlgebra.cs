using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo.Operation
{
    public class ModuloAlgebra
    {
        public static long ModuloSetNumber{get; set;}

        public static long modOf(long value)
        {
            if(value % ModuloSetNumber == 0)
                return 0;

            if (value > 0)
                return value % ModuloSetNumber;
            else 
                return value % ModuloSetNumber + ModuloSetNumber;
        }
    }
}
