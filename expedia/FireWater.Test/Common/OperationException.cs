using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.Common
{
    public class OperationException : Exception
    {
        public OperationException(string message)
            : base(message)
        {

        }
    }
}
