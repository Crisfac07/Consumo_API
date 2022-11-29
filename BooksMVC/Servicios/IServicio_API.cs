using APIBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksMVC.Servicios
{
   public interface IServicio_API
    {
        Task<List<Author>> Listar();
    }
}
