//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examen_2.Models
{   using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int VentaID { get; set; }
        public int AgenciaID { get; set; }
        public int ClienteID { get; set; }
        public int VehiculoID { get; set; }
        public Nullable<System.DateTime> FechaVenta { get; set; }
        public decimal PrecioVenta { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
