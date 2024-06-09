using Business.Abstracts;
using Business.Dtos.Project.Request;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] int Id)
        {
            var result = await _projectService.Get(Id);
            return Ok(result);
        }

        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _projectService.GetList(pageRequest);
            return Ok(result);

        }

        [HttpGet("getListByUserId")]
        public async Task<IActionResult> GetListByUserId([FromQuery] GetListByUserIdRequest request)
        {
            var result = await _projectService.GetListByUserId(request);
            return Ok(result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateProjectRequest updateProjectRequest)
        {
            var result = await _projectService.Update(updateProjectRequest);
            return Ok(result);
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateProjectRequest createProjectRequest)
        {
            var result = await _projectService.Add(createProjectRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteProjectRequest deleteProjectRequest)
        {
            var result = await _projectService.Delete(deleteProjectRequest);
            return Ok(result);
        }
    }
}
