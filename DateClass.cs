using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Draft
{
    class DateClass
    {
        const decimal Fee = 0M;

        public static decimal NumberOfGuests(decimal Guest, decimal Fee)
        {
            decimal B;
            B = (Guest * Fee);
            return B;
        }
    }
}
