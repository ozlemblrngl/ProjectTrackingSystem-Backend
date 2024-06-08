using AutoMapper;
using Business.Dtos.Assignment.Request;
using Business.Dtos.Assignment.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AssignmentMappingProfile : Profile
    {
        public AssignmentMappingProfile()
        {
            CreateMap<Assignment, CreateAssignmentRequest>().ReverseMap();
            CreateMap<Assignment, DeleteAssignmentRequest>().ReverseMap();
            CreateMap<Assignment, UpdateAssignmentRequest>().ReverseMap();


            CreateMap<GetAssignmentResponse, CreateAssignmentRequest>().ReverseMap();
            CreateMap<GetAssignmentResponse, DeleteAssignmentRequest>().ReverseMap();
            CreateMap<GetAssignmentResponse, UpdateAssignmentRequest>().ReverseMap();

            CreateMap<Assignment, GetAssignmentResponse>().ReverseMap();
            CreateMap<Assignment, GetListAssignmentResponse>().ReverseMap();
            CreateMap<Paginate<Assignment>, Paginate<GetListAssignmentResponse>>().ReverseMap();

        }
    }
}
