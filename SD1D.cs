using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using MathNet.Numerics.LinearAlgebra.Double;

namespace sismys
{
    public partial class SD1D : Form
    {
        public SD1D()
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
        int wid=0;
        int hgt=0;

        Double xclickTang = 0;
        Double yclickTang = 0;


        private void MakeGraph(Boolean cuadro1, Boolean cuadro2, Boolean cuadro3)
        {
            // The bounds to draw.
            float xmin;
            float xmax;
            float ymin;
            float ymax;
            try
            {
                xmin = float.Parse(txxmin.Text, CultureInfo.InvariantCulture.NumberFormat);
                xmax = float.Parse(txxmax.Text, CultureInfo.InvariantCulture.NumberFormat);
                ymin = float.Parse(txymin.Text, CultureInfo.InvariantCulture.NumberFormat);
                ymax = float.Parse(txymax.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception)
            {
                xmin = -10;
                xmax = 10;
                ymin = -10;
                ymax = 10;
            }

            // Make the Bitmap.
            wid = picFuncion.ClientSize.Width;
            hgt = picFuncion.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            if (cuadro1)
            {
                
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    RectangleF rect = new RectangleF(xmin, ymin, xmax - xmin, ymax - ymin);
                    PointF[] pts =
                    {
                        new PointF(0, hgt),
                        new PointF(wid, hgt),
                        new PointF(0, 0),
                    };
                    gr.Transform = new System.Drawing.Drawing2D.Matrix(rect, pts);
                    using (Pen graph_pen = new Pen(Color.Black, 0))
                    {
                        int nh = 1;
                        //Graficar líneas de h.
                        graph_pen.Color = Color.LightGray;
                        for (float x = 0; x <= (float)xmax; x += nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float x = 0; x >= (float)xmin; x -= nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float y = 0; y <= (float)ymax; y += nh)
                            gr.DrawLine(graph_pen, ymin, y, ymax, y);
                        for (float y = 0; y >= (float)ymin; y -= nh)
                            gr.DrawLine(graph_pen, ymax, y, ymin, y);

                        // Graficar los ejes coordenados.
                        graph_pen.Color = Color.Black;
                        gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                        gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                        for (int x = (int)xmin; x <= xmax; x++)
                            gr.DrawLine(graph_pen, x, 0, x, 0.1f);
                        for (int y = (int)ymin; y <= ymax; y++)
                            gr.DrawLine(graph_pen, 0, y, 0.1f, y);

                        //Color del gráfico.
                        graph_pen.Color = Color.Red;

                        // Comprobar tamaño de pixel horizontal.
                        System.Drawing.Drawing2D.Matrix inverse = gr.Transform;
                        inverse.Invert();
                        PointF[] pixel_pts =
                        {
                            new PointF(0, 0),
                            new PointF(1, 0)
                        };
                        inverse.TransformPoints(pixel_pts);



                        //////////////////////////////////////////////////////////////////////////////////////////////////

                        float h = float.Parse(txh.Text.Replace(".", ","));
                        float t = 0;

                        List<PointF> euler = new List<PointF>();

                        //iteracion
                        Double limit = 20;
                        graph_pen.Color = Color.Green;

                        for (float x = 0; x > -limit && t > -limit; x -= h)
                        {
                            euler.Add(new PointF(x, t));
                            t -= h * F(x, txFunction.Text);

                        }
                        ///
                        if(euler.Count > 1)
                            gr.DrawLines(graph_pen, euler.ToArray());
                        euler.Clear();
                        ///
                        t = 0;
                        for (float x = 0; x < limit && t < limit; x += h)
                        {
                            euler.Add(new PointF(x, t));
                            t += h * Fk(x, float.Parse(txk.Text), txFunction.Text);

                        }
                        ///
                        if (euler.Count > 1)
                            gr.DrawLines(graph_pen, euler.ToArray());
                        ///
                        //ERROR 1: NO FUNCIONA CON 1/x
                        List<PointF> funciongraf = new List<PointF>();
                        graph_pen.Color = Color.Red;

                        for (float x = xmin; x < xmax; x += 0.1F)
                        {
                            funciongraf.Add(new PointF(x, Fk(x, float.Parse(txk.Text), txFunction.Text)));

                        }
                        gr.DrawLines(graph_pen, funciongraf.ToArray());
                        int counter2 = 1;
                        lbRaices.Text = "Raíces:";
                        foreach (PointF p in GetRaices(txFunction.Text.Replace("k", txk.Text), 200))
                        {
                            lbRaices.Text = lbRaices.Text + "  (X*" + counter2++ + ": " + p.X + ")";
                        }
                    }
                }
                picFuncion.Image = bm;
            }
            //###########################################################################################################
            //###########################################################################################################
            //PARTE 2
            //###########################################################################################################

            xmin = -5;
            xmax = 5;
            ymin = -5;
            ymax = 5;
            wid = picTang.ClientSize.Width;
            hgt = picTang.ClientSize.Height;
            bm = new Bitmap(wid, hgt);
            if (cuadro2)
            {
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    RectangleF rect = new RectangleF(xmin, ymin, xmax - xmin, ymax - ymin);
                    PointF[] pts =
                    {
                        new PointF(0, hgt),
                        new PointF(wid, hgt),
                        new PointF(0, 0),
                    };
                    gr.Transform = new System.Drawing.Drawing2D.Matrix(rect, pts);
                    using (Pen graph_pen = new Pen(Color.Black, 0))
                    {
                        int nh = 1;
                        graph_pen.Color = Color.LightGray;
                        for (float x = 0; x <= (float)xmax; x += nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float x = 0; x >= (float)xmin; x -= nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float y = 0; y <= (float)ymax; y += nh)
                            gr.DrawLine(graph_pen, ymin, y, ymax, y);
                        for (float y = 0; y >= (float)ymin; y -= nh)
                            gr.DrawLine(graph_pen, ymax, y, ymin, y);
                        graph_pen.Color = Color.FromArgb(40, 40, 40);
                        gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                        gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                        for (int x = (int)xmin; x <= xmax; x++)
                            gr.DrawLine(graph_pen, x, 0, x, 0.1f);
                        for (int y = (int)ymin; y <= ymax; y++)
                            gr.DrawLine(graph_pen, 0, y, 0.1f, y);
                        System.Drawing.Drawing2D.Matrix inverse = gr.Transform;
                        inverse.Invert();
                        PointF[] pixel_pts =
                        {
                            new PointF(0, 0),
                            new PointF(1, 0)
                        };
                        inverse.TransformPoints(pixel_pts);

                        //Variables


                        float h = 0.1F;

                        xclickTang = GetMousePositionTang(true).X;
                        yclickTang = GetMousePositionTang(true).Y;
                        //Console.WriteLine(xclick + "  " + yclick);
                        //iteracionD
                        float corr = float.Parse(txCorr.Text.Replace(".", ",")); //CORRIMIENTO.
                        foreach (PointF pf in GetRaices(txFunction.Text.Replace("k", txk.Text), 100))
                        {
                            //Console.WriteLine(pf);
                            List<PointF> tray = new List<PointF>();
                            for (float i=xmin-4; i<xmax+2; i += 2)
                            {
                                tray = Graficar(1, i, pf.X + corr, h, 100, txFunction.Text);
                                if (tray.Count > 1)
                                    gr.DrawLines(graph_pen, tray.ToArray());
                                tray = Graficar(-1, i, pf.X + corr, h, 100, txFunction.Text);
                                if (tray.Count > 1)
                                    gr.DrawLines(graph_pen, tray.ToArray());

                                tray = Graficar(1, i, pf.X - corr, h, 100, txFunction.Text);
                                if (tray.Count > 1)
                                    gr.DrawLines(graph_pen, tray.ToArray());
                                tray = Graficar(-1, i, pf.X - corr, h, 100, txFunction.Text);
                                if (tray.Count > 1)
                                    gr.DrawLines(graph_pen, tray.ToArray());
                                //Console.WriteLine("     " + (pf.X + corr) + "    " + (pf.X - corr));
                            }
                        }
                        
                        List<PointF> a = Graficar(1, xclickTang, yclickTang, h, 100, txFunction.Text);
                        graph_pen.Color = Color.Red;
                        if (a.Count > 1)
                            gr.DrawLines(graph_pen, a.ToArray());
                        graph_pen.Color = Color.Green;

                        a = Graficar(-1, xclickTang, yclickTang, h, 100, txFunction.Text);
                        if (a.Count > 1)
                            gr.DrawLines(graph_pen, a.ToArray());
                        
                    }

                }
                picTang.Image = bm;
            }
            //###########################################################################################################
            //###########################################################################################################
            //PARTE 3
            //###########################################################################################################


