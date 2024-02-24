using WebAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var result = _instructorService.GetById(id);
            return Ok(result);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _instructorService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Add(Instructor instructor)
        {
            _instructorService.Add(instructor);
            return Ok();
        }
        [HttpPut]
        public ActionResult Update(Instructor instructor)
        {
            _instructorService.Update(instructor);
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _instructorService.Delete(id);
            return Ok();
        }
    }
}
