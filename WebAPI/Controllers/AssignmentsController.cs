using Business.Abstracts;
using Business.Dtos.Assignment.Request;
using Business.Dtos.Project.Request;
using Core.Business.Requests;
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

            var result = await _assignmentService.Get(Id);
            return Ok(result);
        }

        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _assignmentService.GetList(pageRequest);
            return Ok(result);

        }

        [HttpGet("getListByUserId")]
        public async Task<IActionResult> GetListByUserId([FromQuery] GetListByUserIdRequest request)
        {
            var result = await _assignmentService.GetListByUserId(request);
            return Ok(result);

        }

        [HttpGet("getListByProjectId")]
        public async Task<IActionResult> GetListByProjectId([FromQuery] GetListAssigmentRequest request)
        {
            var result = await _assignmentService.GetListByProjectId(request);
            return Ok(result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateAssignmentRequest updateAssignmentRequest)
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
