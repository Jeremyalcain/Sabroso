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

            string query = "select * from cliente";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;

          
        }

        public DataTable ConsultarTablaEncargosDG()
        {

            string query = "select * from encargos";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public DataTable ConsultarTablaProductosDG()
        {

            string query = "select * from stock";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            con.Close();

            return tabla;


        }

        public int AgregarCliente(string nom, string ape, int tel, string dire)
        {
            int flag = 0;
            con.Open();
            string query = "insert into cliente (nombre, apellido, telefono, direccion) values ('" + nom + "','" + ape + "','" + tel + "','" + dire + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
           
            return flag;
        }

        public int AgregarProducto(string nom, int pre)
        {
            int flag = 0;
            con.Open();
            string query = "insert into stock (nombre, precio) values ('" + nom + "', " + pre.ToString() +  ")";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }


        public int AgregarEncargo(string nom, string dir, string  fecha)
        {
            int flag = 0;
            con.Open();
            string query = "insert into encargos (nombre, direccion, fecha) values ('" + nom + "','" + dir + "','" + fecha + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarCliente(int id, string nom, string ape, int tel, string dire)
        {
            int flag = 0;
            con.Open();
            string query = "Update cliente set Nombre ='"+ nom +"', Apellido ='"+ ape +"', Telefono ='"+ tel +"', Direccion ='"+ dire + "'where id="+id+"";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarProductos(int id, string nom, string pre)
        {
            int flag = 0;
            con.Open();
            string query = "Update stock set Nombre ='" + nom + "', Precio ='" + pre + "'where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarEncargos(int id, string nom, string dire, string fecha)
        {
            int flag = 0;
            con.Open();
            string query = "Update encargos set Nombre ='" + nom + "', Direccion ='" + dire + "', Fecha ='" + fecha + "'where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag; 
        }

        public int EliminarCliente(int id)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from cliente where ID = '" +id+ "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarProducto(string id)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from stock where ID = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarEncargo(string id)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from encargos where ID = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }
    }

}
