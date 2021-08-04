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
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceController(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            try
            {
                var devices = await _deviceRepository.GetAll();
                var devicesResult = _mapper.Map<IList<DeviceDTO>>(devices);
                return Ok(devicesResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

    
        [HttpDelete]
        public async Task<IActionResult> DeleteDevice(int Id)
        {
            if (Id < 1)
            {
                return BadRequest();
            }

            try
            {
                var device = await _deviceRepository.Get(Id);

                if (device == null)
                {
                    return BadRequest("Submited Data Invalid");

                }
                await _deviceRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
    }
}