using Controladores;
using PersistenciaBD;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para CrearProfesional.xaml
    /// </summary>
    public partial class CrearProfesional : UserControl
    {
        public CrearProfesional()
        {
            InitializeComponent();
        }

        private async void crearProf(string Rut_prof, string Nombre_prof, string Apellido_prof, int Rendimiento_prof, string Estado_prof, DateTime Fecha_nacimiento_prof, string Mail_prof, string Telefono, string Direccion)
        {
            try
            {
                using (BD_NMAEntities db = new BD_NMAEntities())
                {
                    db.CREATE_PROFESIONAL(Rut_prof, Nombre_prof, Apellido_prof, Rendimiento_prof, Estado_prof, Fecha_nacimiento_prof, Mail_prof, Telefono, Direccion);
                    db.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: ", "Se ha producido un error al actualizar la Base de Datos. \n" + ex.Message);
            }
        }

        private async void crearUsuario(string usuario, string clave, int rol, int? Profesional_id_prof, int? Cliente_id_emp, int? Administrador_id_adm)
        {
            try
            {
                using (BD_NMAEntities db = new BD_NMAEntities())
                {
                    db.CREATE_USUARIO(usuario, clave, rol, Profesional_id_prof, Cliente_id_emp, Administrador_id_adm);
                    db.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: ", "Se ha producido un error al crear usuario en la Base de Datos. \n" + ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                crearProf(txbRutProf.Text.ToUpper(), txbNombreProf.Text, txbApellProf.Text, 0, "Normal", Convert.ToDateTime(dpFecNacProf.Text), txbMailGer.Text, txbTelefProf.Text, txbDirecProf.Text);

                int contador = 0;
                ServiceProfesional sc = new ServiceProfesional();
                foreach (Profesional p in sc.GetEntities())
                {

                    contador = p.id_prof;

                }
                crearUsuario(txbNombreUs.Text, txbContraseña.Text, 2, contador, null, null);

                MessageBox.Show("PROFESIONAL CREADO");
                Window.GetWindow(this).Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: ", "Se ha producido un error al Insertar en la Base de Datos. \n" + ex.Message);
            }
            
        }

        private void txbNombreProf_KeyDown(object sender, KeyEventArgs e)
        {
            txbNombreProf.IsReadOnly = true;
            if ((e.Key >= Key.A && e.Key <= Key.Z) | e.Key == Key.OemMinus) { txbNombreProf.IsReadOnly = false; }
        }

        private void txbApellProf_KeyDown(object sender, KeyEventArgs e)
        {
            txbApellProf.IsReadOnly = true;
            if ((e.Key >= Key.A && e.Key <= Key.Z) | e.Key == Key.OemMinus) { txbApellProf.IsReadOnly = false; }
        }

        private void txbRutProf_KeyDown(object sender, KeyEventArgs e)
        {
            int cant = txbRutProf.Text.Length;
            txbRutProf.IsReadOnly = true;
            if (e.Key == Key.D1 | e.Key == Key.D2 | e.Key == Key.K | e.Key == Key.D3 | e.Key == Key.D4 | e.Key == Key.D5 | e.Key == Key.D6 | e.Key == Key.D7 | e.Key == Key.D8 | e.Key == Key.D9 | e.Key == Key.D0 | e.Key == Key.OemMinus | e.Key == Key.Delete)
            {
                txbRutProf.IsReadOnly = false;

            }
        }
    }
}
