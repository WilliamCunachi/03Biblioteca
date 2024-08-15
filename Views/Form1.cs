using _03Biblioteca.Models;
using _03Biblioteca.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03Biblioteca
{
    public partial class Form1 : Form
    {
        private MiembroCotroller miembroCotroller;

        public Form1()
        {
            InitializeComponent();
            miembroCotroller = new MiembroCotroller();
            Cargarmiembros();
        }

        private void Cargarmiembros()
        {
            List<Miembros> miembros = miembroCotroller.ObtenerMiembros();
            lstmiembros.Items.Clear();
            foreach (Miembros miembro in miembros)
            {
                lstmiembros.Items.Add($"{miembro.miembro_id}: {miembro.nombre} {miembro.apellido}");
            }
        }

        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                !EsEmailValido(txt_email.Text) ||
                !DateTime.TryParse(txt_fecha.Text, out DateTime fechaSuscripcion))
            {
                MessageBox.Show("Completa todos los campos con datos válidos.");
                return;
            }
           
            Miembros miembros = new Miembros
            {
                nombre = txt_nombre.Text,
                apellido = txt_apellido.Text,
                email = txt_email.Text,
                fecha_suscripcion = fechaSuscripcion
            };

            if (miembroCotroller.AgregarMiembro(miembros))
            {
                MessageBox.Show("Miembro agregado con éxito");
                Cargarmiembros();
            }
            else
            {
                MessageBox.Show("Error al agregar miembro");
            }
        }

        private void btnEliminarMiembro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_miembroid.Text, out int miembro_id))
            {
                if (miembroCotroller.EliminarMiembro(miembro_id))
                {
                    MessageBox.Show("Miembro eliminado con éxito");
                    Cargarmiembros();
                }
                else
                {
                    MessageBox.Show("Error al eliminar miembro");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un ID de miembro válido.");
            }
        }

        private void btnModificarMiembro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_miembroid.Text, out int miembro_id) &&
                !string.IsNullOrWhiteSpace(txt_nombre.Text) &&
                !string.IsNullOrWhiteSpace(txt_apellido.Text) &&
                EsEmailValido(txt_email.Text) &&
                DateTime.TryParse(txt_fecha.Text, out DateTime fechaSuscripcion))
            {
                Miembros miembros = new Miembros
                {
                    miembro_id = miembro_id,
                    nombre = txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    email = txt_email.Text,
                    fecha_suscripcion = fechaSuscripcion
                };

                if (miembroCotroller.ModificarMiembro(miembros))
                {
                    MessageBox.Show("Miembro modificado con éxito");
                    Cargarmiembros();
                }
                else
                {
                    MessageBox.Show("Error al modificar miembro");
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos con datos válidos.");
            }
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
