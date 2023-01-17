using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Encuestados
    {

        public string identificacion { get; set; }
        public string nombres { get; set; }
        public string PartidoPolitico { get; set; }
        public DateTime fecha { get; set; }
        public string Sexo { get; set; }


        public Encuestados(string linea)
        {
            if (linea != null)
            {
                Mapear(linea);
            }

        }

        public Encuestados()
        {
        }

        public Encuestados(string identificacion, string nombres, string cargo, DateTime fechaingreso, string estado)
        {
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.PartidoPolitico = cargo;
            this.fecha = fechaingreso;
            this.Sexo = estado;
        }

        public string Linea()
        {
            return identificacion + "," + nombres + "," + PartidoPolitico + "," + fecha + "," + Sexo;
        }
        private void Mapear(string linea)
        {
            identificacion = linea.Split(',')[0];
            nombres = linea.Split(',')[1];
            PartidoPolitico = linea.Split(',')[2];
            fecha = DateTime.Parse(linea.Split(',')[3]);
            Sexo = linea.Split(',')[4];
        }



    }
}
