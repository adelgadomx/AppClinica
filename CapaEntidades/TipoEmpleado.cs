using System;

namespace CapaEntidades
{
    public class TipoEmpleado
    {
        public int idTipoEmpleado { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public TipoEmpleado() { }

        public TipoEmpleado(int idTipoEmpleado, string descripcion, bool estado)
        {
            this.idTipoEmpleado = idTipoEmpleado;
            this.descripcion = descripcion;
            this.estado = estado;
        }
    }
}
