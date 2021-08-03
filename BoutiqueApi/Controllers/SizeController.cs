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
    public class SizeController : ControllerBase
    {

        private readonly ISizeRepository _sizeRepository;
        private readonly IMapper _mapper;

        public SizeController(ISizeRepository sizeRepository, IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSizes(int ProductId)
        {
            try
            {
                var sizes = await _sizeRepository.GetAll(ProductId);
                var sizeResult = _mapper.Map<IList<SizeDTO>>(sizes);
                return Ok(sizeResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize([FromBody] SizeDTO sizeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var size = _mapper.Map<Size>(sizeDTO);
                await _sizeRepository.Insert(size);
                return Ok(StatusCodes.Status201Created);
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSize([FromBody] SizeDTO sizeDTO)
        {

            if(!ModelState.IsValid || sizeDTO.Id <1)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var size = await _sizeRepository.Get(sizeDTO.Id);
                if(size == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(sizeDTO, size);
                _sizeRepository.Update(size);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSize(int Id)
        {
            if(Id<1)
            {
                return BadRequest();
            }

            try
            {
                var size = await _sizeRepository.Get(Id);

                if(size == null)
                {
                    return BadRequest("Submited Data Invalid");

                }

                await _sizeRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
        }
}