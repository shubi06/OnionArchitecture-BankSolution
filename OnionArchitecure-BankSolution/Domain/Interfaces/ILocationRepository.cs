using Domain.Entities;

namespace Domain.Interfaces;

public interface ILocationRepository
{
    Task<Location> GetLocationByIdAsync(int locationId);
    Task<IEnumerable<Location>> GetAllLocationsAsync();
    Task AddLocationAsync(Location location);
    Task UpdateLocationAsync(Location location);
    Task DeleteLocationAsync(int locationId);
}