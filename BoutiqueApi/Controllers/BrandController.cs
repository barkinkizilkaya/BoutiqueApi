using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}