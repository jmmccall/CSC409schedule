using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schedule.Models
{
    public class Semester
    {
        semesterType type;
        int year;
    }

    enum semesterType{Fall,Spring,Summer}
}