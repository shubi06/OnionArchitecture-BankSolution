using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AllocationService
    {
        private readonly IAllocationRepository _allocationRepository;
        public AllocationService(IAllocationRepository allocationRepository)
        {
            _allocationRepository = allocationRepository;
        }
        
        public async Task<AllocationDto> GetAllocationAsync(int allocationId)
        {
            var allocation = await _allocationRepository.GetAllocationByIdAsync(allocationId);
            if (allocation == null)
                return null;
            
            return new AllocationDto
            {
                AllocationId = allocation.AllocationId,
                EmployeePersonalNumber = allocation.EmployeePersonalNumber,
                ProjectId = allocation.ProjectId,
                WeeklyHours = allocation.WeeklyHours
            };
        }
        
        public async Task<IEnumerable<AllocationDto>> GetAllAllocationsAsync()
        {
            var allocations = await _allocationRepository.GetAllAllocationsAsync();
            var list = new List<AllocationDto>();
            foreach (var allocation in allocations)
            {
                list.Add(new AllocationDto
                {
                    AllocationId = allocation.AllocationId,
                    EmployeePersonalNumber = allocation.EmployeePersonalNumber,
                    ProjectId = allocation.ProjectId,
                    WeeklyHours = allocation.WeeklyHours
                });
            }
            return list;
        }
        
        public async Task AddAllocationAsync(AllocationDto allocationDto)
        {
            var allocation = new Allocation
            {
                AllocationId = allocationDto.AllocationId,
                EmployeePersonalNumber = allocationDto.EmployeePersonalNumber,
                ProjectId = allocationDto.ProjectId,
                WeeklyHours = allocationDto.WeeklyHours
            };
            await _allocationRepository.AddAllocationAsync(allocation);
        }
        
        public async Task UpdateAllocationAsync(AllocationDto allocationDto)
        {
            var allocation = new Allocation
            {
                AllocationId = allocationDto.AllocationId,
                EmployeePersonalNumber = allocationDto.EmployeePersonalNumber,
                ProjectId = allocationDto.ProjectId,
                WeeklyHours = allocationDto.WeeklyHours
            };
            await _allocationRepository.UpdateAllocationAsync(allocation);
        }
        
        public async Task DeleteAllocationAsync(int allocationId)
        {
            await _allocationRepository.DeleteAllocationAsync(allocationId);
        }
    }