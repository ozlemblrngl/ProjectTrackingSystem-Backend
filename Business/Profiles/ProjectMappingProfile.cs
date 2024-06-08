using AutoMapper;
using Business.Dtos.Project.Request;
using Business.Dtos.Project.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {
            CreateMap<Project, CreateProjectRequest>().ReverseMap();
            CreateMap<Project, DeleteProjectRequest>().ReverseMap();
            CreateMap<Project, UpdateProjectRequest>().ReverseMap();


            CreateMap<GetProjectResponse, CreateProjectRequest>().ReverseMap();
            CreateMap<GetProjectResponse, DeleteProjectRequest>().ReverseMap();
            CreateMap<GetProjectResponse, UpdateProjectRequest>().ReverseMap();

            CreateMap<Project, GetProjectResponse>().ReverseMap();
            CreateMap<Project, GetListProjectResponse>().ReverseMap();
            CreateMap<Paginate<Project>, Paginate<GetListProjectResponse>>().ReverseMap();

        }
    }
}
