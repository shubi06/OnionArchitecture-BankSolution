using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly AppDbContext _context;
    public LocationRepository(AppDbContext context)
    {
        _context = context;
    }
        
    public async Task AddLocationAsync(Location location)
    {
        _context.Locations.Add(location);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteLocationAsync(int locationId)
    {
        var location = await _context.Locations.FindAsync(locationId);
        if (location != null)
        {
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Location>> GetAllLocationsAsync()
    {
        return await _context.Locations.ToListAsync();
    }

    public async Task<Location> GetLocationByIdAsync(int locationId)
    {
        return await _context.Locations.FindAsync(locationId);
    }

    public async Task UpdateLocationAsync(Location location)
    {
        _context.Locations.Update(location);
        await _context.SaveChangesAsync();
    }
}