using FireWater.Test.PageTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test
{
    public class CaseFactory
    {
        public static ICase getCase(CaseTypes ct)
        {
            switch (ct)
            {
                default:
                    return null;
            }
        }
    }
}
