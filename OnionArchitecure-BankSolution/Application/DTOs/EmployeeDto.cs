namespace Application.DTOs;

public class EmployeeDto
{
    public int PersonalNumber { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }
}