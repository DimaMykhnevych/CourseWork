using CourseWork.Enums;
using System;


namespace CourseWork
{
    public class CompanySchedule
    {
        public Days Day { get; set; }
        public DateTime StartWorkingTime { get; set; } = ToDateTime("00:00");
        public DateTime EndWorkingTime { get; set; } = ToDateTime("23:59");
        public static DateTime ToDateTime(string time)
        {
            return Convert.ToDateTime("01/01/1800 " + time + ":00.00");
        }
    }
}
