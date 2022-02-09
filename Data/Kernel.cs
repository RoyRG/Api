using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DATA
{
    public static class Kernel
    {
        const string cadenaConexion = @"Data Source=DESKTOP-EIGQN0C; Initial Catalog=Heroes2.0; User ID=sa; Password=royale681018";
        public static IServiceCollection RegistrarRepositorios<TContexto>(this IServiceCollection services) where TContexto : DbContext
        {
            services.AddDbContext<Contexto>(
                options => options.UseSqlServer(cadenaConexion));
            return services;
        }
    }
}
