using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEncuestados
    {
        string ruta = "encuestados.txt";
        public string Guardar(Encuestados empleados)
        {
            try
            {
              
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(empleados.Linea());
                escritor.Close();
               
                return "error al guardar";
            }
            catch (Exception)
            {

                return "NO Se pudo guardar";
            }

        }

       
        public Encuestados Buscar(string identificacion)
        {
            List<Encuestados> clientes = ConsultarTodos();
            foreach (var item in clientes)
            {
                if (Encontrado(Convert.ToString( item.identificacion), identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        private bool Encontrado(string IdClienteRegistrado, string IdClienteBuscado)
        {
            return IdClienteRegistrado == IdClienteBuscado;
        }

        public List<Encuestados> ConsultarTodos()
        {
            List<Encuestados> empleados = new List<Encuestados>();
            FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            string linea = string.Empty;
            while (!lector.EndOfStream)
            {
                linea = lector.ReadLine();
                Encuestados emplead = new Encuestados(linea);
                empleados.Add(emplead);
            }
            lector.Close();
            archivo.Close();
            return empleados;
        }

        public List<Encuestados> FiltrarPorSexo(string sexo)
        {
            IEnumerable<Encuestados> estudiantes = from encuestados in ConsultarTodos() where encuestados.Sexo == sexo select encuestados;
            return estudiantes.ToList();
        }
        public List<Encuestados> FiltrarPorFecha(DateTime mes)
        {
            IEnumerable<Encuestados> filtrofecha = from fechaEncuestado in ConsultarTodos() where fechaEncuestado.fecha.Month == mes.Month select fechaEncuestado;
            return filtrofecha.ToList();

        }





    }
}
