using Conversor_de_Unidades_de_Longitud.logica;
using Conversor_de_Unidades_de_Longitud.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_Unidades_de_Longitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdingresar_Click(object sender, EventArgs e)
        {
            
            Usuarios usuario = new Usuarios()
            {
                usuario = txtusuario.Text,
                clave = txtclave.Text,
            };
            
            usuariosConexion con = new usuariosConexion();

            // Comando Para guardar un usuario en la base de datos con el mismo formulario
            // Descomentar para usar
            // con.Guardar(usuario);

            bool Ingresar = con.BuscarUsuario(usuario);
            if (Ingresar)
            {
                this.Hide();
                Form2 obj = new Form2();
                obj.Show();
            }
        }
    }
}

