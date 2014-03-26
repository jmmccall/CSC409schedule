using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schedule.Models
{
    public class Class
    {
        int classID;
        string department;
        int classNum;
        int section;
        List<TimePeriod> times;
        DateTime startDate;
        DateTime endDate;
    }
}