using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaAccesoDatos
{
    public class EmpleadoDAO
    {
        #region "Patron Singleton"
        private static EmpleadoDAO daoEmpleado = null;
        private EmpleadoDAO() { }
        public static EmpleadoDAO getInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new EmpleadoDAO();
            }

            return daoEmpleado;
        }
        #endregion

        public Empleado AccesoSistema (String user, String password)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Empleado objEmpleado = null;
            SqlDataReader dr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPassword", password);
                dr = cmd.ExecuteReader();
                conexion.Open();
                if(dr.Read())
                {
                    objEmpleado = new Empleado();
                    objEmpleado.idEmpleado = Convert.ToInt32(dr["idEmpleado"].ToString());
                    objEmpleado.usuario = dr["usuario"].ToString();
                    objEmpleado.clave = dr["clave"].ToString();
                }
            }
            catch (Exception e)
            {
                objEmpleado = null;
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return objEmpleado;
        }
    }
}
