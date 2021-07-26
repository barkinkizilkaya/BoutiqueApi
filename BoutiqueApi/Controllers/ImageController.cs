using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BoutiqueApi.IRepositories;
using BoutiqueApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public ImageController(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllImagesByProduct(int ProductId)
        {
            try
            {
                var Images =  await _imageRepository.GetAll(ProductId);
                var ImagesResult = _mapper.Map<ImageDTO>(Images);
                return Ok(ImagesResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            } 
        }
    }
}