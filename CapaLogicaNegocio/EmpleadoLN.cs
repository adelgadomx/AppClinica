using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN
    {
        #region "Patron Singleton"
        private static EmpleadoLN objEmpleado = null;
        private EmpleadoLN() { }
        public static EmpleadoLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }

            return objEmpleado;
        }
        #endregion

        public Empleado AccesoSistema(String user, String password)
        {
            try
            {
                return EmpleadoDAO.getInstance().AccesoSistema(user, password);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
