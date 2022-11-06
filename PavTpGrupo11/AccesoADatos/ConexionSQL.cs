using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.AccesoADatos


{
   public  class ConexionSQL
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        static SqlConnection conexion = new SqlConnection(cadena);

        public int Login( string us, string pass )
        {
            int count;
            conexion.Open();
            string query = "Select Count(*) FROM Usuario WHERE Nombre = '"+us+ "'and Contraseña = '"+pass+"'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public DataTable ConsultarUsuarios()
        {
            string query = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public Usuario obtenerUsuario(string nom)
        {
            Usuario resultado = new Usuario();
            conexion.Open();
            string query = "SELECT * FROM Usuario WHERE Nombre = '" + nom + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                resultado.contrasena = reader["Contraseña"].ToString();
                resultado.nombre = reader["Nombre"].ToString();

            }
            conexion.Close();
            return resultado;
        }

        public int InsertarUsuarioU(Usuario us)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Usuario(Nombre, Contraseña ) values('" + us.nombre + "', '" +  us.contrasena + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarUsuario(string nom)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Usuario WHERE Nombre = '" + nom + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarUsuario(Usuario us)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Usuario SET Contraseña = '" + us.contrasena + "' WHERE Nombre = '" + us.nombre + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public DataTable ObtenerRepuestos()
        {
            string query = "SELECT * FROM REPUESTO";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public Repuesto ObtenerRepuestos(int cod)
        {
            Repuesto resultado = new Repuesto();
            conexion.Open();
            string query = "SELECT * FROM REPUESTO WHERE Codigo_Repuesto = '" + cod + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                resultado.Codigo = int.Parse(reader["Codigo_Repuesto"].ToString());
                resultado.nombre = reader["Nombre_Repuesto"].ToString();
            }
            conexion.Close();
            return resultado;
        }

        public int InsertarRepuesto(Repuesto re)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into REPUESTO(Codigo_Repuesto, Nombre_Repuesto ) values('" + re.Codigo + "', '" + re.nombre + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarRespuesto(int cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM REPUESTO WHERE Codigo_Repuesto = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarRepuesto(Repuesto re)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE REPUESTO SET Nombre_Repuesto = '" + re.nombre + "' WHERE Codigo_Repuesto = '" + re.Codigo + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public static DataTable ConsultarUsuariosDG()
        {
            string query = "SELECT * FROM Empleados";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public Empleado obtenerEmpleado(int cod)
        {
            Empleado resultado = new Empleado();
            conexion.Open();
            string query = "SELECT * FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                resultado.CodigoEmpleado = int.Parse(reader["Cod_Empleado"].ToString());
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.NroTipoDocumento = int.Parse(reader["Documento"].ToString());
                resultado.calle = reader["calle"].ToString();
                resultado.NroCalle = int.Parse(reader["nro_calle"].ToString());
                resultado.telefono = int.Parse(reader["Telefono"].ToString());
                resultado.IdBarrio = int.Parse(reader["id_barrio"].ToString());

            }
            conexion.Close();
            return resultado;
        }
        public DataTable ConsultarBarriosDG()
        {
            string query = "SELECT * FROM Barrios";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public Barrio ObtenerBarrio(int id)
        {
            Barrio resultado = new Barrio();
            conexion.Open();
            string query = "SELECT * FROM Barrios WHERE id_barrio = '" + id + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                resultado.Id = int.Parse(reader["id_barrio"].ToString());
                resultado.Nombre = reader["nombre_barrio"].ToString();

            }
            conexion.Close();
            return resultado;
        }
        public int InsertarEmpleado(Empleado emp)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Empleados(Cod_Empleado, Nombre, Telefono, Documento, calle, nro_Calle, id_barrio) values('" +emp.CodigoEmpleado + "', '" + emp.Nombre + "', '" + emp.telefono + "', '" + emp.NroTipoDocumento + "', '" + emp.calle + "', '" + emp.NroCalle + "', '" + emp.IdBarrio + "')";
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
               
            
        }
        public int  EliminarEmpleado(string cod)
        {

            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarEmpleado(Empleado emp)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Empleados SET Nombre = '" + emp.Nombre + "', Telefono = '" + emp.telefono + "', Documento = '" + emp.NroTipoDocumento + "', calle =  '" + emp.calle + "', nro_calle =  '" + emp.NroCalle + "', id_barrio = '" + emp.IdBarrio + "' WHERE Cod_Empleado = '" + emp.CodigoEmpleado + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
       

        public bool InsertarBarrio(Barrio ba)

        {
            bool resultado = false;

            try
            {
                conexion.Open();
                string query = "insert into Barrios(id_barrio, nombre_barrio) values('" + ba.Id + "', '" + ba.Nombre + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                
                resultado= true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public int ModificarBarrio(Barrio ba)

        {
            int resultado = 0;
            try
            {
                conexion.Open();
                string query = "UPDATE Barrios SET nombre_barrio = '" + ba.Nombre + "' where id_barrio = '" + ba.Id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                resultado =cmd.ExecuteNonQuery();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            
          


        }
        public int EliminarBarrio(string id)

        {
            int flag = 0;

            try
            {
                conexion.Open();
                string query = "DELETE FROM Barrios WHERE id_barrio = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                flag = cmd.ExecuteNonQuery();
                return flag;
                 
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
            
           


        }
        // proveedores david
        public DataTable ConsultarProveedoresDG()
        {
            string query = "SELECT * FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarProveedor(Proveedor pro)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Proveedor(Cod_Proveedor, Nombre, Telefono, Mail, Calle, nro_Calle, id_barrio) values('" + pro.cod_proveedor + "', '" + pro.Nombre + "', '" + pro.telefono + "', '" + pro.Mail + "', '" + pro.calle + "', '" + pro.NroCasa + "', '" + pro.IdBarrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarProveedor(Proveedor pro)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Proveedor SET Nombre = '" + pro.Nombre + "', Telefono = '" + pro.telefono + "', Mail = '" + pro.Mail + "', Calle =  '" + pro.calle + "', nro_calle =  '" + pro.NroCasa + "', id_barrio = '" + pro.IdBarrio + "' WHERE Cod_Proveedor = '" + pro.cod_proveedor + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarProveedor(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Proveedor WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        // Obra david
        public static DataTable ConsultarObrasDG()
        {
            string query = "SELECT * FROM Obras";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarObra(Obra ob)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Obras(codigo_obra, nombre_Obra, calle, nro_Calle, id_barrio) values('" + ob.Codigo_Obra + "','" + ob.NombreObra + "', '" + ob.calle + "', '" + ob.NroCalle + "', '" + ob.IdBarrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarObra(Obra ob)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Obras SET nombre_Obra = '" + ob.NombreObra + "', Calle =  '" + ob.calle + "', nro_calle =  '" + ob.NroCalle + "', id_barrio = '" + ob.IdBarrio + "' WHERE codigo_Obra = '" + ob.Codigo_Obra + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarObra(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Obras WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }


        public static DataTable ObtenerCamiones()
        {
            string query = "SELECT * FROM Camiones";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public static DataTable ObtenerVentas()
        {
            string query = "SELECT * FROM Ventas";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarCamion(Camion cam)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Camiones(Patente, Marca_Camión, Año_Modelo, Capacidad ) values('" + cam.patente + "', '" + cam.Marca + "', '" + cam.Anio_modelo + "', '" + cam.Capacidad + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarCamion(string patente)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Camiones WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public Camion obtenerCamion(string patente)
        {
            Camion resultado = new Camion();
            conexion.Open();
            string query = "SELECT * FROM Camiones WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader!= null && reader.Read())
            {
                resultado.patente = reader["Patente"].ToString();
                resultado.Marca = reader["Marca_Camión"].ToString();
                resultado.Anio_modelo = int.Parse(reader["Año_Modelo"].ToString());
                resultado.Capacidad = int.Parse(reader["Capacidad"].ToString());

            }
            conexion.Close();
            return resultado;


        }

        public int ModificarCamion(Camion cam)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Camiones SET Marca_Camión = '" + cam.Marca + "', Año_Modelo =  '" + cam.Anio_modelo + "', Capacidad =  '" + cam.Capacidad + "' WHERE Patente = '" + cam.patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        
        public static DataTable ConsultarMaterialesDG()
        {
            string query = "SELECT * FROM Materiales";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public int InsertarMaterial(Material ma)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Materiales(Codigo_Material, Cantidad, Cod_Unidad_Medida, Cod_Proveedor, Fecha_Ingreso, precio) values('" + ma.codigo_material + "','" + ma.cantidad + "', '" + ma.cod_unidad_medida + "', '" + ma.cod_proveedor + "', '" + ma.fecha_ingreso + "', '" + ma.precio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }
        public int ModificarMaterial(Material ma)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Materiales SET Cantidad = '" + ma.cantidad + "', Cod_Unidad_Medida =  '" + ma.cod_unidad_medida + "', Cod_Proveedor =  '" + ma.cod_proveedor + "', Fecha_Ingreso = '" + ma.fecha_ingreso + "', precio = '"+ ma.precio + "' WHERE Codigo_Material = '" + ma.codigo_material + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarMaterial(string Material)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Materiales WHERE Codigo_Material = '" + Material + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public Material obtenerMAterial(int cod)
        {
            Material resultado = new Material();
            conexion.Open();
            string query = "SELECT * FROM Materiales WHERE Codigo_Material = '" + cod + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                resultado.codigo_material = int.Parse(reader["Codigo_Material"].ToString());
                resultado.cantidad = int.Parse(reader["Cantidad"].ToString());
                resultado.cod_unidad_medida = int.Parse(reader["Cod_Unidad_Medida"].ToString());
                resultado.cod_proveedor = int.Parse(reader["Cod_Proveedor"].ToString());
                resultado.fecha_ingreso = DateTime.Parse(reader["Fecha_Ingreso"].ToString());
                resultado.precio = float.Parse(reader["precio"].ToString());

            }
            conexion.Close();
            return resultado;
        }

        public static DataTable ObtenerEmpleadoXcod(int cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

        }
        public static DataTable ObtenerEmpleadoXnom(string nom)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Empleados WHERE Nombre = '" + nom + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

        }
        public static DataTable ObtenerMaterialxCod(int cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Materiales WHERE Codigo_Material = '" + cod + "'";
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerVentaxNum(int Num)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ventas WHERE numero_venta = '" + Num + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerVentaxCamion(string patente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ventas WHERE patente_camion = '" + patente + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerVentaxObra(int Num)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ventas WHERE codigo_obra = '" + Num + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static int obtenerUltimoIDVenta()
        {
            try
            {   
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(numero_venta) FROM Ventas";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection=conexion;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ConsultarHerramientas()
        {
            string query = "SELECT * FROM Herramientas";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public static DataTable ObtenerHerramientaxCod(int cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Herramientas WHERE Cod_herramienta = '" + cod + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerMaterialesxProv(int cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Materiales WHERE Cod_Proveedor = '" + cod + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerHerramientasxVenta()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select v.numero_venta,COUNT(de.cod_herramienta) as Cantidad FROM DETALLExENTREGAxALQUILER de Inner join Ventas v On de.numero_venta = v.numero_venta Group by v.numero_venta";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerEmpleadosXbarrio()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select v.nombre_barrio,COUNT(de.id_barrio) as Cantidad FROM Empleados de Inner join Barrios v On de.id_barrio = v.id_barrio Group by v.nombre_barrio";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerBarrioXnombre(string nom)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * FROM Barrios WHERE nombre_barrio ='" + nom + "'"; 

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerBarrioXCod(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * FROM Barrios WHERE id_barrio = '" + id + "'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static DataTable ObtenerVentasxCamion()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select v.patente_camion as Camion,COUNT(*) as Cantidad_ventas FROM Ventas v Group by v.patente_camion";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        

        public static bool RegistrarVenta(Venta venta, List<Objeto_de_Venta> listaMateriales, List<Objeto_de_Venta> listaHerramienta)
        {
            SqlTransaction objetoTransaccion = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Ventas VALUES(@num,@feVen,@patente,@atraso,@monto,@codObra,@feEntrega)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num", venta.numero);
                cmd.Parameters.AddWithValue("@feVen",venta.fecha);
                cmd.Parameters.AddWithValue("@patente",venta.patente);
                cmd.Parameters.AddWithValue("@atraso",venta.atraso);
                cmd.Parameters.AddWithValue("@monto",venta.monto);
                cmd.Parameters.AddWithValue("@codObra",venta.codObra);
                cmd.Parameters.AddWithValue("@feEntrega",venta.fechaEntrega);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                
                objetoTransaccion=conexion.BeginTransaction("RegistroVenta");

                cmd.Transaction=objetoTransaccion;

                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();

                foreach(var Objeto_de_Venta in listaHerramienta)
                {
                    string consultaEntregaXAlquiler = "INSERT INTO DETALLExENTREGAxALQUILER VALUES(@numven,@codHerra,@fechaDev,@respon,@precio)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numven", venta.numero);
                    cmd.Parameters.AddWithValue("@codHerra",Objeto_de_Venta.cod);
                    cmd.Parameters.AddWithValue("@fechaDev",Objeto_de_Venta.fecha);
                    cmd.Parameters.AddWithValue("@respon",Objeto_de_Venta.responsable);
                    cmd.Parameters.AddWithValue("@precio",Objeto_de_Venta.precio);
                    cmd.CommandText=consultaEntregaXAlquiler;
                    cmd.ExecuteNonQuery();
                }
                foreach(var Objeto_de_Venta in listaMateriales)
                {
                    string consultaEntregaXMaterial = "INSERT INTO ENTREGAxMATERIAL VALUES(@numven,@codMat,@cant,@precio)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numven", venta.numero);
                    cmd.Parameters.AddWithValue("@codMat", Objeto_de_Venta.cod);
                    cmd.Parameters.AddWithValue("@cant", Objeto_de_Venta.cantidad);
                    cmd.Parameters.AddWithValue("@precio", Objeto_de_Venta.precio);
                    cmd.CommandText = consultaEntregaXMaterial;
                    cmd.ExecuteNonQuery();
                }
                objetoTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {
                objetoTransaccion.Rollback();
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}
