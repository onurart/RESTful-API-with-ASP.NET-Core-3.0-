using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Helpers
{
    public static class FoundYearsAgo
    {
        public static int GetYearsAgo(this DateTime dateTime)
        {
            var currenDate = DateTime.Now;
            int yearsAgo = currenDate.Year - dateTime.Year;
            return yearsAgo;
        }
    }
}
