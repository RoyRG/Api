using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO.Interfaces
{
    public interface IServicioBase<T>
    {
        List<T> Get(Guid Id);
    }
}
