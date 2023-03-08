using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public required string EmployeeNo { get; set; }

        public required string FirstName { get; set; }

        public string MiddleName { get; set; }

        public required string LastName { get; set; }

        public required string Gender { get; set; }

        public required  string EmailAddress { get; set; }

        public required string Region { get; set; }

        public  string Phone { get; set; }
    }
}
