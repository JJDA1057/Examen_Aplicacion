using examen_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace examen_2.Clases
{
	public class clsVehiculo
	{
		private ITM_VentasEntities dbItm = new ITM_VentasEntities();

		public Vehiculo vehiculo { get; set; }

		public string Insertar()
		{
			try
			{
				dbItm.Vehiculoes.Add(vehiculo);
				dbItm.SaveChanges();
				return "El vehiculo fue ingresado con exito";
			}
			catch (Exception ex)
			{

				return "Error al insertar el vehiculo" + ex.Message;
			}
		}

		public string Actualizar()
		{
			Vehiculo veh = Consultar(vehiculo.VehiculoID);
			if (veh == null)
			{
				return "El empleado no es valido,se debe insertar uno valido";

			}
			dbItm.Vehiculoes.AddOrUpdate(vehiculo);
			dbItm.SaveChanges();
			return "Se actualizo el empleado correctamente";

		}

		public Vehiculo Consultar(int VehiculoID)
		{
			Vehiculo veh = dbItm.Vehiculoes.FirstOrDefault(e => e.VehiculoID == VehiculoID);

			return veh;
		}

		public List<Vehiculo> ConsultarMarca()
		{
            return dbItm.Vehiculoes.OrderBy(e => e.Modelo).ToList(); //ToList() es una función que convierte una lista de datos en una lista de objetos

        }


        public string Eliminar()
		{
			try
			{
				Vehiculo veh = Consultar(vehiculo.VehiculoID);
				if (veh == null)
				{
					return "El empleado no es valido";

				}
				dbItm.Vehiculoes.Remove(veh);
				dbItm.SaveChanges();

				return "Se elimino el vehiculo correctamente";
			}
			catch (Exception ex) {
				return "Error al eliminar el vehiculo"+ex.Message;
			
			}

        }

	}
}