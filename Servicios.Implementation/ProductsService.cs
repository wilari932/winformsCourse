using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementation
{
    public class ProductsService:IProductService
    {
        public ICollection<Producto> GetProducs()
        {
            return new List<Producto>
            {
                new Producto
                {
                    Nombre = "p1",
                    Percio = 20,
                },
                new Producto
                {
                    Nombre = "p152",
                    Percio = 201554,
                },
            };
        }
    }
}
