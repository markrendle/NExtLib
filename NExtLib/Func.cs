using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NExtLib
{
    public static class Func
    {
        public static Func<TIn, TOut> NoOp<TIn, TOut>()
            where TIn : TOut
        {
            return (x) => x;
        }
    }
}
