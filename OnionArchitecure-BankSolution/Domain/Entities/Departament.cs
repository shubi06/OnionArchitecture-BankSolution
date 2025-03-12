using Domain.Entities;

namespace Domain;

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public int ManagerPersonalNumber { get; set; }
    public DateTime ManagerStartDate { get; set; }
        
    // Navigation properties
    public ICollection<Employee> Employees { get; set; }
    public ICollection<Project> Projects { get; set; }
}