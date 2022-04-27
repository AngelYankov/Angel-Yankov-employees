using System;

namespace Angel_Yankov_employees
{
    public class WorkLog
    {
        public int EmpID { get; set; }
        public int ProjectID { get; set; }
        public DateTime DateFrom { get; set; }

        public DateTime? dateTo;

        public DateTime? DateTo
        {
            get
            {
                return dateTo;
            }
            set
            {
                if (value == null)
                {
                    dateTo = DateTime.Now;
                }
                else
                {
                    dateTo = value;
                }
            }
        }
    }
}