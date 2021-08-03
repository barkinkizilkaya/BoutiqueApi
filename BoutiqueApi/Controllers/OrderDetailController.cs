
using System;
using System.Collections;
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
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderAll(int OrderId)
        {
            try
            {
                var orderDetail = await _orderDetailRepository.GetAll(OrderId);
                var orderDetailResult = _mapper.Map<IList<OrderDetailDTO>>(orderDetail);
                return Ok(orderDetailResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail([FromBody] OrderDetailDTO orderDetailDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var orderDetail = _mapper.Map<OrderDetail>(orderDetailDTO);
                await _orderDetailRepository.Insert(orderDetail);
                return Ok(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail ([FromBody] OrderDetailDTO orderDetailDTO)
        {
            if(!ModelState.IsValid || orderDetailDTO.Id<1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var orderDetail = await _orderDetailRepository.Get(orderDetailDTO.Id);
                if(orderDetail == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(orderDetailDTO, orderDetail);

                _orderDetailRepository.Update(orderDetail);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrderDetail(int Id)
        {
            if(Id<1)
            {
                return BadRequest();
            }
            try
            {
                var orderDetail = await _orderDetailRepository.Get(Id);

                if(orderDetail == null)
                {
                    return BadRequest("Submited Data Invalid");
                }

                await _orderDetailRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }
    }
}