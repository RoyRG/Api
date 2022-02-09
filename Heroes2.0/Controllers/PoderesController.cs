using API.ENTIDADES.Modelos;
using API.SERVICIO.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Heroes2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoderesController : ControllerBase
    {
        protected readonly IServicioPoder servicioPoder;

        public PoderesController(IServicioPoder servicioPoder)
        {
            this.servicioPoder = servicioPoder;
        }
        [HttpGet]
        public List<PoderModelo> Get([FromQuery] Guid Id)
        {
            var rPoder = servicioPoder.Get(Id);          
            return rPoder;
        }
    }
}

