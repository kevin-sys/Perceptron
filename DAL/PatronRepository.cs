using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;


namespace DAL
{
    public class PatronRepository
    {
        string FileName = @"patron.txt";
        List<Patron> patrones;
        public PatronRepository()
        {
            patrones = new List<Patron>();
        }
        public List<Patron> ConsultarTodos()
        {
            patrones.Clear();
            FileStream origen = new FileStream(FileName, FileMode.Open);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea=reader.ReadLine())!=null)
            {
                Patron patron = Mapear(linea);
                patrones.Add(patron);
            }
            reader.Close();
            origen.Close();
            return patrones;
        }
        private static Patron Mapear(string linea) 
        {
            string[] datos = linea.Split(',');
            Patron patron = new Patron();
            patron.Entrada1 = Int32.Parse(datos[0]);
            patron.Entrada2 = Int32.Parse(datos[1]);
            patron.Salida = Int32.Parse(datos[2]);
            return patron;


        }
    }
}
