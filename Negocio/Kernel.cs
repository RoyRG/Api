using API.DATA;
using API.NEGOCIO.Interfaces;
using API.NEGOCIO.Negocios;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.NEGOCIO
{
    public static class Kernel
    {
        public static IServiceCollection RegistrarNegocios(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<INegocioPelea, NegocioPelea>();
            services.AddTransient<INegocioPoder, NegocioPoder>();
            services.RegistrarRepositorios<Contexto>();
            return services;
        }
    }
}