            xmin = -5;
            xmax = 5;
            ymin = -5;
            ymax = 5;
            wid = picBifu.ClientSize.Width;
            hgt = picBifu.ClientSize.Height;
            bm = new Bitmap(wid, hgt);
            if (cuadro3)
            {
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    float nh = 1;
                    gr.SmoothingMode = SmoothingMode.AntiAlias;

                    // Transform to map the graph bounds to the Bitmap.
                    RectangleF rect = new RectangleF(xmin, ymin, xmax - xmin, ymax - ymin);
                    PointF[] pts =
                    {
                        new PointF(0, hgt),
                        new PointF(wid, hgt),
                        new PointF(0, 0),
                    };
                    gr.Transform = new System.Drawing.Drawing2D.Matrix(rect, pts);


                    using (Pen graph_pen = new Pen(Color.Black, 0))
                    {
                        //Graficar líneas de h.
                        graph_pen.Color = Color.LightGray;
                        for (float x = 0; x <= (float)xmax; x += nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float x = 0; x >= (float)xmin; x -= nh)
                            gr.DrawLine(graph_pen, x, ymin, x, ymax);
                        for (float y = 0; y <= (float)ymax; y += nh)
                            gr.DrawLine(graph_pen, ymin, y, ymax, y);
                        for (float y = 0; y >= (float)ymin; y -= nh)
                            gr.DrawLine(graph_pen, ymax, y, ymin, y);

                        // Graficar los ejes coordenados.
                        graph_pen.Color = Color.FromArgb(40, 40, 40);
                        gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                        gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                        for (int x = (int)xmin; x <= xmax; x++)
                            gr.DrawLine(graph_pen, x, 0, x, 0.1f);
                        for (int y = (int)ymin; y <= ymax; y++)
                            gr.DrawLine(graph_pen, 0, y, 0.1f, y);

                        //Color del gráfico.
                        graph_pen.Color = Color.Red;

                        // Comprobar tamaño de pixel horizontal.
                        System.Drawing.Drawing2D.Matrix inverse = gr.Transform;
                        inverse.Invert();
                        PointF[] pixel_pts =
                        {
                            new PointF(0, 0),
                            new PointF(1, 0)
                        };
                        inverse.TransformPoints(pixel_pts);

                        //Variables
                        Double h = 0.05F;

                        if (cuadro3)
                        {
                            List<PointF> a = new List<PointF>();
                            List<PointF> b = new List<PointF>();
                            List<PointF> c = new List<PointF>();
                            List<PointF> d = new List<PointF>();
                            List<PointF> e = new List<PointF>();
                            List<PointF> f = new List<PointF>();
                            for (float i = xmin; i < xmax; i += (float)h)
                            {
                                int counter = 0;
                                List<PointF> actual = GetRaices(txFunction.Text.Replace("k", i.ToString()), 10);
                                foreach (PointF p in actual)
                                {
                                    if (counter == 0)
                                    {
                                        a.Add(new PointF(i, p.X));
                                    }
                                    if (counter == 1)
                                    {
                                        b.Add(new PointF(i, p.X));
                                    }
                                    if (counter == 2)
                                    {
                                        c.Add(new PointF(i, p.X));
                                    }
                                    if (counter == 3)
                                    {
                                        d.Add(new PointF(i, p.X));
                                    }
                                    if (counter == 4)
                                    {
                                        e.Add(new PointF(i, p.X));
                                    }
                                    counter++;
                                }
                            }
                            if (a.Count > 1)
                                gr.DrawLines(graph_pen, a.ToArray());
                            if (b.Count > 1)
                                gr.DrawLines(graph_pen, b.ToArray());
                            if (c.Count > 1)
                                gr.DrawLines(graph_pen, c.ToArray());
                            if (d.Count > 1)
                                gr.DrawLines(graph_pen, d.ToArray());
                            if (e.Count > 1)
                                gr.DrawLines(graph_pen, e.ToArray());

                        }
                    }
                }
                picBifu.Image = bm;
            }
        }


        private float F(float x, String math)
        {
            try
            {
                math = math.Replace("x", "(" + x.ToString() + ")");
                math = math.Replace("k", "0");
                math = math.Replace(',', '.');
                //Console.WriteLine(math);
                string value = new DataTable().Compute(math, "").ToString();
                return float.Parse(value);
            }
            catch (Exception)
            {
            }
            return 10F;
        }
        private float Fk(float x, float k, String math)
        {
            try
            {
                math = math.Replace("x", "(" + x.ToString() + ")");
                math = math.Replace("k", "(" + k.ToString() + ")");
                math = math.Replace(',', '.');
                //Console.WriteLine(math);
                string value = new DataTable().Compute(math, "").ToString();
                return float.Parse(value);
            }
            catch (Exception)
            {
            }
            return 10F;
        }


        private void BtGraph_Click(object sender, EventArgs e)
        {
            MakeGraph(cbFunGraf.Checked, cbTrayectorias.Checked, cbBifu.Checked);
            Definiciones();
        }

        private List<PointF> Graficar(int dir, Double x1, Double y1, Double h1, int max, String funcion)
        {
            List<PointF> solution = new List<PointF>();
            Double xant = y1;
            Double yant = x1;
            float k = float.Parse(txk.Text);
            int counter = 0;
            Boolean ok = true;
            for (Double x = 0; max > counter++ && ok && xant < 200 && xant > -200 && yant < 200 && yant > -200; x++)
            {
                Double xnueva = xant + h1 * dir * Fk((float)xant, k, funcion);
                Double ynueva = yant + h1 * dir * Fk((float)xant, k, "1");
                //Console.WriteLine("            " + xant + " - " + yant + "."); ;
                if (xant < 1000000 && yant < 1000000)
                    solution.Add(new PointF((float)yant, (float)xant));
                if (xant == xnueva || yant == ynueva)
                    ok = false;
                xant = xnueva;
                yant = ynueva;
            }
            return solution;
        }
        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Borrar_todo_Click(object sender, EventArgs e)
        {
            picFuncion.Image = new Bitmap(wid, hgt);
            picTang.Image = new Bitmap(wid, hgt);
            picBifu.Image = new Bitmap(wid, hgt);
        }

        // Obtiene las raices de una función por el método de bisección.
        private List<PointF> GetRaices(String funcion, float exactitud)
        {
            List<PointF> arr = new List<PointF>();
            int xmin = -10, xmax = 10;
            PointF pf = new PointF(xmin, F(xmin, funcion));
            float cc = 0.1F; //coeficiente de crecimiento.
            float ex = exactitud; //exactitud máxima en el cálculo
            //int red = 4;//decimales significativos
            for (float x = xmin; x < xmax; x += cc)
            {
                PointF ant = pf;
                pf = new PointF(x, F(x, funcion));
                float counter = 0;
                if ((ant.Y > 0 && pf.Y < 0))
                {
                    float cn = Math.Abs(ant.X - x) / 2;
                    PointF n = new PointF(ant.X + cn, F(ant.X + cn, funcion)); //acá nos paramos en el medio
                    float inf, sup;//busco las dos puntas
                    if (ant.X > x)//pongo el menor con el inf y el mayor con el sup
                    {
                        sup = ant.X;
                        inf = x;
                    }
                    else
                    {
                        sup = x;
                        inf = ant.X;
                    }
                    float dif = Math.Abs(inf - sup);
                    do
                    {
                        dif /= 2;
                        if (n.Y < 0)
                        {
                            //achico el superior
                            sup -= dif;
                        }
                        else
                        {
                            //achico el inferior
                            inf += dif;

                        }
                        n = new PointF((inf + dif / 2), F((inf + dif / 2), funcion));
                    }
                    while (n.Y != 0 && counter++ < ex);

                    arr.Add(n);
                }
                else if (ant.Y < 0 && pf.Y > 0)
                {
                    float cn = Math.Abs(ant.X - x) / 2;
                    PointF n = new PointF(ant.X + cn, F(ant.X + cn, funcion)); //acá nos paramos en el medio
                    float inf;//busco las dos puntas
                    float sup;
                    if (ant.X > x)//pongo el menor con el inf y el mayor con el sup
                    {
                        sup = ant.X;
                        inf = x;
                    }
                    else
                    {
                        sup = x;
                        inf = ant.X;
                    }
                    float dif = Math.Abs(inf - sup);
                    do
                    {
                        dif /= 2;
                        if (n.Y > 0) //lo doy vuelta
                        {
                            //achico el superior
                            sup -= dif;
                        }
                        else
                        {
                            //achico el inferior
                            inf += dif;

                        }
                        n = new PointF((inf + dif / 2), F((inf + dif / 2), funcion));
                    }
                    while (n.Y != 0 && counter++ < ex);
                    arr.Add(n);
                    //arr.Add(new PointF((float)Math.Round(n.X, red), (float)Math.Round(n.Y, red)));
                }
            }
            return arr;
        }
        
        private PointF CoefPixel(float x, float y)
        {
            return new PointF(
                picTang.Size.Width / (x),
                picTang.Size.Height / (y));
        }

        private void PicTang_MouseDown(object sender, MouseEventArgs e)
        {
            xclickTang = GetMousePositionTang(true).X;
            yclickTang = GetMousePositionTang(true).Y;
            lbOrDes.Text = "Origen: " + ParseTendencia(VieneDe(new PointF((float)xclickTang, (float)yclickTang), txFunction.Text.Replace("k", txk.Text))) +
                ". Destino: " + ParseTendencia(TiendeA(new PointF((float)xclickTang, (float)yclickTang), txFunction.Text.Replace("k", txk.Text))) + ".";
            MakeGraph(false, true, false);
        }

        //devuelve la posicion del mouse en el plano COORDENADO.
        private PointF GetMousePositionTang(Boolean exact)
        {
            Double zerox = CoefPixel(10, 10).X * Math.Abs(5); ;
            Double zeroy = CoefPixel(10, 10).Y * Math.Abs(5); ;
            Double mousex = Cursor.Position.X - (this.Location.X + picTang.Location.X);
            Double mousey = Cursor.Position.Y - (this.Location.Y + picTang.Location.Y);
            Double calcx = (mousex - zerox) / CoefPixel(10, 10).X;
            Double calcy = (zeroy - mousey) / CoefPixel(10, 10).Y;
            if (exact)
                return new PointF((float)calcx, (float)calcy);
            else
                return new PointF((float)Math.Round(calcx), (float)Math.Round(calcy));
        }
        
        private PointF GetMousePositionFunction(Boolean exact)
        {
            float xmin = float.Parse(txxmin.Text, CultureInfo.InvariantCulture.NumberFormat);
            float xmax = float.Parse(txxmax.Text, CultureInfo.InvariantCulture.NumberFormat);
            float ymin = float.Parse(txymin.Text, CultureInfo.InvariantCulture.NumberFormat);
            float ymax = float.Parse(txymax.Text, CultureInfo.InvariantCulture.NumberFormat);
            float ancho = Math.Abs(xmin)+ Math.Abs(xmax);
            float alto = Math.Abs(ymin) + Math.Abs(ymax);
            Double zerox = CoefPixel(ancho, alto).X * Math.Abs(ancho/2);
            Double zeroy = CoefPixel(ancho, alto).Y * Math.Abs(alto/2);
            Double mousex = Cursor.Position.X - (this.Location.X + picFuncion.Location.X);
            Double mousey = Cursor.Position.Y - (this.Location.Y + picFuncion.Location.Y);
            Double calcx = (mousex - zerox) / CoefPixel(ancho, alto).X;
            Double calcy = (zeroy - mousey) / CoefPixel(ancho, alto).Y;
            if (exact)
                return new PointF((float)calcx, (float)calcy);
            else
                return new PointF((float)Math.Round(calcx), (float)Math.Round(calcy));
        }

        private void PicTang_MouseMove(object sender, MouseEventArgs e)
        {

            xpos.Text = GetMousePositionTang(true).X.ToString();
            ypos.Text = GetMousePositionTang(true).Y.ToString();
        }

        private void PicFuncion_MouseMove(object sender, MouseEventArgs e)
        {
            xposF.Text = GetMousePositionFunction(true).X.ToString();
            yposF.Text = GetMousePositionFunction(true).Y.ToString();
        }

        private List<PointF> ExtractRaices()
        {
            List<PointF> lista = new List<PointF>();
            if (cbRoots.Checked)
            {
                
                foreach (String s in txRoots.Text.Split('/'))
                {
                    try
                    {
                        lista.Add(new PointF(float.Parse(s), 0));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Parámetro de raíces mal ingresado.");
                    }
                }
            }
            else
            {
                lista = GetRaices(txFunction.Text.Replace("k", txk.Text), 100);
            }
            return lista;
        }

        private void CbRoots_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRoots.Checked)
                txRoots.Visible = true;
            else txRoots.Visible = false;
        }

        private void Txk_TextChanged(object sender, EventArgs e)
        {
            txRootK.Text = txk.Text;
        }
                
        private void Definiciones()
        {

            defs.Text = "";
            if (cbChoose.Text.StartsWith("1"))
            {
                defs.Text = "Funcionalidad aún no desarrollada. El resto sí, pero son experimentales y pueden fallar.";
            }
            else if (cbChoose.Text.StartsWith("2"))
            {
                List<PointF> raices = ExtractRaices();
                raices.OrderBy(x => x.X);
                Boolean listo = false;
                foreach (PointF p in raices)
                {

                    if (txParaX.Text.Equals("X0"))
                    {
                        if (raices.IndexOf(p) == 0)
                        {
                            defs.Text = defs.Text + "(-inf, " + p.X + ") sí X0 < " + p.X + "\n";

                            defs.Text = defs.Text + "{" + p.X + "} sí X0 = " + p.X + "\n";
                        }
                        else
                        {
                            float xant = raices.ElementAt(raices.IndexOf(p) - 1).X;

                            defs.Text = defs.Text + "(" + xant + ", " + p.X + ")" + " sí " + xant + " < X0 < " + p.X + "\n";

                            defs.Text = defs.Text + "{" + p.X + "} sí X0 = " + p.X + "\n";

                            if (raices.IndexOf(p) == raices.Count - 1)
                            {
                                defs.Text = defs.Text + "(" + p.X + ", inf) sí X0 > " + p.X + "\n";
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            float parax = float.Parse(txParaX.Text);
                            if (!listo)
                            {
                                if (raices.IndexOf(p) == 0 && parax < p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(-inf, " + p.X + ") }";
                                    listo = true;
                                }
                                else if (raices.IndexOf(p) == raices.Count - 1 && parax > p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(" + p.X + ", inf) }";
                                    listo = true;
                                }
                                else if (parax == p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = {" + p.X + "}";
                                    listo = true;
                                }
                                else if (raices.ElementAt(raices.IndexOf(p) - 1).X < parax && parax < p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(" + raices.ElementAt(raices.IndexOf(p) - 1).X + ", " + p.X + ") }";
                                    listo = true;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            defs.Text = "Error: Solamente puede poner X0 para que sea universal, o bien, un valor flotante para que te diga exáctamente dónde es la órbita.";
                        }
                    }
                }
            }
            else if (cbChoose.Text.StartsWith("3"))

            {

                List<PointF> raices = ExtractRaices();
                raices.OrderBy(x => x.X);
                Boolean listo = false;
                String funcion = txFunction.Text.Replace("k", txRootK.Text);
                foreach (PointF c in raices)
                {
                    PointF p = new PointF((float)Math.Round(c.X), (float)Math.Round(c.Y));
                    if (txParaX.Text.Equals("X0"))
                    {

                        if (raices.IndexOf(c) == 0)
                        {
                            defs.Text = defs.Text + "(-inf, " + p.X + ") sí X0 < " + p.X + "\n";

                            defs.Text = defs.Text + "{" + p.X + "} sí X0 = " + p.X + "\n";
                        }
                        else
                        {
                            float xant = (float)Math.Round(raices.ElementAt(raices.IndexOf(c) - 1).X, 3);

                            defs.Text = defs.Text + "(" + xant + ", " + p.X + ")" + " sí " + xant + " < X0 < " + p.X + "\n";

                            defs.Text = defs.Text + "{" + p.X + "} sí X0 = " + p.X + "\n";

                            if (raices.IndexOf(c) == raices.Count - 1)
                            {
                                defs.Text = defs.Text + "(" + p.X + ", inf) sí X0 > " + p.X + "\n";
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            float parax = (float)Math.Round(float.Parse(txParaX.Text), 3);
                            if (!listo)
                            {
                                if (raices.IndexOf(c) == 0 && parax < p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(-inf, " + p.X + ") }";
                                    listo = true;
                                }
                                else if (raices.IndexOf(c) == raices.Count - 1 && parax > p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(" + p.X + ", inf) }";
                                    listo = true;
                                }
                                else if (parax == p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = {" + p.X + "}";
                                    listo = true;
                                }
                                else if (raices.ElementAt(raices.IndexOf(c) - 1).X < parax && parax < p.X)
                                {
                                    defs.Text = "γ(" + parax + ") = { " + "(" + raices.ElementAt(raices.IndexOf(c) - 1).X + ", " + p.X + ") }";
                                    listo = true;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            defs.Text = "Error: Solamente puede poner X0 para que sea universal, o bien, un valor flotante para que te diga exáctamente dónde es la órbita.";
                        }
                    }
                }
            }
            else if (cbChoose.Text.StartsWith("4"))//omega
            {
                float dist = 0.1F;
                List<PointF> raices = ExtractRaices();
                raices.OrderBy(x => x.X);
                raices.Reverse();
                //raices.Reverse();
                String funcion = txFunction.Text.Replace("k", txRootK.Text);
                List<ParteD> lista = new List<ParteD>();
                //conseguir
                foreach (PointF c in raices)
                {
                    lista.Add(new ParteD(c.X, TiendeA(new PointF(0, c.X + dist), funcion)));
                    lista.Add(new ParteD(c.X, c.X));
                    lista.Add(new ParteD(c.X, TiendeA(new PointF(0, c.X - dist), funcion)));

                }
                //filtrar
                int counter = 0;
                int size = lista.Count - 1;
                ParteD ant = new ParteD(false);
                List<ParteD> filtrada = new List<ParteD>();
                foreach (ParteD p in lista)
                {
                    ParteD sig = new ParteD(false);
                    if (lista.Count > (counter + 1))
                        sig = lista.ElementAt(counter + 1);

                    if (ant.loaded && sig.loaded)
                    {
                        if (p.destino != ant.destino || p.destino != sig.destino)
                        {
                            filtrada.Add(p);
                        }
                    }
                    else
                        filtrada.Add(p);
                    ant = p;
                    counter++;
                }
                counter = 0;
                Boolean segui = true;
                foreach (ParteD p in filtrada)
                {
                    if (segui)
                    {
                        Console.WriteLine("{raiz=" + Math.Round(p.raiz, 2) + ", destino=" + Math.Round(p.destino, 2) + "}");
                        ParteD sig = new ParteD(false);
                        Boolean paso = false;
                        if (filtrada.Count > (counter + 1))
                        {

                            paso = true;
                            sig = filtrada.ElementAt(counter + 1);
                            //Console.WriteLine("                {raiz=" + sig.raiz + ", destino=" + sig.destino + "}");
                        }
                        if (paso)
                        {
                            if (p.destino == sig.destino)
                            {
                                segui = false;
                                if (counter == 0)
                                {
                                    if (p.destino == 528491)
                                    {
                                        //este caso no existe
                                    }
                                    else
                                    {
                                        defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 > " + Math.Round(sig.raiz, 2) + "\n";
                                    }
                                }
                                else if (counter + 1 != filtrada.Count)
                                {
                                    if (p.destino == -528491)
                                    {
                                        //este caso no existe
                                    }
                                    else
                                    {
                                        //problems
                                        if (filtrada.IndexOf(sig) != filtrada.Count - 1)
                                            defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", " + Math.Round(sig.raiz, 2) + ")" + "\n";
                                        else
                                            defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 < " + Math.Round(p.raiz, 2) + "\n";

                                    }
                                }
                                else
                                {
                                    defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", " + Math.Round(sig.raiz, 2) + ")" + "\n";
                                }
                            }
                            else //cuando hay un siguiente pero no tienen nada que ver.
                            {

                                if (counter == 0)
                                {

                                    if (p.destino == 528491)
                                    {
                                        
                                        defs.Text = defs.Text + "Э/ sí X0 > " + Math.Round(p.raiz, 2) + "\n";
                                    }
                                    else
                                    {
                                        //este caso no existe.
                                    }
                                }
                                else if (counter + 1 != filtrada.Count)
                                {

                                    if (p.destino == -528491)
                                    {
                                        defs.Text = defs.Text + "Э/ sí X0 < " + Math.Round(p.raiz, 2) + "\n";
                                    }
                                    else
                                    {
                                        if (p.destino == p.raiz)
                                            defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 = " + Math.Round(p.raiz, 2) + "\n";
                                    }
                                }
                                else
                                {

                                    //defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", " + Math.Round(sig.raiz, 2) + ")" + "\n";
                                    defs.Text = defs.Text + "{" + Math.Round(p.destino, 2) + "} sí X0 = " + Math.Round(p.raiz, 2) + "\n";
                                }
                            }
                        }
                        else //cuando ya es el último.
                        {
                            defs.Text = defs.Text + "Э/ sí X0 < " + Math.Round(p.raiz, 2) + "\n";
                        }

                    }
                    else segui = true;
                    counter++;

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (cbChoose.Text.StartsWith("5"))
            {
                float dist = 0.1F;
                List<PointF> raices = ExtractRaices();
                raices.OrderBy(x => x.X);
                raices.Reverse();
                String funcion = txFunction.Text.Replace("k", txRootK.Text);
                List<ParteO> lista = new List<ParteO>();
                //conseguir
                foreach (PointF c in raices)
                {
                    lista.Add(new ParteO(c.X, VieneDe(new PointF(0, c.X + dist), funcion)));
                    lista.Add(new ParteO(c.X, c.X));
                    lista.Add(new ParteO(c.X, VieneDe(new PointF(0, c.X - dist), funcion)));

                }
                //filtrar
                int counter = 0;
                int size = lista.Count - 1;
                ParteO ant = new ParteO(false);
                List<ParteO> filtrada = new List<ParteO>();
                foreach (ParteO p in lista)
                {
                    ParteO sig = new ParteO(false);
                    if (lista.Count > (counter + 1))
                        sig = lista.ElementAt(counter + 1);

                    if (ant.loaded && sig.loaded)
                    {
                        if (p.origen != ant.origen || p.origen != sig.origen)
                        {
                            filtrada.Add(p);
                        }
                    }
                    else
                        filtrada.Add(p);
                    ant = p;
                    counter++;
                }
                counter = 0;
                Boolean endCounted = false;
                //2*x-x*x
                foreach (ParteO p in filtrada)
                {
                    Console.WriteLine("{raiz=" + Math.Round(p.raiz, 2) + ", origen=" + Math.Round(p.origen, 2) + "}");
                    ParteO sig = new ParteO(false);
                    Boolean paso = false;
                    if (filtrada.Count > (counter + 1))
                    {
                        paso = true;
                        sig = filtrada.ElementAt(counter + 1);
                        //Console.WriteLine("                {raiz=" + sig.raiz + ", origen=" + sig.origen + "}");
                    }
                    if (p.origen == 528491)
                    {
                        defs.Text = defs.Text + "Э/ sí X0 > " + Math.Round(p.raiz, 2) + "\n";
                    }
                    else
                    {
                        if (p.origen == p.raiz && endCounted == false)
                            defs.Text = defs.Text + "{" + Math.Round(p.raiz, 2) + "} sí X0 = " + Math.Round(p.raiz, 2) + "\n";
                        else
                        {
                            if (paso)
                            {
                                if (sig.origen == p.origen)
                                {
                                    if (sig.raiz != p.raiz)
                                    {
                                        if (filtrada.Count == (counter + 2))
                                        {
                                            if (filtrada.ElementAt(counter + 1).origen == p.origen)
                                            {
                                                defs.Text = defs.Text + "{" + Math.Round(p.origen, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", -inf)" + "\n";
                                                endCounted = true;
                                            }
                                            else
                                                defs.Text = defs.Text + "{" + Math.Round(p.origen, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", " + Math.Round(sig.raiz, 2) + ")" + "\n";
                                        }
                                        else
                                            defs.Text = defs.Text + "{" + Math.Round(p.origen, 2) + "} sí X0 e (" + Math.Round(p.raiz, 2) + ", " + Math.Round(sig.raiz, 2) + ")" + "\n";
                                    }
                                    else
                                        defs.Text = defs.Text + "{" + Math.Round(p.origen, 2) + "} sí X0 = " + Math.Round(p.raiz, 2) + "\n";
                                }
                            }
                        }
                    }
                    if (p.origen == -528491 && endCounted == false)
                        defs.Text = defs.Text + "Э/ sí X0 < " + Math.Round(p.raiz, 2) + "\n";
                    counter++;
                }
            }
            else if (cbChoose.Text.StartsWith("6"))
            {
                List<PointF> raices = ExtractRaices();
                raices.OrderBy(x => x.X);
                String funcion = txFunction.Text.Replace("k", txRootK.Text);
                foreach (PointF c in raices)
                {
                    defs.Text = defs.Text + "" + c.X + " (X*" + (raices.IndexOf(c) + 1) + ") es un " + Clasificar(c, funcion).ToLower() + ".\n";
                }
            }
        }
        private String ParseTendencia(float val)
        {
            if (val == -528491)
                return "-inf";
            else if (val == 528491)
                return "inf";
            else
                return val.ToString();
        }
        private Boolean EstanCerca(float v1, float v2)
        {
            float confianza = 0.15F;
            //Console.Write("              " + v1 + " cerca de " + v2 + "?  ");
            if(Math.Abs(Math.Abs(v1) - Math.Abs(v2)) < confianza)
            {
                //Console.WriteLine("si");
                return true;
            }
            else
            {
                //Console.WriteLine("no");
                return false;
            }
                
        }
        private float DistanciaEntre(float a, float b)
        {
            float val = Math.Abs(Math.Abs(a) - Math.Abs(b));
            //Console.WriteLine(val);
            return val;
        }

        //0.5*x*x*x-x*x+k
        private float TiendeA(PointF p, String funcion)
        {
            List<PointF> raices = ExtractRaices();
            raices.OrderBy(x => x.X);
            PointF final = Graficar(1, p.X, p.Y, 0.05F, 100, funcion).Last();
            PointF ganador = new PointF();
            float distanciaGan = 5;
            foreach (PointF r in raices)
            {
                float d = DistanciaEntre(r.X, final.Y);
                if (d < distanciaGan)
                {
                    distanciaGan = d;
                    ganador = r;
                }
            }
            //Console.WriteLine(distanciaGan);
            if (distanciaGan < 0.2F)
            {
                //Console.WriteLine(p.Y + " tiende a " + ganador.X);
                return ganador.X;
            }
            //va para algun infinito.
            if (raices.First().X > final.Y)
            {
                //Console.WriteLine(p.Y + " tiende a -inf");
                return -528491F;
            }
            else
            {
                //Console.WriteLine(p.Y + " tiende a inf.");
                return 528491F;
            }
        }

        private float VieneDe(PointF p, String funcion)
        {
            List<PointF> raices = ExtractRaices();
            raices.OrderBy(x => x.X);
            PointF final = Graficar(-1, p.X, p.Y, 0.05F, 100, funcion).Last();
            PointF ganador = new PointF();
            float distanciaGan = 5;
            foreach (PointF r in raices)
            {
                float d = DistanciaEntre(r.X, final.Y);
                if (d < distanciaGan)
                {
                    distanciaGan = d;
                    ganador = r;
                }
            }
            //Console.WriteLine(distanciaGan);
            if (distanciaGan < 0.2F)
            {
                //Console.WriteLine(p.Y + " viene de " + ganador.X);
                return ganador.X;
            }
            //va para algun infinito.
            if (raices.First().X > final.Y)
            {
                //Console.WriteLine(p.Y + " viene de -inf");
                return -528491F;
            }
            else
            {
                //Console.WriteLine(p.Y + " viene de inf.");
                return 528491F;
            }
        }
        private String Clasificar(PointF raiz, String funcion)
        {
            float tendPosit = TiendeA(new PointF(0, raiz.X + 0.01F), funcion);
            float tendNegat = TiendeA(new PointF(0, raiz.X - 0.01F), funcion);
            if (EstanCerca(tendPosit, raiz.X))
            {
                if (EstanCerca(tendNegat, raiz.X))
                {
                    return "Atractor";
                }
                else
                {
                    return "Híbrido que atrae por arriba";
                }
            }
            if (!EstanCerca(tendPosit, raiz.X))
            {
                if (!EstanCerca(tendNegat, raiz.X))
                {
                    return "Repulsor";
                }
                else
                {
                    return "-Híbrido que atrae por abajo";
                }
            }
            return "Híbrido";
            
        }
        struct ParteO
        {
            public float raiz, origen;
            public Boolean loaded;

            public ParteO(float raiz, float origen)
            {
                this.raiz = raiz;
                this.origen = origen;
                loaded = true;
            }
            public ParteO(bool nothing)
            {
                this.raiz = 0;
                this.origen = 0;
                loaded = false;
                
            }
        }
        struct ParteD
        {
            public float raiz, destino;
            public Boolean loaded;

            public ParteD(float raiz, float destino)
            {
                this.raiz = raiz;
                this.destino = destino;
                loaded = true;
            }
            public ParteD(bool nothing)
            {
                this.raiz = 0;
                this.destino = 0;
                loaded = false;

            }
        }

        private void CbChoose_TextChanged_1(object sender, EventArgs e)
        {
            Definiciones();
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
            SD1D.ReleaseCapture();
            SD1D.SendMessage(this.Handle, 161, 2, 0);
        }
    }
}
