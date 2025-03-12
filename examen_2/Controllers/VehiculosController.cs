using examen_2.Clases;
using examen_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace examen_2.Controllers
{
    [RoutePrefix("api/Vehiculos")]
    public class VehiculosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vehiculo> ConsultarMarca()
        {
            clsVehiculo vehiculo = new clsVehiculo();
            return vehiculo.ConsultarMarca();
        }

        [HttpGet]
        [Route("ConsultarXID")]
        public Vehiculo ConsultarXID(int VehiculoID)
        {
            clsVehiculo vehiculo = new clsVehiculo();
            return vehiculo.Consultar(VehiculoID);
        }


        [HttpPost]
        [Route("Insertar")]

        public string Insertar([FromBody] Vehiculo veh)
        {
            clsVehiculo vehiculo = new clsVehiculo();
            vehiculo.vehiculo = veh;
            return vehiculo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]

        public string Actualizar([FromBody] Vehiculo veh)
        {
            clsVehiculo vehiculo = new clsVehiculo();
            vehiculo.vehiculo = veh;
            return vehiculo.Actualizar();
        
        }

        [HttpDelete]
        [Route("Eliminar")]

        public string Eliminar([FromBody] Vehiculo veh)
        {
            clsVehiculo vehiculo = new clsVehiculo();
            vehiculo.vehiculo = veh;
            return vehiculo.Eliminar();
        }

    }
}