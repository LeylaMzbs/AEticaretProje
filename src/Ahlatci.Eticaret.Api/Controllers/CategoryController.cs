using Ahlatci.Eticaret.Application.Models.Dtos.Categories;
using Ahlatci.Eticaret.Application.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Ahlatci.Eticaret.Application.Models.RequestModels.Categories;
using Microsoft.AspNetCore.Authorization;
using Ahlatci.Eticaret.Application.Wrapper;

namespace Ahlatci.Eticaret.Api.Controllers
{

    //Endpoint url : [ControllerRoute]/[ActionRoute]
    //category/getAll

    [ApiController]
    [Route("category")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get")]
        [AllowAnonymous]
        public async Task<ActionResult<Result<List<CategoryDto>>>> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("get/{id:int}")]  //Get yapýlan isteði adres satýrýndan gönderir.
        [AllowAnonymous]
        public async Task<ActionResult<Result<CategoryDto>>> GetCategoryById(int id)
        {
            var category = await _categoryService.GetCategoryById(new GetCategoryByIdVM { Id = id });
            return Ok(category);
        }

        [HttpPost("create")]    //Post yapýlan isteðin gövdesinde bilgiyi gönderiyor.
        public async Task<ActionResult<Result<int>>> CreateCategory(CreateCategoryVM createCategoryVM)
        {
            var categoryId = await _categoryService.CreateCategory(createCategoryVM);
            return Ok(categoryId);
        }

        [HttpPut("update/{id:int}")] //Put adres satýrýndan güncellenecek kaydýn id alýnýr.
        public async Task<ActionResult<Result<int>>> UpdateCategory(int id, UpdateCategoryVM updateCategoryVM)
        {
            if (id != updateCategoryVM.Id) //id ile Vm'in içerisindeki id eþleþmiyorsa BadRequest döndürür.
            {
                return BadRequest();
            }
            var categoryId = await _categoryService.UpdateCategory(updateCategoryVM);
            return Ok(categoryId);
        }

        [HttpDelete("delete/{id:int}")] //Delete adres satýrýndan id alýnýr.
        public async Task<ActionResult<Result<int>>> DeleteCategory(int id)
        {
            var categoryId = await _categoryService.DeleteCategory(new DeleteCategoryVM { Id = id });
            return Ok(categoryId);
        }

    }
}

