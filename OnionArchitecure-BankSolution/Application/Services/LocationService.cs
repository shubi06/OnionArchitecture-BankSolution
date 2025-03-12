using Application.DTOs;
using Domain.Interfaces;

namespace Application.Services;
public class LocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        
        public async Task<LocationDto> GetLocationAsync(int locationId)
        {
            var location = await _locationRepository.GetLocationByIdAsync(locationId);
            if (location == null)
                return null;
            
            return new LocationDto
            {
                LocationId = location.LocationId,
                Name = location.Name,
                Address = location.Address
            };
        }
        
        public async Task<IEnumerable<LocationDto>> GetAllLocationsAsync()
        {
            var locations = await _locationRepository.GetAllLocationsAsync();
            var list = new List<LocationDto>();
            foreach (var location in locations)
            {
                list.Add(new LocationDto
                {
                    LocationId = location.LocationId,
                    Name = location.Name,
                    Address = location.Address
                });
            }
            return list;
        }
        
        public async Task AddLocationAsync(LocationDto locationDto)
        {
            var location = new Domain.Entities.Location
            {
                LocationId = locationDto.LocationId,
                Name = locationDto.Name,
                Address = locationDto.Address
            };
            await _locationRepository.AddLocationAsync(location);
        }
        
        public async Task UpdateLocationAsync(LocationDto locationDto)
        {
            var location = new Domain.Entities.Location
            {
                LocationId = locationDto.LocationId,
                Name = locationDto.Name,
                Address = locationDto.Address
            };
            await _locationRepository.UpdateLocationAsync(location);
        }
        
        public async Task DeleteLocationAsync(int locationId)
        {
            await _locationRepository.DeleteLocationAsync(locationId);
        }
    }