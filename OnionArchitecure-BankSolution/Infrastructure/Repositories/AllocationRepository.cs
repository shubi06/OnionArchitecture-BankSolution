using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AllocationRepository : IAllocationRepository
{
    private readonly AppDbContext _context;
    public AllocationRepository(AppDbContext context)
    {
        _context = context;
    }
        
    public async Task AddAllocationAsync(Allocation allocation)
    {
        _context.Allocations.Add(allocation);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAllocationAsync(int allocationId)
    {
        var allocation = await _context.Allocations.FindAsync(allocationId);
        if (allocation != null)
        {
            _context.Allocations.Remove(allocation);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Allocation>> GetAllAllocationsAsync()
    {
        return await _context.Allocations.ToListAsync();
    }

    public async Task<Allocation> GetAllocationByIdAsync(int allocationId)
    {
        return await _context.Allocations.FindAsync(allocationId);
    }

    public async Task UpdateAllocationAsync(Allocation allocation)
    {
        _context.Allocations.Update(allocation);
        await _context.SaveChangesAsync();
    }
}