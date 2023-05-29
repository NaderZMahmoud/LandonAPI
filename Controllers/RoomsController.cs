using LandonAPI2.Models;
using LandonAPI2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace LandonAPI2.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class RoomsController: ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController( IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet(Name =nameof(GetRoom))]
        public IActionResult GetRoom()
        {
            throw  new NotImplementedException();  
        }

        [HttpGet("{roomId}", Name =nameof(GetRoomById))]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<ActionResult<Room>> GetRoomById(Guid roomId)
        {
            var room = await _roomService.GetRoomAsync(roomId);
            if(room == null) return NotFound();
            return room;
        }
    }
}
