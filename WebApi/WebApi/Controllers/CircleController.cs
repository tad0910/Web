﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult tinh_chuvi_dientich_duongkinh(double rr)
        {
            if (rr <= 0)
                return BadRequest("Ban kinh phai duong");
            double cv = Math.PI * 2 * rr;
            double dt = Math.PI * rr * rr;
            double dk = 2 * rr;
            var json_str = new { dien_tich = dt, chu_vi = cv, duong_kinh = dk };
            return Ok(json_str);
        }
    }
}
