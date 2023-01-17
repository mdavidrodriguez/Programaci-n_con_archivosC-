using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsulta : Form
    {
        servicioEncuestados listar = new servicioEncuestados();
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void txtbuscadoempleado_TextChanged(object sender, EventArgs e)
        {
            filtros();
        }

        void filtros()
        {

            grilladeempleados.CurrentCell = null;
            foreach (DataGridViewRow r in grilladeempleados.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in grilladeempleados.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscadoempleado.Text.ToUpper()) == 0)
                    {
                        r.Visible = true;
                    }
                }
            }
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            grilladeempleados.DataSource =listar.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(Dtp1.Text);
            grilladeempleados.DataSource = listar.ConsultarPorFecha(fecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(Cmb1.Text == "Todos")
            {
                grilladeempleados.DataSource = listar.Consultar();
            }
            else
            {
                grilladeempleados.DataSource = listar.ConsultarPorSexo(Cmb1.Text);

            }

        }
    }
}
