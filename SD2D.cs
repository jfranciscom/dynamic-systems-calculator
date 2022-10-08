using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sismys
{
    public partial class SD2D : Form
    {
        public SD2D()
        {
            InitializeComponent();
            //calcDerivadaEn(0, 0);
        }

        // Draw the graph.
        private void Form1_Load(object sender, EventArgs e)
        {
            //MakeGraph();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //MakeGraph();
        }
        int wid = 0;
        int hgt = 0;

        //Posicion donde fue clickeado.
        Double xclick = 0;
        Double yclick = 0;

        //Límites de coordenada.
        Double xmin;
        Double xmax;
        Double ymin;
        Double ymax;

        //Valor de h por defecto.
        Double h = 0.1F;

        //Para cuando queremos que la tabla quede sin funciones dibujadas.
        Boolean cleaning = false;

        //Historial de gráficos hechos.
        List<List<PointF>> historial = new List<List<PointF>>();


        private void MakeGraph()
        {


            try
            {
                xmin = Double.Parse(txxmin.Text, CultureInfo.InvariantCulture.NumberFormat);
                xmax = Double.Parse(txxmax.Text, CultureInfo.InvariantCulture.NumberFormat);
                ymin = Double.Parse(txymin.Text, CultureInfo.InvariantCulture.NumberFormat);
                ymax = Double.Parse(txymax.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception)
            {
                xmin = -10;
                xmax = 10;
                ymin = -10;
                ymax = 10;
            }

            // Generar el mapa.
            wid = picFuncion.ClientSize.Width;
            hgt = picFuncion.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {

                gr.SmoothingMode = SmoothingMode.AntiAlias; //Ignorar

                // Define el tamaño de trabajo.
                RectangleF rect = new RectangleF((float)xmin, (float)ymin, (float)xmax - (float)xmin, (float)ymax - (float)ymin);
                PointF[] pts =
                {
                    new PointF(0, hgt),
                    new PointF(wid, hgt),
                    new PointF(0, 0),
                };
                gr.Transform = new System.Drawing.Drawing2D.Matrix(rect, pts);


                using (Pen graph_pen = new Pen(Color.Black, 0))
                {
                    try
                    {
                        //Graficar grilla de coordenadas.
                        if (grid.Checked)
                        {
                            graph_pen.Color = Color.FromArgb(80, 80, 80);
                            List<List<PointF>> gridlines = GetGridLines();

                            foreach (List<PointF> a in gridlines)
                                gr.DrawLines(graph_pen, a.ToArray());
                        }
                        // Graficar los ejes coordenados.
                        graph_pen.Color = Color.Black;
                        gr.DrawLine(graph_pen, (float)xmin, 0, (float)xmax, 0);
                        gr.DrawLine(graph_pen, 0, (float)ymin, 0, (float)ymax);
                        for (int x = (int)xmin; x <= xmax; x++)
                            gr.DrawLine(graph_pen, x, 0, x, 0.1f);
                        for (int y = (int)ymin; y <= ymax; y++)
                            gr.DrawLine(graph_pen, 0, y, 0.1f, y);

                        //Color del gráfico.



                        //////////////////////////////////////////////////////////// Parseo de h.
                        h = Double.Parse(hv.Text.Replace(".", ",").ToString());
                        ////////////////////////////////////////////////////////////

                        ///MAPA DE TRAYECTORIAS/TRAZAS

                        Boolean paso = false;
                        if (cbtray.Checked)
                        {
                            List<List<PointF>>[] total = new List<List<PointF>>[2];
                            graph_pen.Color = Color.FromArgb(255, 102, 179);
                            total = GetTrayectorias();
                            foreach (List<PointF> a in total[0])
                            {
                                if (!paso)
                                {
                                    paso = true;
                                }
                                gr.DrawLines(graph_pen, a.ToArray());
                            }
                            graph_pen.Color = Color.FromArgb(204, 0, 102);
                            paso = false;
                            foreach (List<PointF> a in total[1])
                            {
                                if (!paso)
                                {
                                    //Console.WriteLine(a[0] + ", " + a[1]);
                                    paso = true;
                                }
                                gr.DrawLines(graph_pen, a.ToArray());
                            }
                        }
                        ////////////////////////////////////////////////////////////
                        /// Nulclinas.
                        List<PointF> nulclines = new List<PointF>();
                        graph_pen.Color = Color.Blue;
                        if (cbNulclines.Checked)
                        {
                            nulclines.Add(new PointF((float)xmin, (float)F((float)xmin, 0, DespejarFuncionNulclinas(txEc1.Text))));
                            nulclines.Add(new PointF((float)xmax, (float)F((float)xmax, 0, DespejarFuncionNulclinas(txEc1.Text))));
                            gr.DrawLines(graph_pen, nulclines.ToArray());
                            nulclines.Clear();
                            nulclines.Add(new PointF((float)ymin, (float)F((float)ymin, 0, DespejarFuncionNulclinas(txEc2.Text))));
                            nulclines.Add(new PointF((float)ymax, (float)F((float)ymax, 0, DespejarFuncionNulclinas(txEc2.Text))));
                            gr.DrawLines(graph_pen, nulclines.ToArray());
                        }
                        ////////////////////////////////////////////////////////////
                        //TRAZADOR DEL SISTEMA.
                        List<PointF> solution = new List<PointF>();
                        List<PointF> solutionizq = new List<PointF>();

                        if (!cleaning)
                        {
                            solution = Graficar(1);
                            solutionizq = Graficar(-1);
                            graph_pen.Color = Color.LimeGreen;
                            gr.DrawLines(graph_pen, solution.ToArray());
                            gr.DrawLines(graph_pen, solutionizq.ToArray());
                        }
                        ////////////////////////////////////////////////////////////
                        //t

                        if (!cleaning)
                        {
                            if(cbxt.Checked || cbyt.Checked)
                            {
                                List<PointF> tdown = solutionizq;
                                tdown.Reverse();
                                List<PointF> final = tdown;
                                final.AddRange(solution);
                                final = RecortarSobrantes(final);
                                
                                if (cbxt.Checked)
                                {
                                    graph_pen.Color = Color.OrangeRed;
                                    gr.DrawLines(graph_pen, GetT(final, 'x').ToArray());
                                }
                                if (cbyt.Checked)
                                {
                                    graph_pen.Color = Color.MediumPurple;
                                    gr.DrawLines(graph_pen, GetT(final, 'y').ToArray());
                                }
                            }


                        }

                        ////////////////////////////////////////////////////////////
                        //GUARDADO DE DIBUJOS EN EL HISTORIAL.
                        graph_pen.Color = Color.CadetBlue;
                        if (hist.Checked && !cleaning)
                        {
                            foreach (List<PointF> a in historial)
                                gr.DrawLines(graph_pen, a.ToArray());

                            historial.Add(solution);
                            historial.Add(solutionizq);
                        }
                        else
                            historial.Clear();
                        ////////////////////////////////////////////////////////////
                        //Dibuja un '+' para ver a donde clickeamos.
                        if (!cleaning)
                        {
                            List<PointF> crosshair = GetCrosshair();
                            graph_pen.Color = Color.Red;
                            gr.DrawLines(graph_pen, crosshair.ToArray());
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
            picFuncion.Image = bm;


        }
        //Calculo de nulclinas.
        private String DespejarFuncionNulclinas(String f)
        {
            Double a = CalcularOrdenadaOrigen(f);
            Double b = F(1, 0, f) - a;
            Double c = F(0, 1, f) - a;

            return b / (-c) + "*x + " + a / (-c);
        }
        private Double CalcularOrdenadaOrigen(String funcion)
        {
            return F(0, 0, funcion);
        }

        //Resuelve funciones
        private Double F(Double x, Double y, String math)
        {
            try
            {
                math = math.ToLower();
                math = math.Replace("x", "(" + x.ToString() + ")");
                math = math.Replace("y", "(" + y.ToString() + ")");
                math = math.Replace(',', '.');
                string value = new DataTable().Compute(math, "").ToString();
                
                return Double.Parse(value);
            }
            catch (Exception)
            {
            }
            return 10F;
        }

        public List<PointF> RecortarSobrantes(List<PointF> l)
        {
            float xmin = float.Parse(txxmin.Text, CultureInfo.InvariantCulture.NumberFormat);
            float xmax = float.Parse(txxmax.Text, CultureInfo.InvariantCulture.NumberFormat);
            float ymin = float.Parse(txymin.Text, CultureInfo.InvariantCulture.NumberFormat);
            float ymax = float.Parse(txymax.Text, CultureInfo.InvariantCulture.NumberFormat);
            List<PointF> final = new List<PointF>();
            foreach (PointF p in l)
            {
                if (AdentroMapa(p, xmax, xmin, ymax, ymin))
                    final.Add(p);
            }
            return final;
        }
        public Boolean AdentroMapa(PointF p, float xmax, float xmin, float ymax, float ymin)
        {

            return p.X < xmax && p.X > xmin && p.Y < ymax && p.Y > ymin;
        }


        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Bt_limpiar_Click(object sender, EventArgs e)
        {
            picFuncion.Image = new Bitmap(wid, hgt);
        }

        private void PicFuncion_MouseDown(object sender, MouseEventArgs e)
        {
            xclick = GetMousePosition(exact.Checked).X;
            yclick = GetMousePosition(exact.Checked).Y;
            MakeGraph();
        }

        private void PicFuncion_MouseMove(object sender, MouseEventArgs e)
        {
            xpos.Text = GetMousePosition(exact.Checked).X.ToString();
            ypos.Text = GetMousePosition(exact.Checked).Y.ToString();
        }

        //devuelve la posicion del mouse en el plano COORDENADO.
        private PointF GetMousePosition(Boolean exact)
        {
            Double zerox = CoefPixel().X * Math.Abs(Double.Parse(txxmin.Text)); ;
            Double zeroy = CoefPixel().Y * Math.Abs(Double.Parse(txymax.Text)); ;
            Double mousex = Cursor.Position.X - (this.Location.X + picFuncion.Location.X);
            Double mousey = Cursor.Position.Y - (this.Location.Y + picFuncion.Location.Y);
            Double calcx = (mousex - zerox) / CoefPixel().X;
            Double calcy = (zeroy - mousey) / CoefPixel().Y;
            if (exact)
                return new PointF((float)calcx, (float)calcy);
            else
                return new PointF(float.Parse(Math.Round(calcx).ToString()), float.Parse(Math.Round(calcy).ToString()));
        }

        //calcula cuantos pixeles hay entre cada coordenada del plano.
        private PointF CoefPixel()
        {
            return new PointF(
                picFuncion.Size.Width / (Math.Abs(float.Parse(txxmax.Text)) + Math.Abs(float.Parse(txxmin.Text))),
                picFuncion.Size.Height / (Math.Abs(float.Parse(txymax.Text)) + Math.Abs(float.Parse(txymin.Text))));
        }

        private Boolean DentroGrafico(Double x, Double y)
        {
            //Console.WriteLine(x + " < " + picFuncion.Size.Width + " ||| " + y + " < " + picFuncion.Size.Height);
            if (x > picFuncion.Size.Width || y > picFuncion.Size.Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            cleaning = true;
            historial.Clear();
            try
            {
                MakeGraph();
            }
            catch (Exception)
            {

            }
            cleaning = false;
        }

        private List<PointF> Graficar(int dir)
        {
            List<PointF> solution = new List<PointF>();
            Double h1 = h;
            Double incremento = Double.Parse(tbhIncrement.Text, CultureInfo.InvariantCulture.NumberFormat);
            Double xant = xclick;
            Double yant = yclick;
            solution.Add(new PointF((float)xant, (float)yant));
            int counter = 0;
            int max = int.Parse(tbmaxiter.Text); //Consigue de la pantalla la cantidad de iteraciones que queremos que tenga.
            Double smallLimit = Math.Pow(10, -Double.Parse(tbSmallLimit.Text, CultureInfo.InvariantCulture.NumberFormat));
            //Con el smallLimit restringimos a que no se grafiquen partes que son tan chicas-
            //que no se pueden ver.
            Boolean ok = true;
            for (Double x = 0; counter++ < max && ok && DentroGrafico(xant, yant); x++)
            {
                //Console.WriteLine(counter++ + ") " + xant + " - " + yant + ".");
                Double valEuler = h1 * dir * F(xant, yant, txEc1.Text);
                Double xnueva = xant + h1 * dir * F(xant, yant, txEc1.Text);
                Double ynueva = yant + h1 * dir * F(xant, yant, txEc2.Text);
                //Console.WriteLine("            " + xnueva + " - " + yant + "."); ;
                if (xant < 1000000 && yant < 1000000)
                    solution.Add(new PointF((float)xant, (float)yant));
                if (xant == xnueva || yant == ynueva)
                    ok = false;
                if (Math.Abs(xant - xnueva) < smallLimit || Math.Abs(yant - ynueva) < smallLimit)
                    ok = false;

                xant = xnueva;
                yant = ynueva;
                h1 += incremento;
            }
            if (dir > 0)
                lbitersder.Text = counter.ToString();
            else
                lbitersizq.Text = counter.ToString();
            return solution;
        }

        public List<PointF> GetT(List<PointF> l, char c)
        {
            List<PointF> t = new List<PointF>();
            float ymin = float.Parse(txymin.Text);
            float ymax = float.Parse(txymax.Text);
            float coefAmpl = (Math.Abs(ymin)+Math.Abs(ymax))/l.Count;

            float cursor = ymin;
            if(c == 'x')
                foreach(PointF p in l)
                {
                    t.Add(new PointF(p.X, cursor));
                    cursor += coefAmpl;
                }
            else
                foreach (PointF p in l)
                {
                    t.Add(new PointF(-cursor, p.Y));
                    cursor += coefAmpl;
                }
            return t;
        }


        //Devuelve el '+'.
        private List<PointF> GetCrosshair()
        {
            List<PointF> crosshair = new List<PointF>();

            Double crossSize = 7;
            crosshair.Add(new PointF((float)xclick + (float)(crossSize / CoefPixel().X), (float)yclick));
            crosshair.Add(new PointF((float)xclick - (float)(crossSize / CoefPixel().X), (float)yclick));
            crosshair.Add(new PointF((float)xclick, (float)yclick));
            crosshair.Add(new PointF((float)xclick, (float)yclick - (float)(crossSize / CoefPixel().Y)));
            crosshair.Add(new PointF((float)xclick, (float)yclick + (float)(crossSize / CoefPixel().Y)));
            return crosshair;
        }

        //Lineas de la grilla.
        private List<List<PointF>> GetGridLines()
        {
            List<List<PointF>> list = new List<List<PointF>>();
            for (Double x = xmin; x <= (Double)xmax; x++)
                for (Double y = ymin; y < ymax; y += 0.4F) {
                    List<PointF> l = new List<PointF>();
                    l.Add(new PointF((float)x, (float)y));
                    l.Add(new PointF((float)x, (float)y + 0.1F));
                    //Console.WriteLine("(" + x + ", " + y + ") - (" + x + ", " + y+0.3F + ")");
                    list.Add(l);
                }
            for (Double y = ymin; y <= (Double)ymax; y++)
                for (Double x = xmin; x < xmax; x += 0.4F)
                {
                    List<PointF> l = new List<PointF>();
                    l.Add(new PointF((float)x, (float)y));
                    l.Add(new PointF((float)x + 0.1F, (float)y));
                    //Console.WriteLine("(" + x + ", " + y + ") - (" + x + ", " + y+0.3F + ")");
                    list.Add(l);
                }
            return list;
        }

        // Modifica las dimensiones de los ejes dentro del gráfico entre 50 y 10.
        private void Lb_Dimension_Click(object sender, EventArgs e)
        {
            if (txxmin.Text.Equals("-10"))
            {
                txxmin.Text = "-50";
                txxmax.Text = "50";
                txymin.Text = "-50";
                txymax.Text = "50";
            }
            else
            {
                txxmin.Text = "-10";
                txxmax.Text = "10";
                txymin.Text = "-10";
                txymax.Text = "10";
            }
        }


        private List<List<PointF>>[] GetTrayectorias()
        {
            List<List<PointF>>[] total = new List<List<PointF>>[2];
            List<List<PointF>> tgs1 = new List<List<PointF>>();
            List<List<PointF>> tgs2 = new List<List<PointF>>();
            for (Double i = -Math.Abs(CoefPixel().X * (xmin)); i <= 400; i += 40)//25
            {
                for (Double j = -Math.Abs(CoefPixel().Y * (ymin)); j <= 380; j += 40)
                {
                    Double x = i / CoefPixel().X;
                    Double y = j / CoefPixel().Y;
                    List<PointF> tangente1 = new List<PointF>();
                    List<PointF> tangente2 = new List<PointF>();

                    PointF uno = new PointF((float)(x - F(x, y, txEc1.Text)), (float)(y - F(x, y, txEc2.Text)));
                    PointF dos = new PointF((float)(x + F(x, y, txEc1.Text)), (float)(y + F(x, y, txEc2.Text)));
                    PointF v = new PointF(dos.X - uno.X, dos.Y - uno.Y);
                    Double modulo = CalcularModulo(uno, dos);

                    v.X = v.X / (float)(Math.Sqrt(modulo) * 20);
                    v.Y = v.Y / (float)(Math.Sqrt(modulo) * 20);

                    //flechas
                    PointF[] flechas;
                    flechas = GetFlechas(new PointF((float)(x + v.X), (float)(y + v.Y)), new PointF((float)(x - v.X), (float)(y - v.Y)), modulo);
                    List<PointF> flechas1 = new List<PointF>();
                    List<PointF> flechas2 = new List<PointF>();

                    flechas2.Add(new PointF((float)(x - v.X), (float)(y - v.Y)));//iba dos
                    flechas2.Add(flechas[0]);
                    flechas1.Add(new PointF((float)(x - v.X), (float)(y - v.Y)));
                    flechas1.Add(flechas[1]);
                    //
                    tangente1.Add(new PointF((float)(x - v.X), (float)(y - v.Y)));
                    tangente1.Add(new PointF((float)x, (float)y));
                    tangente2.Add(new PointF((float)x, (float)y));
                    tangente2.Add(new PointF((float)(x + v.X), (float)(y + v.Y)));

                    tgs1.Add(tangente1);
                    tgs1.Add(tangente2);
                    tgs1.Add(flechas1);
                    tgs1.Add(flechas2);


                }
            }
            total[0] = tgs1;
            total[1] = tgs2;
            return total;
        }
        private PointF[] GetFlechas(PointF uno, PointF dos, Double modulo)
        {
            Double inclinacion = 30;
            Double tamFlecha = 0.02 * modulo;
            Double m = (dos.Y - uno.Y) / (dos.X - uno.X);//pendiente
            Double rads = Math.Atan(m);
            Double angulo = rads * (180 / Math.PI);//de la pendiente

            PointF puntoFinal1; //los dos puntos que van a quedar.
            PointF puntoFinal1B;
            //////////////////PUNTO 1
            {
                String fc1 = GetFuncionFlecha(dos, angulo, inclinacion); //me busca el y=mx+b de la flecha

                Double b1;
                PointF segundoPunto1;
                PointF segundoPunto2;
                PointF puntoGanador;
                //calculo dos puntos que son consecutivos y paralelos _._ para elegir el que tenga el punto de atrás más cerca al punto 1.
                            //el punto 1 es el de la cola de la flecha.
                //1ra parte.
                Double ptoAcer1 = Double.Parse(txxmin.Text);
                b1 = GetBParaFlecha(dos, angulo, inclinacion, ptoAcer1);
                segundoPunto1 = new PointF((float)ptoAcer1, (float)b1);
                //2da parte.
                Double ptoAcer2 = Double.Parse(txxmax.Text);
                b1 = GetBParaFlecha(dos, angulo, inclinacion, ptoAcer2);
                segundoPunto2 = new PointF((float)ptoAcer2, (float)b1);

                //veo cuál está más cerca.
                if (CalcularModulo(GetPuntoPulido(segundoPunto1, dos, tamFlecha), uno) < CalcularModulo(GetPuntoPulido(segundoPunto2, dos, tamFlecha), uno))
                {
                    puntoGanador = segundoPunto1;
                }
                else
                {
                    puntoGanador = segundoPunto2;
                }

                Double mod1 = CalcularModulo(dos, puntoGanador);

                puntoFinal1 = GetPuntoPulido(puntoGanador, dos, tamFlecha);

            }
            //······································································································································································
            //////////////////PUNTO 2
            {
                inclinacion = inclinacion * -1;
                String fc1B = GetFuncionFlecha(dos, angulo, inclinacion);

                Double b1B;
                PointF segundoPunto1B;
                PointF segundoPunto2B;
                PointF puntoGanadorB;
                //calculo dos puntos para luego ver cuál está más cerca.

                Double ptoAcer1B = Double.Parse(txxmin.Text);
                b1B = GetBParaFlecha(dos, angulo, inclinacion, ptoAcer1B);
                segundoPunto1B = new PointF((float)ptoAcer1B, (float)b1B);
                //Console.WriteLine("PUNTO: "+dos);
                //Console.WriteLine("OPCION 1: " + getPuntoPulido(segundoPunto1, dos, tamFlecha) + " - mod: " + calcularModulo(getPuntoPulido(segundoPunto1, dos, tamFlecha), uno));

                Double ptoAcer2B = Double.Parse(txxmax.Text);
                b1B = GetBParaFlecha(dos, angulo, inclinacion, ptoAcer2B);
                segundoPunto2B = new PointF((float)ptoAcer2B, (float)b1B);
                //Console.WriteLine("OPCION 2: " + getPuntoPulido(segundoPunto2, dos, tamFlecha) + " - mod: " + calcularModulo(getPuntoPulido(segundoPunto2, dos, tamFlecha), uno));
                //veo cuál está más cerca.
                if (CalcularModulo(GetPuntoPulido(segundoPunto1B, dos, tamFlecha), uno) < CalcularModulo(GetPuntoPulido(segundoPunto2B, dos, tamFlecha), uno))
                {
                    puntoGanadorB = segundoPunto1B;
                    //Console.WriteLine("GANÓ OPCIÓN 1.");
                }
                else
                {
                    puntoGanadorB = segundoPunto2B;
                    //Console.WriteLine("GANÓ OPCIÓN 2.");
                }

                Double mod1B = CalcularModulo(dos, puntoGanadorB);

                puntoFinal1B = GetPuntoPulido(puntoGanadorB, dos, tamFlecha);
            }
            //////////////////
            PointF[] puntos =
            {
                puntoFinal1,
                puntoFinal1B
            };
            return puntos;
        }
        private PointF GetPuntoPulido(PointF a, PointF b, Double tam)
        {
            PointF n = new PointF(a.X - b.X, a.Y - b.Y);
            Double mod = CalcularModulo(a,b);
            return new PointF((float)(b.X + (n.X / mod) * tam), (float)(b.Y + (n.Y / mod) * tam));

        }
        private String GetFuncionFlecha(PointF final, Double theta, Double inclinacionAdicionalgr)
        {
            Double anguloFinal = (theta + inclinacionAdicionalgr) * (Math.PI / 180);//en radianes
            Double inclDef = (Math.Tan(anguloFinal));
            return "y=" + inclDef + "*x+(" + (final.Y - (inclDef * final.X))+")";
        }

        private Double GetBParaFlecha(PointF final, Double theta, Double inclinacionAdicionalgr, Double posx)
        {
            Double anguloFinal = (theta + inclinacionAdicionalgr) * (Math.PI / 180);//en radianes

            Double inclDef = Math.Tan(anguloFinal);

            Double b = final.Y - (inclDef * final.X);

            Double y = inclDef * posx + b;

            return y;
        }

        private Double CalcularModulo(PointF uno, PointF dos)
        {
            PointF v = new PointF(dos.X - uno.X, dos.Y - uno.Y);
            return Math.Sqrt((v.X * v.X) + (v.Y * v.Y));
        }
        private void PicFuncion_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Btmax_Click(object sender, EventArgs e)
        {

            if (picFuncion.Width < 500)
            {
                this.Height = 765;
                this.Width += 750;
                picFuncion.Width = 740;
                picFuncion.Height = 740;
                picFuncion.BringToFront();
                picFuncion.Location = new Point(450, 15);
                MakeGraph();
            }
            else
            {
                this.Width -= 750;
                this.Height = 595;

                picFuncion.Width = 400;
                picFuncion.Height = 400;
                picFuncion.Location = new Point(13, 167);
                MakeGraph();
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }



        // Movimiento de la ventana.
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            SD2D.ReleaseCapture();
            SD2D.SendMessage(this.Handle, 161, 2, 0);
        }
    }
}