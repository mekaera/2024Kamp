using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Abstract;
using WebAPI.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return Ok();
        }
        [HttpPut]
        public ActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    }
}
