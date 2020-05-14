using CourseWork.Enums;
using System.Collections.Generic;

namespace CourseWork.Models
{
    public class CompanySearchParameter
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Specialization Specialization { get; set; }
        public List<string> Services { get; set; }
        public OwnershipType Ownership { get; set; }
        public CompanyContactData Contacts { get; set; }
        public List<CompanySchedule> Schedules { get; set; }
    }
}
