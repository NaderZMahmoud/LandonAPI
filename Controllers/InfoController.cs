﻿using LandonAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace LandonAPI2.Controllers
{
    
    [ApiController]
    [Route("/[controller]")]
    public class InfoController: ControllerBase
    {
        private readonly HotelInfo _hotelInfo;

        public InfoController(IOptions<HotelInfo> hotelInfoWrapper)
        {
            _hotelInfo = hotelInfoWrapper.Value;
        }

        [HttpGet(Name = nameof(GetInfo))]
        [ProducesResponseType(200)]
        public ActionResult<HotelInfo> GetInfo()
        {
            _hotelInfo.Href = Url.Link(nameof(GetInfo),null);
            return _hotelInfo;
        }
    }
}
