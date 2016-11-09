using FireWater.Test.PageTests;
using FireWater.Test.PageTests.n11;
using FireWater.Test.PageTests.phptravels;
using FireWater.Test.PageTests.thedemositecouk;
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
                case CaseTypes.N11UyeOl:
                    return new N11CaseUyeOl();
                case CaseTypes.N11GirisYap:
                    return new N11CaseGirisYap();
                case CaseTypes.ThedemositeCaseLogin:
                    return new ThedemositeLogin();
                case CaseTypes.ThedemositeCaseAddUser:
                    return new ThedemositeCaseAddUser();
                case CaseTypes.PhptravelsCaseAddUser:
                    return new PhptravelsCaseAddUser();
                case CaseTypes.PhptravelsCaseLogin:
                    return new PhptravelsCaseLogin();
                default:
                    return null;
            }
        }
    }
}
