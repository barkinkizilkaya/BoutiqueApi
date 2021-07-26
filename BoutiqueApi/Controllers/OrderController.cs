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
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpGet]
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

        //[HttpGet]
        //public async Task<IActionResult> GetOrderById(int Id)
        //{
        //    try
        //    {
        //        var order = await _orderRepository.Get(Id);
        //        var orderResult = _mapper.Map<OrderDTO>(order);
        //        return Ok(orderResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Internal Server Error");
        //    }
        //}

    }
}