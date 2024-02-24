using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Abstract;
using WebAPI.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            return Ok(result);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _courseService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Add(Course course)
        {
            _courseService.Add(course);
            return Ok();
        }
        [HttpPut]
        public ActionResult Update(Course course)
        {
            _courseService.Update(course);
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _courseService.Delete(id);
            return Ok();
        }
    }
}
