using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace LandonAPI2.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class RoomsController: ControllerBase
    {
        [HttpGet(Name =nameof(GetRoom))]
        public IActionResult GetRoom()
        {
            throw  new NotImplementedException();  
        }
    }
}
