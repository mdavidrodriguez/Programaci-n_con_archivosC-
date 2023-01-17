using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class servicioEncuestados
    {
        List<Encuestados> empleados;
        RepositorioEncuestados repositorioempleados = new RepositorioEncuestados();
        public servicioEncuestados()
        {
            empleados = repositorioempleados.ConsultarTodos();
        }

        public string Guardar(Encuestados empleado)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorioempleados.Buscar(Convert.ToString( empleado.identificacion)) == null)
                {
                    mensaje = repositorioempleados.Guardar(empleado);
                    Actualizar();
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        private void Actualizar()
        {
            empleados = repositorioempleados.ConsultarTodos();
        }
        public List<Encuestados> ConsultarPorSexo(string sexo)
        {
            
                empleados = repositorioempleados.FiltrarPorSexo(sexo);
            
           
            return empleados;

        }
        public List<Encuestados> ConsultarPorFecha(DateTime fecha)
        {
            empleados = repositorioempleados.FiltrarPorFecha(fecha);


            return empleados;
        }
        public List<Encuestados> Consultar()
        {
            return empleados;
        }
    }
}
