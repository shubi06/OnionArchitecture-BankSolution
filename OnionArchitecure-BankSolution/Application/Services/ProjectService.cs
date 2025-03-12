using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

  public class ProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        
        public async Task<ProjectDto> GetProjectAsync(int projectId)
        {
            var project = await _projectRepository.GetProjectByIdAsync(projectId);
            if (project == null)
                return null;
            
            return new ProjectDto
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName,
                DepartmentId = project.DepartmentId,
                Offices = project.Offices
            };
        }
        
        public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            var projects = await _projectRepository.GetAllProjectsAsync();
            var list = new List<ProjectDto>();
            foreach (var project in projects)
            {
                list.Add(new ProjectDto
                {
                    ProjectId = project.ProjectId,
                    ProjectName = project.ProjectName,
                    DepartmentId = project.DepartmentId,
                    Offices = project.Offices
                });
            }
            return list;
        }
        
        public async Task AddProjectAsync(ProjectDto projectDto)
        {
            var project = new Project
            {
                ProjectId = projectDto.ProjectId,
                ProjectName = projectDto.ProjectName,
                DepartmentId = projectDto.DepartmentId,
                Offices = projectDto.Offices
            };
            await _projectRepository.AddProjectAsync(project);
        }
        
        public async Task UpdateProjectAsync(ProjectDto projectDto)
        {
            var project = new Project
            {
                ProjectId = projectDto.ProjectId,
                ProjectName = projectDto.ProjectName,
                DepartmentId = projectDto.DepartmentId,
                Offices = projectDto.Offices
            };
            await _projectRepository.UpdateProjectAsync(project);
        }
        
        public async Task DeleteProjectAsync(int projectId)
        {
            await _projectRepository.DeleteProjectAsync(projectId);
        }
    }