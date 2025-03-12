namespace Domain.Interfaces;

public interface IDepartmentRepository
{
    Task<Department> GetDepartmentByIdAsync(int departmentId);
    Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    Task AddDepartmentAsync(Department department);
    Task UpdateDepartmentAsync(Department department);
    Task DeleteDepartmentAsync(int departmentId);
}