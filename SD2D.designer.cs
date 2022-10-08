namespace sismys
{
    partial class SD2D
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picFuncion = new System.Windows.Forms.PictureBox();
            this.txEc1 = new System.Windows.Forms.RichTextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.txxmin = new System.Windows.Forms.TextBox();
            this.txxmax = new System.Windows.Forms.TextBox();
            this.txymin = new System.Windows.Forms.TextBox();
            this.txymax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxmin = new System.Windows.Forms.Label();
            this.lbxmax = new System.Windows.Forms.Label();
            this.lbymin = new System.Windows.Forms.Label();
            this.lbymax = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.txEc2 = new System.Windows.Forms.RichTextBox();
            this.xpos = new System.Windows.Forms.Label();
            this.ypos = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exact = new System.Windows.Forms.CheckBox();
            this.lbhval = new System.Windows.Forms.Label();
            this.hv = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.CheckBox();
            this.hist = new System.Windows.Forms.CheckBox();
            this.cbtray = new System.Windows.Forms.CheckBox();
            this.lbxprima = new System.Windows.Forms.Label();
            this.lbyprima = new System.Windows.Forms.Label();
            this.btmax = new System.Windows.Forms.Button();
            this.lbitersder = new System.Windows.Forms.Label();
            this.lbcantiters = new System.Windows.Forms.Label();
            this.lbitersizq = new System.Windows.Forms.Label();
            this.lbmaxiter = new System.Windows.Forms.Label();
            this.tbmaxiter = new System.Windows.Forms.TextBox();
            this.cbNulclines = new System.Windows.Forms.CheckBox();
            this.lbmindist = new System.Windows.Forms.Label();
            this.tbSmallLimit = new System.Windows.Forms.TextBox();
            this.sugerencias = new System.Windows.Forms.ToolTip(this.components);
            this.lbhplus = new System.Windows.Forms.Label();
            this.cbxt = new System.Windows.Forms.CheckBox();
            this.cbyt = new System.Windows.Forms.CheckBox();
            this.tbhIncrement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncion)).BeginInit();
            this.SuspendLayout();
            // 
            // picFuncion
            // 
            this.picFuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.picFuncion.Location = new System.Drawing.Point(13, 167);
            this.picFuncion.Name = "picFuncion";
            this.picFuncion.Size = new System.Drawing.Size(400, 400);
            this.picFuncion.TabIndex = 1;
            this.picFuncion.TabStop = false;
            this.picFuncion.DoubleClick += new System.EventHandler(this.PicFuncion_DoubleClick);
            this.picFuncion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicFuncion_MouseDown);
            this.picFuncion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicFuncion_MouseMove);
            // 
            // txEc1
            // 
            this.txEc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txEc1.Font = new System.Drawing.Font("Consolas", 13F);
            this.txEc1.ForeColor = System.Drawing.Color.White;
            this.txEc1.Location = new System.Drawing.Point(160, 36);
            this.txEc1.Name = "txEc1";
            this.txEc1.Size = new System.Drawing.Size(253, 27);
            this.txEc1.TabIndex = 4;
            this.txEc1.Text = "0.1*x-y";
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.btClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClose.Location = new System.Drawing.Point(401, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(28, 32);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "✕";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.btMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimize.Location = new System.Drawing.Point(336, -3);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(28, 32);
            this.btMinimize.TabIndex = 16;
            this.btMinimize.Text = "_";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // txxmin
            // 
            this.txxmin.Location = new System.Drawing.Point(16, 124);
            this.txxmin.Name = "txxmin";
            this.txxmin.Size = new System.Drawing.Size(32, 20);
            this.txxmin.TabIndex = 18;
            this.txxmin.Text = "-5";
            // 
            // txxmax
            // 
            this.txxmax.Location = new System.Drawing.Point(57, 125);
            this.txxmax.Name = "txxmax";
            this.txxmax.Size = new System.Drawing.Size(32, 20);
            this.txxmax.TabIndex = 19;
            this.txxmax.Text = "5";
            // 
            // txymin
            // 
            this.txymin.Location = new System.Drawing.Point(99, 125);
            this.txymin.Name = "txymin";
            this.txymin.Size = new System.Drawing.Size(32, 20);
            this.txymin.TabIndex = 20;
            this.txymin.Text = "-5";
            // 
            // txymax
            // 
            this.txymax.Location = new System.Drawing.Point(138, 125);
            this.txymax.Name = "txymax";
            this.txymax.Size = new System.Drawing.Size(32, 20);
            this.txymax.TabIndex = 21;
            this.txymax.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dimension tabla";
            this.label2.Click += new System.EventHandler(this.Lb_Dimension_Click);
            // 
            // lbxmin
            // 
            this.lbxmin.AutoSize = true;
            this.lbxmin.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbxmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxmin.Location = new System.Drawing.Point(12, 102);
            this.lbxmin.Name = "lbxmin";
            this.lbxmin.Size = new System.Drawing.Size(44, 19);
            this.lbxmin.TabIndex = 24;
            this.lbxmin.Text = "X min";
            // 
            // lbxmax
            // 
            this.lbxmax.AutoSize = true;
            this.lbxmax.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbxmax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxmax.Location = new System.Drawing.Point(54, 103);
            this.lbxmax.Name = "lbxmax";
            this.lbxmax.Size = new System.Drawing.Size(46, 19);
            this.lbxmax.TabIndex = 25;
            this.lbxmax.Text = "X max";
            // 
            // lbymin
            // 
            this.lbymin.AutoSize = true;
            this.lbymin.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbymin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbymin.Location = new System.Drawing.Point(95, 103);
            this.lbymin.Name = "lbymin";
            this.lbymin.Size = new System.Drawing.Size(44, 19);
            this.lbymin.TabIndex = 26;
            this.lbymin.Text = "Y min";
            // 
            // lbymax
            // 
            this.lbymax.AutoSize = true;
            this.lbymax.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbymax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbymax.Location = new System.Drawing.Point(134, 103);
            this.lbymax.Name = "lbymax";
            this.lbymax.Size = new System.Drawing.Size(46, 19);
            this.lbymax.TabIndex = 27;
            this.lbymax.Text = "Y max";
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(9, 11);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(162, 20);
            this.lbtitulo.TabIndex = 32;
            this.lbtitulo.Text = "Sistemas 2D dinámicos";
            // 
            // txEc2
            // 
            this.txEc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txEc2.Font = new System.Drawing.Font("Consolas", 13F);
            this.txEc2.ForeColor = System.Drawing.Color.White;
            this.txEc2.Location = new System.Drawing.Point(160, 72);
            this.txEc2.Name = "txEc2";
            this.txEc2.Size = new System.Drawing.Size(253, 25);
            this.txEc2.TabIndex = 5;
            this.txEc2.Text = "x+0.1*y";
            // 
            // xpos
            // 
            this.xpos.AutoSize = true;
            this.xpos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xpos.Location = new System.Drawing.Point(31, 151);
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(13, 13);
            this.xpos.TabIndex = 33;
            this.xpos.Text = "0";
            // 
            // ypos
            // 
            this.ypos.AutoSize = true;
            this.ypos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ypos.Location = new System.Drawing.Point(94, 151);
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(13, 13);
            this.ypos.TabIndex = 34;
            this.ypos.Text = "0";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Location = new System.Drawing.Point(351, 102);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(62, 42);
            this.btClear.TabIndex = 35;
            this.btClear.Text = "Limpiar";
            this.sugerencias.SetToolTip(this.btClear, "Deja la interfaz sin soluciones graficadas.");
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(82, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "y:";
            this.sugerencias.SetToolTip(this.label1, "Posición actual en el plano (eje Y).");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(19, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "x:";
            this.sugerencias.SetToolTip(this.label7, "Posición actual en el plano (eje X).");
            // 
            // exact
            // 
            this.exact.AutoSize = true;
            this.exact.BackColor = System.Drawing.Color.Transparent;
            this.exact.Checked = true;
            this.exact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exact.Location = new System.Drawing.Point(12, 573);
            this.exact.Name = "exact";
            this.exact.Size = new System.Drawing.Size(64, 17);
            this.exact.TabIndex = 38;
            this.exact.Text = "Exactos";
            this.sugerencias.SetToolTip(this.exact, "Mientras se encuentre desactivado, solamente se podrán clickear valores enteros e" +
        "n el mapa.");
            this.exact.UseVisualStyleBackColor = false;
            // 
            // lbhval
            // 
            this.lbhval.AutoSize = true;
            this.lbhval.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbhval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbhval.Location = new System.Drawing.Point(10, 36);
            this.lbhval.Name = "lbhval";
            this.lbhval.Size = new System.Drawing.Size(35, 19);
            this.lbhval.TabIndex = 40;
            this.lbhval.Text = "h = ";
            // 
            // hv
            // 
            this.hv.Location = new System.Drawing.Point(55, 36);
            this.hv.Name = "hv";
            this.hv.Size = new System.Drawing.Size(46, 20);
            this.hv.TabIndex = 39;
            this.hv.Text = "0.0075";
            // 
            // grid
            // 
            this.grid.AutoSize = true;
            this.grid.BackColor = System.Drawing.Color.Transparent;
            this.grid.Checked = true;
            this.grid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grid.Location = new System.Drawing.Point(78, 573);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(49, 17);
            this.grid.TabIndex = 41;
            this.grid.Text = "Grilla";
            this.sugerencias.SetToolTip(this.grid, "Prolongación de las líneas coordenadas en forma de matriz.");
            this.grid.UseVisualStyleBackColor = false;
            // 
            // hist
            // 
            this.hist.AutoSize = true;
            this.hist.BackColor = System.Drawing.Color.Transparent;
            this.hist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hist.Location = new System.Drawing.Point(133, 573);
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(63, 17);
            this.hist.TabIndex = 42;
            this.hist.Text = "Historial";
            this.sugerencias.SetToolTip(this.hist, "Las soluciones graficadas previamente se conservarán.");
            this.hist.UseVisualStyleBackColor = false;
            // 
            // cbtray
            // 
            this.cbtray.AutoSize = true;
            this.cbtray.BackColor = System.Drawing.Color.Transparent;
            this.cbtray.Checked = true;
            this.cbtray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbtray.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbtray.Location = new System.Drawing.Point(193, 573);
            this.cbtray.Name = "cbtray";
            this.cbtray.Size = new System.Drawing.Size(84, 17);
            this.cbtray.TabIndex = 48;
            this.cbtray.Text = "Trayectorias";
            this.sugerencias.SetToolTip(this.cbtray, "También conocido como mapa de trazas o slope field.");
            this.cbtray.UseVisualStyleBackColor = false;
            // 
            // lbxprima
            // 
            this.lbxprima.AutoSize = true;
            this.lbxprima.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbxprima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxprima.Location = new System.Drawing.Point(132, 41);
            this.lbxprima.Name = "lbxprima";
            this.lbxprima.Size = new System.Drawing.Size(28, 19);
            this.lbxprima.TabIndex = 49;
            this.lbxprima.Text = "x\'=";
            // 
            // lbyprima
            // 
            this.lbyprima.AutoSize = true;
            this.lbyprima.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbyprima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbyprima.Location = new System.Drawing.Point(131, 75);
            this.lbyprima.Name = "lbyprima";
            this.lbyprima.Size = new System.Drawing.Size(29, 19);
            this.lbyprima.TabIndex = 50;
            this.lbyprima.Text = "y\'=";
            // 
            // btmax
            // 
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmax.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.btmax.ForeColor = System.Drawing.SystemColors.Control;
            this.btmax.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmax.Location = new System.Drawing.Point(365, 0);
            this.btmax.Margin = new System.Windows.Forms.Padding(0);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(28, 32);
            this.btmax.TabIndex = 51;
            this.btmax.Text = "◻";
            this.btmax.UseVisualStyleBackColor = false;
            this.btmax.Click += new System.EventHandler(this.Btmax_Click);
            // 
            // lbitersder
            // 
            this.lbitersder.AutoSize = true;
            this.lbitersder.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbitersder.Location = new System.Drawing.Point(300, 147);
            this.lbitersder.Name = "lbitersder";
            this.lbitersder.Size = new System.Drawing.Size(13, 13);
            this.lbitersder.TabIndex = 52;
            this.lbitersder.Text = "0";
            // 
            // lbcantiters
            // 
            this.lbcantiters.AutoSize = true;
            this.lbcantiters.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbcantiters.Location = new System.Drawing.Point(240, 146);
            this.lbcantiters.Name = "lbcantiters";
            this.lbcantiters.Size = new System.Drawing.Size(62, 13);
            this.lbcantiters.TabIndex = 53;
            this.lbcantiters.Text = "Iteraciones:";
            this.sugerencias.SetToolTip(this.lbcantiters, "Cantidad de ciclos procesados para graficar la solución clickeada.");
            // 
            // lbitersizq
            // 
            this.lbitersizq.AutoSize = true;
            this.lbitersizq.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbitersizq.Location = new System.Drawing.Point(348, 147);
            this.lbitersizq.Name = "lbitersizq";
            this.lbitersizq.Size = new System.Drawing.Size(13, 13);
            this.lbitersizq.TabIndex = 54;
            this.lbitersizq.Text = "0";
            this.lbitersizq.Click += new System.EventHandler(this.Label11_Click);
            // 
            // lbmaxiter
            // 
            this.lbmaxiter.AutoSize = true;
            this.lbmaxiter.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbmaxiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmaxiter.Location = new System.Drawing.Point(206, 125);
            this.lbmaxiter.Name = "lbmaxiter";
            this.lbmaxiter.Size = new System.Drawing.Size(98, 15);
            this.lbmaxiter.TabIndex = 56;
            this.lbmaxiter.Text = "Máx. iteraciones: ";
            this.sugerencias.SetToolTip(this.lbmaxiter, "Define la cantidad de ciclos que realizará hasta detenerse (por cada eje).");
            // 
            // tbmaxiter
            // 
            this.tbmaxiter.Location = new System.Drawing.Point(307, 123);
            this.tbmaxiter.Name = "tbmaxiter";
            this.tbmaxiter.Size = new System.Drawing.Size(41, 20);
            this.tbmaxiter.TabIndex = 55;
            this.tbmaxiter.Text = "20000";
            this.sugerencias.SetToolTip(this.tbmaxiter, "Define la cantidad de ciclos que realizará hasta detenerse (por cada eje).");
            // 
            // cbNulclines
            // 
            this.cbNulclines.AutoSize = true;
            this.cbNulclines.BackColor = System.Drawing.Color.Transparent;
            this.cbNulclines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbNulclines.Location = new System.Drawing.Point(274, 573);
            this.cbNulclines.Name = "cbNulclines";
            this.cbNulclines.Size = new System.Drawing.Size(69, 17);
            this.cbNulclines.TabIndex = 57;
            this.cbNulclines.Text = "Nulclinas";
            this.cbNulclines.UseVisualStyleBackColor = false;
            // 
            // lbmindist
            // 
            this.lbmindist.AutoSize = true;
            this.lbmindist.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbmindist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmindist.Location = new System.Drawing.Point(206, 105);
            this.lbmindist.Name = "lbmindist";
            this.lbmindist.Size = new System.Drawing.Size(116, 15);
            this.lbmindist.TabIndex = 59;
            this.lbmindist.Text = "Distancia mín:   10^-";
            this.sugerencias.SetToolTip(this.lbmindist, "Cuando se grafican soluciones muy pequeñas, puede que ni se aprecien en el mapa.\r" +
        "\nPara ello, definimos el intervalo mínimo que debe haber entre un punto y otro.");
            // 
            // tbSmallLimit
            // 
            this.tbSmallLimit.Location = new System.Drawing.Point(323, 102);
            this.tbSmallLimit.Name = "tbSmallLimit";
            this.tbSmallLimit.Size = new System.Drawing.Size(25, 20);
            this.tbSmallLimit.TabIndex = 58;
            this.tbSmallLimit.Text = "7";
            this.sugerencias.SetToolTip(this.tbSmallLimit, "Cuando se grafican soluciones muy pequeñas, puede que ni se aprecien en el mapa. " +
        "Para ello, definimos el intervalo mínimo que debe haber entre un punto y otro.");
            // 
            // sugerencias
            // 
            this.sugerencias.IsBalloon = true;
            // 
            // lbhplus
            // 
            this.lbhplus.AutoSize = true;
            this.lbhplus.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbhplus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbhplus.Location = new System.Drawing.Point(10, 62);
            this.lbhplus.Name = "lbhplus";
            this.lbhplus.Size = new System.Drawing.Size(45, 19);
            this.lbhplus.TabIndex = 61;
            this.lbhplus.Text = "h += ";
            this.sugerencias.SetToolTip(this.lbhplus, "Para prevenir procesamiento excesivo, la variable h puede ir incrementando.");
            // 
            // cbxt
            // 
            this.cbxt.AutoSize = true;
            this.cbxt.BackColor = System.Drawing.Color.Transparent;
            this.cbxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbxt.Location = new System.Drawing.Point(344, 573);
            this.cbxt.Name = "cbxt";
            this.cbxt.Size = new System.Drawing.Size(39, 17);
            this.cbxt.TabIndex = 62;
            this.cbxt.Text = "x/t";
            this.sugerencias.SetToolTip(this.cbxt, "dx/dt (cómo se vería en 3D). Sugerimos que elijas uno de los dos, y no lo dos.");
            this.cbxt.UseVisualStyleBackColor = false;
            // 
            // cbyt
            // 
            this.cbyt.AutoSize = true;
            this.cbyt.BackColor = System.Drawing.Color.Transparent;
            this.cbyt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbyt.Location = new System.Drawing.Point(382, 573);
            this.cbyt.Name = "cbyt";
            this.cbyt.Size = new System.Drawing.Size(39, 17);
            this.cbyt.TabIndex = 63;
            this.cbyt.Text = "y/t";
            this.sugerencias.SetToolTip(this.cbyt, "Muestra y en funcion de t. Que junto con dx/dt busca generar un mapa 3D.");
            this.cbyt.UseVisualStyleBackColor = false;
            // 
            // tbhIncrement
            // 
            this.tbhIncrement.Location = new System.Drawing.Point(54, 62);
            this.tbhIncrement.Name = "tbhIncrement";
            this.tbhIncrement.Size = new System.Drawing.Size(46, 20);
            this.tbhIncrement.TabIndex = 60;
            this.tbhIncrement.Text = "0.00001";
            // 
            // SD2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(433, 595);
            this.Controls.Add(this.cbyt);
            this.Controls.Add(this.cbxt);
            this.Controls.Add(this.lbhplus);
            this.Controls.Add(this.tbhIncrement);
            this.Controls.Add(this.lbmindist);
            this.Controls.Add(this.tbSmallLimit);
            this.Controls.Add(this.cbNulclines);
            this.Controls.Add(this.lbmaxiter);
            this.Controls.Add(this.tbmaxiter);
            this.Controls.Add(this.lbitersizq);
            this.Controls.Add(this.lbcantiters);
            this.Controls.Add(this.lbitersder);
            this.Controls.Add(this.btmax);
            this.Controls.Add(this.lbyprima);
            this.Controls.Add(this.lbxprima);
            this.Controls.Add(this.cbtray);
            this.Controls.Add(this.hist);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lbhval);
            this.Controls.Add(this.hv);
            this.Controls.Add(this.exact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.txEc2);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lbymax);
            this.Controls.Add(this.lbymin);
            this.Controls.Add(this.lbxmax);
            this.Controls.Add(this.lbxmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txymax);
            this.Controls.Add(this.txymin);
            this.Controls.Add(this.txxmax);
            this.Controls.Add(this.txxmin);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.txEc1);
            this.Controls.Add(this.picFuncion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SD2D";
            this.Text = "1045062";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picFuncion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picFuncion;
        public System.Windows.Forms.RichTextBox txEc1;
        public System.Windows.Forms.Button btClose;
        public System.Windows.Forms.Button btMinimize;
        public System.Windows.Forms.TextBox txxmin;
        public System.Windows.Forms.TextBox txxmax;
        public System.Windows.Forms.TextBox txymin;
        public System.Windows.Forms.TextBox txymax;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbxmin;
        public System.Windows.Forms.Label lbxmax;
        public System.Windows.Forms.Label lbymin;
        public System.Windows.Forms.Label lbymax;
        public System.Windows.Forms.Label lbtitulo;
        public System.Windows.Forms.RichTextBox txEc2;
        private System.Windows.Forms.Label xpos;
        private System.Windows.Forms.Label ypos;
        public System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox exact;
        public System.Windows.Forms.Label lbhval;
        public System.Windows.Forms.TextBox hv;
        private System.Windows.Forms.CheckBox grid;
        private System.Windows.Forms.CheckBox hist;
        private System.Windows.Forms.CheckBox cbtray;
        public System.Windows.Forms.Label lbxprima;
        public System.Windows.Forms.Label lbyprima;
        public System.Windows.Forms.Button btmax;
        private System.Windows.Forms.Label lbitersder;
        private System.Windows.Forms.Label lbcantiters;
        private System.Windows.Forms.Label lbitersizq;
        public System.Windows.Forms.Label lbmaxiter;
        public System.Windows.Forms.TextBox tbmaxiter;
        private System.Windows.Forms.CheckBox cbNulclines;
        public System.Windows.Forms.Label lbmindist;
        public System.Windows.Forms.TextBox tbSmallLimit;
        private System.Windows.Forms.ToolTip sugerencias;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Label lbhplus;
        public System.Windows.Forms.TextBox tbhIncrement;
        private System.Windows.Forms.CheckBox cbxt;
        private System.Windows.Forms.CheckBox cbyt;
    }
}

