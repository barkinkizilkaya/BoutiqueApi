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

        [HttpPost]
        public async Task<IActionResult> CreateImage([FromBody] ImageDTO imageDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var image = _mapper.Map<Image>(imageDTO);
                await _imageRepository.Insert(image);
                return Ok(StatusCodes.Status201Created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteImage(int Id)
        {
            if (Id < 1)
            {
                return BadRequest();
            }
            try
            {
                var image = await _imageRepository.Get(Id);

                if (image == null)
                {
                    return BadRequest("Submited Data Invalid");

                }
                await _imageRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
    }
}