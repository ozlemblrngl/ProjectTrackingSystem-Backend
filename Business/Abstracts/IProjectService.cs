using Business.Dtos.Project.Request;
using Business.Dtos.Project.Response;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IProjectService
    {
        Task<GetProjectResponse> Add(CreateProjectRequest createProjectRequest);
        Task<GetProjectResponse> Update(UpdateProjectRequest updateProjectRequest);
        Task<GetProjectResponse> Delete(DeleteProjectRequest deleteProjectRequest);
        Task<IPaginate<GetListProjectResponse>> GetList(PageRequest pageRequest);
        Task<GetProjectResponse> Get(int id);
    }
}
