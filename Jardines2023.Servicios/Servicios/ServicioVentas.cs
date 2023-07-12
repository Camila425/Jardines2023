using Jardines2023.Comun.Interfaces;
using Jardines2023.Datos.Repositorios;
using Jardines2023.Entidades.Dtos;
using Jardines2023.Entidades.Entidades;
using Jardines2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Servicios.Servicios
{
    public class ServicioVentas : IServicioVentas
    {
        private readonly IRepositorioVentas repositorio;
        public ServicioVentas()
        {
            repositorio = new RepositorioVentas();
        }

        public List<VentaDto> GetVentas()
        {
            try
            {
              return  repositorio.GetVentas();
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}
