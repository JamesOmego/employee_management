using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models

    Public class Departments
{
    [Key]
    public int Id { get; set; }

    public required string DepartmentName { get; set; }

    public  string DepartmentRegion { get; set; }

    public string DepartmentHead { get; set; }
}