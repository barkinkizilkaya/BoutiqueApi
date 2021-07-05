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



    }
}