using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PatronService
    {
        private static PatronRepository repository = new PatronRepository();

        public static List<Patron> Consultar()
        {
            return repository.ConsultarTodos();
        }
    }
}
