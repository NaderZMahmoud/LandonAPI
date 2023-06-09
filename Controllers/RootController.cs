﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace LandonAPI2.Controllers
{
    [Route("/")]
    [ApiController]
    [ApiVersion("1.0")]
    public class RootController: ControllerBase
    {
        [HttpGet(Name=nameof(GetRoot))]   
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                rooms = new
                {
                    href=Url.Link(nameof(RoomsController.GetRoom), null)
                },
                Info = new
                {
                    href = Url.Link(nameof(InfoController.GetInfo), null)
                }
            };
        return Ok(response);    
        }
    }
}
