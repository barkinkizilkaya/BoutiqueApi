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
   
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders(string creator)
        {
            try
            {
                var orders = await _orderRepository.GetAll(creator);
                var orderResult = _mapper.Map<IList<OrderDTO>>(orders);
                return Ok(orderResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet]
        [Route("GetOrderBy")]
        public async Task<IActionResult> GetOrderById(int Id)
        {
            try
            {
                var order = await _orderRepository.Get(Id);
                var orderResult = _mapper.Map<OrderDTO>(order);
                return Ok(orderResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDTO orderDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var order = _mapper.Map<Order>(orderDTO);
                await _orderRepository.Insert(order);
                return Ok(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateSize([FromBody] OrderDTO orderDTO)
        {

            if (!ModelState.IsValid || orderDTO.Id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var order = await _orderRepository.Get(orderDTO.Id);
                if (order == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(orderDTO, order);
                _orderRepository.Update(order);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int Id)
        {
            if (Id < 1)
            {
                return BadRequest();
            }

            try
            {
                var order = await _orderRepository.Get(Id);

                if (order == null)
                {
                    return BadRequest("Submited Data Invalid");

                }

                await _orderRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }


    }
}