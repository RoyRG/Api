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
    public class PeleasController : ControllerBase
    {
        protected readonly IServicioPelea servicioPelea;

        public PeleasController(IServicioPelea servicioPelea)
        {
            this.servicioPelea = servicioPelea;
        }
        [HttpGet]
        public List<PeleaModelo> Get([FromQuery] Guid Id)
        {
            var rPeleas = servicioPelea.Get(Id);
            return rPeleas;
        }
    }
}
