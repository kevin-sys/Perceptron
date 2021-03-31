using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;


namespace BLL
{
    public class PerceptronUnicapaService
    {
        private static PerceptronUnicapaRepository repository = new PerceptronUnicapaRepository();

        public static List<PerceptronUnicapa> Consultar()
        {
            return repository.ConsultarTodos();
        }
        public static List<PerceptronUnicapa> ConsultarPeso()
        {
            return repository.Consultarpesos();
        }
        public static List<PerceptronUnicapa> ConsultarDatosNuevos()
        {
            return repository.ConsultarDatosNuevos();
        }
    }

}
