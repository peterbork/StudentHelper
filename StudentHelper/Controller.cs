using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHelper.Helper;

namespace StudentHelper {
    class Controller {
        int WeekNumber;

        public int GetWeekNumber() {
            if (WeekNumber == 0) {
                WeekNumber = DateHelper.GetCurrentWeekNumber();
            }

            return WeekNumber;
        }
    }
}
