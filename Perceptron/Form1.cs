using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BLL;
using Entity;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        PerceptronUnicapa perceptronUnicapa = new PerceptronUnicapa();
        PerceptronUnicapaService service = new PerceptronUnicapaService();
        IList<PerceptronUnicapa> DatosEntradaSalida = new List<PerceptronUnicapa>();
        IList<PerceptronUnicapa> DatosPesosIniciales = new List<PerceptronUnicapa>();
        IList<PerceptronUnicapa> Umbrales = new List<PerceptronUnicapa>();
        IList<Decimal> listaEp = new List<Decimal>();
        IList<Decimal> listaERMS = new List<Decimal>();

        public Form1()
        {
            InitializeComponent();

        }
        int limite = 0;
        string respuesta;
        Boolean estado = false;
        int AuxIteraciones = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TablaPatron.DataSource = null;
            TablaPatron.AutoGenerateColumns = true;
            TablaPatron.DataSource = PerceptronUnicapaService.Consultar();
            TablaPatron.Columns.Remove("W1");
            TablaPatron.Columns.Remove("W2");
            TablaPatron.Columns.Remove("U");
            TablaPatron.Columns.Remove("Salida");
            TablaPatron.Columns.Remove("NumeroIteraciones");
            TablaPatron.Columns.Remove("RataAprendizaje");
            TablaPatron.Columns.Remove("ErrorRMS");
            TablaPatron.Columns.Remove("NumeroMaximoIteraciones");
            TablaPatron.Columns.Remove("Patrones");
            TablaPatron.Columns.Remove("Entrada");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TablaVector.DataSource = null;
            TablaVector.AutoGenerateColumns = true;
            TablaVector.DataSource = PerceptronUnicapaService.ConsultarPeso();
            TablaVector.Columns.Remove("X1");
            TablaVector.Columns.Remove("X2");
            TablaVector.Columns.Remove("YD1");
            TablaVector.Columns.Remove("Salida");
            TablaVector.Columns.Remove("NumeroIteraciones");
            TablaVector.Columns.Remove("RataAprendizaje");
            TablaVector.Columns.Remove("ErrorRMS");
            TablaVector.Columns.Remove("NumeroMaximoIteraciones");
            TablaVector.Columns.Remove("Patrones");
            TablaVector.Columns.Remove("Entrada");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0, Xo = 1;
            int j = 0;
            int X1 = 0, X2 = 0;
            decimal W11 = 0, W21 = 0;
            decimal U1 = 0;
            decimal YD1 = 0;
            decimal Rata = 0;
            int aux_i = 1;

            //
            decimal Aux_W11 = 0, Aux_W21 = 0;
            decimal Aux_U1 = 0;

            double S1 = 0;
            decimal YR1 = 0;
            decimal El1 = 0;
            decimal Ep = 0;
            decimal ERMS = 0;

            do
            {
                for (int p = 0; p < TablaPatron.RowCount; p++)
                {
                    if (p == i)
                    {
                        X1 = Convert.ToInt32(TablaPatron.Rows[p].Cells[0].Value.ToString());
                        X2 = Convert.ToInt32(TablaPatron.Rows[p].Cells[1].Value.ToString());
                    }
                }
                //actualizar
                if (j == 0)
                {
                    for (int p = 0; p < TablaVector.RowCount; p++)
                    {
                        if (p == i)
                        {
                            W11 = Convert.ToDecimal(TablaVector.Rows[p].Cells[0].Value.ToString());
                            W21 = Convert.ToDecimal(TablaVector.Rows[p].Cells[1].Value.ToString());
                        }
                    }

                    for (int p = 0; p < TablaVector.RowCount; p++)
                    {
                        if (p == i)
                        {
                            U1 = Convert.ToDecimal(TablaVector.Rows[p].Cells[2].Value.ToString());
                        }
                    }
                }
                else
                {
                    W11 = Aux_W11;
                    W21 = Aux_W21;
                    U1 = Aux_U1;
                }
                //
                S1 = perceptronUnicapa.CalcularSalidaFuncion();
                YR1 = perceptronUnicapa.CalcularSalidadRed();

                for (int p = 0; p < TablaPatron.RowCount; p++)
                {
                    if (p == i)
                    {
                        YD1 = Convert.ToInt32(TablaPatron.Rows[p].Cells[2].Value.ToString());
                    }
                }

                El1 = perceptronUnicapa.CalcularErrorLineal(YD1, YR1);
                Ep = perceptronUnicapa.CalcularErrorPatron(El1, Convert.ToInt32(textSalida.Text));

                listaEp.Add(Ep);

                Rata = Convert.ToDecimal(textRataAprendizaje.Text);
                Aux_W11 = perceptronUnicapa.ModificarPesos(W11, Rata, El1, X1);
                Aux_W21 = perceptronUnicapa.ModificarPesos(W21, Rata, El1, X2);
                Aux_U1 = perceptronUnicapa.ModificarUmbrales(U1, Rata, El1, Xo);

                if (i + 1 == Convert.ToInt32(texPatrones.Text))
                {
                    MessageBox.Show(" ITERACION COMPLETADA " + aux_i);
                    ERMS = perceptronUnicapa.CalcularErrorRMS(listaEp);
                    MessageBox.Show(ERMS.ToString());
                    estado = perceptronUnicapa.EstadoRNA(Math.Round(ERMS, 5), Convert.ToDecimal(textErrorRMS.Text));
                    respuesta = perceptronUnicapa.RespuestaRNA(Math.Round(ERMS, 5), Convert.ToDecimal(textErrorRMS.Text));

                    listaEp.Clear();
                    AuxIteraciones++;

                    //texIteraciones.Text = AuxIteraciones.ToString();
                    MessageBox.Show(respuesta);
                    listaERMS.Add(ERMS);

                    tablaERMS.Rows.Clear();

                    foreach (var item in listaERMS)
                    {
                        tablaERMS.Rows.Add(Math.Round(item, 5).ToString());

                    }
                    i = 0;

                    Grafica.Series["Chart"].Points.AddXY(aux_i, ERMS);

                    aux_i++;
                }
                else
                {
                    i++;
                    j++;
                    estado = false;
                }

            } while (estado == false);///ADIOS //NO ESTOY

            //   GuardarTXT(W11.ToString(), W21.ToString(), U1.ToString());
        }
        decimal El11 = 0;
        decimal Ep1 = 0;
        decimal ERMS1 = 0;

        int A;
        int i1 = 0, Xo1 = 1;
        int j1 = 0;
        int X11 = 0, X21 = 0;
        decimal W111 = 0, W211 = 0;
        decimal U11 = 0;
        decimal YD11 = 0;
        decimal Rata1 = 0;
        decimal Aux_W111 = 0, Aux_W211 = 0;
        decimal Aux_U111 = 0;

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarDatos_Click(object sender, EventArgs e)
        {
            TablaNueva.DataSource = null;
            TablaNueva.AutoGenerateColumns = true;
            TablaNueva.DataSource = PerceptronUnicapaService.ConsultarDatosNuevos();
            TablaNueva.Columns.Remove("W1");
            TablaNueva.Columns.Remove("W2");
            TablaNueva.Columns.Remove("U");
            TablaNueva.Columns.Remove("Entrada");
            TablaNueva.Columns.Remove("X1");
            TablaNueva.Columns.Remove("X2");
            TablaNueva.Columns.Remove("YD1");
        }

        private void TablaNueva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCajas();
            try
            {
                texIteraciones.Text = TablaNueva.CurrentRow.Cells[0].Value.ToString();
                textRataAprendizaje.Text = TablaNueva.CurrentRow.Cells[1].Value.ToString();
                textErrorRMS.Text = TablaNueva.CurrentRow.Cells[2].Value.ToString();
                textMaximoIteraciones.Text = TablaNueva.CurrentRow.Cells[3].Value.ToString();
                texPatrones.Text = TablaNueva.CurrentRow.Cells[4].Value.ToString();
                textSalida.Text = TablaNueva.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error"+ error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            textSalida.Text = "";
            texIteraciones.Text = "";
            textRataAprendizaje.Text = "";
            textErrorRMS.Text = "";
            textMaximoIteraciones.Text = "";
            texPatrones.Text = "";
        }

        double S11 = 0;
        decimal YR11 = 0;
        int aux_ii;
        private void button4_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < TablaPatron.RowCount; p++)
            {
                if (p == i1)
                {
                    X11 = Convert.ToInt32(TablaPatron.Rows[p].Cells[0].Value.ToString());
                    X21 = Convert.ToInt32(TablaPatron.Rows[p].Cells[1].Value.ToString());
                }
            }
            //actualizar
            if (j1 == 0)
            {
                for (int p = 0; p < TablaVector.RowCount; p++)
                {
                    if (p == i1)
                    {
                        W111 = Convert.ToDecimal(TablaVector.Rows[p].Cells[0].Value.ToString());
                        W211 = Convert.ToDecimal(TablaVector.Rows[p].Cells[1].Value.ToString());
                    }
                }

                for (int p = 0; p < TablaVector.RowCount; p++)
                {
                    if (p == i1)
                    {
                        U11 = Convert.ToDecimal(TablaVector.Rows[p].Cells[2].Value.ToString());
                    }
                }
            }


            //
            S11 = perceptronUnicapa.CalcularSalidaFuncion();
            YR11 = perceptronUnicapa.CalcularSalidadRed();



            for (int p = 0; p < TablaPatron.RowCount; p++)
            {
                if (p == i1)
                {
                    YD11 = Convert.ToInt32(TablaPatron.Rows[p].Cells[2].Value.ToString());
                }
            }

            El11 = perceptronUnicapa.CalcularErrorLineal(YD11, YR11);
            Ep1 = perceptronUnicapa.CalcularErrorPatron(El11, Convert.ToInt32(textSalida.Text));



            listaEp.Add(Ep1);

            Rata1 = Convert.ToDecimal(textRataAprendizaje.Text);
            Aux_W111 = perceptronUnicapa.ModificarPesos(W111, Rata1, El11, X11);
            Aux_W211 = perceptronUnicapa.ModificarPesos(W211, Rata1, El11, X21);
            Aux_U111 = perceptronUnicapa.ModificarUmbrales(U11, Rata1, El11, Xo1);

            textW11.Text = Aux_W111.ToString();
            textW21.Text = Aux_W211.ToString();
            textU1.Text = Aux_U111.ToString();


        }
    }
}


