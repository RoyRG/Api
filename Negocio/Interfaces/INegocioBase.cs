using System;
using System.Collections.Generic;
using System.Text;

namespace API.NEGOCIO.Interfaces
{
    public interface INegocioBase<T>
    {
        List<T> Get(Guid Id);
    }
}
