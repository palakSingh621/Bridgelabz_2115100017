using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Assignment
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date.ToString("dd-MM-yyyy");
            }
            else
            {
                throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");
            }
        }
    }
}
