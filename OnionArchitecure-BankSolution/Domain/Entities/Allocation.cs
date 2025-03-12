namespace Domain.Entities;

public class Allocation
{
    public int AllocationId { get; set; }
    public int EmployeePersonalNumber { get; set; }
    public Employee Employee { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public int WeeklyHours { get; set; }
}