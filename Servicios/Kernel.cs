using API.NEGOCIO;
using API.SERVICIO.Interfaces;
using API.SERVICIO.Servicios;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO
{
    public static class Kernel
    {
        public static IServiceCollection RegistrarServicios(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IServicioPelea, ServicioPelea>();
            services.AddTransient<IServicioPoder, ServicioPoder>();
            services.RegistrarNegocios(configuration);
            return services;
        }
    }
}
