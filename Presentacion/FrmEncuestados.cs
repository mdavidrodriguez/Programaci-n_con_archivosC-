using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEncuestados : Form
    {
        public FrmEncuestados()
        {
            InitializeComponent();
            cargarcombobox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardadodeempleado();
        }
        void guardadodeempleado()
        {

            

            Encuestados empleados = new Encuestados();
            servicioEncuestados servicio = new servicioEncuestados();
            empleados.identificacion = (txtidentifacion.Text);
            empleados.nombres = txtnombres.Text;
            empleados.PartidoPolitico = cmbcargos.Text;
            empleados.fecha = DateTime.Parse(datefechaingreso.Text);
            empleados.Sexo = cmbestado.Text;
            servicio.Guardar(empleados);
            MessageBox.Show("Empleado Guardado correctamente");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtidentifacion.Text = "";
            txtnombres.Text = "";
            cmbestado.Text = "";
            cmbcargos.Text = "";
        

        }

        void cargarcombobox()
        {

            //solo cargar el id
            using (StreamReader lector = new StreamReader("partidos.txt"))
            {

                while (lector.Peek() > 0)
                {
                    cmbcargos.Items.Add(lector.ReadLine().Split(';')[1]);
                }

            }

           
        }



        private void cmbcargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarcombobox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
         
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
