using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;


namespace DAL
{
    public class PesoUmbralRepository
    {
        string FileName = @"pesoumbral.txt";
        List<PesoUmbral> pesoUmbrales;
        public PesoUmbralRepository()
        {
            pesoUmbrales = new List<PesoUmbral>();
        }
        public List<PesoUmbral>ConsultarTodos()
        {
            pesoUmbrales.Clear();
            FileStream origen = new FileStream(FileName, FileMode.Open);
            StreamReader reader = new StreamReader(origen);

            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                PesoUmbral peso = Mapear(linea);
                pesoUmbrales.Add(peso);
            }
            reader.Close();
            origen.Close();
            return pesoUmbrales;
        }
        private static PesoUmbral Mapear(string linea)
        {
            string[] datos = linea.Split(',');
            PesoUmbral peso = new PesoUmbral();
            peso.W1 = Int32.Parse(datos[0]);
            peso.W2 = Int32.Parse(datos[1]);
            peso.U = Int32.Parse(datos[2]);
            return peso;

        }
    }
}
