using Business.Abstracts;
using Business.Dtos.Assignment.Request;
using Core.Business.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        IAssignmentService _assignmentService;

        public AssignmentsController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] int Id)
        {
            User user = new User();
            user.Projects = new List<Project>();
            var result = await _assignmentService.Get(Id);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _assignmentService.GetList(pageRequest);
            return Ok(result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateAssignmentRequest updateAssignmentRequest)
        {
            var result = await _assignmentService.Update(updateAssignmentRequest);
            return Ok(result);
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateAssignmentRequest createAssignmentRequest)
        {
            var result = await _assignmentService.Add(createAssignmentRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteAssignmentRequest deleteAssignmentRequest)
        {
            var result = await _assignmentService.Delete(deleteAssignmentRequest);
            return Ok(result);
        }
    }
}
