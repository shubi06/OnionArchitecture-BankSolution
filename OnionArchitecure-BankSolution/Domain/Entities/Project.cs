namespace Domain.Entities;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public string Offices { get; set; } // Për shembull, një varg me emrat e zyrave
        

    public ICollection<Allocation> Allocations { get; set; }
}