namespace Application.DTOs;

public class DepartmentDto
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public int ManagerPersonalNumber { get; set; }
    public DateTime ManagerStartDate { get; set; }
}