namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TablaPatron = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TablaVector = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.texIteraciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textRataAprendizaje = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textErrorRMS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.texPatrones = new System.Windows.Forms.TextBox();
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textW11 = new System.Windows.Forms.TextBox();
            this.textW21 = new System.Windows.Forms.TextBox();
            this.textU1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textMaximoIteraciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tablaERMS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TablaNueva = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnBuscarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPatron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaERMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaPatron
            // 
            this.TablaPatron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPatron.Location = new System.Drawing.Point(11, 36);
            this.TablaPatron.Name = "TablaPatron";
            this.TablaPatron.ReadOnly = true;
            this.TablaPatron.Size = new System.Drawing.Size(343, 150);
            this.TablaPatron.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(242, 207);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(112, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar Patrón";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TablaVector
            // 
            this.TablaVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVector.Location = new System.Drawing.Point(11, 271);
            this.TablaVector.Name = "TablaVector";
            this.TablaVector.ReadOnly = true;
            this.TablaVector.Size = new System.Drawing.Size(343, 66);
            this.TablaVector.TabIndex = 2;
            this.TablaVector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patrones, entradas y salidas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vectores y peso umbral";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar vectores y peso umbral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texIteraciones
            // 
            this.texIteraciones.Location = new System.Drawing.Point(504, 31);
            this.texIteraciones.Name = "texIteraciones";
            this.texIteraciones.ReadOnly = true;
            this.texIteraciones.Size = new System.Drawing.Size(43, 20);
            this.texIteraciones.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N. de iteraciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rata de aprendizaje";
            // 
            // textRataAprendizaje
            // 
            this.textRataAprendizaje.Location = new System.Drawing.Point(504, 64);
            this.textRataAprendizaje.Name = "textRataAprendizaje";
            this.textRataAprendizaje.ReadOnly = true;
            this.textRataAprendizaje.Size = new System.Drawing.Size(43, 20);
            this.textRataAprendizaje.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(445, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Entrenar Perceptron";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gráfica en tiempo real";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Error RMS";
            // 
            // textErrorRMS
            // 
            this.textErrorRMS.Location = new System.Drawing.Point(504, 97);
            this.textErrorRMS.Name = "textErrorRMS";
            this.textErrorRMS.ReadOnly = true;
            this.textErrorRMS.Size = new System.Drawing.Size(43, 20);
            this.textErrorRMS.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Patrones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Salida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Entrada";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // texPatrones
            // 
            this.texPatrones.Location = new System.Drawing.Point(504, 163);
            this.texPatrones.Name = "texPatrones";
            this.texPatrones.ReadOnly = true;
            this.texPatrones.Size = new System.Drawing.Size(43, 20);
            this.texPatrones.TabIndex = 19;
            // 
            // textEntrada
            // 
            this.textEntrada.Location = new System.Drawing.Point(604, 28);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.ReadOnly = true;
            this.textEntrada.Size = new System.Drawing.Size(43, 20);
            this.textEntrada.TabIndex = 20;
            // 
            // textSalida
            // 
            this.textSalida.Location = new System.Drawing.Point(604, 62);
            this.textSalida.Name = "textSalida";
            this.textSalida.ReadOnly = true;
            this.textSalida.Size = new System.Drawing.Size(43, 20);
            this.textSalida.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "U1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "W21";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(568, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "W11";
            // 
            // textW11
            // 
            this.textW11.Location = new System.Drawing.Point(604, 96);
            this.textW11.Name = "textW11";
            this.textW11.ReadOnly = true;
            this.textW11.Size = new System.Drawing.Size(43, 20);
            this.textW11.TabIndex = 25;
            // 
            // textW21
            // 
            this.textW21.Location = new System.Drawing.Point(604, 130);
            this.textW21.Name = "textW21";
            this.textW21.ReadOnly = true;
            this.textW21.Size = new System.Drawing.Size(43, 20);
            this.textW21.TabIndex = 26;
            // 
            // textU1
            // 
            this.textU1.Location = new System.Drawing.Point(604, 164);
            this.textU1.Name = "textU1";
            this.textU1.ReadOnly = true;
            this.textU1.Size = new System.Drawing.Size(43, 20);
            this.textU1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(624, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(730, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Realizar Patron";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "N. Maximo de  Iteraciones";
            // 
            // textMaximoIteraciones
            // 
            this.textMaximoIteraciones.Location = new System.Drawing.Point(504, 130);
            this.textMaximoIteraciones.Name = "textMaximoIteraciones";
            this.textMaximoIteraciones.ReadOnly = true;
            this.textMaximoIteraciones.Size = new System.Drawing.Size(43, 20);
            this.textMaximoIteraciones.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(689, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "ERMS";
            // 
            // tablaERMS
            // 
            this.tablaERMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaERMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.tablaERMS.Location = new System.Drawing.Point(693, 44);
            this.tablaERMS.Name = "tablaERMS";
            this.tablaERMS.Size = new System.Drawing.Size(142, 186);
            this.tablaERMS.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ERMS POR ITERACION";
            this.Column1.Name = "Column1";
            // 
            // Grafica
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafica.Legends.Add(legend2);
            this.Grafica.Location = new System.Drawing.Point(580, 360);
            this.Grafica.Name = "Grafica";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Chart";
            this.Grafica.Series.Add(series2);
            this.Grafica.Size = new System.Drawing.Size(256, 233);
            this.Grafica.TabIndex = 34;
            this.Grafica.Text = "chart1";
            // 
            // TablaNueva
            // 
            this.TablaNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaNueva.Location = new System.Drawing.Point(11, 420);
            this.TablaNueva.Name = "TablaNueva";
            this.TablaNueva.Size = new System.Drawing.Size(477, 121);
            this.TablaNueva.TabIndex = 35;
            this.TablaNueva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaNueva_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "DATOS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // BtnBuscarDatos
            // 
            this.BtnBuscarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarDatos.Location = new System.Drawing.Point(381, 547);
            this.BtnBuscarDatos.Name = "BtnBuscarDatos";
            this.BtnBuscarDatos.Size = new System.Drawing.Size(107, 44);
            this.BtnBuscarDatos.TabIndex = 37;
            this.BtnBuscarDatos.Text = "Buscar Datos";
            this.BtnBuscarDatos.UseVisualStyleBackColor = true;
            this.BtnBuscarDatos.Click += new System.EventHandler(this.BtnBuscarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(863, 604);
            this.Controls.Add(this.BtnBuscarDatos);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TablaNueva);
            this.Controls.Add(this.Grafica);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tablaERMS);
            this.Controls.Add(this.textMaximoIteraciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textU1);
            this.Controls.Add(this.textW21);
            this.Controls.Add(this.textW11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.textEntrada);
            this.Controls.Add(this.texPatrones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textErrorRMS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRataAprendizaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texIteraciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaVector);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TablaPatron);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERCEPTRÓN UNICAPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPatron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaERMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPatron;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView TablaVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texIteraciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRataAprendizaje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textErrorRMS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox texPatrones;
        private System.Windows.Forms.TextBox textEntrada;
        private System.Windows.Forms.TextBox textSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textW11;
        private System.Windows.Forms.TextBox textW21;
        private System.Windows.Forms.TextBox textU1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMaximoIteraciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView tablaERMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView TablaNueva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnBuscarDatos;
    }
}

