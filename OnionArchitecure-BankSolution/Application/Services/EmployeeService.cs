using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class EmployeeService
{
   private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public async Task<EmployeeDto> GetEmployeeAsync(int personalNumber)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(personalNumber);
            if (employee == null) return null;
            
            return new EmployeeDto
            {
                PersonalNumber = employee.PersonalNumber,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                Address = employee.Address,
                Gender = employee.Gender,
                Salary = employee.Salary,
                DepartmentId = employee.DepartmentId
            };
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var employees = await _employeeRepository.GetAllEmployeesAsync();
            var list = new List<EmployeeDto>();
            foreach (var employee in employees)
            {
                list.Add(new EmployeeDto
                {
                    PersonalNumber = employee.PersonalNumber,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    BirthDate = employee.BirthDate,
                    Address = employee.Address,
                    Gender = employee.Gender,
                    Salary = employee.Salary,
                    DepartmentId = employee.DepartmentId
                });
            }
            return list;
        }

        public async Task AddEmployeeAsync(EmployeeDto dto)
        {
            var employee = new Employee
            {
                PersonalNumber = dto.PersonalNumber,
                FirstName = dto.FirstName,
                MiddleName = dto.MiddleName,
                LastName = dto.LastName,
                BirthDate = dto.BirthDate,
                Address = dto.Address,
                Gender = dto.Gender,
                Salary = dto.Salary,
                DepartmentId = dto.DepartmentId
            };
            await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task UpdateEmployeeAsync(EmployeeDto dto)
        {
            var employee = new Employee
            {
                PersonalNumber = dto.PersonalNumber,
                FirstName = dto.FirstName,
                MiddleName = dto.MiddleName,
                LastName = dto.LastName,
                BirthDate = dto.BirthDate,
                Address = dto.Address,
                Gender = dto.Gender,
                Salary = dto.Salary,
                DepartmentId = dto.DepartmentId
            };
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int personalNumber)
        {
            await _employeeRepository.DeleteEmployeeAsync(personalNumber);
        }

}