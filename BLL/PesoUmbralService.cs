using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;


namespace BLL
{
    public class PesoUmbralService
    {
        private static PesoUmbralRepository repository = new PesoUmbralRepository();
        public static List<PesoUmbral> Consultar()
        {
            return repository.ConsultarTodos();
        }
    }
}
