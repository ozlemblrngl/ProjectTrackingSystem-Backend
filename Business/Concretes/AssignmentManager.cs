using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Assignment.Request;
using Business.Dtos.Assignment.Response;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class AssignmentManager : IAssignmentService
    {
        IAssignmentDal _assignmentDal;
        IMapper _mapper;
        AssignmentBusinessRules _businessRules;

        public AssignmentManager(IAssignmentDal assignmentDal, IMapper mapper, AssignmentBusinessRules businessRules)
        {
            _assignmentDal = assignmentDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }



        public async Task<GetAssignmentResponse> Add(CreateAssignmentRequest request)
        {
            Assignment assignment = _mapper.Map<Assignment>(request);

            await _assignmentDal.AddAsync(assignment);
            GetAssignmentResponse response = _mapper.Map<GetAssignmentResponse>(assignment);
            return response;

        }



        public async Task<GetAssignmentResponse> Delete(DeleteAssignmentRequest request)
        {
            Assignment assignment = await _assignmentDal.GetAsync(predicate: u => u.Id == request.Id);


            await _assignmentDal.DeleteAsync(assignment);
            GetAssignmentResponse response = _mapper.Map<GetAssignmentResponse>(assignment);
            return response;

        }



        public async Task<GetAssignmentResponse> Get(int id)
        {
            Assignment assignment = await _assignmentDal.GetAsync(predicate: u => u.Id == id);


            GetAssignmentResponse response = _mapper.Map<GetAssignmentResponse>(assignment);

            return response;
        }



        public async Task<IPaginate<GetListAssignmentResponse>> GetList(PageRequest request)
        {
            var result = await _assignmentDal.GetListAsync(index: request.Index, size: request.Size, include: x => x.Include(y => y.Project));
            Paginate<GetListAssignmentResponse> response = _mapper.Map<Paginate<GetListAssignmentResponse>>(result);
            return response;
        }



        public async Task<GetAssignmentResponse> Update(UpdateAssignmentRequest request)
        {
            Assignment assignment = await _assignmentDal.GetAsync(predicate: c => c.Id == request.Id);


            Assignment updatedAssignment = _mapper.Map(request, assignment);

            await _assignmentDal.UpdateAsync(updatedAssignment);

            GetAssignmentResponse response = _mapper.Map<GetAssignmentResponse>(updatedAssignment);
            return response;
        }
    }
}
