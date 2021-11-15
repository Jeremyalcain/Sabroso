using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SabrosoSoftware
{
    class ConexionSQL
    {
        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306" ;
        MySqlConnection con = new MySqlConnection(conexionstring);




        public DataTable ConsultarTablaClienteDG()
        {

            string query = "select CI, nombre_y_apellido, telefono, direccion from cliente where eliminados=0";
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

        public DataTable ConsultarTablaEncargosDG()
        {

            string query = "select id, nombre_cliente, fecha, horario, Productos from encargos where eliminado=0";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaProductosBusquedaDG(string nom)
        {

            string query = "select id, nombre, precio from stock where Nombre='"+nom+"' AND eliminados=0";
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


        public int AgregarEncargo(string nom, string fecha, string hora)
        {
            int flag = 0;
            con.Open();
            string query = "insert into encargos (nombre_cliente, fecha, horario) values ('" + nom + "', '" + fecha + "', '" + hora + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarCliente(int ciEliminar, string nom, int tel, string dire, int ci)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre_y_Apellido ='" + nom +"', Telefono ='"+ tel +"', Direccion ='"+ dire + "', CI ='" + ci + "'where CI=" + ciEliminar+"";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
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


        public int ModificarEncargos(int id, string fecha, string hora)
        {
            int flag = 0;
            con.Open();
            string query = "Update encargos set Fecha ='" + fecha + "', Horario ='" + hora + "', where id=" + id + "";

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
