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
    public class NotificationController : Controller
    {

        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public NotificationController(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetNotification")]
        public async Task<IActionResult> GetNotification(int Id)
        {
            try
            {
                var notifications = await _notificationRepository.Get(Id);
                var notificationResult = _mapper.Map<NotificationDTO>(notifications);
                return Ok(notificationResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpGet]
        [Route("GetNotifications")]
        public async Task<IActionResult> GetAllNotifications()
        {
            try
            {
                var notifications = await _notificationRepository.GetAll();
                var notificationResult = _mapper.Map<IList<NotificationDTO>>(notifications);
                return Ok(notificationResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotification([FromBody] NotificationDTO notificationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var notification = _mapper.Map<Notification>(notificationDTO);
                await _notificationRepository.Insert(notification);
                return Ok(StatusCodes.Status201Created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "InternalServer Error. Please Try Again Later");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification([FromBody] NotificationDTO notificationDTO)
        {

            if (!ModelState.IsValid || notificationDTO.Id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var notification = await _notificationRepository.Get(notificationDTO.Id);
                if (notification == null)
                {
                    return BadRequest("Submited data is Invalid");
                }

                _mapper.Map(notificationDTO, notification);
                _notificationRepository.Update(notification);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try Again Later");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNotification(int Id)
        {
            if (Id < 1)
            {
                return BadRequest();
            }

            try
            {
                var notification = await _notificationRepository.Get(Id);

                if (notification == null)
                {
                    return BadRequest("Submited Data Invalid");

                }
                await _notificationRepository.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }

        }
    }
}