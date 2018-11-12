using CapaEntidades;
using System;

namespace CapaEntidades
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public TipoEmpleado idTipoEmpleado { get; set; }
        public string nombres { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string nroDocumento { get; set; }
        public bool estado { get; set; }
        public string imagen { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }

        public Empleado() { }

        public Empleado(int idEmpleado, TipoEmpleado idTipoEmpleado, string nombres, string apPaterno, string apMaterno, string nroDocumento, bool estado, string imagen, string usuario, string clave)
        {
            this.idEmpleado = idEmpleado;
            this.idTipoEmpleado = idTipoEmpleado;
            this.nombres = nombres;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.nroDocumento = nroDocumento;
            this.estado = estado;
            this.imagen = imagen;
            this.usuario = usuario;
            this.clave = clave;

        }
    }
}
