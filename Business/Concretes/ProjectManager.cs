using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Project.Request;
using Business.Dtos.Project.Response;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;
        IMapper _mapper;
        ProjectBusinessRules _businessRules;

        public ProjectManager(IProjectDal projectDal, IMapper mapper, ProjectBusinessRules businessRules)
        {
            _projectDal = projectDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }


        public async Task<GetProjectResponse> Add(CreateProjectRequest request)
        {
            Project project = _mapper.Map<Project>(request);

            await _projectDal.AddAsync(project);
            GetProjectResponse response = _mapper.Map<GetProjectResponse>(project);
            return response;

        }



        public async Task<GetProjectResponse> Delete(DeleteProjectRequest request)
        {
            Project project = await _projectDal.GetAsync(predicate: u => u.Id == request.Id);


            await _projectDal.DeleteAsync(project);
            GetProjectResponse response = _mapper.Map<GetProjectResponse>(project);
            return response;

        }

        public async Task<GetProjectResponse> Get(int id)
        {
            Project project = await _projectDal.GetAsync(predicate: u => u.Id == id);


            GetProjectResponse response = _mapper.Map<GetProjectResponse>(project);

            return response;
        }



        public async Task<IPaginate<GetListProjectResponse>> GetList(PageRequest request)
        {
            var result = await _projectDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListProjectResponse> response = _mapper.Map<Paginate<GetListProjectResponse>>(result);
            return response;
        }

        public async Task<IPaginate<GetListProjectResponse>> GetListByUserId(GetListByUserIdRequest request)
        {
            var result = await _projectDal.GetListAsync(predicate: x => x.UserId == request.UserId, index: request.Index, size: request.Size);
            Paginate<GetListProjectResponse> response = _mapper.Map<Paginate<GetListProjectResponse>>(result);
            return response;
        }

        public async Task<GetProjectResponse> Update(UpdateProjectRequest request)
        {
            Project project = await _projectDal.GetAsync(predicate: c => c.Id == request.Id);


            Project updatedProject = _mapper.Map(request, project);

            await _projectDal.UpdateAsync(updatedProject);

            GetProjectResponse response = _mapper.Map<GetProjectResponse>(updatedProject);
            return response;
        }



    }
}
