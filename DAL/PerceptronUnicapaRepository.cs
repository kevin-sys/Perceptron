using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
namespace DAL
{
    public class PerceptronUnicapaRepository
    {
        string FileName = @"patron.txt";
        string FilePeso = @"pesoumbral.txt";
        string FileDatos = @"Archivo.txt";


        List<PerceptronUnicapa> patrones;
        List<PerceptronUnicapa> pesos;
        List<PerceptronUnicapa> Datos;



        public PerceptronUnicapaRepository()
        {
            patrones = new List<PerceptronUnicapa>();
            pesos = new List<PerceptronUnicapa>();
            Datos = new List<PerceptronUnicapa>();

        }
        public List<PerceptronUnicapa> ConsultarDatosNuevos()
        {
            Datos.Clear();
            FileStream origen = new FileStream(FileDatos, FileMode.Open);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                PerceptronUnicapa datosnuevos = MapearDatosNuevos(linea);
                Datos.Add(datosnuevos);
            }
            reader.Close();
            origen.Close();
            return Datos;
        }
        private static PerceptronUnicapa MapearDatosNuevos(string linea)
        {
            string[] datos = linea.Split(',');
            PerceptronUnicapa perceptron = new PerceptronUnicapa();
            perceptron.NumeroIteraciones = Double.Parse(datos[0]);
            perceptron.RataAprendizaje = Double.Parse(datos[1]);
            perceptron.ErrorRMS = Double.Parse(datos[2]);
            perceptron.NumeroMaximoIteraciones = Double.Parse(datos[3]);
            perceptron.Patrones = Double.Parse(datos[4]);
            perceptron.Salida = Double.Parse(datos[5]);




            return perceptron;
        }
        public List<PerceptronUnicapa> ConsultarTodos()
        {
            patrones.Clear();
            FileStream origen = new FileStream(FileName, FileMode.Open);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                PerceptronUnicapa patron = Mapear(linea);
                patrones.Add(patron);
            }
            reader.Close();
            origen.Close();
            return patrones;
        }
        private static PerceptronUnicapa Mapear(string linea)
        {
            string[] datos = linea.Split(',');
            PerceptronUnicapa perceptron = new PerceptronUnicapa();
            perceptron.X1 = Double.Parse(datos[0]);
            perceptron.X2 = Double.Parse(datos[1]);
            perceptron.YD1 = Double.Parse(datos[2]);
            return perceptron;
        }
        public List<PerceptronUnicapa> Consultarpesos()
        {
            pesos.Clear();
            FileStream origen = new FileStream(FilePeso, FileMode.Open);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                PerceptronUnicapa peso = MapearPeso(linea);
                pesos.Add(peso);
            }
            reader.Close();
            origen.Close();
            return pesos;
        }
        private static PerceptronUnicapa MapearPeso(string linea)
        {
            string[] datos = linea.Split(',');
            PerceptronUnicapa perceptron = new PerceptronUnicapa();
            perceptron.W1 = Double.Parse(datos[0]);
            perceptron.W2 = Double.Parse(datos[1]);
            perceptron.U = Double.Parse(datos[2]);
            return perceptron;
        }



    }
}

