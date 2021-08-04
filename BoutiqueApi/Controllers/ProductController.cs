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
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var product = await _productRepository.GetAll();
                var productResult = _mapper.Map<IList<ProductDTO>>(product);
                return Ok(productResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        [Route("GetProduct")]
        public async Task<IActionResult> GetProduct(int Id)
        {
            try
            {
                var product = await _productRepository.Get(Id);
                var productResult = _mapper.Map<ProductDTO>(product);
                return Ok(productResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDTO productDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var product = _mapper.Map<Product>(productDto);
                await _productRepository.Insert(product);
                return Ok(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDTO productDto)
        {
            if(!ModelState.IsValid || productDto.Id<1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var product = await _productRepository.Get(productDto.Id);
                if(product == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(productDto, product);              
                _productRepository.Update(product);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProduct(int Id)
        {
            if(Id<1)
            {
                return BadRequest();
            }
            try
            {
                var product = await _productRepository.Get(Id);
                if(product == null)
                {
                    return BadRequest("Submited Data Invalid");
                }

                await _productRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }

    }
}