using Application.DTOs;
using Domain.Interfaces;

namespace Application.Services;

public class DepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;
    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public async Task<DepartmentDto> GetDepartmentAsync(int departmentId)
    {
        var department = await _departmentRepository.GetDepartmentByIdAsync(departmentId);
        if (department == null) return null;
            
        return new DepartmentDto
        {
            DepartmentId = department.DepartmentId,
            Name = department.Name,
            ManagerPersonalNumber = department.ManagerPersonalNumber,
            ManagerStartDate = department.ManagerStartDate
        };
    }
}