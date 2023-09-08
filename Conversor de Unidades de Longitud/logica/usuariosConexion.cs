using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Conversor_de_Unidades_de_Longitud.Modelo;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Conversor_de_Unidades_de_Longitud.logica
{
    internal class usuariosConexion
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static usuariosConexion _instancia = null;
        public usuariosConexion()
        {
        }
        public static usuariosConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new usuariosConexion();
                }
                return _instancia;
            }
        }

        public bool Guardar(Usuarios obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                String query = "insert into usuarios (usuario,clave) values (@usuario, @clave)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@usuario", obj.usuario));
                cmd.Parameters.Add(new SQLiteParameter("@clave", obj.clave));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public List<Usuarios> ListaUsuarios()
        {
            List < Usuarios > Lusuarios = new List<Usuarios> ();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                String query = "select id, usuario, clave from usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Lusuarios.Add(new Usuarios()
                        {
                            idUsuario = int.Parse(dr["id"].ToString()),
                            usuario = dr["usuario"].ToString(),
                            clave = dr["clave"].ToString()
                        }); ;
                    }
                }
            }
            return Lusuarios;
        }

        public bool BuscarUsuario(Usuarios obj)
        {
            bool OK= false;
            Usuarios usuarioOk = new Usuarios();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                String query = "select usuario, clave from usuarios where usuario = @usuario and clave = @clave ";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@usuario", obj.usuario));
                cmd.Parameters.Add(new SQLiteParameter("@clave", obj.clave));
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usuarioOk.usuario = dr["usuario"].ToString();
                        MessageBox.Show("Bienvenido " + usuarioOk.usuario);
                        OK = true;
                    }
                }
            }

            if (OK==false)
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            return OK;
        }
    }
}

