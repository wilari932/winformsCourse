using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementation
{
    public class NuevoProductService:IProductService
    {
        public ICollection<Producto> GetProducs()
        {
            return new List<Producto>
            {
                new Producto
                {
                    Nombre = "Frutas",
                    Percio = 20,
                },
                new Producto
                {
                    Nombre = "Verduras",
                    Percio = 201554,
                },
            };
        }
    }
}
