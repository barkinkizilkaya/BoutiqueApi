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
    public class BrandController : ControllerBase
    {

        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

    
        public BrandController(IMapper mapper,IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetBrands")]
        public async Task<IActionResult> GetAllBrands()
        {
            try
            {
                var brands = await _brandRepository.GetAll();
                var brandResult = _mapper.Map<IList<BrandDTO>>(brands);
                return Ok(brandResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpGet]
        [Route("GetBrand")]
        public async Task<IActionResult> GetBrand(int Id)
        {
            try
            {
                var brand = await _brandRepository.Get(Id);
                var brandResult = _mapper.Map<BrandDTO>(brand);
                return Ok(brandResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize([FromBody] BrandDTO brandDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var brand = _mapper.Map<Brand>(brandDTO);
                await _brandRepository.Insert(brand);
                return Ok(StatusCodes.Status201Created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSize([FromBody] BrandDTO brandDTO)
        {

            if (!ModelState.IsValid || brandDTO.BrandId < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var brand = await _brandRepository.Get(brandDTO.BrandId);
                if (brand == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(brandDTO, brand);
                _brandRepository.Update(brand);

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
                var brand = await _brandRepository.Get(Id);

                if (brand == null)
                {
                    return BadRequest("Submited Data Invalid");

                }
                await _brandRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
    }
}