using Domain.Entities;

namespace Domain.Interfaces;

public interface IAllocationRepository
{
    Task<Allocation> GetAllocationByIdAsync(int allocationId);
    Task<IEnumerable<Allocation>> GetAllAllocationsAsync();
    Task AddAllocationAsync(Allocation allocation);
    Task UpdateAllocationAsync(Allocation allocation);
    Task DeleteAllocationAsync(int allocationId);
}