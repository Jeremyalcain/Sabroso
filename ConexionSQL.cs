using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    class ConexionSQL
    {
        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306" ;
        MySqlConnection con = new MySqlConnection(conexionstring);




        public DataTable ConsultarTablaClienteDG()
        {

            string query = "select CI, Nombre_y_Apellido, Telefono, Direccion from cliente where eliminados=0";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;

          
        }
        public DataTable ConsultarTablaClienteBusquedaDG(string nom)
        {

            string query = "select CI, Nombre_Y_Apellido, Telefono, Direccion from cliente where nombre_y_apellido='" + nom + "' AND eliminados=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaEncargosBusquedaResumenDiaDG(int Fecha)
        {

            string query = "select ID, Cliente, Fecha, Horario, Productos from encargos where substring(fecha, 1, 2) ='" + Fecha + "' AND eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaEncargosBusquedaResumenMesDG(int Fecha)
        {

            string query = "select ID, Cliente, Fecha, Horario, Productos from encargos where substring(fecha, 4, 2) ='" + Fecha + "' AND eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaEncargosBusquedaResumenAñoDG(int Fecha)
        {

            string query = "select ID, Cliente, Fecha, Horario, Productos from encargos where substring(fecha, 7, 4) ='" + Fecha + "' AND eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaEncargosBusquedaDG(string nom)
        {

            string query = "select ID, Cliente, Fecha, Horario, Productos from encargos where Cliente='" + nom + "' AND eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaEncargosDG()
        {

            string query = "select ID, Cliente, Fecha, Horario, Productos from encargos where eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaProductosBusquedaDG(string nom)
        {

            string query = "select ID, Nombre, Precio from stock where Nombre='"+nom+"' AND eliminados=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaProductosDG()
        {

            string query = "select id, nombre, precio from stock where eliminados=0";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;

            
        }
        public int ResumenMesDG(int mes)
        {
            MySqlConnection connection = new MySqlConnection(conexionstring);
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select count(id) As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '" + mes + "'";

            int EncargoMes = (int)cmd.ExecuteScalar();

            con.Close();

            return EncargoMes;


        }


        public int AgregarCliente(string nom, int tel, string dire, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "insert into cliente (nombre_y_apellido, telefono, direccion, ci) values ('" + nom + "','" + tel + "','" + dire + "', '" + ci + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
           
            return flag;
        }

        public int AgregarProducto(string nom, string pre)
        {
            int flag = 0;
            con.Open();
            string query = "insert into stock (nombre, precio) values ('" + nom + "', '" + pre + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }


        public int AgregarEncargo(string nom, string fecha, string hora, string  pro)
        {
            int flag = 0;
            con.Open();
            string query = "insert into encargos (Cliente, fecha, horario, Productos) values ('" + nom + "', '" + fecha + "','" + hora + "','" + pro + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarCliente1(int ciEliminar, string nom, int tel, string dire, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom +"', Telefono ='"+ tel +"', Direccion ='"+ dire + "', CI ='" + ci + "'where CI=" + ciEliminar+"";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita todo
        }

        public int ModificarCliente2(int ciEliminar, int tel, string dire, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Telefono ='" + tel + "', Direccion ='" + dire + "', CI ='" + ci + "'where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita todo menos nombre
        }

        public int ModificarCliente3(int ciEliminar, string nom, int tel, string dire)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom + "', Telefono ='" + tel + "', Direccion ='" + dire + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita todo menos ci
        }

        public int ModificarCliente4(int ciEliminar, string nom, string dire, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom + "', Direccion ='" + dire + "', CI ='" + ci + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita todo menos tel
        }

        public int ModificarCliente5(int ciEliminar, string nom, int tel, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom + "', Telefono ='" + tel + "', CI ='" + ci + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita todo menos dire
        }


        public int ModificarCliente6(int ciEliminar, string nom)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita solo nom
        }

        public int ModificarCliente7(int ciEliminar, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set CI ='" + ci + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita solo ci
        }

        public int ModificarCliente8(int ciEliminar, int tel)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Telefono ='" + tel + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita solo tel
        }

        public int ModificarCliente9(int ciEliminar, string dire)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Direccion ='" + dire + "' where CI=" + ciEliminar + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

            //Se edita solo tel
        }

        public int ModificarProductos3(int id, string nom)
        {
            int flag = 0;
            con.Open();
            string query = "Update stock set Nombre ='" + nom + "' where id='" + id + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarProductos(int id, string nom, string pre)
        {
            int flag = 0;
            con.Open();
            string query = "Update stock set Nombre ='" + nom + "', Precio ='" + pre + "' where id='" + id + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }



        public int ModificarProductos2(int id, string pre)
        {
            int flag = 0;
            con.Open();
            string query = "Update stock set Precio ='" + pre + "' where id='" + id + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }


        public int ModificarEncargos(int id, string cli, string fecha, string hora, string pro)
        {
            int flag = 0;
            con.Open();
            string query = "Update encargos set Cliente ='" + cli + "',Fecha ='" + fecha + "', Horario ='" + hora + "', Productos ='" + pro + "' where id='" + id + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag; 
        }

        public int EliminarCliente(int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set eliminados='1' where CI = '" +ci+ "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarProducto(string id)
        {
            int flag = 0;
            con.Open();
            string query = "Update Stock set eliminados='1' where ID = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarEncargo(string id)
        {
            int flag = 0;
            con.Open();
            string query = "Update encargos set eliminado='1' where id = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }
    }

}
