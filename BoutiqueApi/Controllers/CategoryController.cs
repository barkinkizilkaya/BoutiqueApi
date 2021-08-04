using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using BoutiqueApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                var categories = await _categoryRepository.GetAll();
                var categoryResult = _mapper.Map<IList<CategoryDTO>>(categories);
                return Ok(categoryResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        [Route("GetCategory")]
        public async Task<IActionResult> GetCategory(int Id)
        {
            try
            {
                var categories = await _categoryRepository.Get(Id);
                var categoryResult = _mapper.Map<CategoryDTO>(categories);
                return Ok(categoryResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize([FromBody] CategoryDTO categoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var category = _mapper.Map<Category>(categoryDTO);
                await _categoryRepository.Insert(category);
                return Ok(StatusCodes.Status201Created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSize([FromBody] CategoryDTO categoryDTO)
        {

            if (!ModelState.IsValid || categoryDTO.Id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var category = await _categoryRepository.Get(categoryDTO.Id);
                if (category == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(categoryDTO, category);
                _categoryRepository.Update(category);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            if (Id < 1)
            {
                return BadRequest();
            }

            try
            {
                var category = await _categoryRepository.Get(Id);

                if (category == null)
                {
                    return BadRequest("Submited Data Invalid");

                }
                await _categoryRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
    }
}