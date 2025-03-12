using Domain.Entities;

namespace Domain.Interfaces;

public interface IProjectRepository
{
    Task<Project> GetProjectByIdAsync(int projectId);
    Task<IEnumerable<Project>> GetAllProjectsAsync();
    Task AddProjectAsync(Project project);
    Task UpdateProjectAsync(Project project);
    Task DeleteProjectAsync(int projectId);
}